using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");   
            List<string> stringList = new List<string>();
            

            using (reader)
            {
                
                string currentLine = reader.ReadLine();
                
                while (currentLine != null)
                {
                    stringList.Add(currentLine);
                    currentLine = reader.ReadLine();
                }   
            }
            
            stringList.Sort();
            StreamWriter writer = new StreamWriter(@"../../result.txt");
            using (writer)
            {
                for (int i = 0; i < stringList.Count; i++)
                {
                    writer.WriteLine(stringList[i]);
                }
            }
        }
    }
}
