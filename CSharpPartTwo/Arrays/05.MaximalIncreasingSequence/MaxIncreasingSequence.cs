using System;
//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the lenght of your Array ");
        int n = int.Parse(Console.ReadLine());

        int[] myIntArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            myIntArray[i] = int.Parse(Console.ReadLine());
        }
        int bestSeq = 1;
        int currSeq = 1;
        string currNum = "";
        string bestNum = "";
        for (int i = 0; i < n - 1; i++)
        {
            if (myIntArray[i] < myIntArray[i + 1])
            {
                currSeq++;
                currNum += myIntArray[i] + " ";
            }
            else
            {
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    currNum += myIntArray[i] + " ";
                    bestNum = currNum;
                }
                currSeq = 1;
                currNum = "";
            }
        }
        if (currSeq > bestSeq)
        {
            currNum += myIntArray[myIntArray.Length - 1];
            bestNum = currNum;
        }
        Console.WriteLine(bestNum);
    }
}

