using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Test
    {
        static void Main()
        {
            GenericList<int> test = new GenericList<int>(5);
            test.Add(56);
            test.Add(56);
            test.Add(56);
            test.Add(56);
            test.Add(56);
            test.Add(56);
            GenericList<string> test2 = new GenericList<string>(10);
            test2.Add("asdasda");
            test2.Add("sadasdsd");
            test2.RemoveElement(0);
            Console.WriteLine(test2.ElementByIndex(0));
            test.InsertAt(2, 57);
            Console.WriteLine(test.FindElementByValue(57));          
            int t = GenericList<GenericList<string>>.Min<int>(67, 68);
            Console.WriteLine(t);


            //GenericList<int> testList = new GenericList<int>();
            //GenericList<string> testList2 = new GenericList<string>();
            //testList.Add(56);
            //Tuple<int, string> test = new Tuple<int, string>(5, "az");
            //Console.WriteLine(test.Item2);
            //int a = 5;
            //int b = 6;
            //int min = Max<int>(a, b);
            //Console.WriteLine(min);
        }
    }
}
