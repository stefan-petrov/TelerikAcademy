using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTaskIdNotEnough
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = 2;
            int[] lamps = new int[n];
            int indexLastLamp = 0;
            int counter = 1;
            while (true)
            {
                int index = Array.IndexOf(lamps, 0);
                int temp = counter;
                for (int i = index; i < lamps.Length; i++)
                {

                    if (i == index)
                    {
                        lamps[i] = 1;
                        indexLastLamp = i;
                    }
                    else if (lamps[i] == 0)
                    {
                        temp--;
                        if (temp < 0)
                        {
                            lamps[i] = 1;
                            indexLastLamp = i;
                            temp = counter;
                        }
                    }

                }
                counter++;

                if (CheckIFAllLampsAreOn(lamps))
                {
                    break;
                }
                step++;
            }

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            List<string> result = new List<string>();

            int countR1 = CountR(input1);
            int countL1 = CountL(input1);
            int countR2 = CountR(input2);
            int countL2 = CountL(input2);

            if (countR1 > 0 && countR1 > countL1)
            {
                result.Add("bounded");
            }
            else if (countL1 > 0 && countL1 > countR1)
            {
                result.Add("bounded");
            }
            else
            {
                result.Add("unbounded");
            }

            if (countR2 > 0 && countR2 > countL2)
            {
                result.Add("bounded");
            }
            else if (countL2 > 0 && countL2 > countR2)
            {
                result.Add("bounded");
            }
            else
            {
                result.Add("unbounded");
            }
            

            Console.WriteLine(indexLastLamp + 1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int CountR(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'R')
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountL(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'L')
                {
                    count++;
                }
            }
            return count;
        }
        
        private static int FindIndexOfFirstTurndedOffLamp(bool[] arr)
        {
            int index = Array.IndexOf(arr, false);
            return index;
            
        }
        
        private static bool CheckIFAllLampsAreOn(int[] arr)
        {
            int index = Array.IndexOf(arr, 0);
            if (index == -1)
            {
                return true;
            }
            return false;
            
        }
    }
}
