using System;

namespace Ex09TriangleWithCopyrightSymbol
{
    class Ex09TriangleWithCopyrightSymbol
    {
        static void Main()
        {
            char copyrightSymbol = '\u00A9';
            Console.WriteLine("  {0} ", copyrightSymbol);
            Console.WriteLine(" {0}{1}{2}", copyrightSymbol, copyrightSymbol, copyrightSymbol);
            Console.WriteLine(new string(copyrightSymbol, 5));
        }
    }
}
