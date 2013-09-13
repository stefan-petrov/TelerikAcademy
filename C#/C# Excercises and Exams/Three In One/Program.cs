using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeInOne
{
    class Program
    {
        public static bool CheckForEqual(int[] arr, int num, int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num && i != index)
                {
                    return false;
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(',');
            int[] input1AsInt = ConvertStringArrToIntArr(input1);
            List<int> results = new List<int>();
            int indexOfWinner = -1;

            while (FindBiggest(input1AsInt) != 0)
            {
                int currentNum = FindBiggest(input1AsInt);

                if (currentNum <= 21)
                {
                    if (CheckForEqual(input1AsInt, currentNum, Array.IndexOf(input1AsInt, FindBiggest(input1AsInt))))
                    {
                        indexOfWinner = Array.IndexOf(input1AsInt, FindBiggest(input1AsInt));
                        break;
                    }
                    else
                    {
                        indexOfWinner = -1;
                        break;
                    }

                }
                else
                {
                    input1AsInt[Array.IndexOf(input1AsInt, FindBiggest(input1AsInt))] = 0;
                }
            }

            results.Add(indexOfWinner);
            //Console.WriteLine(indexOfWinner);

            string[] input2 = Console.ReadLine().Split(',');
            int[] input2AsIntArr = ConvertStringArrToIntArr(input2);
            int numberOfFriends = int.Parse(Console.ReadLine());
            int bites = 0;
            while (FindBiggest(input2AsIntArr) != 0)
            {
                bites += FindBiggest(input2AsIntArr);
                int index = Array.IndexOf(input2AsIntArr, FindBiggest(input2AsIntArr));
                input2AsIntArr[index] = 0;
                int temp = numberOfFriends;
                while (temp > 0)
                {
                    index = Array.IndexOf(input2AsIntArr, FindBiggest(input2AsIntArr));
                    input2AsIntArr[index] = 0;
                    temp--;
                }
            }
            results.Add(bites);
            //Console.WriteLine(bites);

            string[] input3 = Console.ReadLine().Split(' ');
            int g1 = int.Parse(input3[0]);
            int s1 = int.Parse(input3[1]);
            int b1 = int.Parse(input3[2]);
            int g2 = int.Parse(input3[3]);
            int s2 = int.Parse(input3[4]);
            int b2 = int.Parse(input3[5]);

            int operations = 0;
            bool canBuyBeer = false;
            bool isOver = false;
            while (!canBuyBeer && !isOver)
            {
                while (g1 < g2)
                {
                    if (s1 >= 11)
                    {
                        s1 -= 11;
                        g1 += 1;
                        operations++;
                    }
                    else if (b1 >=11)
                    {
                        b1 -= 11;
                        s1 += 1;
                        operations++;
                    }
                    else
                    {
                        isOver = true;
                    }
                    if (g1 > g2 && s1 > s2 && b1 > b2)
                    {
                        canBuyBeer = true;
                        break;
                    }                   
                }

                while (s1 < s2 && !isOver)
                {
                    if (g1 >= 1 && g1 > g2)
                    {
                        g1--;
                        s1 += 9;
                        operations++;
                    }
                    else if (b1 >= 11 && b1 + 11 > b2)
                    {
                        b1 -= 11;
                        s1 += 1;
                        operations++;
                    }
                    else
                    {
                        isOver = true;
                    }
                    if (g1 > g2 && s1 > s2 && b1 > b2)
                    {
                        canBuyBeer = true;
                        break;
                    }
                }

                while (b1 < b2 && !isOver)
                {
                    if (s1 >= 1 && s1 + 1 >= s2)
                    {
                        s1--;
                        b1 += 9;
                        operations++;
                    }
                    else if (g1 + 1 >= g2 && g1 >= 1)
                    {
                        g1--;
                        s1 += 9;
                        operations++;
                    }
                    else
                    {
                        isOver = true;
                    }
                }

                if (g1 >= g2 && s1 >= s2 && b1 >= b2)
                {
                    canBuyBeer = true;
                    break;
                }
            }
            results.Add(operations);
            //Console.WriteLine(operations);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
     

        public static int[] ConvertStringArrToIntArr(string[] strArr)
        {
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }
            return intArr;
        }

        public static int FindBiggest(int[] intArr)
        {
            int biggest = int.MinValue;
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] >= biggest)
                {
                    biggest = intArr[i];
                }
            }
            return biggest;
        }
    }
}
