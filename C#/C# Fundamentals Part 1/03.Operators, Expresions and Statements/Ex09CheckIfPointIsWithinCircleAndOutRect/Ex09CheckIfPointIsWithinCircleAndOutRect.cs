using System;

namespace Ex09CheckIfPointIsWithinCircleAndOutRect
{
    class Ex09CheckIfPointIsWithinCircleAndOutRect
    {
        static void Main()
        {
            Console.WriteLine("Enter X :");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y :");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
            bool inRectangle = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
            if (inCircle == true)
            {
                if (inRectangle == true)
                {
                    Console.WriteLine("The given point is In the circle and In the rectangle");
                }
                else
                {
                    Console.WriteLine("The given point is In the circle and Out the rectangle");
                }
            }
            else
                if (inRectangle == true)
                {
                    Console.WriteLine("The given point is Out the circle and In the rectangle");
                }
                else
                {
                    Console.WriteLine("The given point is Out the circle and Out the rectangle");
                }
        }
    }
}
