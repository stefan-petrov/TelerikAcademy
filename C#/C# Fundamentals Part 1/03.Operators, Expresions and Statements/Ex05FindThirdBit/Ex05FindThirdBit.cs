using System;

namespace Ex05FindThirdBit
{
    class Ex05FindThirdBit
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            int position = 3;
            int mask = 1 << position;
            int inputAndMask = input & mask;
            int bit = inputAndMask >> position;
            Console.WriteLine("The bit at position 3 is {0}", bit);
        }
    }
}
