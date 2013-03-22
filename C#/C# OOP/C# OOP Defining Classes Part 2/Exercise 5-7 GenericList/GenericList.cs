using Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class GenericList<T> : IEnumerable<T>
    
    {
        private T[] arr;
        private uint count = 0;

        public GenericList(int capacity)
        {
            arr = new T[capacity];
        }

        //Method for adding elements
        public void Add(T element)
        {
            if (count < arr.Length)
            {
                arr[count] = element;
                count++;
            }
            else
            {
                AutoResize();
                arr[count] = element;
                count++;
            }
        }

        //Resizing the array
        private void AutoResize()
        {
            T[] tempArray = new T[arr.Length * 2];
            Array.Copy(arr, tempArray, arr.Length);
            arr = tempArray;
        }

        //Accessing element by index
        public T ElementByIndex(int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                T tempValue = arr[index];
                return tempValue;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        //Removing element by index
        public void RemoveElement(int index)
        {
            if (index > 0)
            {
                T[] arrBeforeIndex = new T[index];
                T[] arrAfterIndex = new T[arr.Length - index - 1];
                Array.Copy(arr, arrBeforeIndex, index);
                Array.Copy(arr, index + 1, arrAfterIndex, 0, arr.Length - index - 1);
                T[] newArr = new T[arr.Length - 1];
                Array.Copy(arrBeforeIndex, 0, newArr, 0, arrBeforeIndex.Length);
                Array.Copy(arrAfterIndex, arrBeforeIndex.Length - 1, newArr, arrBeforeIndex.Length, arrAfterIndex.Length);
                arr = newArr;
            }
            else if (index == 0)
            {
                T[] tempArr = new T[arr.Length - 1];
                Array.Copy(arr, 1, tempArr, 0, arr.Length - 1);
                arr = tempArr;
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

       // Inserting element at given position
        public void InsertAt(int index, T value)
        {
            if (index > 0)
            {
                T[] newArr = new T[arr.Length + 1];
                Array.Copy(arr, newArr, index);
                newArr[index] = value;
                Array.Copy(arr, index, newArr, index + 1, arr.Length - index);
                arr = newArr;
            }
            else if (index == 0)
            {
                T[] tempArr = new T[arr.Length + 1];
                tempArr[index] = value;
                Array.Copy(arr, 0, tempArr, 1, arr.Length);
                arr = tempArr;
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        //Clearing the list
        public void ClearTheWholeList()
        {
            Array.Clear(arr, 0, arr.Length);
        }

        //Finding Element by its value
        public int FindElementByValue(T value)
        {
            int index = Array.IndexOf(arr, value);
            return index;
        }

        public override string ToString()
        {
            StringBuilder elements = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                elements.AppendFormat("{0} \n", arr[i].ToString());
              
            }
            string final = elements.ToString();
            return final;
        }

        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static T Max<T>(T first, T second)
          where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}