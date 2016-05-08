using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 510
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                640, // index: 640, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                6, // array length: 6
                1062, // index: 1062, string: "Lines"
                1068, // index: 1068, string: "Match"
                1074, // index: 1074, string: "MatchActions"
                1087, // index: 1087, string: "News"
                1092, // index: 1092, string: "TeamStatsLast10"
                1108, // index: 1108, string: "TeamStatsLast5"
                6, // array length: 6
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                2, // array length: 2
                1123, // index: 1123, string: "Players"
                1131, // index: 1131, string: "Team"
                2, // array length: 2
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                4, // array length: 4
                1136, // index: 1136, string: "Id"
                1139, // index: 1139, string: "Name"
                1144, // index: 1144, string: "Number"
                1131, // index: 1131, string: "Team"
                4, // array length: 4
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                640, // index: 640, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                1189, // index: 1189, string: "AwayGoals"
                1199, // index: 1199, string: "AwayTeam"
                1208, // index: 1208, string: "Country"
                1216, // index: 1216, string: "GameStarted"
                1228, // index: 1228, string: "HomeGoals"
                1238, // index: 1238, string: "HomeTeam"
                1136, // index: 1136, string: "Id"
                1247, // index: 1247, string: "League"
                1254, // index: 1254, string: "MatchDate"
                1264, // index: 1264, string: "MatchEvents"
                1276, // index: 1276, string: "OnlyResultAvailable"
                1296, // index: 1296, string: "PeriodResults"
                1310, // index: 1310, string: "PlayedMinutes"
                1324, // index: 1324, string: "Round"
                1330, // index: 1330, string: "RoundNumber"
                1342, // index: 1342, string: "Season"
                1349, // index: 1349, string: "SecondHalfStarted"
                1367, // index: 1367, string: "Status"
                18, // array length: 18
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                1374, // index: 1374, string: "AssistPlayerNames"
                1392, // index: 1392, string: "AssistPlayers"
                1406, // index: 1406, string: "Description"
                1418, // index: 1418, string: "ElapsedSeconds"
                1433, // index: 1433, string: "EventMinute"
                1445, // index: 1445, string: "EventType"
                1455, // index: 1455, string: "EventTypeEnum"
                1469, // index: 1469, string: "EventTypeIcon"
                1483, // index: 1483, string: "FullDescription"
                1136, // index: 1136, string: "Id"
                1499, // index: 1499, string: "Identifier"
                1510, // index: 1510, string: "IsGoal"
                1517, // index: 1517, string: "MatchId"
                1525, // index: 1525, string: "Modifier"
                1534, // index: 1534, string: "Player"
                1541, // index: 1541, string: "PlayerId"
                1550, // index: 1550, string: "Score"
                1556, // index: 1556, string: "TeamId"
                18, // array length: 18
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                640, // index: 640, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                10, // array length: 10
                1563, // index: 1563, string: "Content"
                1571, // index: 1571, string: "DateTime"
                1136, // index: 1136, string: "Id"
                1580, // index: 1580, string: "ImageUrl"
                1589, // index: 1589, string: "OriginalUrl"
                1601, // index: 1601, string: "RelatedTeams"
                1614, // index: 1614, string: "Source"
                1621, // index: 1621, string: "Summary"
                1629, // index: 1629, string: "Title"
                1635, // index: 1635, string: "Url"
                10, // array length: 10
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                9, // array length: 9
                1639, // index: 1639, string: "GamesPlayed"
                1651, // index: 1651, string: "GoalsAgainst"
                1664, // index: 1664, string: "GoalsScored"
                1676, // index: 1676, string: "Highlight"
                1686, // index: 1686, string: "Lost"
                1691, // index: 1691, string: "Points"
                1131, // index: 1131, string: "Team"
                1698, // index: 1698, string: "Tie"
                1702, // index: 1702, string: "Won"
                9, // array length: 9
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                9, // array length: 9
                1639, // index: 1639, string: "GamesPlayed"
                1651, // index: 1651, string: "GoalsAgainst"
                1664, // index: 1664, string: "GoalsScored"
                1676, // index: 1676, string: "Highlight"
                1686, // index: 1686, string: "Lost"
                1691, // index: 1691, string: "Points"
                1131, // index: 1131, string: "Team"
                1698, // index: 1698, string: "Tie"
                1702, // index: 1702, string: "Won"
                9, // array length: 9
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                640, // index: 640, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                640, // index: 640, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                18, // array length: 18
                1189, // index: 1189, string: "AwayGoals"
                1199, // index: 1199, string: "AwayTeam"
                1208, // index: 1208, string: "Country"
                1216, // index: 1216, string: "GameStarted"
                1228, // index: 1228, string: "HomeGoals"
                1238, // index: 1238, string: "HomeTeam"
                1136, // index: 1136, string: "Id"
                1247, // index: 1247, string: "League"
                1254, // index: 1254, string: "MatchDate"
                1264, // index: 1264, string: "MatchEvents"
                1276, // index: 1276, string: "OnlyResultAvailable"
                1296, // index: 1296, string: "PeriodResults"
                1310, // index: 1310, string: "PlayedMinutes"
                1324, // index: 1324, string: "Round"
                1330, // index: 1330, string: "RoundNumber"
                1342, // index: 1342, string: "Season"
                1349, // index: 1349, string: "SecondHalfStarted"
                1367, // index: 1367, string: "Status"
                18, // array length: 18
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                7, // array length: 7
                1151, // index: 1151, string: "FullName"
                1136, // index: 1136, string: "Id"
                1160, // index: 1160, string: "Logo"
                1165, // index: 1165, string: "LogoUrl"
                1173, // index: 1173, string: "Message"
                1139, // index: 1139, string: "Name"
                1181, // index: 1181, string: "Ranking"
                7, // array length: 7
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285, // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
                285  // index: 285, string: "http://schemas.datacontract.org/2004/07/Veikkausliiga"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=62
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Cult" +
                                "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                "f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Match, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                "03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0." +
                                "0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTo" +
                                "ken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
                                "n=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team3, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0" +
                                ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team2, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Cult" +
                                "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                "f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=16
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // OpenMatchInfoProxy.RootObject
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 255, // OpenMatchInfoProxy.RootObject
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 255, // OpenMatchInfoProxy.RootObject
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 8,
                    MemberNamesListIndex = 10,
                    MemberNamespacesListIndex = 17,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 370, // OpenMatchInfoProxy.Line
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 370, // OpenMatchInfoProxy.Line
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 370, // OpenMatchInfoProxy.Line
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 24,
                    ContractNamespacesListIndex = 27,
                    MemberNamesListIndex = 29,
                    MemberNamespacesListIndex = 32,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 427, // OpenMatchInfoProxy.Player
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 427, // OpenMatchInfoProxy.Player
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 427, // OpenMatchInfoProxy.Player
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 35,
                    ContractNamespacesListIndex = 40,
                    MemberNamesListIndex = 42,
                    MemberNamespacesListIndex = 47,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 453, // OpenMatchInfoProxy.Team
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 453, // OpenMatchInfoProxy.Team
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 453, // OpenMatchInfoProxy.Team
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 52,
                    ContractNamespacesListIndex = 60,
                    MemberNamesListIndex = 62,
                    MemberNamespacesListIndex = 70,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 477, // OpenMatchInfoProxy.Match
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 477, // OpenMatchInfoProxy.Match
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 477, // OpenMatchInfoProxy.Match
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Match, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Match, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 78,
                    ContractNamespacesListIndex = 97,
                    MemberNamesListIndex = 99,
                    MemberNamespacesListIndex = 118,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 502, // OpenMatchInfoProxy.AwayTeam
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 502, // OpenMatchInfoProxy.AwayTeam
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 502, // OpenMatchInfoProxy.AwayTeam
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 137,
                    ContractNamespacesListIndex = 145,
                    MemberNamesListIndex = 147,
                    MemberNamespacesListIndex = 155,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 530, // OpenMatchInfoProxy.HomeTeam
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 530, // OpenMatchInfoProxy.HomeTeam
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 530, // OpenMatchInfoProxy.HomeTeam
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 163,
                    ContractNamespacesListIndex = 171,
                    MemberNamesListIndex = 173,
                    MemberNamespacesListIndex = 181,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 595, // OpenMatchInfoProxy.MatchEvent
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 595, // OpenMatchInfoProxy.MatchEvent
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 595, // OpenMatchInfoProxy.MatchEvent
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 189,
                    ContractNamespacesListIndex = 208,
                    MemberNamesListIndex = 210,
                    MemberNamespacesListIndex = 229,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 729, // OpenMatchInfoProxy.News
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 729, // OpenMatchInfoProxy.News
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 729, // OpenMatchInfoProxy.News
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 248,
                    ContractNamespacesListIndex = 259,
                    MemberNamesListIndex = 261,
                    MemberNamespacesListIndex = 272,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 795, // OpenMatchInfoProxy.TeamStatsLast10
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 795, // OpenMatchInfoProxy.TeamStatsLast10
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 795, // OpenMatchInfoProxy.TeamStatsLast10
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
                                    "n=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
                                    "n=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 283,
                    ContractNamespacesListIndex = 293,
                    MemberNamesListIndex = 295,
                    MemberNamespacesListIndex = 305,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 830, // OpenMatchInfoProxy.Team3
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 830, // OpenMatchInfoProxy.Team3
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 830, // OpenMatchInfoProxy.Team3
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team3, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team3, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 315,
                    ContractNamespacesListIndex = 323,
                    MemberNamesListIndex = 325,
                    MemberNamespacesListIndex = 333,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 896, // OpenMatchInfoProxy.TeamStatsLast5
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 896, // OpenMatchInfoProxy.TeamStatsLast5
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 896, // OpenMatchInfoProxy.TeamStatsLast5
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 341,
                    ContractNamespacesListIndex = 351,
                    MemberNamesListIndex = 353,
                    MemberNamespacesListIndex = 363,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 930, // OpenMatchInfoProxy.Team2
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 930, // OpenMatchInfoProxy.Team2
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 930, // OpenMatchInfoProxy.Team2
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team2, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Team2, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 373,
                    ContractNamespacesListIndex = 381,
                    MemberNamesListIndex = 383,
                    MemberNamespacesListIndex = 391,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 988, // OpenMatchProxy.RootObject
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 988, // OpenMatchProxy.RootObject
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 988, // OpenMatchProxy.RootObject
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 399,
                    ContractNamespacesListIndex = 418,
                    MemberNamesListIndex = 420,
                    MemberNamespacesListIndex = 439,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1014, // OpenMatchProxy.AwayTeam
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 1014, // OpenMatchProxy.AwayTeam
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 1014, // OpenMatchProxy.AwayTeam
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+AwayTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 458,
                    ContractNamespacesListIndex = 466,
                    MemberNamesListIndex = 468,
                    MemberNamespacesListIndex = 476,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1038, // OpenMatchProxy.HomeTeam
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 1038, // OpenMatchProxy.HomeTeam
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 1038, // OpenMatchProxy.HomeTeam
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+HomeTeam, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 484,
                    ContractNamespacesListIndex = 492,
                    MemberNamesListIndex = 494,
                    MemberNamespacesListIndex = 502,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=9
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 339, // ArrayOfOpenMatchInfoProxy.Line
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 339, // ArrayOfOpenMatchInfoProxy.Line
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 339, // ArrayOfOpenMatchInfoProxy.Line
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 370, // OpenMatchInfoProxy.Line
                    KeyNameIndex = -1,
                    ItemNameIndex = 370, // OpenMatchInfoProxy.Line
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Line, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 394, // ArrayOfOpenMatchInfoProxy.Player
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 394, // ArrayOfOpenMatchInfoProxy.Player
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 394, // ArrayOfOpenMatchInfoProxy.Player
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                    "f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                    "f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 427, // OpenMatchInfoProxy.Player
                    KeyNameIndex = -1,
                    ItemNameIndex = 427, // OpenMatchInfoProxy.Player
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+Player, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 558, // ArrayOfOpenMatchInfoProxy.MatchEvent
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 558, // ArrayOfOpenMatchInfoProxy.MatchEvent
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 558, // ArrayOfOpenMatchInfoProxy.MatchEvent
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 595, // OpenMatchInfoProxy.MatchEvent
                    KeyNameIndex = -1,
                    ItemNameIndex = 595, // OpenMatchInfoProxy.MatchEvent
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+MatchEvent, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 625, // ArrayOfanyType
                        NamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 625, // ArrayOfanyType
                        StableNameNamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 625, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 698, // ArrayOfOpenMatchInfoProxy.News
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 698, // ArrayOfOpenMatchInfoProxy.News
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 698, // ArrayOfOpenMatchInfoProxy.News
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 729, // OpenMatchInfoProxy.News
                    KeyNameIndex = -1,
                    ItemNameIndex = 729, // OpenMatchInfoProxy.News
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+News, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 753, // ArrayOfOpenMatchInfoProxy.TeamStatsLast10
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 753, // ArrayOfOpenMatchInfoProxy.TeamStatsLast10
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 753, // ArrayOfOpenMatchInfoProxy.TeamStatsLast10
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 795, // OpenMatchInfoProxy.TeamStatsLast10
                    KeyNameIndex = -1,
                    ItemNameIndex = 795, // OpenMatchInfoProxy.TeamStatsLast10
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast10, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
                                "n=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 855, // ArrayOfOpenMatchInfoProxy.TeamStatsLast5
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 855, // ArrayOfOpenMatchInfoProxy.TeamStatsLast5
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 855, // ArrayOfOpenMatchInfoProxy.TeamStatsLast5
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 896, // OpenMatchInfoProxy.TeamStatsLast5
                    KeyNameIndex = -1,
                    ItemNameIndex = 896, // OpenMatchInfoProxy.TeamStatsLast5
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchInfoProxy+TeamStatsLast5, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 955, // ArrayOfOpenMatchProxy.RootObject
                        NamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        StableNameIndex = 955, // ArrayOfOpenMatchProxy.RootObject
                        StableNameNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        TopLevelElementNameIndex = 955, // ArrayOfOpenMatchProxy.RootObject
                        TopLevelElementNamespaceIndex = 285, // http://schemas.datacontract.org/2004/07/Veikkausliiga
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                    "f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                                    "f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 988, // OpenMatchProxy.RootObject
                    KeyNameIndex = -1,
                    ItemNameIndex = 988, // OpenMatchProxy.RootObject
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Veikkausliiga.OpenMatchProxy+RootObject, Veikkausliiga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 625, // ArrayOfanyType
                        NamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 625, // ArrayOfanyType
                        StableNameNamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 625, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 640, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=25
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteOpenMatchInfoProxy_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadOpenMatchInfoProxy_RootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type8.WriteArrayOfOpenMatchInfoProxy_LineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type7.ReadArrayOfOpenMatchInfoProxy_LineFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type9.ReadArrayOfOpenMatchInfoProxy_LineFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type13.WriteOpenMatchInfoProxy_LineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type12.ReadOpenMatchInfoProxy_LineFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type18.WriteArrayOfOpenMatchInfoProxy_PlayerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type17.ReadArrayOfOpenMatchInfoProxy_PlayerFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type19.ReadArrayOfOpenMatchInfoProxy_PlayerFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type23.WriteOpenMatchInfoProxy_PlayerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type22.ReadOpenMatchInfoProxy_PlayerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type27.WriteOpenMatchInfoProxy_TeamToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type26.ReadOpenMatchInfoProxy_TeamFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteOpenMatchInfoProxy_MatchToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadOpenMatchInfoProxy_MatchFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteOpenMatchInfoProxy_AwayTeamToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadOpenMatchInfoProxy_AwayTeamFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type39.WriteOpenMatchInfoProxy_HomeTeamToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type38.ReadOpenMatchInfoProxy_HomeTeamFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type44.WriteArrayOfOpenMatchInfoProxy_MatchEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type43.ReadArrayOfOpenMatchInfoProxy_MatchEventFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type45.ReadArrayOfOpenMatchInfoProxy_MatchEventFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteOpenMatchInfoProxy_MatchEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadOpenMatchInfoProxy_MatchEventFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type54.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type53.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type55.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type60.WriteArrayOfOpenMatchInfoProxy_NewsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type59.ReadArrayOfOpenMatchInfoProxy_NewsFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type61.ReadArrayOfOpenMatchInfoProxy_NewsFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type65.WriteOpenMatchInfoProxy_NewsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type64.ReadOpenMatchInfoProxy_NewsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type70.WriteArrayOfOpenMatchInfoProxy_TeamStatsLast10ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type69.ReadArrayOfOpenMatchInfoProxy_TeamStatsLast10FromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type71.ReadArrayOfOpenMatchInfoProxy_TeamStatsLast10FromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type75.WriteOpenMatchInfoProxy_TeamStatsLast10ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type74.ReadOpenMatchInfoProxy_TeamStatsLast10FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteOpenMatchInfoProxy_Team3ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadOpenMatchInfoProxy_Team3FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type84.WriteArrayOfOpenMatchInfoProxy_TeamStatsLast5ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type83.ReadArrayOfOpenMatchInfoProxy_TeamStatsLast5FromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type85.ReadArrayOfOpenMatchInfoProxy_TeamStatsLast5FromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type89.WriteOpenMatchInfoProxy_TeamStatsLast5ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type88.ReadOpenMatchInfoProxy_TeamStatsLast5FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type93.WriteOpenMatchInfoProxy_Team2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type92.ReadOpenMatchInfoProxy_Team2FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type98.WriteArrayOfOpenMatchProxy_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type97.ReadArrayOfOpenMatchProxy_RootObjectFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type99.ReadArrayOfOpenMatchProxy_RootObjectFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type103.WriteOpenMatchProxy_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type102.ReadOpenMatchProxy_RootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type107.WriteOpenMatchProxy_AwayTeamToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type106.ReadOpenMatchProxy_AwayTeamFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type111.WriteOpenMatchProxy_HomeTeamToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type110.ReadOpenMatchProxy_HomeTeamFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type116.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type115.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type117.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r',
            'o','x','y','.','R','o','o','t','O','b','j','e','c','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'd','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','V','e','i','k','k',
            'a','u','s','l','i','i','g','a','\0','A','r','r','a','y','O','f','O','p','e','n','M','a','t','c','h','I','n','f','o','P',
            'r','o','x','y','.','L','i','n','e','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','L',
            'i','n','e','\0','A','r','r','a','y','O','f','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.',
            'P','l','a','y','e','r','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','P','l','a','y',
            'e','r','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','T','e','a','m','\0','O','p','e',
            'n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','M','a','t','c','h','\0','O','p','e','n','M','a','t','c',
            'h','I','n','f','o','P','r','o','x','y','.','A','w','a','y','T','e','a','m','\0','O','p','e','n','M','a','t','c','h','I',
            'n','f','o','P','r','o','x','y','.','H','o','m','e','T','e','a','m','\0','A','r','r','a','y','O','f','O','p','e','n','M',
            'a','t','c','h','I','n','f','o','P','r','o','x','y','.','M','a','t','c','h','E','v','e','n','t','\0','O','p','e','n','M',
            'a','t','c','h','I','n','f','o','P','r','o','x','y','.','M','a','t','c','h','E','v','e','n','t','\0','A','r','r','a','y',
            'O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o',
            's','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n',
            '/','A','r','r','a','y','s','\0','A','r','r','a','y','O','f','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r',
            'o','x','y','.','N','e','w','s','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','N','e',
            'w','s','\0','A','r','r','a','y','O','f','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','T',
            'e','a','m','S','t','a','t','s','L','a','s','t','1','0','\0','O','p','e','n','M','a','t','c','h','I','n','f','o','P','r',
            'o','x','y','.','T','e','a','m','S','t','a','t','s','L','a','s','t','1','0','\0','O','p','e','n','M','a','t','c','h','I',
            'n','f','o','P','r','o','x','y','.','T','e','a','m','3','\0','A','r','r','a','y','O','f','O','p','e','n','M','a','t','c',
            'h','I','n','f','o','P','r','o','x','y','.','T','e','a','m','S','t','a','t','s','L','a','s','t','5','\0','O','p','e','n',
            'M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','T','e','a','m','S','t','a','t','s','L','a','s','t','5','\0',
            'O','p','e','n','M','a','t','c','h','I','n','f','o','P','r','o','x','y','.','T','e','a','m','2','\0','A','r','r','a','y',
            'O','f','O','p','e','n','M','a','t','c','h','P','r','o','x','y','.','R','o','o','t','O','b','j','e','c','t','\0','O','p',
            'e','n','M','a','t','c','h','P','r','o','x','y','.','R','o','o','t','O','b','j','e','c','t','\0','O','p','e','n','M','a',
            't','c','h','P','r','o','x','y','.','A','w','a','y','T','e','a','m','\0','O','p','e','n','M','a','t','c','h','P','r','o',
            'x','y','.','H','o','m','e','T','e','a','m','\0','L','i','n','e','s','\0','M','a','t','c','h','\0','M','a','t','c','h','A',
            'c','t','i','o','n','s','\0','N','e','w','s','\0','T','e','a','m','S','t','a','t','s','L','a','s','t','1','0','\0','T','e',
            'a','m','S','t','a','t','s','L','a','s','t','5','\0','P','l','a','y','e','r','s','\0','T','e','a','m','\0','I','d','\0','N',
            'a','m','e','\0','N','u','m','b','e','r','\0','F','u','l','l','N','a','m','e','\0','L','o','g','o','\0','L','o','g','o','U',
            'r','l','\0','M','e','s','s','a','g','e','\0','R','a','n','k','i','n','g','\0','A','w','a','y','G','o','a','l','s','\0','A',
            'w','a','y','T','e','a','m','\0','C','o','u','n','t','r','y','\0','G','a','m','e','S','t','a','r','t','e','d','\0','H','o',
            'm','e','G','o','a','l','s','\0','H','o','m','e','T','e','a','m','\0','L','e','a','g','u','e','\0','M','a','t','c','h','D',
            'a','t','e','\0','M','a','t','c','h','E','v','e','n','t','s','\0','O','n','l','y','R','e','s','u','l','t','A','v','a','i',
            'l','a','b','l','e','\0','P','e','r','i','o','d','R','e','s','u','l','t','s','\0','P','l','a','y','e','d','M','i','n','u',
            't','e','s','\0','R','o','u','n','d','\0','R','o','u','n','d','N','u','m','b','e','r','\0','S','e','a','s','o','n','\0','S',
            'e','c','o','n','d','H','a','l','f','S','t','a','r','t','e','d','\0','S','t','a','t','u','s','\0','A','s','s','i','s','t',
            'P','l','a','y','e','r','N','a','m','e','s','\0','A','s','s','i','s','t','P','l','a','y','e','r','s','\0','D','e','s','c',
            'r','i','p','t','i','o','n','\0','E','l','a','p','s','e','d','S','e','c','o','n','d','s','\0','E','v','e','n','t','M','i',
            'n','u','t','e','\0','E','v','e','n','t','T','y','p','e','\0','E','v','e','n','t','T','y','p','e','E','n','u','m','\0','E',
            'v','e','n','t','T','y','p','e','I','c','o','n','\0','F','u','l','l','D','e','s','c','r','i','p','t','i','o','n','\0','I',
            'd','e','n','t','i','f','i','e','r','\0','I','s','G','o','a','l','\0','M','a','t','c','h','I','d','\0','M','o','d','i','f',
            'i','e','r','\0','P','l','a','y','e','r','\0','P','l','a','y','e','r','I','d','\0','S','c','o','r','e','\0','T','e','a','m',
            'I','d','\0','C','o','n','t','e','n','t','\0','D','a','t','e','T','i','m','e','\0','I','m','a','g','e','U','r','l','\0','O',
            'r','i','g','i','n','a','l','U','r','l','\0','R','e','l','a','t','e','d','T','e','a','m','s','\0','S','o','u','r','c','e',
            '\0','S','u','m','m','a','r','y','\0','T','i','t','l','e','\0','U','r','l','\0','G','a','m','e','s','P','l','a','y','e','d',
            '\0','G','o','a','l','s','A','g','a','i','n','s','t','\0','G','o','a','l','s','S','c','o','r','e','d','\0','H','i','g','h',
            'l','i','g','h','t','\0','L','o','s','t','\0','P','o','i','n','t','s','\0','T','i','e','\0','W','o','n','\0'};
    }
}
