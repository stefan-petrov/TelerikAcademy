using System;

// Write a method that asks the user for his name and prints “Hello, <name>” 
// (for example, “Hello, Peter!”). Write a program to test this method.


namespace Ex01PrintYourName
{
    class Ex01PrintYourName
    {
        static void HelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);

        }
        static void Main()
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            HelloName(input);
        }
    }
}
