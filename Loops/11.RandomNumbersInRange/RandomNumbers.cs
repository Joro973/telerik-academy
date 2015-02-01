using System;
//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
    class RandomNumbers
    {
        static void Main()
        {
            Console.Write("How much numbers you want to see? ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the minimal number ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximal number ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }
                Console.WriteLine();
            }
   
        }
    }

