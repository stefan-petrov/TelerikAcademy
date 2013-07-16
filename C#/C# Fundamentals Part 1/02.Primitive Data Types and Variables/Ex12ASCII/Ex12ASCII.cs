using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12ASCII
{
    class Ex12ASCII
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 127; i++)
            {
                char currentChar = (char)i;
                Console.WriteLine("{0} = {1}", i, currentChar);
            }

            // im using the 'for' loop
        }
    }
}
