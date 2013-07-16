using System;

namespace Ex08IntDoubleOrString
{
    class Ex08IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Enter int, double or string: ");
            string input = Console.ReadLine();

            int intInput;
            double doubleInput;
            bool isInt = Int32.TryParse(input, out intInput);
            bool isDouble = Double.TryParse(input, out doubleInput);

            int value = 0;

            if (isInt == true)
            {
                value = 1;
            }

            if (isDouble == true)
            {
                value = 2;
            }

            if (value == 0)
            {
                value = 3;
            }
            switch (value)
            {
                case 1: Console.WriteLine(intInput + 1); 
                    break;
                case 2: Console.WriteLine(doubleInput + 1); 
                    break;
                case 3: Console.WriteLine("{0}*", input);
                    break;
                default: Console.WriteLine("Not a valid input"); 
                    break;
            }
        }
    }
}
