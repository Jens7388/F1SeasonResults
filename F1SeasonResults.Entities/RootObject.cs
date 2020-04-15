
namespace F1SeasonResults.Entities
{
    public class RootObject
    {
        protected MRData mRData;

        public RootObject(MRData mRData)
        {
            MRData = mRData;
        }
        public virtual MRData MRData
        {
            get
            {
                return mRData;
            }

            set
            {
                mRData = value;
            }
        }
    }
}