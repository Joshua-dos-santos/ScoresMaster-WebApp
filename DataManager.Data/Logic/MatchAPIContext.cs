using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Data.Logic
{
    class MatchAPIContext : IMatchContext
    {
        public IEnumerable<MatchDTO> GetAllMatches(int id, MatchDTO matchDTO)
        {
            string result = null;
            string requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=78b7f4f0-781d-11eb-b7ce-ab513a4a050f&season_id=" + id + "&date_from=" + DateTime.Now + "";
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
            List<MatchDTO> matchList = new List<MatchDTO>();
            dynamic matchData = JsonConvert.DeserializeObject(result);
            for (int i = 0; i <= 9; i++)
            {
                MatchDTO match = new MatchDTO();
                match.Home_Team = matchData.data[i].home_team.name;
                match.Match_Start = matchData.data[i].match_start;
                match.Away_Team = matchData.data[i].away_team.name;
                matchList.Add(match);
            }

            return matchList;
        }
    }
}
