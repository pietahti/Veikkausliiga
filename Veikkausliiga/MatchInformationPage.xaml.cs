using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Globalization; // for datetime formatting

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Veikkausliiga
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MatchInformationPage : Page
    {
        public MatchInformationPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Dictionary<string, string> matchInfoDict = new Dictionary<string, string>();

            // Set the parameters onto screen.
            matchInfoDict = e.Parameter as Dictionary<string, string>;
            
            // Match information
            MatchTeams.Text = matchInfoDict["HomeName"].ToString() + " - "
                + matchInfoDict["AwayName"].ToString();

            // Match date
            DateTimeFormatInfo dtfi = CultureInfo.CurrentUICulture.DateTimeFormat;
            dtfi.ShortTimePattern = "d";
            dtfi.ShortDatePattern = @"dd.MM.yyyy";

            string DateText = matchInfoDict["MatchDate"].ToString();
            DateTime dtdummy = new DateTime(int.Parse(DateText.Substring(0, 4)),
              int.Parse(DateText.Substring(5, 2)),
              int.Parse(DateText.Substring(8, 2)));
            MatchDate.Text = dtdummy.ToString("d");

            // Hometeam
            string HomeIcon = matchInfoDict["HomeIcon"].ToString();
            HomeLogo.Source = new BitmapImage(new Uri(HomeIcon, UriKind.Absolute));

            HomeTeam.Text = matchInfoDict["HomeName"].ToString();
            HomeFullName.Text = matchInfoDict["HomeFullName"].ToString();

            HomeGoals.Text = matchInfoDict["HomeGoals"].ToString();

            // Awayteam 
            string AwayIcon = matchInfoDict["AwayIcon"].ToString();
            AwayLogo.Source = new BitmapImage(new Uri(AwayIcon, UriKind.Absolute));

            AwayTeam.Text = matchInfoDict["AwayName"].ToString();
            AwayFullName.Text = matchInfoDict["AwayFullName"].ToString();

            AwayGoals.Text = matchInfoDict["AwayGoals"].ToString();

        }

        private void OpenMainPage(object sender, TappedRoutedEventArgs e)
        {
            
            // Back to Matchlist 
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
           
        }
    }
}
