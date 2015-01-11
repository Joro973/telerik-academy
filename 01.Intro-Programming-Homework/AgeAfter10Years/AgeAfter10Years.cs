using System;
//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Write your birthday in format: yyyy.m.d (e.g. 2003.8.12)");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());
            DateTime todaysDate = DateTime.Now;
            int MyAge = todaysDate.Year - myBirthday.Year;
            if ((myBirthday.Month <= todaysDate.Month && myBirthday.Day<=todaysDate.Day) 
                ^ (myBirthday.Month<todaysDate.Month && myBirthday.Day>todaysDate.Day))
            {
                Console.WriteLine("My age is:"+ MyAge);
                Console.WriteLine("My age after 10 years will be: {0}",MyAge+10 );
            }
            else
            {
                Console.WriteLine("My age is:{0}",MyAge-1);
                Console.WriteLine("My age after 10 yers will be: {0}",MyAge+9 );
            }
        }
    }

