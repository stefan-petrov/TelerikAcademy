using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculation
{
    static class CalcDistance
    {    
        public static double CalculateDistance(Exercise1.Point3D point1, Exercise1.Point3D point2)
        {
            return Math.Sqrt(((point1.X - point2.X) * (point1.X - point2.X)) + ((point1.Y - point2.Y) * (point1.Y - point2.Y)) + ((point1.Z - point2.Z) * (point1.Z - point2.Z)));
        }
    }
}
