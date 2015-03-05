using System;

//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

class SayHello
{
    static string ReturnGreeting(string name)
    {
        return string.Format("Hello, {0}!", name);
    }
    static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(ReturnGreeting(name));
    }
}

