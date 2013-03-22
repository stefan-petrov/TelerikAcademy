using System;

namespace ArraysExercises
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * 5;
            }

            foreach (var number in array)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }
    }
}
