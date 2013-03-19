using System;

namespace Exercise2
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance)
        {
            this.customer = customer;
            this.balance = balance;
        }

        public override void DepositMoney(decimal depositValue)
        {
            balance += depositValue;
        }

        public override decimal CalcInterest(int months)
        {
            if (customer.GetType().Name == "IndividualCustomer")
            {
                decimal interest = ((months - 6) * InterestRate.IntRate) * balance;
                if (interest > 0)
                {
                    return interest;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 12)
                {
                    decimal interest = ((months - 12) * InterestRate.IntRate) - 2;
                    int remainingMonths = months - 12;
                    interest += remainingMonths * InterestRate.IntRate;
                    interest = interest * balance;

                    if (interest > 0)
                    {
                        return interest / 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return (months * InterestRate.IntRate * balance) / 2;

                }
                
            }              
        }
    }
}
