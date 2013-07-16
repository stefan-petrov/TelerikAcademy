using System;

namespace Ex03BigestOfThreeIntegers
{
    class Ex03BigestOfThreeIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer");
            int thirdInt = int.Parse(Console.ReadLine());

            if ((firstInt > secondInt) && (firstInt > thirdInt))
            {
                Console.WriteLine("The bigest ineger is {0}", firstInt);
            }

            else if ((secondInt > firstInt) && (secondInt > thirdInt))
            {
                Console.WriteLine("The bigest ineger is {0}", secondInt);
            }
            else if ((thirdInt > firstInt) && (thirdInt > secondInt))
            {
                Console.WriteLine("The bigest ineger is {0}", thirdInt);
            }
            else if (firstInt== secondInt && firstInt == thirdInt)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("Two of the bigest integers are equal");
            }
        }
    }
}
