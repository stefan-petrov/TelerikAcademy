using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You are given an array of strings. Write a method that sorts the array 
// by the length of its elements (the number of characters composing them).

namespace Ex05SortingArrayOfStrings
{
    class Ex05SortingArrayOfStrings
    {
        class strArrayComparer : IComparer<string>
        {
            public int Compare(string stringLenght, string stringLenght2)
            {
                var lenght = stringLenght.Length;
                var lenght2 = stringLenght2.Length;
                return lenght.CompareTo(lenght2);
            }
        }

        static void Main()
        {
            Console.Write("Enter the lenght of the string array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            string[] strArray = new string[arrayLenght];

            Console.WriteLine("Enter the elements of the string array: ");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write("[{0}] - ", i);
                strArray[i] = Console.ReadLine();               
            }

            Array.Sort(strArray, new strArrayComparer());

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("The sorted array will look like this: ");
            Console.WriteLine();
            foreach (string item in strArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
