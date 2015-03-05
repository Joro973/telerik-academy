using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
class DigitAsWord
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        GetDigitAsWord(number);
    }
    static string GetDigitAsWord(int number)
    {
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Thre"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seve"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: Console.WriteLine("Zero"); break;
        }
        return lastDigit.ToString();
    }
}
