using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScoresMaster.Models;

namespace ScoresMaster
{
    public class Api
    {
        public static string GetMatches(string id)
        {
            string result = null;
            string requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=78b7f4f0-781d-11eb-b7ce-ab513a4a050f&season_id="+id+"&date_from="+DateTime.Now+"";
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
            return result;
        }

    }
}