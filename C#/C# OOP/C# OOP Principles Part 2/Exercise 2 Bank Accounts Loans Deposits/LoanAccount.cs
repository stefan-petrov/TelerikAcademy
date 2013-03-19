using System;

namespace Exercise2
{
    class LoanAccount : Account
    {
        public LoanAccount(IndividualCustomer customer, decimal balance)
        {
            this.customer = customer;
            this.balance = balance;
        }

        public LoanAccount(CompanyCustomer customer, decimal balance)
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
            if (customer.GetType().Name ==  "IndividualCustomer" )
            {
                decimal interest = ((months - 3) * InterestRate.IntRate);
                if (interest > 0)
                {
                    return interest * balance;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                decimal interest = ((months - 2) * InterestRate.IntRate);
                if (interest > 0)
                {
                    return interest * balance;
                }
                else
                {
                    return 0;
                }
            }          
        }
    }
}
