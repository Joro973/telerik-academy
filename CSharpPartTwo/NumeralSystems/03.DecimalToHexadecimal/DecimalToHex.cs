using System;
//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.
class DecimalToHex
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexadecimal(decimalNumber));
    }
    static string DecimalToHexadecimal(long decimalNumber)
    {
        string hexaDecimalNumber = "";
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 16;
            if (digit >=0 && digit <= 9)
            {
                hexaDecimalNumber = (char)digit + '0' + hexaDecimalNumber;
            }
            else
            {
                hexaDecimalNumber = (char)(digit - 10 + 'A' )+ hexaDecimalNumber;
            }
            decimalNumber /= 16;
        }
        return hexaDecimalNumber;
    }
}
