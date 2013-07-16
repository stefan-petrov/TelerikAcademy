using System;

namespace Ex06QuadricEquation
{
    class Ex06QuadricEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficient a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient c");
            double c = double.Parse(Console.ReadLine());

            double diskriminanta = ((b * b) - (4 * a * c));
            double diskriminantaSqrt = (Math.Sqrt(diskriminanta));

            if ((a != 0) && (diskriminanta > 0))
            {
                double x1 = (b * (-1) + diskriminantaSqrt) / (2 * a);
                double x2 = (b * (-1) - diskriminantaSqrt) / (2 * a);

                Console.WriteLine("The equation has real roots and they are:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if ((a != 0) && diskriminanta == 0)
            {
                double x = (b * (-1)) / 2 * a;
                Console.WriteLine("The equation has one real root: ");
                Console.WriteLine("x = {0}", x);
            }

            else if ((a != 0) && (diskriminanta < 0))
            {
                Console.WriteLine("The equation has no real roots !");
            }

            else if ((a == 0) && (b != 0))
            {
                double xlinear = (c / b) * (-1);

                Console.WriteLine("The equation is linear");
                Console.WriteLine("x = {0}", xlinear);
            }
            else if ((a == 0) && (b == 0) && (c != 0))
            {
                Console.WriteLine("The equation is linear");
                Console.WriteLine("The equation has no solution");
            }
            else if ((a == 0) && (b == 0) && (c == 0))
            {
                Console.WriteLine("The equation is linear");
                Console.WriteLine("Every real number is a solution for the equation");
            }
        }
    }
}
