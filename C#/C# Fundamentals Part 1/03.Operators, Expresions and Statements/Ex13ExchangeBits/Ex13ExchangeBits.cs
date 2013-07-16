using System;

namespace Ex13ExchangeBits
{
    class Ex13ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Convert.ToString(input, 2).PadLeft(32, '0'));
            int mask3 = 1 << 3;
            int bit3 = (mask3 & input) >> 3;
            int mask24 = 1 << 24;
            int bit24 = (mask24 & input) >> 24;
            int mask4 = 1 << 4;
            int bit4 = (mask4 & input) >> 4;
            int mask25 = 1 << 25;
            int bit25 = (mask25 & input) >> 25;
            int mask5 = 1 << 5;
            int bit5 = (mask5 & input) >> 5;
            int mask26 = 1 << 26;
            int bit26 = (mask26 & input) >> 26;
            int newInteger = 0;

            if (bit3 == 1)
            {
                newInteger = mask24 | input;
            }
            else
            {
                newInteger = ~mask24 & input;
            }

            if (bit24 == 1)
            {
                newInteger = mask3 | newInteger;
            }
            else
            {
                newInteger = ~mask3 & newInteger;
            }

            if (bit4 == 1)
            {
                newInteger = mask25 | newInteger;
            }
            else
            {
                newInteger = ~mask25 & newInteger;
            }

            if (bit25 == 1)
            {
                newInteger = mask4 | newInteger;
            }
            else
            {
                newInteger = ~mask4 & newInteger;
            }            

            if (bit5 == 1)
            {
                newInteger = mask26 | newInteger;
            }
            else
            {
                newInteger = ~mask26 & newInteger;
            }
            
            if (bit26 == 1)
            {
                newInteger = mask5 | newInteger;
            }
            else
            {
                newInteger = ~mask5 & newInteger;
            }
            
            Console.WriteLine("{0}", Convert.ToString(newInteger, 2).PadLeft(32, '0'));
            Console.WriteLine(newInteger);
        }
    }
}
