using System;

namespace ReadAgeFromConsole
{
    class ReadAgeFromConsole
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("After 10 Years you will be {0} years old", age + 10);
        }
    }
}
