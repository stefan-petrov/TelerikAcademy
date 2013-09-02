using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
// Format the output aligned right in 15 symbols.

namespace Ex11NumAsHexDecPerc
{
    class Ex11NumAsHexDecPerc
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());         
            
            Console.WriteLine("As decimal: {0}", inputNum.ToString("D15"));
            Console.WriteLine("As hexadecimal: {0}", inputNum.ToString("X15"));
            Console.WriteLine("As percentage: {0}", (inputNum/100.00).ToString("P15"));
            Console.WriteLine("As scientific notation: {0}", inputNum.ToString("E15"));
        }
    }
}
