using System;
using System.Collections.Generic;
using System.Linq;
//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
class MaximalSum
{
    static void Main()
    {
        var matrix = new int[99, 99];
        var rand = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(1, 101);
            }
        }

        int platformMaxX = 3;
        int platformMaxY = 3;
        int maxSum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0)-platformMaxX - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - platformMaxY - 1; j++)
            {
                //i , j => start of the platforms
                int currSum = 0;
                for (int platformX = i; platformX < i + platformMaxX; platformX++)
                {
                    for (int platformY = j; platformY < j + platformMaxY; platformY++)
                    {
                        currSum += matrix[platformMaxX, platformMaxY];
                    }
                }
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}








//    Console.Write("Number of rows = ");
//    int rows = int.Parse(Console.ReadLine());
//    Console.Write("Number of cols = ");
//    int cols = int.Parse(Console.ReadLine());
//    Console.WriteLine("Enter size of the square = ");
//    int squareSize = int.Parse(Console.ReadLine());
//    int[,] matrix = new int[rows, cols];
//    Console.WriteLine("Enter your matrix");
//    //entering matrix in correct format
//    for (int r = 0; r < rows; r++)
//    {
//        string currRow = Console.ReadLine();
//        string[] numsAsStrings = currRow.Split(' ');
//        for (int c = 0; c < cols; c++)
//        {
//            matrix[r, c] = int.Parse(numsAsStrings[c]);
//        }
//    }

//    int bestSum = int.MinValue;
//    int bestRow = 0;
//    int bestCol = 0;
//    int sum = 0;
//    int[,] subMatrix = new int[squareSize, squareSize];
//    for (int r = 0; r < matrix.GetLength(0) - squareSize - 1; r++)
//    {
//        for (int n = 0; n < matrix.GetLength(1) - squareSize - 1; n++)
//        {
//            sum = 0;
//            for (int subMatrixRow = 0; subMatrixRow < 3; subMatrixRow++)
//            {
//                for (int subMatrixCol = 0; subMatrixCol < 3; subMatrixCol++)
//                {
//                    sum += matrix[r + subMatrixRow, n + subMatrixCol];
//                }
//            }
//            if (sum > bestSum)
//            {
//                bestSum = sum;
//                bestRow = r;
//                bestCol = n;
//            }
//        }
//    }
//    Console.WriteLine("Maximal sum is:{0}", bestSum);