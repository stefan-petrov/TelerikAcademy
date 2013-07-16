using System;

namespace Ex06CheckIfPointWithinCircle
{
    class Ex06CheckIfPointWithinCircle
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for Y: ");
            int y = int.Parse(Console.ReadLine());
            bool inCircle = (x * x) + (y * y) <= 5 * 5;
            Console.WriteLine(inCircle ? "In Circle" : "Not In Circle");
        }
    }
}
