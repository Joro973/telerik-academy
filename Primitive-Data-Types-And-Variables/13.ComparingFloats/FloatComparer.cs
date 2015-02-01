using System;
//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

    class FloatComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool equals = true;
            if (Math.Abs(a-b)< 0.000001)
            {
                Console.WriteLine(equals);

            }
            else
            {
                equals = false;
                Console.WriteLine(equals);


            }

        }
    }

