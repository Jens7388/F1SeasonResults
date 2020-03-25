using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class StandingsList
    {
        protected string season;
        protected string round;
        protected List<DriverStanding> driverStandings;

        public StandingsList(string season, string round, List<DriverStanding> driverStandings)
        {
            Season = season;
            Round = round;
            DriverStandings = driverStandings;
        }

        public virtual string Season
        {
            get
            {
                return season;
            }

            set
            {
                season = value;
            }
        }

        public virtual string Round
        {
            get
            {
                return round;
            }

            set
            {
                round = value;
            }
        }

        public virtual List<DriverStanding> DriverStandings
        {
            get
            {
                return driverStandings;
            }

            set
            {
                driverStandings = value;
            }
        }
    }
}