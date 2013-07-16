using System;

namespace Ex06QuadricEquation
{
    class Ex06QuadricEquation
    {
        static void Main()
        {
            Console.Write("Enter coeficient a: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter coeficient b: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("Enter coeficient c: ");
            decimal c = decimal.Parse(Console.ReadLine());
            decimal discriminant = (decimal)Math.Pow((double)b, 2) - 4 * a * c;

            if (discriminant > 0)
            {
                decimal x1 = (b * (-1) + (decimal)Math.Sqrt((double)discriminant)) / 2 * a;
                decimal x2 = (b * (-1) - (decimal)Math.Sqrt((double)discriminant)) / 2 * a;
                Console.WriteLine("The equation has two real roots:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);

            }
            else if (discriminant == 0)
            {
                decimal onlyRoot = (b / 2 * a) * (-1);
                Console.WriteLine("The equation has only one real root: " + onlyRoot);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}
