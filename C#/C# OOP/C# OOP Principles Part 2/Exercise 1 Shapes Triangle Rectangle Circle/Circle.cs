using System;


namespace Exercise1
{
    class Circle : Shape
    {
        public Circle(double width)
            : base(width)
        {         
        }

        public override double CalculateSurface()
        {          
            return width* width * Math.PI;
        }
    }
}
