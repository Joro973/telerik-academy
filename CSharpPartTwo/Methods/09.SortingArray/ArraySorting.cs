using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class ArraySorting
{
    static void Main()
    {
        int[] numbers = { 1, 3, 7, 9, 69, 420, 15, 17, 29, 31, 6, 9, 69, 7, 2, 1, 19, 44, 31, 33, 26, 28, 31 };
        SortDescending(numbers);
        PrintSortedArray(numbers);
        SortAscending(numbers);

    }
    static void SortAscending(int[] numbers)
    {
        int[] newNumbs = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbs[i] = numbers[numbers.Length - i - 1];
        }
        PrintSortedArray(newNumbs);
    }
    static void PrintSortedArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 10 == 0)
            {
                Console.Write("\n");
            }
            Console.Write("{0} ",numbers[i]);
        }
        Console.WriteLine();
    }
    static void SortDescending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = FindMaxIndex(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }
    }
    static int FindMaxIndex(int[] numbers,int startIndex)
    {
        int currentMax = int.MinValue;
        int currentMaxIndex = startIndex;
        for (int i = startIndex; i < numbers.Length; i++)
        {
            if (currentMax < numbers[i])
            {
                currentMax = numbers[i];
                currentMaxIndex = i;
            }
        }
        return currentMaxIndex;
    }
}
