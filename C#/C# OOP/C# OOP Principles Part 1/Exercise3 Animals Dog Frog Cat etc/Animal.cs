using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Animal 
    {
        private double age;
        private string sex;
        private string name;

        public double Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

       
    }
}
