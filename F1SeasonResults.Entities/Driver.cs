
namespace F1SeasonResults.Entities
{
    public class Driver
    {
        protected string driverID;
        protected string url;
        protected string givenName;
        protected string familyName;
        protected string fullName;
        protected string dateOfBirth;
        protected string nationality;

        public Driver(string driverId, string url, string givenName, string familyName, string dateOfBirth, string nationality)
        {
            DriverID = driverId;
            Url = url;
            GivenName = givenName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
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

        public virtual string FullName
        {
            get
            {
                return fullName = GivenName + " " + FamilyName;
            }
            set
            {
                fullName = value;
            }
        }

        public virtual string DateOfBirth
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
    }
}