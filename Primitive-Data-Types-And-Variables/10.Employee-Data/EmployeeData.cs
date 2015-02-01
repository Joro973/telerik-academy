using System;
//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
    class EmployeeData
    {
        static void Main()
        {
            Console.Write("Enter first name: ");
            string firstName=Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Enter gender: (M for male and F for female)");
            string gender = Console.ReadLine();
            Console.Write("Enter personal ID number: ");
            ulong numID = ulong.Parse(Console.ReadLine());
            Console.Write("Enter unique empoyee number: ");
            ulong employeeNum = ulong.Parse(Console.ReadLine());

        }
    }

