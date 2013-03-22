using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {    
        private T[,] matrix;
        private uint count = 0;
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
    } 
}
