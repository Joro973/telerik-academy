using System;
//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            for (int i = 0; i <=n ; i++)
            {
                Console.Write("{0} ",firstNum);
                int fibonnacci = firstNum;
                firstNum = secondNum;
                secondNum = fibonnacci + secondNum;

            }
        }
    }

