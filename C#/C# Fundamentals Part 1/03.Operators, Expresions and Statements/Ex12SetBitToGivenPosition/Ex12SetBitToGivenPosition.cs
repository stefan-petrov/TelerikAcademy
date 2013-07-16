using System;

namespace Ex12SetBitToGivenPosition
{
    class Ex12SetBitToGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value: ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Postion: ");
            int p = int.Parse(Console.ReadLine());


            if (v <= 1 && v >= 0)
            {
                if (v == 1)
                {
                    int mask = 1 << p;
                    int nAndMask = mask | n;
                    Console.WriteLine("{0}({1})", nAndMask, Convert.ToString(nAndMask, 2).PadLeft(8, '0'));
                }

                else
                {
                    int mask = 1 << p;
                    int invMask = ~mask;
                    int nAndinvMask = invMask & n;
                    Console.WriteLine("{0}({1})", nAndinvMask, Convert.ToString(nAndinvMask, 2).PadLeft(8, '0'));
                }
            }
            else
            {
                Console.WriteLine("You must enter 1 or 0 for Value");
            }
        }
    }
}
