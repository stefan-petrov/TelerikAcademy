using System;

// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".

namespace Ex03LastDigit
{
    class Ex03LastDigit
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnAsString(inputNum));
        }

        static string ReturnAsString(int num)
        {

            int remainder = num % 10;
            string output = "";

            switch (remainder)
            {
                case 1: output = "One";
                    break;
                case 2: output = "Two";
                    break;
                case 3: output = "Three";
                    break;
                case 4: output = "Four";
                    break;
                case 5: output = "Five";
                    break;
                case 6: output = "Six";
                    break;
                case 7: output = "Seven";
                    break;
                case 8: output = "Eight";
                    break;
                case 9: output = "Nine";
                    break;
                case 0: output = "Zero";
                    break;
                default: output = "Zero";
                    break;
            }

            return output;
        }
    }
}
