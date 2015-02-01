using System;
using System.Linq;
//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
    class SumOf5
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers separated by a space ");
            var numbers = Console.ReadLine().Split().Take(5);
            Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
            double sum = digits.Sum();
            Console.WriteLine("Sum = {0}",sum);
        }
    }
