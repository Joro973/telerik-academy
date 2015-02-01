using System;
//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
    class BitCheck
    {
        static void Main()
        {
            Console.Write("n= ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Position= ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;
            bool isOne = true;
            if (bit == 1)
            {
                Console.WriteLine(isOne);
            }
            else
            {
                isOne = false;
                Console.WriteLine(isOne);
            }
        }
    }

