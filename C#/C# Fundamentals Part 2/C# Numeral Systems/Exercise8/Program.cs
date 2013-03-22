using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"short\" number: ");
            short input = short.Parse(Console.ReadLine());
            string shortAsBinary = Convert.ToString(input, 2);
            Console.WriteLine("The binary representation looks like this: ");
            Console.WriteLine(shortAsBinary.PadLeft(16, '0'));
        }
    }
}
