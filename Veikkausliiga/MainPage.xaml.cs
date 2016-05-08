using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Globalization; // for datetime formatting

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Veikkausliiga
{

    /// <summary>
    /// The match page: browse all the matches to select one.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        /// <summary>
        /// Definitions for net fetching (rootObject) and for browsing the matches.
        /// </summary>
        // Get the matches on this url. Add matchId for detailed info.
        const string UrlStringBase = "http://adafyvlstorage.blob.core.windows.net/YYYY/finland/veikkausliiga/matches";
        int serieYear = 2014;   // the default year
        string UrlString;
        
        // for detailed match info.
        string[,] MatchStringArrayInfo;

        /// For Browsing the matches
        //  Every match
        List<OpenMatchProxy.RootObject> MatchStringList = new List<OpenMatchProxy.RootObject>(); 

        // LiFo for first line matches in the match listing.
        Stack<int> oldLowStack = new Stack<int>();  

        int oldLowSelect = 0;
        int lowSelect = 0;
        int upSelect = 0;

        int matchCount = 0;

        /// <summary>
        /// Main page. Browse matches.
        /// </summary>
        public MainPage()
        {

            // Url for getting matches.
            UrlString = UrlStringBase.Replace("YYYY", serieYear.ToString());

            this.InitializeComponent();

        }

        /// <summary>
        /// The match is chosen for detailed info. The button for match info is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MatchButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            int matchID = 0;   // MatchID from the xaml.
            string MatchInfoUrl = "";

            // Get the calling button name callerButton.Name, for ex Buttonyks0
            Button callerButton = (Button)sender;

            try
            {

                if (callerButton.Name == "MatchButton0")
                {
                    matchID = int.Parse(MatchId0.Text);
                }
                else if (callerButton.Name == "MatchButton1")
                {
                    matchID = int.Parse(MatchId1.Text);
                }
                else if (callerButton.Name == "MatchButton2")
                {
                    matchID = int.Parse(MatchId2.Text);
                }
                else if (callerButton.Name == "MatchButton3")
                {
                    matchID = int.Parse(MatchId3.Text);
                }
                else if (callerButton.Name == "MatchButton4")
                {
                    matchID = int.Parse(MatchId4.Text);
                }
            }
            catch (System.FormatException)
            {
                // When the net cannot answer fast enough and the user has chosen
                // a match without the match information available, the button 
                // cannot be chosable.
                InfoText.Text = "Odota ...";
                return;
            }


            // Add matchID into url for detailed match info.
            //MatchInfoUrl = UrlString + "/" + String.Format("{0:0000000}", matchID);
            MatchInfoUrl = UrlString + "/" + String.Format("{0:000000}", matchID);

            // Get the data for the match and decompress it.
            try
            {
                // Json - text decompression
                string matchString = await OpenMatchInfoProxy.GetMatch(MatchInfoUrl);

                // deserialize match info site into an array.
                MatchStringArrayInfo = OpenMatchInfoProxy.deserializeMatchInfo(matchString);

            }
            catch (NullReferenceException)
            {
                InfoText.Text = "Ei tietoja";
            }
            catch (HttpRequestException)
            {
                InfoText.Text = "Tarkista internet-yhteys!";
            }

            // Parameters onto detailed page
            Dictionary < string, string> matchDetails = new Dictionary<string, string>();
            int width = MatchStringArrayInfo.GetLength(1);
            int height = MatchStringArrayInfo.GetLength(0);
            for (int i = 0; i < height; i++)
            {
                matchDetails.Add(MatchStringArrayInfo[i, 0], MatchStringArrayInfo[i, 1]);

            }

            // Navigate to the match information page, the detailed match screen.
            // Param: deserialized match information in a dictionary.

            Frame.Navigate(typeof(MatchInformationPage), matchDetails);

        }

        /// <summary>
        /// For showing the next screen of matches clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Forward_Tapped(object sender, TappedRoutedEventArgs e)
        {
            InfoText.Text = "";
            if (MatchStringList != null) matchListForward(true);  // browse forward
        }

        /// <summary>
        /// For showing the previous screen of matches clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Backward_Tapped(object sender, TappedRoutedEventArgs e)
        {
            InfoText.Text = "";
            if (MatchStringList != null) matchListForward(false); // false: browse backward
        }

        /// <summary>
        /// Event for loading MatchFrame in start of the program, fetches match.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private async void MatchFrame_Loading(FrameworkElement sender, object args)
        {
            RefreshMenu.Content = "VUOSI " + serieYear.ToString();
            InfoText.Text = "";

            try
            {
                // Json-text
                string matchString = await OpenMatchProxy.GetMatch(UrlString);

                // deserialize data into classes.
                MatchStringList = OpenMatchProxy.deserializeMatch(matchString);

                matchCount = MatchStringList.Count;
                InfoText.Text = matchCount.ToString() + " ottelua.";

            }
            catch (InvalidDataException)
            {

                // If no matches the empty screen is shown.
                MatchStringList = null;
                clearMatches();

                InfoText.Text = "Ei ottelutietoja";

            }
            catch (NullReferenceException)
            {
                InfoText.Text = "Ei tietoja";
            }
            catch (HttpRequestException)
            {
                InfoText.Text = "Tarkista internet-yhteys!";
            }
            finally
            {
                // Write the matches onto screen.
                if (MatchStringList != null) matchListForward(true); // true: search forward
            }
        }

        /// <summary>
        /// Writes the match headers into the screen.
        /// </summary>
        /// <param name="updirection">Shows the direction of the browsing.</param>
        private void matchListForward(bool updirection)
        {

            // Match button index i
            int i = 0;

            DateTimeFormatInfo dtfi = CultureInfo.CurrentUICulture.DateTimeFormat;
            dtfi.ShortTimePattern = "d";
            dtfi.ShortDatePattern = @"dd.MM.yyyy";
            DateTime dtdummy ;

            // Clear the frame first.
            clearMatches();
            
           
            // kokeilu
            /* int start = 10;
            if (oldLowStack.Count > 0)
            {
                //InfoText.Text = "stakki " + oldLowStack.Peek();
                start = oldLowStack.Pop();
                oldLowStack.Clear();
            }*/

            var matchEnumerator = MatchStringList.GetEnumerator(); // Get enumerator
            for (var iInd = 1; matchEnumerator.MoveNext() == true; iInd++)
            {
                var currentItem = matchEnumerator.Current; // Get current item.

                // Updirection goes to smaller match ids
                if (updirection) // Forward chosen.
                {
                    if (upSelect >= iInd)
                    {
                        continue; // already shown
                    }
                }
                else // updirection: false, backward chosen.
                {
                    // can we continue
                    if (oldLowStack.Count > 0)
                    {
                        oldLowSelect = oldLowStack.Peek();
                    }
                    else
                    {
                        oldLowSelect = 0;
                        InfoText.Text = "Otteluiden alku saavutettu.";
                    }

                    if (oldLowSelect > iInd)
                    {
                        continue; // already shown
                    }
                }

                // can continue
                upSelect = iInd;
                if (i == 0 && updirection)
                {
                    oldLowStack.Push(iInd); // previously shown first match saved in
                    lowSelect = iInd;
                }
                if (i == 0 && updirection == false)
                {
                    // the new lowest and latest line into memomy
                    if (oldLowStack.Count > 0)
                        lowSelect = oldLowStack.Pop();
                    else
                        oldLowSelect = 0;
                }

                if (i == 0)
                {

                    dtdummy = new DateTime(int.Parse(currentItem.MatchDate.Substring(0, 4)),
                         int.Parse(currentItem.MatchDate.Substring(5, 2)),
                         int.Parse(currentItem.MatchDate.Substring(8, 2)));
                    MatchDate0.Text = dtdummy.ToString("d");

                    MatchId0.Text = currentItem.Id.ToString();
                    HeaderHometeam0.Text = currentItem.HomeTeam.Name;
                    HeaderAwayteam0.Text = currentItem.AwayTeam.Name;
                    HeaderHomeGoals0.Text = currentItem.HomeGoals.ToString();
                    HeaderSlash0.Text = " - ";
                    HeaderSlashGoals0.Text = " - ";
                    HeaderAwayteamGoals0.Text = currentItem.AwayGoals.ToString();

                }
                if (i == 1)
                {
                    dtdummy = new DateTime(int.Parse(currentItem.MatchDate.Substring(0, 4)),
                    int.Parse(currentItem.MatchDate.Substring(5, 2)),
                    int.Parse(currentItem.MatchDate.Substring(8, 2)));
                    MatchDate1.Text = dtdummy.ToString("d");

                    MatchId1.Text = currentItem.Id.ToString();
                    HeaderHometeam1.Text = currentItem.HomeTeam.Name;
                    HeaderAwayteam1.Text = currentItem.AwayTeam.Name;
                    HeaderHomeGoals1.Text = currentItem.HomeGoals.ToString();
                    HeaderSlash1.Text = " - ";
                    HeaderSlashGoals1.Text = " - ";
                    HeaderAwayteamGoals1.Text = currentItem.AwayGoals.ToString();
                }
                if (i == 2)
                {
                    dtdummy = new DateTime(int.Parse(currentItem.MatchDate.Substring(0, 4)),
                    int.Parse(currentItem.MatchDate.Substring(5, 2)),
                    int.Parse(currentItem.MatchDate.Substring(8, 2)));
                    MatchDate2.Text = dtdummy.ToString("d");

                    MatchId2.Text = currentItem.Id.ToString();
                    HeaderHometeam2.Text = currentItem.HomeTeam.Name;
                    HeaderAwayteam2.Text = currentItem.AwayTeam.Name;
                    HeaderHomeGoals2.Text = currentItem.HomeGoals.ToString();
                    HeaderSlash2.Text = " - ";
                    HeaderSlashGoals2.Text = " - ";
                    HeaderAwayteamGoals2.Text = currentItem.AwayGoals.ToString();
                }
                if (i == 3)
                {
                    dtdummy = new DateTime(int.Parse(currentItem.MatchDate.Substring(0, 4)),
                    int.Parse(currentItem.MatchDate.Substring(5, 2)),
                    int.Parse(currentItem.MatchDate.Substring(8, 2)));
                    MatchDate3.Text = dtdummy.ToString("d");

                    MatchId3.Text = currentItem.Id.ToString();
                    HeaderHometeam3.Text = currentItem.HomeTeam.Name;
                    HeaderAwayteam3.Text = currentItem.AwayTeam.Name;
                    HeaderHomeGoals3.Text = currentItem.HomeGoals.ToString();
                    HeaderSlash3.Text = " - ";
                    HeaderSlashGoals3.Text = " - ";
                    HeaderAwayteamGoals3.Text = currentItem.AwayGoals.ToString();
                }
                if (i == 4)
                {
                    dtdummy = new DateTime(int.Parse(currentItem.MatchDate.Substring(0, 4)),
                    int.Parse(currentItem.MatchDate.Substring(5, 2)),
                    int.Parse(currentItem.MatchDate.Substring(8, 2)));
                    MatchDate4.Text = dtdummy.ToString("d");

                    MatchId4.Text = currentItem.Id.ToString();
                    HeaderHometeam4.Text = currentItem.HomeTeam.Name;
                    HeaderAwayteam4.Text = currentItem.AwayTeam.Name;
                    HeaderHomeGoals4.Text = currentItem.HomeGoals.ToString();
                    HeaderSlash4.Text = " - ";
                    HeaderSlashGoals4.Text = " - ";
                    HeaderAwayteamGoals4.Text = currentItem.AwayGoals.ToString();
                }

                // count the number of matches shown.
                i++;
                if (i > 4) break;
            }

        }

        private void clearMatches ()
        {
            
            MatchId0.Text = "";
            MatchDate0.Text = "";
            HeaderHometeam0.Text = "";
            HeaderAwayteam0.Text = "";
            HeaderHomeGoals0.Text = "";
            HeaderAwayteamGoals0.Text = "";
            HeaderSlashGoals0.Text = "";
            HeaderSlash0.Text = "";

            MatchId1.Text = "";
            MatchDate1.Text = "";
            HeaderHometeam1.Text = "";
            HeaderAwayteam1.Text = "";
            HeaderHomeGoals1.Text = "";
            HeaderAwayteamGoals1.Text = "";
            HeaderSlashGoals1.Text = "";
            HeaderSlash1.Text = "";

            MatchId2.Text = "";
            MatchDate2.Text = "";
            HeaderHometeam2.Text = "";
            HeaderAwayteam2.Text = "";
            HeaderHomeGoals2.Text = "";
            HeaderAwayteamGoals2.Text = "";
            HeaderSlashGoals2.Text = "";
            HeaderSlash2.Text = "";

            MatchId3.Text = "";
            MatchDate3.Text = "";
            HeaderHometeam3.Text = "";
            HeaderAwayteam3.Text = "";
            HeaderHomeGoals3.Text = "";
            HeaderAwayteamGoals3.Text = "";
            HeaderSlashGoals3.Text = "";
            HeaderSlash3.Text = "";

            MatchId4.Text = "";
            MatchDate4.Text = "";
            HeaderHometeam4.Text = "";
            HeaderAwayteam4.Text = "";
            HeaderHomeGoals4.Text = "";
            HeaderAwayteamGoals4.Text = "";
            HeaderSlashGoals4.Text = "";
            HeaderSlash4.Text = "";
        }

        private void RefreshMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            // Refresh the menu.
            oldLowStack.Clear();
            oldLowSelect = 0;
            lowSelect = 0;
            upSelect = 0;

            MatchFrame_Loading(this, null);
        }

    }
}

