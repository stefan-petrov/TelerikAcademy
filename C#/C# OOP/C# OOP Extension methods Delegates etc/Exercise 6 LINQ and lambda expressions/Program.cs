using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 4, 14, 17, 18, 21, 4, 0, 102, 97, 84, 15, 3, 4, 5, 6, 7, 8 };
            
            //with lambda
            int[] newArr = Array.FindAll(intArray, x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            //with LINQ
            var linqArr =
                from nums in intArray
                where nums % 7 == 0 && nums % 3 == 0
                select nums;

            foreach (var item in linqArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
