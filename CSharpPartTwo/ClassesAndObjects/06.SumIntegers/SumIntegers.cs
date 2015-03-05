﻿using System;
//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
class SumIntegers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum = sum + int.Parse(input[i].Trim());
        }
        Console.WriteLine(sum);
    }
}
