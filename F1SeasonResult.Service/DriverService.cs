using F1SeasonResults.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;

namespace F1SeasonResult.Service
{
    public class DriverService
    {
        static List<DriverStanding> driverStandings;
        public virtual List<DriverStanding> GetDrivers(string url)
        {
            RootObject jsonObject;
            driverStandings = new List<DriverStanding>();
            string resultTask;

            using(WebClient client = new WebClient())
            {
                resultTask = client.DownloadString(url);
            }

            jsonObject = JsonConvert.DeserializeObject<RootObject>(resultTask);
            foreach(DriverStanding driverStanding in jsonObject.MRData.StandingsTable.StandingsLists[0].DriverStandings)
            {
                driverStandings.Add(driverStanding);
            }
            return driverStandings;
        }
        public virtual List<DriverStanding> GetAll()
        {
            return driverStandings;
        }
    }
    
    
}