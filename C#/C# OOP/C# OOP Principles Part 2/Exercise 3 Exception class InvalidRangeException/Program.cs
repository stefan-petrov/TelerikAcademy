using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 56;

            if (n < 0 || n > 100)
            {
                throw new InvalidRangeException<int>("Invalid Range : Range must be between 0 and 100");
            }

            DateTime date = new DateTime(2014, 03, 19);
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            if (date > endDate || date < startDate)
            {
                throw new InvalidRangeException<int>("Invalid Range : Date must be between 1.1.1980 and 31.12.2013");
            }                        
        }
    }
}
