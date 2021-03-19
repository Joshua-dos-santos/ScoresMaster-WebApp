using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace ScoresMaster
{
    public class Api
    {
        public static string Get_Matches_API()
        {
            string result = null;
            string requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=78b7f4f0-781d-11eb-b7ce-ab513a4a050f&season_id=352&date_from=2021-03-18";
            WebRequest requestObject = WebRequest.Create(requestString);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }
            /*            result = result.Replace("{\"response_code\":0,\"results\":[", "");
                        result = result.Remove(result.Length - 2, 2);*/
            return result;
        }
    }
}