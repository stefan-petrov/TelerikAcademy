using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static bool ValidMail(string str)
        {    
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
+ "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            Match match = regex.Match(str);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
        
        static void Main(string[] args)
        {
            List<string> validEmails = new List<string>();
            List<string> test = new List<string>();
            StreamReader reader = new StreamReader("../../sometextfile.txt");
            using (reader)
            {
                string textFromTextFile = reader.ReadToEnd();
                string[] newInput = Regex.Split(textFromTextFile, @"\s+");

                foreach (var item in newInput)
                {                
                    if (ValidMail(item.ToString()))
                    {
                        validEmails.Add(item.ToString());
                    }
                }
            }
            foreach (var item in validEmails)
            {
                Console.WriteLine(item);
            }
        }
    }
}
