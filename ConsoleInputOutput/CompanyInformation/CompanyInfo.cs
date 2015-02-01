using System;
//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Company address:");
            string address = Console.ReadLine();
            Console.Write("Phone number:");
            decimal phoneNum = decimal.Parse(Console.ReadLine());
            Console.Write("Fax number:");
            string faxNum = Console.ReadLine();
            Console.Write("Web site:");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name:");
            string manFirstName = Console.ReadLine();
            Console.Write("Manager last name:");
            string manLastName = Console.ReadLine();
            Console.Write("Manager age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone:");
            decimal phone = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Tel."+phoneNum);
            Console.WriteLine("Fax: "+faxNum);
            Console.WriteLine("Web site: "+webSite);
            Console.WriteLine("Manager:{0} {1} (age:{2}, tel. {3}) ",manFirstName,manLastName,age,phone);


        }
    }

