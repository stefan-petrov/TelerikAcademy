using System;

namespace Ex07GreatestOf5
{
    class Ex07GreatestOf5
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 integers");
            Console.WriteLine("Enter the first integer");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third integer");
            int int3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth integer");
            int int4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth integer");
            int int5 = int.Parse(Console.ReadLine());

            if (int1 > int2 && int1 > int3 && int1 > int4 && int1 > int5)
            {
                Console.WriteLine("The bigest integer is {0}", int1);
            }
            else if (int2 > int1 && int2 > int3 && int2 > int4 && int2 > int5)
            {
                Console.WriteLine("The bigest integer is {0}", int2);
            }
            else if (int3 > int1 && int3 > int2 && int3 > int4 && int3 > int5)
            {
                Console.WriteLine("The bigest integer is {0}", int3);
            }
            else if (int4 > int1 && int4 > int2 && int4 > int3 && int4 > int5)
            {
                Console.WriteLine("The bigest integer is {0}", int4);
            }
            else if (int5 > int1 && int5 > int2 && int5 > int3 && int5 > int4)
            {
                Console.WriteLine("The bigest integer is {0}", int5);
            }

            // Solved with loop

            //int bigestInt = int1;
            //int[] intArray = new int[5] { int1, int2, int3, int4, int5 };
            //for (int i = 1; i < intArray.Length; i++)
            //{
            //    if (intArray[i] > bigestInt)
            //    {
            //        bigestInt = intArray[i];
            //    }
            //}
            //Console.WriteLine("The bigest integer is {0}", bigestInt);
        }
    }
}
