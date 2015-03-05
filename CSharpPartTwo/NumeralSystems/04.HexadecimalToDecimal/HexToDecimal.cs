using System;

class HexToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        Console.WriteLine(HexaDecimalToDecimal(hex));
    }
    static long HexaDecimalToDecimal(string hex)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i] >= '0' && hex[i] <='9')
            {
                digit = hex[i] - '0';
            }
            else 
            {
                digit = hex[i] - 'A' + 10;
            }

            decimalNumber += digit * (long) Math.Pow(16, hex.Length - i - 1);
        }
        return decimalNumber;
    }
}

