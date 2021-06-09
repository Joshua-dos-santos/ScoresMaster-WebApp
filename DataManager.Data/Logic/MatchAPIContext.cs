using DataManager.Data.DTO;
using DataManager.Data.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DataManager.Data.Logic
{
    public class MatchAPIContext : IMatchContext
    {
        public IEnumerable<MatchDTO> GetAllMatches(int id)
        {
            ClubDatabaseContext clubDatabaseContext = new ClubDatabaseContext();
            string result = null;
            string requestString = "";
            if (id == 352 || id == 619)
            {
                requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=78b7f4f0-781d-11eb-b7ce-ab513a4a050f&season_id=" + id + "&date_from=2021-03-10";
            }
            else if (id == 496 || id == 706)
            {
                requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=d9f4bae0-7809-11eb-aec7-0397bbf3998c&season_id=" + id + "&date_from=2021-03-10";
            }
            else if(id == 762 || id == 455)
            {
                requestString = "https://app.sportdataapi.com/api/v1/soccer/matches?apikey=22823260-c462-11eb-ac7c-c1b68c46562d&season_id=" + id + "&date_from=2021-03-10";
            }
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
            for (int i = 0; i <= 10; i++)
            {
                MatchDTO match = new MatchDTO();
                match.MatchID = matchData.data[i].match_id;
                match.Home_Team = clubDatabaseContext.GetClubByName((string)matchData.data[i].home_team.name);
                match.Match_Start = matchData.data[i].match_start;
                match.Match_Status = matchData.data[i].status;
                match.Away_Team = clubDatabaseContext.GetClubByName((string)matchData.data[i].away_team.name);
                matchList.Add(match);
            }

            return matchList;
        }
    }
}
