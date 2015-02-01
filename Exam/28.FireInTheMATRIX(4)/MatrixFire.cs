using System;

class MatrixFire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
         //part1
            //...##...
            //..#..#..
            //.#....#.
            //#......#
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2 - i - 1; j++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int j = 0; j < i * 2; j++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int j = 0; j < n / 2 - i - 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
            //#......#
            //.#....#.
        for (int i = 0; i < n / 4; i++)
        {
            for (int j = 0; j < i; j++)         // i * 2 - i
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int j = 0; j < n / 2 - i - 1; j++)
            {
                Console.Write(".");
            }
            for (int j = 0; j < n / 2 - i - 1; j++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int j = 0; j < i; j++)          // i * 2 - i
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        //part2
               //--------
        for (int i = 0; i < n; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        //part3      
                //\\\\////
                //.\\\///.
                //..\\//..
                //...\/...
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            for (int j = 0; j < n / 2 - i; j++)
            {
                Console.Write("\\");
            }
            for (int j = 0; j < n / 2 - i; j++)
            {
                Console.Write("/");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }       
    }
}





