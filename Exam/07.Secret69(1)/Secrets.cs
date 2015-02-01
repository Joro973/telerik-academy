using System;

    class Secrets
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long resultThree = a + c;
            long resultSix = a * c;
            long resultNine = a % c;
            if (b == 3)
            {
                if (resultThree % 3 == 0)
                {
                    Console.WriteLine(resultThree / 3);
                    Console.WriteLine(resultThree);
                }
                else
                {
                    Console.WriteLine(resultThree % 3);
                    Console.WriteLine(resultThree);
                }
            }
            if (b == 6)
            {
                if (resultSix % 3 == 0)
                {
                    Console.WriteLine(resultSix / 3);
                    Console.WriteLine(resultSix);
                }
                else
                {
                    Console.WriteLine(resultSix % 3);
                    Console.WriteLine(resultSix);
                }
            }
            if (b == 9)
            {
                if (resultNine % 3 == 0)
                {
                    Console.WriteLine(resultNine / 3);
                    Console.WriteLine(resultNine);
                }
                else
                {
                    Console.WriteLine(resultNine % 3);
                    Console.WriteLine(resultNine);
                }
            }      
        }
    }
