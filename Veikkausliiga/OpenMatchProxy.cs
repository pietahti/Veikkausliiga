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
    public class OpenMatchProxy
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
        //public static List<RootObject> deserializeMatchInfo(string text)
        //{
        //    var serializer = new DataContractJsonSerializer(typeof(List<RootObject>));
        //    var ms = new MemoryStream(Encoding.UTF8.GetBytes(text));

        //    var data = (List<RootObject>)serializer.ReadObject(ms);
        //    return data;
        //}

        /// <summary>
        /// Deserializes Json text into classes.
        /// </summary>
        /// <param name="text">Json type text</param>
        /// <returns></returns>
        public static List<RootObject> deserializeMatch(string text)
        {
            var serializer = new DataContractJsonSerializer(typeof(List<RootObject>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(text));

            var data = (List<RootObject>)serializer.ReadObject(ms);
            
            return data;
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

        /// <summary>
        /// Class definitions for Json deserialization.
        /// </summary>
        /// 
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
        public class RootObject
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
            public object GameStarted { get; set; }

            [DataMember]
            public List<object> MatchEvents { get; set; }

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

    }
}

