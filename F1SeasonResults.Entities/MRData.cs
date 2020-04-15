
namespace F1SeasonResults.Entities
{
    public class MRData
    {
        protected string xmlns;
        protected string series;
        protected string url;
        protected string limit;
        protected string offset;
        protected string total;
        protected StandingsTable standingsTable;

        public MRData(string xmlns, string series, string url, string limit, string offset, string total, StandingsTable standingsTable)
        {
            Xmlns = xmlns;
            Series = series;
            Url = url;
            Limit = limit;
            Offset = offset;
            Total = total;
            StandingsTable = standingsTable;
        }

        public virtual string Xmlns
        {
            get
            {
                return xmlns;
            }

            set
            {
                xmlns = value;
            }
        }

        public virtual string Series
        {
            get
            {
                return series;
            }

            set
            {
                series = value;
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

        public virtual string Limit
        {
            get
            {
                return limit;
            }

            set
            {
                limit = value;
            }
        }

        public virtual string Offset
        {
            get
            {
                return offset;
            }

            set
            {
                offset = value;
            }
        }

        public virtual string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public virtual StandingsTable StandingsTable
        {
            get
            {
                return standingsTable;
            }

            set
            {
                standingsTable = value;
            }
        }
    }
}