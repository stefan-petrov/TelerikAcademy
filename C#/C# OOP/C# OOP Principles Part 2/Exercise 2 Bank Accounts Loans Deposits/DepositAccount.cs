using System;

namespace Exercise2
{
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance)
        {
            this.customer = customer;
            this.balance = balance;
        }

        public override void DepositMoney(decimal depositValue)
        {
            balance += depositValue;
        }

        public void WithdrawMoney(decimal withdrawValue)
        {
            balance -= withdrawValue;
        }

        public override decimal CalcInterest(int months)
        {
            if (balance < 1000 )
            {
                return 0;
            }
            else
	        {
                return months * InterestRate.IntRate * balance;
	        }
        }
    }
}
