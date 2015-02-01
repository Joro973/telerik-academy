using System;
//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
    class BitModifier
    {
        static void Main()
        {
            Console.Write("n= ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Position= ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("bit value v(0 or 1) ");
            int value = int.Parse(Console.ReadLine());
            if (value ==0)
            {
                int mask = ~(1 << position);
                int result = number & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << position;
                int result = number | mask;
                Console.WriteLine(result);
            }
        }
    }
