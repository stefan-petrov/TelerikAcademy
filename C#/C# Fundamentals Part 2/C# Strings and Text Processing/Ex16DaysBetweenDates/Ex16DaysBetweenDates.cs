using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

namespace Ex16DaysBetweenDates
{
    class Ex16DaysBetweenDates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date in dd.mm.yyyy format: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter second date in dd.mm.yyyy format: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            int days = 0;

            if (firstDate.Year > secondDate.Year)
            {
                while (firstDate.Year != secondDate.Year || firstDate.Month != secondDate.Month || firstDate.Day != secondDate.Day)
                {
                    secondDate = secondDate.AddDays(1);
                    days++;
                }
            }
            else
            {
                while (firstDate.Year != secondDate.Year || firstDate.Month != secondDate.Month || firstDate.Day != secondDate.Day)
                {
                    firstDate = firstDate.AddDays(1);
                    days++;
                }
            }

            Console.WriteLine(days);  
        }
    }
}
