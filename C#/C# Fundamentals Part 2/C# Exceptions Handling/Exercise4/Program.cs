using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            try
            {
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
                Console.WriteLine("Have a nice day !");
            }
        }
    }
}
