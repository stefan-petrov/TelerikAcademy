using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private static readonly Point3D startCoordinate = new Point3D(0, 0, 0);

      
        
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Z = z;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    
        public static Point3D StartCoordinte()
        {
            return startCoordinate;
        }
    
    }

}
