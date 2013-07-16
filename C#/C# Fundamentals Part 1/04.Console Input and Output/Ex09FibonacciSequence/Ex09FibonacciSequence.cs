using System;

namespace Ex09FibonacciSequence
{
    class Ex09FibonacciSequence
    {
        static void Main()
        {
            ulong a = 0L;
            ulong b = 1L;
            ulong c = a + b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            for (int i = 0; i < 97; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
            }
        }
    }
}
