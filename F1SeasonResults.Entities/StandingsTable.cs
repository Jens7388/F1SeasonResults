using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class StandingsTable
    {
        protected string season;
        protected List<StandingsList> standingsLists;

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

        public virtual List<StandingsList> StandingsLists
        {
            get
            {
                return standingsLists;
            }

            set
            {
                standingsLists = value;
            }
        }
    }
}