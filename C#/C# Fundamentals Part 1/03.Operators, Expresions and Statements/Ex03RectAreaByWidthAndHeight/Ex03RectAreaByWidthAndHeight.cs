using System;

namespace Ex03RectAreaByWidthAndHeight
{
    class Ex03RectAreaByWidthAndHeight
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the width of the rectangle: ");
            decimal rectWidth = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the height of the rectangle: ");
            decimal rectHeight = decimal.Parse(Console.ReadLine());
            decimal area = rectHeight * rectWidth;
            Console.WriteLine("The area of given rectangle is: {0}", area);
        }
    }
}
