using System;

//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class SortByLength
{
    static void Main()
    {
        Console.Write("Array length = ");
        int n = int.Parse(Console.ReadLine());
        string[] strArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            strArray[i] = Console.ReadLine();
        }
        Array.Sort(strArray, (x, y) => x.Length.CompareTo(y.Length));
        foreach (string str in strArray)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine();
    }
}

