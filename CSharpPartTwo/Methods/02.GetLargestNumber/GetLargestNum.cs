using System;

//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class GetLargestNum
{
    static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(GetMax(GetMax(numbers[0],numbers[1]),numbers[2]));

    }
    static int GetMax(int firstNumber, int secondNumber)
    {
        return (firstNumber > secondNumber) ?
            firstNumber : secondNumber;
    }
}

