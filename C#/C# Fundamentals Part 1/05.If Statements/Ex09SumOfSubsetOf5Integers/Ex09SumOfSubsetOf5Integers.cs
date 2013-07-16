using System;

namespace Ex09SumOfSubsetOf5Integers
{
    class Ex09SumOfSubsetOf5Integers
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 integers");
            Console.WriteLine("Enter the first integer");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third integer");
            int int3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth integer");
            int int4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth integer");
            int int5 = int.Parse(Console.ReadLine());

            int[] intArr = new int[5] { int1, int2, int3, int4, int5 };
            int subsetSums = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (intArr[i] + intArr[j] == 0 && i != j)
                    {
                        subsetSums++;
                        Console.WriteLine("{0} + {1} = 0",intArr[i], intArr[j]);
                    }
                    for (int k = 0; k < intArr.Length; k++)
                    {
                        if (intArr[i] + intArr[j] + intArr[k] == 0 && (i != j && i != k && j != k))
                        {
                            subsetSums++;
                            Console.WriteLine("{0} + {1} + {2} = 0",intArr[i], intArr[j], intArr[k]);
                        }
                        for (int n = 0; n < intArr.Length; n++)
                        {
                            if (intArr[i] + intArr[j] + intArr[k] == 0 && (i != j && i != k && j != k && i != n && j !=n && k != n))
                        {
                            subsetSums++;
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0",intArr[i], intArr[j], intArr[k], intArr[n]);
                        }
                        }
                    }
                }
            }
            if (intArr[0] + intArr[1] + intArr[2] + intArr[3] + intArr[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", intArr[0], intArr[1], intArr[2], intArr[3], intArr[4]);
            }
        }
    }
}
