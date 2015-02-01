using System;
//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
    class MinMaxSumAvg
    {
        static void Main()
        {
            Console.Write("How much numbers you want to enter? ");
            int nums = int.Parse(Console.ReadLine());
            double sum = 0;
            double average = 0;
            int numMin = int.MaxValue;
            int numMax = int.MinValue;
            for (int i = 1; i <= nums; i++)
            {
                int numsChosen = int.Parse(Console.ReadLine());
                sum += numsChosen;
                average = sum / nums;
                numMin = Math.Min(numMin,numsChosen);
                numMax = Math.Max(numMax, numsChosen);
            }           
            Console.WriteLine("Minimal= "+numMin);
            Console.WriteLine("Maximal= "+numMax);
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine("Average={0:0.00}",average);
        }
    }

