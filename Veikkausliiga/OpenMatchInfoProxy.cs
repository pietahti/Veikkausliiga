using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Veikkausliiga
{
    public class OpenMatchInfoProxy
    {
        /// <summary>
        /// Decompress net content
        /// </summary>
        /// <param name="gzip"></param>
        /// <returns></returns>
        static byte[] Decompress(byte[] gzip)
        {
            using (System.IO.Compression.GZipStream stream = new GZipStream(new MemoryStream(gzip),
                                  CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }

        /// <summary>
        /// Deserializes Json text into classes. The match info.
        /// </summary>
        /// <param name="text">Json type text</param>
        /// <returns></returns>
        public static string[,] /*Task<RootObject>*/ deserializeMatchInfo(string text)
        {
            //var serializer = new DataContractJsonSerializer(typeof(List<RootObject>));
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(text));

            //var data = (List<RootObject>)serializer.ReadObject(ms);
            var data = (RootObject)serializer.ReadObject(ms);

            string HomeIcon = String.Format(data.Match.HomeTeam.LogoUrl);
            string AwayIcon = String.Format(data.Match.AwayTeam.LogoUrl);
            string[,] retti = { { "MatchId", data.Match.Id.ToString() } ,
                                { "MatchDate", data.Match.MatchDate } ,
                                { "HomeIcon", HomeIcon.ToString() } ,
                                { "HomeName", data.Match.HomeTeam.Name} ,
                                { "HomeFullName", data.Match.HomeTeam.FullName } ,
                                { "HomeGoals", data.Match.HomeGoals.ToString() } ,
                                { "AwayName", data.Match.AwayTeam.Name } ,
                                { "AwayFullName", data.Match.AwayTeam.FullName } ,
                                { "AwayGoals", data.Match.AwayGoals.ToString() } ,
                                { "AwayIcon", AwayIcon.ToString() }
                            };

            return retti;
        }

        /// <summary>
        /// Gets the net content.
        /// </summary>
        /// <param name="UrlMatches">Url for the net content.</param>
        /// <returns></returns>
        public async static Task<string> GetMatch(string UrlMatches)  // async return oltava void, task or task<T>
        {
            // ari's solution
            var http = new HttpClient();
            var response = await http.GetAsync(UrlMatches);
            //var result = await response.Content.ReadAsStringAsync();
            var bresult = await response.Content.ReadAsByteArrayAsync(); // this returns byte array
            var result = Decompress(bresult);
            string text = System.Text.ASCIIEncoding.ASCII.GetString(result);

            // Return decompressed data
            return text;
        }

        [DataContract]
        public class HomeTeam
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string FullName { get; set; }

            [DataMember]
            public string Logo { get; set; }

            [DataMember]
            public string LogoUrl { get; set; }

            [DataMember]
            public int Ranking { get; set; }

            [DataMember]
            public string Message { get; set; }
        }

        [DataContract]
        public class AwayTeam
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string FullName { get; set; }

            [DataMember]
            public string Logo { get; set; }

            [DataMember]
            public string LogoUrl { get; set; }

            [DataMember]
            public int Ranking { get; set; }

            [DataMember]
            public string Message { get; set; }
        }

        
        [DataContract]
        public class MatchEvent
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public int MatchId { get; set; }

            [DataMember]
            public int EventMinute { get; set; }

            [DataMember]
            public int ElapsedSeconds { get; set; }

            [DataMember]
            public int TeamId { get; set; }

            [DataMember]
            public string Description { get; set; }

            [DataMember]
            public string FullDescription { get; set; }

            [DataMember]
            public string EventTypeIcon { get; set; }

            [DataMember]
            public string EventType { get; set; }

            [DataMember]
            public int EventTypeEnum { get; set; }

            [DataMember]
            public int PlayerId { get; set; }

            [DataMember]
            public object Player { get; set; }

            [DataMember]
            public string Identifier { get; set; }

            [DataMember]
            public object AssistPlayers { get; set; }

            [DataMember]
            public object AssistPlayerNames { get; set; }

            [DataMember]
            public object Modifier { get; set; }

            [DataMember]
            public object Score { get; set; }

            [DataMember]
            public bool IsGoal { get; set; }
        }

        [DataContract]
        public class Match
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public object Round { get; set; }

            [DataMember]
            public int RoundNumber { get; set; }

            [DataMember]
            public string MatchDate { get; set; }

            [DataMember]
            public HomeTeam HomeTeam { get; set; }

            [DataMember]
            public AwayTeam AwayTeam { get; set; }

            [DataMember]
            public int HomeGoals { get; set; }

            [DataMember]
            public int AwayGoals { get; set; }

            [DataMember]
            public int Status { get; set; }

            [DataMember]
            public int PlayedMinutes { get; set; }

            [DataMember]
            public object SecondHalfStarted { get; set; }

            [DataMember]
            public string GameStarted { get; set; }

            [DataMember]
            public List<MatchEvent> MatchEvents { get; set; }

            [DataMember]
            public List<object> PeriodResults { get; set; }

            [DataMember]
            public bool OnlyResultAvailable { get; set; }

            [DataMember]
            public int Season { get; set; }

            [DataMember]
            public string Country { get; set; }

            [DataMember]
            public string League { get; set; }
        }

            
        [DataContract]
        public class News
        {
            [DataMember]
            public string Title { get; set; }

            [DataMember]
            public string Summary { get; set; }

            [DataMember]
            public string DateTime { get; set; }

            [DataMember]
            public string Url { get; set; }

            [DataMember]
            public string OriginalUrl { get; set; }

            [DataMember]
            public string Source { get; set; }

            [DataMember]
            public string Content { get; set; }

            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public object ImageUrl { get; set; }

            [DataMember]
            public List<object> RelatedTeams { get; set; }
        }

        
        [DataContract]
        public class Team
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string FullName { get; set; }

            [DataMember]
            public string Logo { get; set; }

            [DataMember]
            public string LogoUrl { get; set; }

            [DataMember]
            public int Ranking { get; set; }

            [DataMember]
            public string Message { get; set; }
        }
        
        [DataContract]
        public class Player
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public int Number { get; set; }

            [DataMember]
            public object Team { get; set; }
        }

        [DataContract]
        public class Line
        {
            [DataMember]
            public Team Team { get; set; }

            [DataMember]
            public List<Player> Players { get; set; }
        }
        
        [DataContract]
        public class Team2
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string FullName { get; set; }

            [DataMember]
            public string Logo { get; set; }

            [DataMember]
            public string LogoUrl { get; set; }

            [DataMember]
            public int Ranking { get; set; }

            [DataMember]
            public string Message { get; set; }
        }

        [DataContract]
        public class TeamStatsLast5
        {
            [DataMember]
            public Team2 Team { get; set; }

            [DataMember]
            public int GamesPlayed { get; set; }

            [DataMember]
            public int Won { get; set; }

            [DataMember]
            public int Tie { get; set; }

            [DataMember]
            public int Lost { get; set; }

            [DataMember]
            public int GoalsScored { get; set; }

            [DataMember]
            public int GoalsAgainst { get; set; }

            [DataMember]
            public int Points { get; set; }

            [DataMember]
            public bool Highlight { get; set; }
        }

        [DataContract]
        public class Team3
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string FullName { get; set; }

            [DataMember]
            public string Logo { get; set; }

            [DataMember]
            public string LogoUrl { get; set; }

            [DataMember]
            public int Ranking { get; set; }

            [DataMember]
            public string Message { get; set; }
        }

        [DataContract]
        public class TeamStatsLast10
        {
            [DataMember]
            public Team3 Team { get; set; }

            [DataMember]
            public int GamesPlayed { get; set; }

            [DataMember]
            public int Won { get; set; }

            [DataMember]
            public int Tie { get; set; }

            [DataMember]
            public int Lost { get; set; }

            [DataMember]
            public int GoalsScored { get; set; }

            [DataMember]
            public int GoalsAgainst { get; set; }

            [DataMember]
            public int Points { get; set; }

            [DataMember]
            public bool Highlight { get; set; }
        }

        [DataContract]
        public class MatchAction
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public int Minute { get; set; }

            [DataMember]
            public string Description { get; set; }

            [DataMember]
            public string TeamName { get; set; }

            [DataMember]
            public string PlayerName { get; set; }
        }

        [DataContract]
        public class RootObject
        {
            [DataMember]
            public Match Match { get; set; }

            [DataMember]
            public List<News> News { get; set; }

            [DataMember]
            public List<Line> Lines { get; set; }

            [DataMember]
            public List<TeamStatsLast5> TeamStatsLast5 { get; set; }

            [DataMember]
            public List<TeamStatsLast10> TeamStatsLast10 { get; set; }

            [DataMember]
            public List<object> MatchActions { get; set; }

           
        }
    }
}
