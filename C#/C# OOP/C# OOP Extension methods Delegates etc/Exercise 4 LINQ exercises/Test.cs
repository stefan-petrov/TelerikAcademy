using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Pesho", "Georgiev", 18);
            Student st2 = new Student("Pesho", "Yanakiev", 19);
            Student st3 = new Student("Rosen", "Ivanov", 14);
            Student st4 = new Student("Rosen", "Temelkov", 25);

            Student[] stArray = new Student[4];
            stArray[0] = st1;
            stArray[1] = st2;
            stArray[2] = st3;
            stArray[3] = st4;

            var sortQuery =
                from student in stArray
                where student.Age >= 18 && student.Age <=24
                select student;

            foreach (var item in sortQuery)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }
        }
    }
}
