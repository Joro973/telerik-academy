using System;
//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
class CharArrayComparer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        int m = int.Parse(Console.ReadLine());
        char[] secondArray = new char[m];

        bool areEqual = true;
        Console.WriteLine("Enter chars for your first array");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter chars for your second array");
        for (int i = 0; i < m; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }
        if (n == m)
        {
           for (int i = 0; i < n; i++)
			{
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
			}          
        }
        else if (n != m)
        {
            areEqual = false;
        }
        Console.WriteLine("Are the arrays equal? {0}",areEqual);
    }
}

