using System;

namespace Ex10CalcSum
{
    class Ex10CalcSum
    {
        static void Main(string[] args)
        {
            decimal sum = 1m;

            for (int i = 2; i <= 100; i++)
            {
                sum += (1m / i);
                i++;
                sum -= (1m / i);
            }

            Console.WriteLine("{0:.000}", sum);
        }
    }
}
