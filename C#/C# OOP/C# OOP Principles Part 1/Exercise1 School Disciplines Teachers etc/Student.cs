using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Student : People
    {
        private Guid uniqueNumber;

        public Guid UniqueNumber 
        {
            get
            {
                return this.uniqueNumber;
            }
        }

        public Student(string name)
        {
            this.Name = name;
        }
    }
}
