using System;
//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

class StringReverse
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        Console.WriteLine(input);
    }
}

