using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all 
// exceptions and to free any used resources in the finally block.

namespace Ex04DownloadFile
{
    class Ex04DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            try
            {
                Console.WriteLine("Please wait for download to complete...");
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"../../Logo.jpg");     
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Null reference is passed to a method that does not accept it as a valid argument.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Sorry, but the invoked method is not supported.");
            }
            catch (WebException)
            {
                Console.WriteLine("Error occurs while accessing the network through a pluggable protocol.");
            }
            finally
            {
                Console.WriteLine("Download complete...");
                Console.WriteLine("Have a nice day !");
            }
        }
    }
}
