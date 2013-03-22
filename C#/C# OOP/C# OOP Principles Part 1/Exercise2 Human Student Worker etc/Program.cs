using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stList = new List<Student>();
            stList.Add(new Student("pesho", "peshov", 5.67));
            stList.Add(new Student("nikolai", "nikolov", 4.56));
            stList.Add(new Student("stefan", "stefanov", 3.17));
            stList.Add(new Student("chuck", "norris", 6.00));
            stList.Add(new Student("barack", "obama", 5.30));
            stList.Add(new Student("bai", "ganio", 5.25));
            stList.Add(new Student("johny", "walker", 4.98));
            stList.Add(new Student("jim", "beam", 5.92));
            stList.Add(new Student("jack", "daniels", 5.00));
            stList.Add(new Student("mastika", "peshtera", 3.96));

            var stListSorted =
                from students in stList
                orderby students.Grade
                select students;

            foreach (var item in stListSorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker("bai", "ivan", 450, 8));
            workersList.Add(new Worker("bache", "kiko", 280, 7));
            workersList.Add(new Worker("sulio", "pulev", 360, 9));
            workersList.Add(new Worker("pulio", "sulev", 355, 8));
            workersList.Add(new Worker("winston", "chrurchil", 260, 8));
            workersList.Add(new Worker("albert", "einstein", 280, 6));
            workersList.Add(new Worker("johny", "bravo", 468, 9));
            workersList.Add(new Worker("tom", "jeriev", 330, 10));
            workersList.Add(new Worker("jerry", "tomov", 225, 9));
            workersList.Add(new Worker("burgas", "63", 200, 4));

            var workersListSorted =
                from workers in workersList
                orderby workers.MoneyPerHour() descending
                select workers;

            foreach (var item in workersListSorted)
            {
                Console.WriteLine(item);
            }

            var merged = workersList.Concat<Human>(stList).ToList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var mergedSorted =
                from studentsAndWorkers in merged
                orderby studentsAndWorkers.FirstName, studentsAndWorkers.LastName
                select studentsAndWorkers;

            foreach (var item in mergedSorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
