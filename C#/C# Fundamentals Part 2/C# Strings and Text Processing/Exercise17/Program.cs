using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            inputDate = inputDate.AddHours(6);
            inputDate = inputDate.AddMinutes(30);
            Console.WriteLine(inputDate);

            Console.WriteLine(inputDate.ToString("dddd", CultureInfo.CreateSpecificCulture("bg-BG")));            
        }   
    }
}
