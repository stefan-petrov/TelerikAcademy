using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class c = new Class("asdas");
            c.AddStudent(new Student("pesho"));
            c.AddStudent(new Student("gosho"));

            foreach (var item in c.SetOfStudents )
            {
                Console.WriteLine(item);
            }
        }
    }
}
