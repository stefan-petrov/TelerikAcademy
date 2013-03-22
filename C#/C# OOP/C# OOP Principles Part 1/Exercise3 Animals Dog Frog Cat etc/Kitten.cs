using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Kitten : Cat
    {

        public Kitten(string name, double age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = "Female";
        }
    }
}
