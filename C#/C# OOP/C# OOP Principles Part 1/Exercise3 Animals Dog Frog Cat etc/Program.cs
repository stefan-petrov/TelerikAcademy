using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogArr = new Dog[] { 
                new Dog("sharo", 3, "male"),
                new Dog("balkan", 5.5, "male"),
                new Dog("Lisa", 3.2, "female")
            };


            Cat[] catArr = new Cat[] { 
                new Cat("maca", 2, "female"),
                new Cat("lara", 0.5, "female"),
                new Cat("jorko", 3.8, "male")
            };

            Tomcat[] tomcatArr = new Tomcat[] {
                new Tomcat("maca", 3),
                new Tomcat("lara", 1.5),
                new Tomcat("jorko", 2.8)
            };
            
            var avgDogAge =
                from dogs in dogArr                 
                select dogs.Age;
            Console.WriteLine("The average dog age is: {0}", Convert.ToDouble(avgDogAge.Average()));

            var avgCatAge =
                  from cats in catArr
                  select cats.Age;
            Console.WriteLine("The average cat age is: {0}", Convert.ToDouble(avgCatAge.Average()));

            var avgTomcatAge =
                 from tomcats in tomcatArr
                 select tomcats.Age;
            Console.WriteLine("The average cat age is: {0}", Convert.ToDouble(avgTomcatAge.Average()));
            
        }
    }
}
