using System;

class CreamPie
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());

        decimal fractionAB = A / B;
        decimal fractionCD = C / D;
        decimal result = fractionAB + fractionCD;
        decimal resultNominator = A * D + B * C;
        decimal resultDenominator = B * D;
        decimal finalFraction = B * D;


        if (A / B >= 1 || C / D >= 1 || result >= 1)
        {
            Console.WriteLine("{0:F0}", result);
            Console.WriteLine("{0}/{1}", resultNominator, resultDenominator);
        }
        else if (result < 1)
        {
            Console.WriteLine("{0:F20}", result);
            Console.WriteLine("{0}/{1}", resultNominator, resultDenominator);
        }
    }
}


