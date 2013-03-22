using System;

namespace Exercise11
{
    class Program
    {       

        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());         
            
            Console.WriteLine("As decimal: {0}", inputNum.ToString("D15"));
            Console.WriteLine("As hexadecimal: {0}", inputNum.ToString("X15"));
            Console.WriteLine("As percentage: {0}", inputNum.ToString("P15"));
            Console.WriteLine("As scientific notation: {0}", inputNum.ToString("E15"));


        }
    }
}
