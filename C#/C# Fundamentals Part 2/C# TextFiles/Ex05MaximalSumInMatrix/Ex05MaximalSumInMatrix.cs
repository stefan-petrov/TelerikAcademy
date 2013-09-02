using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a text file containing a square matrix of numbers 
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. Each of the next N 
//lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
// 4
// 2 3 3 4
// 0 2 3 4		->	17
// 3 7 1 2
// 4 3 3 2

namespace Ex05MaximalSumInMatrix
{
    class Ex05MaximalSumInMatrix
    {
        static int FindBiggestArea(int[,] matrix)
        {
            int bigestSum = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] + matrix[i, k + 1] + matrix[i + 1, k] + matrix[i + 1, k + 1] > bigestSum)
                    {
                        bigestSum = matrix[i, k] + matrix[i, k + 1] + matrix[i + 1, k] + matrix[i + 1, k + 1];
                    }
                }
            }

            return bigestSum;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");
            using (reader)
            {
                int n = int.Parse(reader.ReadLine());
                int[,] matrix = new int[n, n];
                string currentLine = reader.ReadLine();
                int countRow = 0;

                while (currentLine != null)
                {
                    string[] tmpString = currentLine.Split(' ');
                    for (int i = 0; i < tmpString.Length; i++)
                    {
                        matrix[countRow, i] = int.Parse(tmpString[i]);
                    }
                    countRow++;
                    currentLine = reader.ReadLine();
                }

                StreamWriter writer = new StreamWriter(@"../../result.txt");
                using (writer)
                {
                    writer.Write(FindBiggestArea(matrix));
                }

            }
        }
    }
}
