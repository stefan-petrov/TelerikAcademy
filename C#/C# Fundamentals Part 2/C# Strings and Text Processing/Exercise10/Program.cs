using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input string to be converted");
            string inputString = Console.ReadLine();

            Console.WriteLine("The string you have entered converted to Unicode character literals:");
            foreach (var item in inputString)
            {
                Console.Write("\\u{0:x4}",(int)item);
            }
            Console.WriteLine();
        }
    }
}
