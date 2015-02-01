using System;
using System.Numerics;
//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n>=1 && n<100)
            {
                BigInteger factN = 1;
                BigInteger factPlusOne = 1;
                BigInteger fact2N = 1;
                

                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }
                for (int j = 1; j <= n+1; j++)
                {
                    factPlusOne *= j;
                }
                for (int k = 1; k <= n*2; k++)
                {
                    fact2N *= k;
                }
          
                BigInteger result = fact2N / (factN * factPlusOne);
                Console.WriteLine(result);
                

            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }
        }
    }

