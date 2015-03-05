using System;
//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
class SumInArray
{
    static void Main()
    {
        Console.WriteLine("Array length ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter sum ");
        int sum = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}] = ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currSum = 0;
        int startIndex = 0;

        for (int i = 0; i < n - 1; i++)
        {
            currSum += array[i];
            startIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                currSum += array[j];
                if (currSum == sum)
                {
                    for (int k = startIndex; k <= j; k++)
                    {
                        Console.WriteLine("{0} ", array[k]);
                    }
                    break;
                }
            }
            currSum = 0;
        }
    }
}

