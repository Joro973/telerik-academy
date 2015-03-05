using System;
//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
class BinarySearch
{
    static void Main()
    {
        Console.Write("Array length ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number which index we are going to look for:");
        int S = int.Parse(Console.ReadLine());
        int[] myIntArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}] = ",i);
            myIntArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myIntArr);
    //    int index = BinarySearch(myIntArr, S, 0, myIntArr.Length);

    //    if (index != -1) Console.WriteLine("Number {0} found at index: {1}", S, index);
    //    else Console.WriteLine("Number {0} not found!", S);
    //}

    //private static int BinarySearch(int[] myIntArr, int value, int start, int end)
    //{
    //    if (end < start)
    //    {
    //        return -1;
    //    }
    //    else
    //    {
    //        int middleIndex = (start + end) / 2;
    //        if (myIntArr[middleIndex] > value)
    //        {
    //            return BinarySearch(myIntArr, value, start, middleIndex - 1);
    //        }
    //        else if (myIntArr[middleIndex] < value)
    //        {
    //            return BinarySearch(myIntArr, value, middleIndex + 1, end);
    //        }
    //        else
    //        {
    //            return middleIndex;
    //        }

    //    }
    }
}

