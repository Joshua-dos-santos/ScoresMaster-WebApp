using DataManager.Data.DatabaseLogic;
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
    public class StandingsAPIContext : IStandingsContext
    {
        LeagueDatabaseContext leagueDatabaseContext = new LeagueDatabaseContext();
        ClubDatabaseContext clubDatabaseContext = new ClubDatabaseContext();
        public IEnumerable<StandingsDTO> GetAllStandings(int id, int clubAmount)
        {
            string result = null;
            string requestString = "https://app.sportdataapi.com/api/v1/soccer/standings?apikey=6d5780e0-c830-11eb-8d04-81eb71d37720&season_id=" + id+"";
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
            List<StandingsDTO> standings = new List<StandingsDTO>();
            dynamic standingData = JsonConvert.DeserializeObject(result);
            for (int i = 0; i <= clubAmount; i++)
            {
                StandingsDTO standingsDTO = new StandingsDTO();
                string clubName = GetStandigsClub((int)standingData.data.standings[i].team_id);
                standingsDTO.Club = clubDatabaseContext.GetClubByName(clubName);
                standingsDTO.League = leagueDatabaseContext.GetLeague(standingsDTO.Club.League.LeagueID);
                standingsDTO.LeaguePoints = standingData.data.standings[i].points;
                standingsDTO.Status = standingData.data.standings[i].status;
                standingsDTO.Result = standingData.data.standings[i].result;
                standings.Add(standingsDTO);
            }
            return standings;
        }

        public string GetStandigsClub(int id)
        {
            string result = null;
            string requestString = "https://app.sportdataapi.com/api/v1/soccer/teams/" + id + "?apikey=05117e70-c9e9-11eb-83fe-29a32a0eb61a";
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
            dynamic matchData = JsonConvert.DeserializeObject(result);
            return (string)matchData.data.name;
        }
    }
}
