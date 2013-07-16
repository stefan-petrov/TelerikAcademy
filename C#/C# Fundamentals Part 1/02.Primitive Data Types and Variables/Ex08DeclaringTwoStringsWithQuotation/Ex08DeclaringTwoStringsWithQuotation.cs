using System;

namespace Ex08DeclaringTwoStringsWithQuotation
{
    class Ex08DeclaringTwoStringsWithQuotation
    {
        static void Main()
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstString);

            string secondString = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondString);
        }
    }
}
