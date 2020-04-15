using System.Collections.Generic;

namespace F1SeasonResults.Entities
{
    public class DriverStanding
    {
        protected string position;
        protected string positionText;
        protected string points;
        protected string wins;
        protected Driver driver;
        protected List<Constructor> constructors;

        public DriverStanding(string position, string positionText, string points, string wins, Driver driver, List<Constructor> constructors)
        {
            Position = position;
            PositionText = positionText;
            Points = points;
            Wins = wins;
            Driver = driver;
            Constructors = constructors;
        }

        public virtual string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public virtual string PositionText
        {
            get
            {
                return positionText;
            }

            set
            {
                positionText = value;
            }
        }

        public virtual string Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public virtual string Wins
        {
            get
            {
                return wins;
            }

            set
            {
                wins = value;
            }
        }

        public virtual Driver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        public virtual List<Constructor> Constructors
        {
            get
            {
                return constructors;
            }

            set
            {
                constructors = value;
            }
        }
    }
}