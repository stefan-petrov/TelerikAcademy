using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Random rand = new Random();
            char[] cypher = new char[rand.Next(6, 10)];

            for (int i = 0; i < cypher.Length; i++)
            {     
                cypher[i] = (char)rand.Next(35, 92);
            }
            char[] inputAsChar = input.ToCharArray();
            char[] arr = new char[input.Length];
            List<char> decoded = new List<char>();
          
            int count = 0; 
            
            for (int i = 0; i < input.Length; i++)
            {
                if (count > cypher.Length - 1)
                {
                    count = 0;
                }
                else
                {     
                    decoded.Add((char)(inputAsChar[i] ^ cypher[count]));
                    count++;
                }
            }

            Console.WriteLine("decoded: ");
            foreach (char item in decoded)
            {
                Console.Write(item);
            }


            List<char> encoded = new List<char>();
            Console.WriteLine();
            for (int i = 0; i < decoded.Count; i++)
            {
                if (count > cypher.Length - 1)
                {
                    count = 0;
                }
                else
                {
                    char temp = (char)(decoded[i] ^ cypher[count]);
                    encoded.Add(temp);
                    count++;
                }
            }

            Console.WriteLine("encoded: ");
            foreach (char item in encoded)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            char res = Convert.ToChar('g' ^ 5);
            Console.WriteLine(res);
            Console.WriteLine((char)((res) ^ 'h'));

        }
    }
}
