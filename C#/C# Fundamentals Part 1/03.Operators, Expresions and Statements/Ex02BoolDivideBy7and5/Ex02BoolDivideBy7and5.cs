using System;

namespace Ex02BoolDivideBy7and5
{
    class Ex02BoolDivideBy7and5
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            bool dividableBy7and5 = input % 35 == 0;
            Console.WriteLine("The integer you have entered can be divided by 7 and 5 ?  {0}", dividableBy7and5);
        }
    }
}
