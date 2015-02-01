using System;
//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.
    class FormulaSumClaculation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double factN = 1;
            double powerX = 1;
            double res = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                powerX *= x;
                res += factN / powerX;
            }
            Console.WriteLine("{0:F5}",res);
        }
    }

