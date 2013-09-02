using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

namespace Ex03CheckExpression
{
    class Ex03CheckExpression
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countLeftBracket = 0;
            int countRightBracket = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string character = Convert.ToString(input[i]);
                if (character == "(")
                {
                    countLeftBracket++;
                }
                if (character == ")")
                {
                    countRightBracket++;
                }
                if (countRightBracket > countLeftBracket)
                {
                    Console.WriteLine("Incorrect expression");
                    break;
                }
                if (character == ")" && countLeftBracket == 0)
                {
                    Console.WriteLine("Incorrect expression");
                    break;
                }
                if (i == input.Length - 1)
                {
                    if (countLeftBracket == countRightBracket)
                    {
                        Console.WriteLine("The expression is correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect expression");
                    }
                }
            }

        }
    }
}
