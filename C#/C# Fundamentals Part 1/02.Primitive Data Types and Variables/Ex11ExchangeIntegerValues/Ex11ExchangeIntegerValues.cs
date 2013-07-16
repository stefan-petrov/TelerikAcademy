using System;

namespace Ex11ExchangeIntegerValues
{
    class Ex11ExchangeIntegerValues
    {
        static void Main()
        {
            int intFive = 5;
            int intTen = 10;
            Console.WriteLine("First integer: {0}  Second integer: {1}", intFive, intTen);
            int temp = intFive;
            intFive = intTen;
            intTen = temp;
            Console.WriteLine("First integer: {0}  Second integer: {1}", intFive, intTen); // this line is exactly like the previous Console.WriteLine, but this time the output on the console is different.
        }
    }
}
