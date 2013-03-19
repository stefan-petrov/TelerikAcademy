using System;

namespace Exercise2
{
    abstract class Account
    {
        protected Customer customer;
        protected decimal balance;
      

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }


        public abstract void DepositMoney(decimal depositVal);

        public abstract decimal CalcInterest(int months);
             
    }
}
