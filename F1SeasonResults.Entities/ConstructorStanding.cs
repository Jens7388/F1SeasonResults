using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class ConstructorStanding
    {
        protected string position;
        protected string positionText;
        protected string points;
        protected string wins;
        protected Constructor constructor;

        public ConstructorStanding(string position, string positionText, string points, string wins, Constructor constructor)
        {
            Position = position;
            PositionText = positionText;
            Points = points;
            Wins = wins;
            Constructor = constructor;
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

        public virtual Constructor Constructor
        {
            get
            {
                return constructor;
            }

            set
            {
                constructor = value;
            }
        }
    }
}