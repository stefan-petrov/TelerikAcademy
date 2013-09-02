using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.


namespace Ex04MaxSequenceOfEqualElements
{
    class Ex04MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];
            int bigestSequence = 0;
            int index = 0;
            int theNum = 0;
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSame = array[i] == array[i + 1];

                if (isSame == true)
                {
                    int counter = 2; 
                   
                    while (array[i] == array[i + counter])
                    {
                        counter++;            
                    }

                    if (counter > bigestSequence)
                    {
                        bigestSequence = counter;
                        index = i;
                        theNum = array[i];
                    }
                }
            }

            Console.Write("The maximal sequence( {0} times ) of equal elements(The number {1}) in the array is: ", bigestSequence, theNum);
            for (int i = 0; i < bigestSequence; i++)
            {
                Console.Write("{0} ", array[index + i]);
            }
        }
    }
}
