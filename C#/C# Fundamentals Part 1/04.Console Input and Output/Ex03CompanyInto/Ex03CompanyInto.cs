using System;

namespace Ex03CompanyInto
{
    class Ex03CompanyInto
    {
        static void Main()
        {
            Console.Write("Please enter company name : ");
            string companyName = Console.ReadLine();
            Console.Write("Please enter company address : ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please enter company phone number : ");
            long companyPhone = long.Parse(Console.ReadLine());
            Console.Write("Please enter company fax : ");
            long companyFax = long.Parse(Console.ReadLine());
            Console.Write("Please enter company website : ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Please enter company's manager's first name : ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please enter company's manager's last name : ");
            string managerLastName = Console.ReadLine();
            Console.Write("Please enter company's manager's age : ");
            string managerAge = Console.ReadLine();
            Console.Write("Please enter company's manager's phone number : ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" ----------" + companyName + "---------- ");
            Console.WriteLine("|" + " Address: " + companyAddress);
            Console.WriteLine("|" + " Phone: {0:0000-00-00-00}", companyPhone);
            Console.WriteLine("|" + " Fax: {0:00 000 0000}", companyFax);
            Console.WriteLine("|" + " WebSite: " + companyWebSite);
            Console.WriteLine(" ----------" + companyName + "---------- ");
            Console.WriteLine();
            Console.WriteLine(" ----------| Manager |---------- ");
            Console.WriteLine("|" + " Name: {0} {1}", managerFirstName, managerLastName);          
            Console.WriteLine("|" + " Age: " + managerAge);
            Console.WriteLine("|" + " Phone: {0:0000-00-00-00}", managerPhone);
            Console.WriteLine(" -------------------------------- ");
        }
    }
}
