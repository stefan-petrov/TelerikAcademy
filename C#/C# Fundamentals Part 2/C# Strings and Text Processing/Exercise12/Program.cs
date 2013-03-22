using System;
using System.Text;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine("Protocol: {0}", ExtractProtocol(input));
            Console.WriteLine("Server: {0}", ExtractServer(input));
            Console.WriteLine("Resource: {0}", ExtractResource(input));
        }
        
        static string ExtractResource(string str)
        {
            int startIndexOfResource = str.IndexOf(ExtractServer(str));         
            StringBuilder sb = new StringBuilder();
            for (int i = startIndexOfResource + ExtractServer(str).Length; i < str.Length; i++)
            {
                sb.Append(str[i]);
            }
            string resource = sb.ToString();      
            return resource;
        }
       
        static string ExtractServer(string str)
        {
            int startIndexOfServer = str.IndexOf("//");
            int endIndexOfServer = str.IndexOf("/", startIndexOfServer + 2);
            StringBuilder sb = new StringBuilder();
            for (int i = startIndexOfServer + 2; i < endIndexOfServer; i++)
            {
                sb.Append(str[i]);
            }
            string server = sb.ToString();
            return server;
        }
        
        static string ExtractProtocol(string str)
        {
            int indexOfProtocol = str.IndexOf(":");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < indexOfProtocol; i++)
            {
                sb.Append(str[i]);
            }
            string protocol = sb.ToString();                
            return protocol;
        }       
    }
}
