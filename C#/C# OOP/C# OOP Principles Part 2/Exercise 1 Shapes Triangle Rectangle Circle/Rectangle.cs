using System;


namespace Exercise1
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {         
        }

        public override double CalculateSurface()
        {          
            return width * height ;
        }
    }
}
