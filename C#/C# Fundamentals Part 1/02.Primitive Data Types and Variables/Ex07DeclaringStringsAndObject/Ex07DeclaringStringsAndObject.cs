using System;

namespace Ex07DeclaringStringsAndObject
{
    class Ex07DeclaringStringsAndObject
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloAndWorld = hello + " " + world;
            string objectAsString = Convert.ToString(helloAndWorld);
            Console.WriteLine(objectAsString);
        }
    }
}
