using System;

namespace Ex13NullValues
{
    class Ex13NullValues
    {
        static void Main()
        {
            int? someInt = null;
            double? someDouble = null;
            Console.WriteLine("{0} {1}", someInt, someDouble);

            someInt = 123;
            someDouble = 23.56;
            Console.WriteLine("{0} {1}", someInt, someDouble);
        }
    }
}
