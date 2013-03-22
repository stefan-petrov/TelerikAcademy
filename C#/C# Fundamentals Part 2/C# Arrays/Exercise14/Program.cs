using System;

class QuickSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lenght of the string array: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        string[] unsortedStringArray = new string[arrayLenght];

        Console.WriteLine("Enter the elements of the string array: ");
        for (int i = 0; i < unsortedStringArray.Length; i++)
        {
            unsortedStringArray[i] = Console.ReadLine();
        }

        Quicksort(unsortedStringArray, 0, unsortedStringArray.Length - 1);

        Console.WriteLine("The sorted array looks like this: ");
        for (int i = 0; i < unsortedStringArray.Length; i++)
        {
            Console.Write(unsortedStringArray[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Quicksort(string[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        string pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                string tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}