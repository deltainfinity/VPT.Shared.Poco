namespace VPT.Shared.Poco.Model.API
{
    public class CreditData
    {
        public CreditData(int credits, int hours)
        {
            CreditBased = credits;

            if (hours <= 0)
            {
                TimeBased = 0;
            }
            else
            {
                TimeBased = hours / 24;
            }
        }

        public int TimeBased { get; set; }


        public int CreditBased { get; set; }
    }
}
