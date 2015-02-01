using System;
//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
    class OddAndEvenProduct
    {
        static void Main()
        {
            int even = 1;
            int odd = 1;
            string readNumbers = Console.ReadLine();
            string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (i % 2 ==0)
                {
                    even *= number;
                }
                else
                {
                    odd *= number;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Product = {0}", even);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd product = {0}", odd);
                Console.WriteLine("Even product = {0}", even);
            }  
        }
    }

