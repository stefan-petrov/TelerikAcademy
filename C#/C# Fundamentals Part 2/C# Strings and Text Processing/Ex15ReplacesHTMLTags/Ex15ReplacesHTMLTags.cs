using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

namespace Ex15ReplacesHTMLTags
{
    class Ex15ReplacesHTMLTags
    {
        static void Main(string[] args)
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            int index = input.IndexOf("<a href=");
            while (index != -1)
            {
                input = input.Replace("<a href=\"", "[URL=");
                input = input.Replace("\">", "]");
                input = input.Replace("</a>", "[/URL]");

                index = input.IndexOf("<a href=");
            }

            Console.WriteLine(input);
        }
    }
}
