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
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("Input string too long");
            }
            else if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
            else
            {
                StringBuilder sb = new StringBuilder();       
                int counter = input.Length;
                
                while (input.Length<20)
                {
                    input = input.Insert(counter, "*");
                    counter++;
                }
                Console.WriteLine(input);         
            }
        }
    }
}
