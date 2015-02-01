using System;
//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b;
            Console.WriteLine(greater);
            
  

        }
    }

