using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public static class Extension
    {
        public static string Substring(this StringBuilder str, int startIndex, int lenght)
        {
            string s = str.ToString();
            return s.Substring(startIndex, lenght);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("sadada");
            sb.Append("  ");
            sb.Append("sadada");
            sb.Append("  ");

            string s = sb.Substring(2, 4);
            Console.WriteLine(s);
                
        }
    }
}
