using System;

class AngryGPS
{
    static void Main()
    {
        long pisiNumber = long.Parse(Console.ReadLine());
        long inputNumber = pisiNumber;
        if (pisiNumber < 0)
        {
            pisiNumber = -pisiNumber;
        }
        long oddDigitSum = 0;
        long evenDigitSum = 0;
        while (pisiNumber > 0)
        {
            long digit = pisiNumber % 10;
            if (digit % 2 == 0)
            {
                evenDigitSum += digit;
            }
            else
            {
                oddDigitSum += digit;
            }
            pisiNumber /= 10;
        }
        if (evenDigitSum > oddDigitSum)
        {
            Console.WriteLine("right {0}", evenDigitSum);
        }
        else if (oddDigitSum > evenDigitSum)
        {
            Console.WriteLine("left {0}", oddDigitSum);
        }
        else
        {
            Console.WriteLine("straight {0}", oddDigitSum);
        }
    }
}
