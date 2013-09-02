using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a class Matrix, to holds a matrix of integers. 
// Overload the operators for adding, subtracting and multiplying of matrices, 
// indexer for accessing the matrix content and ToString().

namespace Ex06ClassMatrix
{
    class Ex06ClassMatrix
    {
        static void Main(string[] args)
        {
            Matrix<double> m1 = new Matrix<double>(2, 3);
            Matrix<double> m2 = new Matrix<double>(2, 3);
            m1[0, 0] = 5;
            m1[0, 1] = 6;
            m1[0, 2] = 2.2;
            m1[1, 0] = 2.6;
            m1[1, 1] = 7;
            m1[1, 2] = 0;
            m2[0, 0] = 1;
            m2[0, 1] = 1;
            m2[0, 2] = 1;
            m2[1, 0] = 1;
            m2[1, 1] = 1;
            m2[1, 2] = 1;

            Matrix<double> m1PlusM2 = m1 + m2;
            Console.WriteLine(m1PlusM2);
            

            Matrix<double> m3 = new Matrix<double>(3, 2);
            Matrix<double> m4 = new Matrix<double>(2, 2);
            m3[0, 0] = 1;
            m3[0, 1] = 3;
            m3[1, 0] = 0;
            m3[1, 1] = -2;
            m3[2, 0] = 4;
            m3[2, 1] = 1;
            m4[0, 0] = 7;
            m4[0, 1] = 9;
            m4[1, 0] = 5;
            m4[1, 1] = 2;

            Matrix<double> m5 = m3 * m4;
            Console.WriteLine(m5);
            
        }
    }

     public class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {    
        private T[,] matrix;
        
        private int rows;
        private int cols;

        public int Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }

        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }

        public Matrix(int row, int col)
        {
            matrix = new T[row,col];
            this.rows = row;
            this.cols = col;
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            return m1.Addition(m2);
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            return m1.Substraction(m2);
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            return m1.Multiplication(m2);
        }

        public Matrix<T> Addition(Matrix<T> m)
        {
            if (this.rows == m.Rows && this.cols == m.Cols)
            {
                Matrix<T> newMatrix = new Matrix<T>(m.Rows, m.Cols);
                for (int i = 0; i < m.Rows; i++)
                {
                    for (int k = 0; k < m.Cols; k++)
                    {
                        dynamic tmpVal1 = this.matrix[i, k];
                        dynamic tmpVal2 = m[i, k];
                        newMatrix[i, k] = tmpVal1 + tmpVal2;
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new Exception("Cannot Substract matrix with different numbers of rows/colons in the given matrixes");
            }

        }

        public Matrix<T> Substraction(Matrix<T> m)
        {
            if (this.rows == m.Rows && this.cols == m.Cols)
            {
                Matrix<T> newMatrix = new Matrix<T>(m.Rows, m.Cols);
                for (int i = 0; i < m.Rows; i++)
                {
                    for (int k = 0; k < m.Cols; k++)
                    {
                        dynamic tmpVal1 = this.matrix[i, k];
                        dynamic tmpVal2 = m[i, k];
                        newMatrix[i, k] = tmpVal1 - tmpVal2;
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new Exception("Cannot Substract matrix with different numbers of rows/colons in the given matrixes");

            }
        }

        public Matrix<T> Multiplication(Matrix<T> m)
        {
            if (this.cols == m.Rows)
            {
                Matrix<T> newMatrix = new Matrix<T>(this.rows, this.cols);
                for (int i = 0; i < this.rows; i++)
                {
                    for (int k = 0; k < this.cols; k++)
                    {
                        dynamic currentSum = 0;
                        int temp = 0;
                        while (temp < m.Cols)
                        {
                            dynamic tmpVal1 = matrix[i, temp];
                            dynamic tmpVal2 = m[temp, k];
                            currentSum += tmpVal1 * tmpVal2;
                            temp++;
                        }
                        newMatrix[i, k] = currentSum;
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new Exception("Cannot multiply matrix with this number of colons/rows");
            }
        }

         public override string ToString()
         {
             int rows = this.rows;
             int cols = this.cols;

             for (int i = 0; i < rows; i++)
             {
                 for (int k = 0; k < cols; k++)
                 {
                     Console.Write(this.matrix[i,k] + " ");
                 }
                 Console.WriteLine();
             }
             return String.Empty;
         }
    } 
}

