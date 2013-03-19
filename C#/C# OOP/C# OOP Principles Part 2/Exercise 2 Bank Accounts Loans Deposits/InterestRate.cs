using System;

namespace Exercise2
{
    static class InterestRate
    {
        private static decimal intRate;

        public static decimal IntRate
        {
            get { return intRate; }
            private set { intRate = value; }
        }


        public static void SetInterestRate(decimal val)
        {
            IntRate = val;
        }

       
    }
}
