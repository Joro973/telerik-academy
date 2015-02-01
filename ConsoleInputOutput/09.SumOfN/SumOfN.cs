using System;
//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

    class SumOfN
    {
        static void Main()
        {
            Console.Write("How much numbers you want to enter? ");
            int numbers = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= numbers; i++)
            {

                double b = double.Parse(Console.ReadLine());
                result += b;        
            }
            Console.WriteLine(result);
        }
    }

