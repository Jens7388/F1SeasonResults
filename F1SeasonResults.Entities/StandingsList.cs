using System.Collections.Generic;

namespace F1SeasonResults.Entities
{
    public class StandingsList
    {
        protected string season;
        protected string round;
        protected List<DriverStanding> driverStandings;
        protected List<ConstructorStanding> constructorStandings;

        public StandingsList(string season, string round, List<DriverStanding> driverStandings, List<ConstructorStanding> constructorStandings)
        {
            Season = season;
            Round = round;
            DriverStandings = driverStandings;
            ConstructorStandings = constructorStandings;
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

        public virtual List<ConstructorStanding> ConstructorStandings
        {
            get
            {
                return constructorStandings;
            }

            set
            {
                constructorStandings = value;
            }
        }
    }
}