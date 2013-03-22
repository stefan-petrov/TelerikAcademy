using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Path
    {
        private List<Exercise1.Point3D> points = new List<Exercise1.Point3D>();

        public List<Exercise1.Point3D> Paths
        {
            get{ return this.points; }
            private set{ this.points = value; }
        }

        public void AddPoint(Exercise1.Point3D point)
        {
            points.Add(point);
        }
    }
}
