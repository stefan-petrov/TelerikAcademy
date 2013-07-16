using System;

namespace Ex07CheckIfPrime
{
    class Ex07CheckIfPrime
    {
        static void Main()
        {
            //Един начин за установяване дали едно число е просто е 
            //като се провери дали се дели на някое от простите числа, 
            //по-малки от квадратния му корен.Корен квадрат на 100 е 9,8488... Простите числа
            //по-малки от 9,8488 са 7, 5, 3 и 2.

            Console.WriteLine("Please enter a number <= 100: ");
            int inputNum = int.Parse(Console.ReadLine());
            bool dividedBy2 = inputNum % 2 != 0;
            bool dividedBy3 = inputNum % 3 != 0;
            bool dividedBy5 = inputNum % 5 != 0;
            bool dividedBy7 = inputNum % 7 != 0;

            //Ако която и да е от променливите dividedBy2, dividedBy3, dividedBy5 и dividedBy7 даде false, 
            //то въведеното число не е просто.

            bool isPrime = dividedBy2 && dividedBy3 && dividedBy5 && dividedBy7;
            Console.WriteLine(isPrime ? "Prime" : "Not Prime");         
        }
    }
}
