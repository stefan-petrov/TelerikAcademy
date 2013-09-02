using System;

// Write a program that reads a rectangular matrix of size N x M and 
// finds in it the square 3 x 3 that has maximal sum of its elements.

namespace Ex02RectMatrix
{
    class Ex02RectMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N - number of rows of the multidimensional array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M - number of colons of the multidimensional array: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("value for [{0}, {1}] : ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            int bestSum = 0;
            int indexK = 0;
            int indexI = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = 0;

                    for (int i = row; i < row + 3; i++)
                    {
                        for (int k = col; k < col + 3; k++)
                        {
                            currentSum += matrix[i, k];

                        }

                    }
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        indexI = row;
                        indexK = col;
                    }
                }
            }

            for (int i = indexI; i < indexI + 3; i++)
            {
                for (int k = indexK; k < indexK + 3; k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("The best sum is: {0}", bestSum);
        }
    }
}
