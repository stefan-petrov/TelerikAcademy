using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N - number of rows of the multidimensional array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M - number of colons of the multidimensional array: ");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("value for [{0}, {1}] : ", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            int bigestSequence = 1;
            int bestRow = 0;
            int bestCol = 0;
            string theString = "";
            
            for (int row = 0; row <= matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 1; col++)
                {                    
                    int counter = 1;                    
                    int tmpcol = col;
                    int tmprow = row;
                    string currentString = matrix[row, col];

                    if (tmprow + 1 < matrix.GetLength(0))
                    {
                        while (currentString == matrix[tmprow + 1, tmpcol] && (tmprow + 1) < matrix.GetLength(0))
                        {
                            counter++;
                            tmprow++;
                            if (tmprow >= matrix.GetLength(0) - 1)
                            {
                                break;
                            }
                        }
                        tmprow = row;
                    }
                    
                    if (tmpcol + 1 < matrix.GetLength(1))
                    {
                        while (currentString == matrix[tmprow, tmpcol + 1] && (tmpcol + 1) < matrix.GetLength(1))
                        {
                            counter++;
                            tmpcol++;
                            if (tmpcol >= matrix.GetLength(1) - 1)
                            {
                                break;
                            }

                        }
                    }
                    tmpcol = col;

                    if (tmpcol + 1 < matrix.GetLength(1) && tmprow + 1 < matrix.GetLength(0))
                    {
                        while (currentString == matrix[tmprow + 1, tmpcol + 1] && (tmprow + 1) < matrix.GetLength(0) && (tmpcol + 1) < matrix.GetLength(1))
                        {
                            counter++;
                            tmprow++;
                            tmpcol++;
                            if (tmprow >= matrix.GetLength(0) - 1 || tmpcol >= matrix.GetLength(1) - 1)
                            {
                                break;
                            }
                        }
                        tmpcol = row;
                        tmprow = col;
                    }
                    
                    if (counter > bigestSequence)
                    {
                        bigestSequence = counter;
                        bestCol = col;
                        bestRow = row;
                        theString = currentString;
                    }              
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            while (bigestSequence > 0)
            {
                Console.Write("{0} ", theString);
                bigestSequence--;
            }
            Console.WriteLine();
        }
    }
}
