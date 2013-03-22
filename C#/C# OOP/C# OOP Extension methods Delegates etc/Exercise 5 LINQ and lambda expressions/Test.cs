using System;
using System.Linq;

namespace Exercise5
{
    class Test
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

            //with lambda expr
            var sortedQuery2 = stArray.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);
            
            foreach (var item in sortedQuery2)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }
                   
            //with LINQ
            var sortedQuery1 =
                from student in stArray
                orderby student.FirstName descending, student.SecondName descending
                select student;

            foreach (var item in sortedQuery1)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }
        }
    }
}
