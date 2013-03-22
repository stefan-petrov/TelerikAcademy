using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
    }

