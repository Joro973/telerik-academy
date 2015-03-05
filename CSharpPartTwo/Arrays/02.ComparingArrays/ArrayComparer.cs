using System;
//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.
class ArrayComparer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];

        int m = int.Parse(Console.ReadLine());
        int[] secondArray = new int[m];

        bool areEqual = true;

        if (firstArray.Length > secondArray.Length)
        {
            areEqual = false;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            areEqual = false;
        }
        else
        {
            Console.WriteLine("Enter {0} numbers for your first array ",n);
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} numbers for your second array ", m);
            for (int i = 0; i < m; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        Console.WriteLine("Are the arrays equal? {0}",areEqual);
    }
}

