using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            InterestRate.SetInterestRate(0.00567m);

            
            Account[] accArr = new Account[] 
            {
                new LoanAccount(new IndividualCustomer("pesho", 19), 14567),
                new MortgageAccount(new CompanyCustomer("Pesho EOOD"), 25000),
                new DepositAccount( new IndividualCustomer("gosho", 24), 5000)
            };


            Console.WriteLine(InterestRate.IntRate.ToString("P") + " per month interest rate");

            foreach (var item in accArr)
            {
                Console.WriteLine(item.CalcInterest(8).ToString("C2"));
            }

            // with 1 line you change the interest lane and that affects all accounts and customers
            InterestRate.SetInterestRate(0.00667m);

            Console.WriteLine(InterestRate.IntRate.ToString("P") + " per month interest rate");

            foreach (var item in accArr)
            {
                Console.WriteLine(item.CalcInterest(8).ToString("C2"));
            }
        }
    }
}
