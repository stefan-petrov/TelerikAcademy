using System;


namespace Exercise1
{
    abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        protected Shape(double width)
        {
            this.width = width;
        }
        
        public abstract double CalculateSurface();
               
    }
}
