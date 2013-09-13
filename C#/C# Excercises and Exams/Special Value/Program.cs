using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<long>> jaggedArr = new List<List<long>>();
            
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(',');
                List<long> temp2 = new List<long>();
                for (int k = 0; k < temp.Length; k++)
                {
                    temp2.Add(long.Parse(temp[k]));
                }
                jaggedArr.Add(temp2);                
            }
            int moves = 1;
            long specialValue = 0;
            for (int i = 0; i < jaggedArr[0].Count; i++)
            {
                long currentNum = jaggedArr[0][i];
                
                if (currentNum < 0)
                {
                    if ((Math.Abs(currentNum) + moves) > specialValue)
                    {
                        specialValue = (Math.Abs(currentNum) + moves);
                    }
                }
                else
                {
                    long index = 0;
                    do
                    {
                        
                        moves++;
                        index++;
                        if (index >= jaggedArr.Count)
                        {
                            index = 0;
                        }
                        currentNum = (long)jaggedArr[(int)index][(int)currentNum];                       

                    } while (currentNum >= 0);
                    if ((Math.Abs(currentNum) + moves) > specialValue)
                    {
                        specialValue = (Math.Abs(currentNum) + moves);
                    }
                    moves = 1;
                }
            }
            Console.WriteLine(specialValue);
        }
    }
}
