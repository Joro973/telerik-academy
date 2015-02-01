using System;
//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            if (n ==1 || n<=0)
            {
                Console.WriteLine("False");
            }
            else
            {
                int primeCount = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        primeCount++;
                    }
                }
                bool isPrime = true;
                if (primeCount > 2)
                {
                    isPrime = false;
                }

                Console.WriteLine(isPrime);
            }
       
        }

    }

