﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(' ');

        Array.Sort(words);
        Console.WriteLine("Your words in alphabetical order: ");
        Console.WriteLine(string.Join(" ", words));
    }
}

