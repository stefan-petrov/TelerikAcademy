﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = File.ReadAllText("C:/WINDOWS/win.ini");
                Console.WriteLine(str);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Sorry, but there is no such direcoty.Are you sure the directory you entered is valid?");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null reference is passed to a method that does not accept it as a valid argument.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The operating system denies access because of an I/O error or a specific type of security error.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("sorry, but the filename you typed is not found.Please check again for filename accuracy.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Sorry, but the invoked method is not supported.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("One of the arguments provided to the method is not valid.Please check the arguments");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path or file name is longer than the system-defined maximum length.");
            }
            catch (IOException)
            {
                Console.WriteLine(" I/O error occurs.Please check the filename, the path to the file.Are you trying to read a closed file");
            }
            finally
            {
                Console.WriteLine("Have a nice day !");
            }
        }
    }
}
