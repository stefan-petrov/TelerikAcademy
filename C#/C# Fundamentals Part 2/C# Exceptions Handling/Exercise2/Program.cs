using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static int  ReadNumber(int start, int end)
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int counter = 10;
            while (counter > 0)
            {
                try
                {
                    int input = ReadNumber(start, end);
                    if (input < 1 || input > 100)
	                {
		                throw new ArgumentOutOfRangeException();
	                }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you entered is out of the 1...100 range.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Non-numbered text.");
                }
                
                counter--;
            }
        }
    }
}
