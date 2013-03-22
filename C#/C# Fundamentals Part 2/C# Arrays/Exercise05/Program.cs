using System;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the lenght of the array: ");
            int arrayElements = int.Parse(Console.ReadLine());
            int[] array = new int[arrayElements];
            int bigestSequence = 0;
            int index = 0;
            int theNum = 0;
            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < arrayElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSame = array[i] == array[i + 1] - 1;

                if (isSame == true)
                {
                    int counter = 2; ;
                    int n = 1;

                    while (array[i + n] == array[i + 1 + n] - 1)
                    {
                        counter++;
                        n++;

                    }

                    if (counter > bigestSequence)
                    {
                        bigestSequence = counter;
                        index = i;
                        theNum = array[i];
                    }
                }
            }

            Console.WriteLine("The maximal increasing sequence in given array is: ");
            for (int i = 0; i < bigestSequence; i++)
            {
                Console.Write("{0} ", array[index + i]);
            }
        }
    }
}
