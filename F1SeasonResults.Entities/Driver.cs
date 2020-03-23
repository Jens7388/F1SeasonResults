using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class Driver
    {
        protected string driverID;
        protected string url;
        protected string givenName;
        protected string familyName;
        protected DateTime dateOfBirth;
        protected string nationality;
        protected List<Contructor> contructors;
        protected int position;
        protected string positionText;
        protected int points;
        protected int wins;

        public Driver(string driverId, string url, string givenName, string familyName, DateTime dateOfBirth, string nationality, 
            List<Contructor> contructors, int position, string positionText, int points, int wins)
        {
            DriverID = driverId;
            Url = url;
            GivenName = givenName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Contructors = contructors;
            Position = position;
            PositionText = positionText;
            Points = points;
            Wins = wins;
        }
        public virtual string DriverID
        {
            get
            {
                return driverID;
            }

            set
            {
                driverID = value;
            }
        }

        public virtual string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public virtual string GivenName
        {
            get
            {
                return givenName;
            }

            set
            {
                givenName = value;
            }
        }

        public virtual string FamilyName
        {
            get
            {
                return familyName;
            }

            set
            {
                familyName = value;
            }
        }

        public virtual DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public virtual string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public virtual List<Contructor> Contructors
        {
            get
            {
                return contructors;
            }

            set
            {
                contructors = value;
            }
        }

        public virtual int Position
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

        public virtual int Points
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

        public virtual int Wins
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
    }
}
