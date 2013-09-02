using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
// date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace Ex17DateAfter6Hrs
{
    class Ex17DateAfter6Hrs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter date in \"day.month.year hour:minute:second\" format: ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            inputDate = inputDate.AddHours(6);
            inputDate = inputDate.AddMinutes(30);
           
            Console.WriteLine("{0} {1}",inputDate.ToString("dddd", new CultureInfo("bg-BG")), inputDate);   
        }
    }
}
