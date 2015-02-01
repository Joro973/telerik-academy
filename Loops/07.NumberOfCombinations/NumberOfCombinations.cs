using System;
using System.Numerics;
//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
    class NumberOfCombinations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            if (n>1 && k>1 && n<100 && k<100 )
            {
               BigInteger factN = 1;
               BigInteger factK = 1;
               BigInteger factNK = 1;
               BigInteger result = 0;

                for (int i = 1; i <=n ; i++)
                {
                    factN *= i;
                }
                for (int j = 1; j <= k; j++)
                {
                    factK *= j;
                }
                for (int r = 1; r <= n-k; r++)
                {
                    factNK *= r;
                    //Console.WriteLine(factNK);
                }
                result = factN / (factK * (factNK));
                Console.WriteLine(result);
                //n! / (k! * (n-k)!)
            }
            else
            {
                Console.WriteLine("Invalid Numbers");
            }
        }
    }

