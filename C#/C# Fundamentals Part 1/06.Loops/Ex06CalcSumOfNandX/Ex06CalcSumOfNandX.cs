using System;


namespace Ex06CalcSumOfNandX
{
    class Ex06CalcSumOfNandX
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for N");
            int inputN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for X");
            double inputX = double.Parse(Console.ReadLine());
            int ifaktoriel = 1;
            int i = 1;
            double sum = 1;

            for (i = 1; i <= inputN; i++)
            {
                ifaktoriel *= i;
                sum += ifaktoriel / (Math.Pow(inputX, i));
            }

            Console.WriteLine(sum); 
        }
    }
}
