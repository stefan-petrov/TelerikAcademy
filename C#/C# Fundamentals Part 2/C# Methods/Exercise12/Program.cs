using System;
using System.Collections.Generic;

namespace Exercise11
{
    class Program
    {

        static decimal[] MultiplyArrays(decimal[] array1, decimal[] array2)
        {
            Array.Reverse(array1);
            Array.Reverse(array2);

            decimal[] newDec = new decimal[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    int position = i + j;
                    newDec[position] += (array1[i] * array2[j]);
                }
            }
            
            Array.Reverse(array1);
            Array.Reverse(array2);
            return newDec;
        }
        
        static decimal[] SubtractArrays(decimal[] array1, decimal[] array2)
        {
            Array.Reverse(array1);
            Array.Reverse(array2);
            decimal[] newDec = new decimal[Math.Max(array1.Length, array2.Length)];

            if (array1.Length < array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    newDec[i] = array1[i] - array2[i];
                }

                for (int i = array1.Length; i < array2.Length; i++)
                {
                    newDec[i] = 0 - array2[i];
                }
            }

            else if (array1.Length > array2.Length)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    newDec[i] = array1[i] - array2[i];
                }

                for (int i = array2.Length; i < array1.Length; i++)
                {
                    newDec[i] = 0 - array1[i];
                }

            }
            else if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    newDec[i] = array1[i] - array2[i];
                }
            }

            Array.Reverse(array1);
            Array.Reverse(array2);

            Array.Reverse(newDec);
            return newDec;

        }
        
        private static decimal[] AddArrays(decimal[] array1, decimal[] array2)
        {
            Array.Reverse(array1);
            Array.Reverse(array2);
            decimal[] newDec = new decimal[Math.Max(array1.Length, array2.Length)];

            if (array1.Length < array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    newDec[i] = array1[i] + array2[i];
                }

                for (int i = array1.Length; i < array2.Length; i++)
                {
                    newDec[i] = array2[i];
                }
            }

            else if (array1.Length > array2.Length)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    newDec[i] = array1[i] + array2[i];
                }

                for (int i = array2.Length; i < array1.Length; i++)
                {
                    newDec[i] = array1[i];
                }

            }
            else if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    newDec[i] = array1[i] + array2[i];
                }
            }

            Array.Reverse(array1);
            Array.Reverse(array2);

            Array.Reverse(newDec);
            return newDec;
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of coeficients of first polynomial");
            int polynomial1Lenght = int.Parse(Console.ReadLine());
            decimal[] poly1 = new decimal[polynomial1Lenght];
            Console.WriteLine("Enter the coeficients on separate lines: ");

            for (int i = 0; i < poly1.Length; i++)
            {
                poly1[i] = decimal.Parse(Console.ReadLine());
            }

            for (int i = 0; i < poly1.Length - 1; i++)
            {
                if (poly1[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}x^{1} + ", poly1[i], poly1.Length - i - 1);
                }
            }
            Console.WriteLine(poly1[poly1.Length - 1]);

            Console.WriteLine("Enter the number of coeficients of seond polynomial");
            int polynomial2Lenght = int.Parse(Console.ReadLine());
            decimal[] poly2 = new decimal[polynomial2Lenght];
            Console.WriteLine("Enter the coeficients on separate lines: ");

            for (int i = 0; i < poly2.Length; i++)
            {
                poly2[i] = decimal.Parse(Console.ReadLine());
            }

            for (int i = 0; i < poly2.Length - 1; i++)
            {
                if (poly2[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}x^{1} + ", poly2[i], poly2.Length - i - 1);
                }
            }
            Console.WriteLine(poly2[poly2.Length - 1]);
            
            Console.WriteLine("The result of adding the polynomials is: ");
            Print(AddArrays(poly1, poly2));
            Console.WriteLine();
            Console.WriteLine("The result of substracting the polynomials is: ");
            Print(SubtractArrays(poly1, poly2));
            Console.WriteLine();
            Console.WriteLine("The result of multiplaying the polynomials is: ");
            
            for (int i = MultiplyArrays(poly1, poly2).Length - 1; i >= 0; i--)
        
            if (MultiplyArrays(poly1, poly2)[i] != 0 && i != 0)
            {
                if (MultiplyArrays(poly1, poly2)[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, MultiplyArrays(poly1, poly2)[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, MultiplyArrays(poly1, poly2)[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", MultiplyArrays(poly1, poly2)[i]);
            }
            
            Console.WriteLine();

        }      

        private static void Print(decimal[] array)
        {

            decimal[] arrayToPrint = array;
            
            for (int i = 0; i < arrayToPrint.Length - 1; i++)
            {
                if (arrayToPrint[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}x^{1} + ", arrayToPrint[i], arrayToPrint.Length - i - 1);
                }
            }
            Console.WriteLine(arrayToPrint[arrayToPrint.Length - 1]);
        }
    }
}
