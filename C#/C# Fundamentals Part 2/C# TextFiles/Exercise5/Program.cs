using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise5
{
    class Program
    {
        static int FindBiggestArea(int[,] matrix)
        {
            int bigestSum = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] + matrix[i, k + 1] + matrix[i + 1, k] + matrix[i +1 , k + 1] > bigestSum)
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
