using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

namespace Ex14QuickSort
{
    class Ex14QuickSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array");
            int listLenght = int.Parse(Console.ReadLine());
            List<int> inputList = new List<int>();

            for (int i = 0; i < listLenght; i++)
            {
                Console.Write("[{0}] - ", i);
                inputList.Add(int.Parse(Console.ReadLine()));
            }

            List<List<int>> containerList = new List<List<int>>();
            containerList.Add(inputList);

            bool infiniteLoop = true;
            while (infiniteLoop)
            {
                List<List<int>> currentListSplitHolder = new List<List<int>>();
                List<List<int>> temporaryContainer = new List<List<int>>();

                foreach (List<int> currentList in containerList)
                {
                    int mainElement = currentList[0];
                    List<int> mainElementList = new List<int>();
                    mainElementList.Add(mainElement);
                    List<int> smallerList = new List<int>();
                    List<int> biggerList = new List<int>();

                    for (int i = 1; i < currentList.Count; i++)
                    {
                        if (currentList[i] > mainElement)
                        {
                            biggerList.Add(currentList[i]);
                        }
                        else
                        {
                            smallerList.Add(currentList[i]);
                        }
                    }

                    currentListSplitHolder.Add(smallerList);
                    currentListSplitHolder.Add(mainElementList);
                    currentListSplitHolder.Add(biggerList);

                    foreach (List<int> splittedList in currentListSplitHolder)
                    {
                        if (splittedList.Count != 0)
                        {
                            temporaryContainer.Add(splittedList);
                        }
                    }

                    currentListSplitHolder.Clear();
                }

                containerList = temporaryContainer;
                for (int i = 0; i < containerList.Count; i++)
                {
                    if (containerList[i].Count != 1)
                    {
                        break;
                    }
                    else if (containerList[containerList.Count - 1].Count == 1)
                    {
                        infiniteLoop = false;
                        break;
                    }
                }
            }

            foreach (List<int> currentList in containerList)
            {
                Console.Write(currentList[0] + "  ");
            }
        }
    }
}

