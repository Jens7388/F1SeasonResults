using System;
using System.Collections.Generic;
using System.Text;

namespace F1SeasonResults.Entities
{
    public class Constructor
    {
        protected string constructorID;
        protected string url;
        protected string name;
        protected string nationality;

        public Constructor(string constructorID, string url, string name, string nationality)
        {
            ConstructorID = constructorID;
            Url = url;
            Name = name;
            Nationality = nationality;
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
    }
}