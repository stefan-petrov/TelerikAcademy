using System;

namespace PrintCurrentDate
{
    class PrintCurrentDate
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
        }
    }
}
