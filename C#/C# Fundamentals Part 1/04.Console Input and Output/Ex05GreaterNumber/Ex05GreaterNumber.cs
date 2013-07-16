using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05GreaterNumber
{
    class Ex05GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());         
            decimal greaterNumber = Math.Max(firstNum, secondNum);
            Console.WriteLine("The greater number is: {0}", greaterNumber);
        }
    }
}
