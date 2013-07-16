using System;

namespace Ex10IfBitAtPis1
{
    class Ex10IfBitAtPis1
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Please enter a position: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int inputAndMask = input & mask;
            int bit = inputAndMask >> position;
            bool bitIsOne = bit == 1;
            Console.WriteLine("The bit at position {0} in {1} is 1 ? {2}", position, input, bitIsOne);
        }
    }
}
