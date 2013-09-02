using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that parses an URL address given in the format:
// [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
//the following information should be extracted:
		//[protocol] = "http"
		//[server] = "www.devbg.org"
		//[resource] = "/forum/index.php"

namespace Ex12ParseUrl
{
    class Ex12ParseUrl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter URL: ");
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
