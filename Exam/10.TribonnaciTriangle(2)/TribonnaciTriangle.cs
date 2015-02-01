using System;

    class TribonnaciTriangle
    {
        static void Main()
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long lines = long.Parse(Console.ReadLine());


            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum+" "+thirdNum);

            int membersCount = 0;
            for (int i = 1; i <= lines; i++)
            {
                membersCount += i;
            }

            int nextLine = 3;
            int lineSize = 0;
            long result = 0;
            for (int i = 4; i <= membersCount; i++)
            {
              
                result = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = result;
                Console.Write(result+" ");
                lineSize++;
                if (lineSize==nextLine)
                {
                    Console.WriteLine();
                    nextLine += 1;
                    lineSize = 0;
                }        
            }
        }
    }
