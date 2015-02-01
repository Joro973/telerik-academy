using System;
//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
    class ExtractBit
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
            Console.WriteLine(bit);

        }
    }

