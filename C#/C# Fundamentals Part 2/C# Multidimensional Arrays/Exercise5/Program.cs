using System;
using System.Collections.Generic;

namespace Exercise5
{
    
    class Program
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
