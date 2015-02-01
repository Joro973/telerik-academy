using System;
//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

    class ThirdDigit7
    {
        static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            int number = n / 100;
            int thirdDigit = number % 10;
            bool isSeven = thirdDigit==7;
            Console.WriteLine(isSeven);
        }
    }

