using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace Ex13MergeSort
{
    class Ex13MergeSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> inputList = new List<int>();


            for (int i = 0; i < n; i++)
            {
                inputList.Add(int.Parse(Console.ReadLine()));
            }

            bool someBool = true;
            List<List<int>> containerList = new List<List<int>>();
            containerList.Add(inputList);

            while (someBool)
            {
                List<List<int>> temp = new List<List<int>>();
                List<List<int>> tempContainer = new List<List<int>>();

                foreach (List<int> currentList in containerList)
                {
                    int middle = 0;
                    
                    if (currentList.Count % 2 == 0)
                    {
                        middle = (currentList.Count / 2) - 1;
                    }
                    else
                    {
                        middle = currentList.Count / 2;
                    }
                   
                    List<int> leftList = new List<int>();
                    List<int> rightList = new List<int>();

                    
                    for (int i = 0; i <= middle; i++)
                    {
                            leftList.Add(currentList[i]);
                    }
                    
                    temp.Add(leftList);

                    if (currentList.Count != 1)
                    {
                        for (int i = middle + 1; i < currentList.Count; i++)
                        {
                            rightList.Add(currentList[i]);
                        }

                        temp.Add(rightList);
                    }    
                    
                    foreach (var item in temp)
                    {
                        tempContainer.Add(item);
                    }
                    
                    temp.Clear();
                }
                
                containerList.Clear();
                foreach (var item in tempContainer)
                {
                    containerList.Add(item);
                }
                       
                tempContainer.Clear();

                for (int i = 0; i < containerList.Count; i++)
                {
                    if (containerList[i].Count != 1)
                    {
                        break;
                    }
                    else if (containerList[containerList.Count - 1].Count == 1)
                    {
                        someBool = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < containerList.Count; i++)
            {
                List<int> temp = new List<int>();
                List<List<int>> newList = new List<List<int>>();
                if (i != containerList.Count - 1)
                {
                    if (containerList[i][0] > containerList[i + 1][0])
	                {
                        temp.Add(containerList[i][0]);
	                }
                    else
                    {
                        temp.Add(containerList[i + 1][0]);
                    }
                    i++;
                }
                else
                {
                    temp.Add(containerList[containerList.Count - 1][0]);
                }

                newList.Add(temp);
                temp.Clear();
                               
            }
        }
    }
}
