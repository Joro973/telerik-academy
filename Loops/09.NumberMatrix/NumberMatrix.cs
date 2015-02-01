using System;
//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
    class NumberMatrix
    {
        static void Main()
        {
            Console.Write("Choose a number to see a matrix of it: ");
            int n = int.Parse(Console.ReadLine());
            int matrix = 1;
            if (n > 1 && n < 20)
            {
                for (int i = 1; i <= n; i++)
                {

                    Console.Write(i + " ");
                    matrix++;
                    Console.Write(matrix + " ");

                    for (int j = 2; j < n; j++)
                    {

                        Console.Write(i + j + " ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }

