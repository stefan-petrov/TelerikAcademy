using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static string[] ReturnReversed(string[] someArray)
        {
            Array.Reverse(someArray);
            return someArray;
        }

        static void Main(string[] args)
        {
             decimal input = decimal.Parse(Console.ReadLine());
             string inputAsString = input.ToString();
             string[] arr = inputAsString.Select(c => c.ToString()).ToArray();

            foreach (var item in ReturnReversed(arr))
	        {
		        Console.Write("{0}", item);
	        }
            Console.WriteLine();
        }
    }
}
