using System;
//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.
class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(BinaryToDecimalConverter(binaryNumber));
    }
    static long BinaryToDecimalConverter(string binaryNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] - '0';
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2,position);
        }
        return decimalNumber;
    }
}

