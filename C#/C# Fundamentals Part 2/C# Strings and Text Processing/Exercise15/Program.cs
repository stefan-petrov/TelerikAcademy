using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int index = input.IndexOf("<a href=\"");
            while (index != -1)
            {
                input = input.Replace("<a href=\"", "[URL=");
                input = input.Replace("\">", "]");
                input = input.Replace("</a>", "[/URL]");
                                
                index = input.IndexOf("<a href=\"");              
            }

            Console.WriteLine(input);
        }
    }
}
