using System;
//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
    class MaximalSumSeq
    {
        static void Main()
        {
            Console.Write("Array length ");
            int n = int.Parse(Console.ReadLine());
            int[] myIntArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr[{0}] = ",i);
                myIntArray[i] = int.Parse(Console.ReadLine());
            }
            int currSum = myIntArray[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempIndex = 0;
            int maxSum = myIntArray[0];
            for (int i = 0; i < n; i++)
            {
                if ( currSum <= 0)
                {
                    startIndex = i;
                    currSum = 0;
                }
                currSum += myIntArray[i];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    tempIndex = startIndex;
                    endIndex = i;
                }
            }
            Console.WriteLine("Best seq is ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(myIntArray[i] + " ");
            }
            Console.WriteLine();

        }
    }
