using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] numArr = new string[] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        string input = Console.ReadLine();
        ulong sum = 0;
        double power = 0;
        List<int> intList = new List<int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            string test = sb.ToString();
            int index = Array.IndexOf(numArr, test);
            int tmpIndex = index;

            if (tmpIndex != -1)
            {
                intList.Add(tmpIndex);
                sb.Clear();
            }

        }
        for (int i = 0; i < intList.Count; i++)
        {
            sum += (ulong)intList[i] * (ulong)Math.Pow(9.0, intList.Count - 1 - i);
            power++;
        }
        Console.WriteLine(sum);
    }   
}

