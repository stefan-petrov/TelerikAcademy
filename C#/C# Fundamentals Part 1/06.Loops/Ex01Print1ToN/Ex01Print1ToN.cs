using System;

namespace Ex01Print1ToN
{
    class Ex01Print1ToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter N");
            int input = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
