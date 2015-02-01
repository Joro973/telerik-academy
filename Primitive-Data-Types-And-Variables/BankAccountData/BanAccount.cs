using System;
//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
    class BanAccount
    {
        static void Main()
        {
            Console.Write("Holder's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Holder's middle name: ");
            string secondName = Console.ReadLine();
            Console.Write("Holder's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Available amount of money: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Bank name: ");
            string bankName = Console.ReadLine();
            Console.Write("IBAN: ");
            string iban = Console.ReadLine();
            Console.Write("Credit card1 number: ");
            ulong card1 = ulong.Parse(Console.ReadLine());
            Console.Write("Credit card2 number: ");
            ulong card2 = ulong.Parse(Console.ReadLine());
            Console.Write("Credit card3 number: ");
            ulong card3 = ulong.Parse(Console.ReadLine());
        }
    }

