using System;

namespace Ex14PrintMatrix2
{
    class Ex14PrintMatrix2
    {
        static void Main()
        {
            Console.WriteLine("Enter N (the size of the matrix N*N): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int num = 1;

            int matrixHeight = matrix.GetLength(0);
            int matrixWidth = matrix.GetLength(1);
            int counter = 0;

            while (counter < n / 2)
            {
                for (int col = counter; col <= matrixWidth - 2 - counter; col++)
                {
                    int row = 0 + counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int row = 0 + counter; row <= matrixHeight - 2 - counter; row++)
                {
                    int col = matrixWidth - 1 - counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int col = matrixWidth - 1 - counter; col > 0 + counter; col--)
                {
                    int row = matrixHeight - 1 - counter;
                    matrix[row, col] = num;
                    num++;
                }

                for (int row = matrixHeight - 1 - counter; row > 0 + counter; row--)
                {
                    int col = 0 + counter;
                    matrix[row, col] = num;
                    num++;
                }
                counter++;
            }

            if (n % 2 != 0)
            {
                matrix[n / 2, n / 2] = n * n;
            }
          
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
