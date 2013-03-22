using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Frog : Animal, ISound   
    {
        public void MakeSound()
        {
            Console.WriteLine("Quak");
        }

        public Frog(string name, double age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
