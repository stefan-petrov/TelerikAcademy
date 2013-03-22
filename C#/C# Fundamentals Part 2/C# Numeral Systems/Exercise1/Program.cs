using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number you want to convert to binary system: ");
            int inputDec = int.Parse(Console.ReadLine());
            int remainder = 0;
            List<int> binary = new List<int>();
            while (inputDec > 0)
            {
                remainder = inputDec % 2;
                binary.Add(remainder);
                inputDec = inputDec / 2;
            }
            binary.Reverse();

            foreach (var item in binary)
            {
                Console.Write(item);
            }

        }
    }
}
