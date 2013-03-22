using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDefiningClassesPart1
{
    class Display
    {
        private decimal size;
        private int colors;

        public decimal Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }

        public Display()
        {
        }

        public Display(decimal size)
        {
            this.size = size;
        }

        public Display(int colors)
        {
            this.colors = colors;
        }

        public Display(decimal size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }
}
