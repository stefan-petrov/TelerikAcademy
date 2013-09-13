using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputValey = Console.ReadLine();
            string[] valeyOriginal = inputValey.Split(',');
            int m = int.Parse(Console.ReadLine());
            int maxCoins = int.MinValue;

            while (m > 0)
            {
                string[] valey = new string[valeyOriginal.Length];
                valeyOriginal.CopyTo(valey, 0);
                string pattern = Console.ReadLine();
                string[] arrPattern = pattern.Split(',');
                int currentCoins = 0;
                int position = 0;
                bool isOver = false;
                currentCoins += int.Parse(valey[0]);
                valey[0] = "#";

                while (!isOver)
                {
                    for (int i = 0; i < arrPattern.Length; i++)
			        {
                                             
                        position += int.Parse(arrPattern[i]);
                        if (valey[position] == "#")
                        {
                            isOver = true;
                            break;
                        } 
                        if (position >= valey.Length)
                        {
                            isOver = true;
                            break;
                        }
                        currentCoins += int.Parse(valey[position]);
                        valey[position] = "#";
			        }
                    
                }
                
                if (currentCoins >= maxCoins)
                {
                    maxCoins = currentCoins;
                }
                m--;
            }

            Console.WriteLine(maxCoins);
        }
    }
}
