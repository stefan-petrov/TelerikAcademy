﻿using System;


namespace Exercise1
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {         
        }

        public override double CalculateSurface()
        {
            return (width * height) / 2;
        }
    }
}
