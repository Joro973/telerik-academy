using System;

    class SevenLand
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int result = 0;
            int lastDigit = k % 10;
            if (lastDigit == 6)
            {
                if (k % 100 == 66 && k % 1000 !=666 )
                {
                    result = k + 34;
                }
                else if (k % 1000 == 666)
                {
                    result = k + 344;
                }
                else
                {
                    result = k + 4;
                }
            }
            else
            {
                result = k + 1;
            }
            Console.WriteLine(result);
        }
    }
