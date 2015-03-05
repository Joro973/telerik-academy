using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter your number = ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("Reversed = ");
        decimal reversed = ReverseDecimal(n);
        Console.Write(reversed);
        Console.WriteLine();

    }
    static decimal ReverseDecimal(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}

