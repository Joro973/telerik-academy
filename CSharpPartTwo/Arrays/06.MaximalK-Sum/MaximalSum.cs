using System;
//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
class MaximalSum
{
    static void Main()
    {
        Console.Write("Array length ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] myIntArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}] = ", i);
            myIntArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myIntArray);
        Array.Reverse(myIntArray);
        int kSum = 0;
        for (int i = 0; i < k; i++)
        {
            kSum += myIntArray[i];
        }
        Console.WriteLine(kSum);
    }
}

