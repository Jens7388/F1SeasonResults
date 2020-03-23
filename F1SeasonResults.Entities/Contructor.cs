using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class Contructor
    {
        protected string constructorID;
        protected string url;
        protected string name;
        protected string nationality;
        protected int position;
        protected string positionText;
        protected int points;
        protected int wins;

        public Contructor(string constructorID, string url, string name, string nationality, int position, string positionText, int points, int wins)
        {
            ConstructorID = constructorID;
            Url = url;
            Name = name;
            Nationality = nationality;
            Position = position;
            PositionText = positionText;
            Points = points;
            Wins = wins;
        }

        public virtual string ConstructorID
        {
            get
            {
                return constructorID;
            }

            set
            {
                constructorID = value;
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

        public virtual string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
