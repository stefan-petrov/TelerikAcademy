﻿using System;

// Write a program that fills and prints a matrix of size (n, n)

namespace Ex01PrintMatrix
{
    class Ex01PrintMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N (the size of the matrix N*N): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int num = 1;

            // for a)
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }

            Console.WriteLine("A):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0} ", Convert.ToString(matrix[i, k]).PadLeft(matrix[i, k].ToString().Length + ((n * n).ToString().Length - matrix[i, k].ToString().Length) / 2).PadRight((n * n).ToString().Length));
                }
                Console.WriteLine();
            }

            // for b)
            num = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (col % 2 == 1)
                {
                    for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
            }

            Console.WriteLine("B):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0} ", Convert.ToString(matrix[i, k]).PadLeft(matrix[i, k].ToString().Length + ((n * n).ToString().Length - matrix[i, k].ToString().Length) / 2).PadRight((n * n).ToString().Length));
                }
                Console.WriteLine();
            }

            // for c)
            num = 1;

            for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
            {
                int col = 0;
                int tmprow = row;
                int tmpcol = col;

                while ((tmprow <= matrix.GetLength(1) - 1) && (tmpcol <= matrix.GetLength(0) - 1))
                {
                    matrix[tmprow, tmpcol] = num;
                    num++;
                    tmprow++;
                    tmpcol++;
                }
            }

            for (int col = 1; col <= matrix.GetLength(1) - 1; col++)
            {
                int row = 0;
                int tmprow = row;
                int tmpcol = col;

                while ((tmprow <= matrix.GetLength(1) - 1) && (tmpcol <= matrix.GetLength(0) - 1))
                {
                    matrix[tmprow, tmpcol] = num;
                    num++;
                    tmprow++;
                    tmpcol++;

                }
            }

            Console.WriteLine("C):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0} ", Convert.ToString(matrix[i, k]).PadLeft(matrix[i, k].ToString().Length + ((n * n).ToString().Length - matrix[i, k].ToString().Length) / 2).PadRight((n * n).ToString().Length));
                }
                Console.WriteLine();
            }

            // for d)
            num = 1;
            int matrixHeight = matrix.GetLength(0);
            int matrixWidth = matrix.GetLength(1);
            int counter = 0;


            while (counter < n / 2)
            {
                for (int row = counter; row <= matrixHeight - 2 - counter; row++)
                {
                    int col = 0 + counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int col = 0 + counter; col <= matrixWidth - 2 - counter; col++)
                {
                    int row = matrixHeight - 1 - counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int row = matrixHeight - 1 - counter; row > 0 + counter; row--)
                {
                    int col = matrixWidth - 1 - counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int col = matrixWidth - 1 - counter; col > 0 + counter; col--)
                {
                    int row = 0 + counter;
                    matrix[row, col] = num;
                    num++;
                }
                counter++;
            }

            if (n % 2 != 0)
            {
                matrix[n / 2, n / 2] = n * n;
            }

            Console.WriteLine("D):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0} ", Convert.ToString(matrix[i, k]).PadLeft(matrix[i, k].ToString().Length + ((n * n).ToString().Length - matrix[i, k].ToString().Length) / 2).PadRight((n * n).ToString().Length));
                }
                Console.WriteLine();
            }
        }
    }
}
