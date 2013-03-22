using System;
using System.Threading;

namespace Task7ExecuteAtTime
{
    class MainClass
    {
        public static void Main()
        {
            decimal seconds = int.Parse(Console.ReadLine());
            long converted = (long)seconds * 1000000;
            TimeSpan s = new TimeSpan(converted);
            while (true)
            {
                Console.WriteLine("AAAAAAAAAAA");
                Thread.Sleep(s);           
            }
        }
    }
}