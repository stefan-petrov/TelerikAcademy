using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
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
