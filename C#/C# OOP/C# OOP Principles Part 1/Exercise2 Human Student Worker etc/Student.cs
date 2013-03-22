using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return this.grade; }
        }

        public Student(string firstName, string lastName, double grade)
        {
            this.grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return this.FirstName.PadRight(10) + " " + this.LastName.PadRight(10) + " " + this.grade.ToString("F2");
        }

        
    }
}
