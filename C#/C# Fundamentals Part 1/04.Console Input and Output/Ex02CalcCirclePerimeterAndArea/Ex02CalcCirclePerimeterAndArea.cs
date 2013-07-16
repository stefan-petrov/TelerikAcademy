using System;

namespace Ex02CalcCirclePerimeterAndArea
{
    class Ex02CalcCirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Please enter the radius of the circle : ");
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal perimeter = 2 * radius * (decimal)Math.PI;
            decimal area = (decimal)Math.PI * (decimal)Math.Pow((double)radius, 2);
            Console.WriteLine("The perimeter of the circle is = " + perimeter);
            Console.WriteLine("The area of the circle is = " + area);
        }
    }
}
