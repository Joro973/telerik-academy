using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        for (int height = 1; height <= n; height++)
        {
            for (int width = 1; width < n; width++)
            {
                if (width == number)
                {
                    Console.Write("*");
                }
                Console.Write(".");
            }
            number++;
            if (height == n)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        number = n - 1;
        for (int height = (n - 1); height >= 1; height--)
        {
            for (int width = 1; width < n; width++)
            {
                if (width == number)
                {
                    Console.Write("*");
                }
                Console.Write(".");
            }
            number--;
            if (height == n)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
