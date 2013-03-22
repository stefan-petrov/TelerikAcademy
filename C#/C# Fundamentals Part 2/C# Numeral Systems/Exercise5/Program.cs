using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in Hexadecimal system that you want to convert to binary system: ");
            string input = Console.ReadLine();
            char[] inputAsChar = input.ToCharArray();
            string[] inputAsString = new string[inputAsChar.Length];

            for (int i = 0; i < inputAsChar.Length; i++)
            {
                inputAsString[i] = Convert.ToString(inputAsChar[i]);
            }
            int[] inputAsInt = new int[input.Length];
            List<string> listString = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int num = 0;
                bool result = Int32.TryParse(inputAsString[i], out num);
                if (result)
                {
                    
                    string temp = Convert.ToString(num, 2);
                    listString.Add(temp.PadLeft(4, '0'));
                }
                else
                {
                    if (inputAsString[i] == "A" || inputAsString[i] == "a")
                    {
                        string temp = Convert.ToString(10, 2);
                        listString.Add(temp.PadLeft(4, '0'));

                    }
                    else if (inputAsString[i] == "B" || inputAsString[i] == "b")
                    {
                        string temp = Convert.ToString(11, 2);
                        listString.Add(temp.PadLeft(4, '0'));
                    }
                    else if (inputAsString[i] == "C" || inputAsString[i] == "c")
                    {
                        string temp = Convert.ToString(12, 2);
                        listString.Add(temp.PadLeft(4, '0'));
                    }
                    else if (inputAsString[i] == "D" || inputAsString[i] == "d")
                    {
                        string temp = Convert.ToString(13, 2);
                        listString.Add(temp.PadLeft(4, '0'));
                    }
                    else if (inputAsString[i] == "E" || inputAsString[i] == "e")
                    {
                        string temp = Convert.ToString(14, 2);
                        listString.Add(temp.PadLeft(4, '0'));
                    }
                    else if (inputAsString[i] == "F" || inputAsString[i] == "f")
                    {
                        string temp = Convert.ToString(15, 2);
                        listString.Add(temp.PadLeft(4, '0'));
                    }
                }
            }
         
            foreach (var item in listString)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
