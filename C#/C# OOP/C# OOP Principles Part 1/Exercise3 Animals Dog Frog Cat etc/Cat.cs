using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Cat : Animal, ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Myauuu");
        }

        protected Cat()
        {
        }
     
        public Cat(string name, double age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        
    }
}
