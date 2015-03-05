using System;
//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinaryConverter(decimalNumber));

    }
    static string DecimalToBinaryConverter(long decimalNumber)
    {
        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 2;
            binaryNumber = digit + binaryNumber;
            decimalNumber /= 2;
            
        }
        return binaryNumber;
    }
}

