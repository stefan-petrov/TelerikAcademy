using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Test
    {
        static void Main()
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(3, 7, 8);
            Console.WriteLine(DistanceCalculation.CalcDistance.CalculateDistance(p1, p2));
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
