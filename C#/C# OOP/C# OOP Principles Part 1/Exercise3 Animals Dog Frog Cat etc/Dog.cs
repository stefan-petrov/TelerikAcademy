using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Dog : Animal, ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Bau bau");
        }

        public Dog(string name, double age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
