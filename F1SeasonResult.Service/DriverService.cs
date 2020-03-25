using F1SeasonResults.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace F1SeasonResult.Service
{
    public class DriverService
    {
        public virtual List<Driver> GetDrivers(string url)
        {
            List<Driver> drivers;
            string resultTask;

            using(WebClient client = new WebClient())
            {
                resultTask = client.DownloadString(url);
            }

            drivers = JsonConvert.DeserializeObject<List<Driver>>(resultTask);
            return drivers;
        }
    }
}