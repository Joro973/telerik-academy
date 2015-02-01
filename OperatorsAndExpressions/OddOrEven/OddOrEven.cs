using System;
//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
    class OddOrEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool odd = true;
            if (n %2 !=0)
            {
                
            }
            else
            {
                odd = false;
            }
            Console.WriteLine(odd);
        }
    }

