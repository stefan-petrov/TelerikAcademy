using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = (weekSalary / 5) / workHoursPerDay;
            return moneyPerHour;
        }

        public Worker(string firstName, string lastName, double weekSalary, int workHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;    
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHours;
        }

        public override string ToString()
        {
            return this.FirstName.PadRight(10) + " " + this.LastName.PadRight(10) + " " + this.MoneyPerHour().ToString("F2") ;
        }
    }

}
