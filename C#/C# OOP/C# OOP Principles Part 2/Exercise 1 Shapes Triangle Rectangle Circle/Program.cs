using System;
using System.Collections.Generic;


namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Shape[] shapesArr = new Shape[]
            {
                new Triangle(5,4),
                new Rectangle(5,6),
                new Circle(6)   
            };

            foreach (var item in shapesArr)
            {
                Console.WriteLine(item.CalculateSurface()); 
            }
        }
    }
}
