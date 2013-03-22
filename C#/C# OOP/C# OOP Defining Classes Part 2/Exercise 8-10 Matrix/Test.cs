using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Test
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
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(m1PlusM2[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

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
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(m5[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
