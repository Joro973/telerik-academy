using System;
//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
class MatrixFill
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Console.WriteLine("Enter your matrix ");
        //entering the matrix in correct format 
        for (int r = 0; r < n; r++)
        {
            string currRow = Console.ReadLine();
            string[] numsAsStrings = currRow.Split(' ');
            for (int c = 0; c < n; c++)
            {
                matrix[r, c] = int.Parse(numsAsStrings[c]);
            }
        }
        Console.WriteLine("Formatted matrix looks like this: ");
        //printing the matrix
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0} ", matrix[c, r]);
            }              
            Console.WriteLine();
        }
    }
}

