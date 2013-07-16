using System;

namespace PrintFullName
{
    class PrintFullName
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Yuor full name is: {0} {1}", firstName, lastName);
            Console.WriteLine();
        }
    }
}
