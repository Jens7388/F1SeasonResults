using F1SeasonResults.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace F1SeasonResult.Service
{
    public class DriverService
    {
        static List<DriverStanding> driverStandings;
        static List<ConstructorStanding> constructorStandings;

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
        public virtual List<ConstructorStanding> GetConstructors(string url)
        {
            RootObject jsonObject;
            constructorStandings = new List<ConstructorStanding>();
            string resultTask;

            using(WebClient client = new WebClient())
            {
                resultTask = client.DownloadString(url);
            }

            jsonObject = JsonConvert.DeserializeObject<RootObject>(resultTask);
            if(jsonObject.MRData.StandingsTable.StandingsLists.Count != 0)
            {
                foreach(ConstructorStanding constructorStanding in jsonObject.MRData.StandingsTable.StandingsLists[0].ConstructorStandings)
                {
                    constructorStandings.Add(constructorStanding);
                }
                return constructorStandings;
            }
            else
            {
                return null;
            }
        }

        public virtual List<DriverStanding> GetAllDrivers()
        {
            return driverStandings;
        }

        public virtual List<ConstructorStanding> GetAllConstructors()
        {
            return constructorStandings;
        }
    }
}