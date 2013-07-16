using System;

namespace Ex08TrapezoidArea
{
    class Ex08TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Please enter the lenght of parallel side A: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of parallel side B: ");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of height H: ");
            int height = int.Parse(Console.ReadLine());
            int area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The Area of the trapezoid is :" + area);
        }
    }
}
