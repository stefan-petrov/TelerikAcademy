using System;
using System.Collections;
using System.Collections.Generic;


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
