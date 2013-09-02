using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

namespace Ex19ExtractDates
{
    class Ex19ExtractDates
    {
        static void Main(string[] args)
        {
            string str = "today 2.9.2013 is very beautiful day. Yesterday was 01.09.2013 and tommorow is gonna be 03.09.2013";
            string pattern = @"((((0?[1-9])|[12][0-9]|3[01])\.((0?[13578])|(1[02])))|(((0?[1-9])|[12][0-9]|30)\.((0?[469])|11))|(((0?[1-9])|[12][0-9])\.(0?2)))\.\d{4}";
            Regex rg = new Regex(pattern);            

            MatchCollection matches = rg.Matches(str);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    DateTime dt = DateTime.Parse(match.Value, CultureInfo.CreateSpecificCulture("ca-CA"));
                    Console.WriteLine(dt);
                }
            }
        }
    }
}
