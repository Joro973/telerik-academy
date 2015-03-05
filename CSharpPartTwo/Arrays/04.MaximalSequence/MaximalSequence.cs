using System;
//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the lenght of your array ");
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];

        int bestSeq = 1;
        int currentSeq = 1;
        int bestNumber = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            intArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            if (intArray[i] == intArray[i + 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (currentSeq >= bestSeq)
            {
                bestSeq = currentSeq;
                bestNumber = intArray[i];
            }
        }
        for (int i = 0; i < bestSeq; i++)
        {
            Console.Write("{0} ", bestNumber);
        }
        Console.WriteLine();
    }
}

