//using System;

//    class ApplesAndOranges
//    {
//        static void Main()
//        {
//            long goshkoDigit = long.Parse(Console.ReadLine());

//            if (goshkoDigit < 0)
//            {
//                goshkoDigit = -goshkoDigit;
//            }
//            int oddDigitSum = 0;
//            int evenDigitSum = 0;
//            while (goshkoDigit>0)
//            {
//                byte digit = (byte)(goshkoDigit % 10);
//                if (digit % 2 == 0)
//                {
//                    evenDigitSum += digit;
//                }
//                else if (digit % 2 !=0)
//                {
//                    oddDigitSum += digit;
//                }
//                goshkoDigit /= 10;
//            }
//            if (evenDigitSum > oddDigitSum)
//            {
//                Console.WriteLine("apples "+evenDigitSum);
//            }
//            else if (oddDigitSum > evenDigitSum)
//            {
//                Console.WriteLine("oranges "+oddDigitSum);
//            }
//            else
//            {
//                Console.WriteLine("both "+evenDigitSum);
//            }
//        }
            
//    }


using System;

class ApplesAndOranges
{
    static void Main()
    {
        long goshkoNum = long.Parse(Console.ReadLine());
        long inputNumber = goshkoNum;
        long evenDigitSum = 0;
        long oddDigitSum = 0;
        if (goshkoNum < 0)
        {
            goshkoNum = -goshkoNum;
        }
        while (goshkoNum > 0 )
        {
            long digit = goshkoNum % 10;
            if (digit % 2 == 0)
            {
                evenDigitSum += digit;
            }
            else
            {
                oddDigitSum += digit;
            }
            goshkoNum /= 10;
        }
        if (evenDigitSum > oddDigitSum)
        {
            Console.WriteLine("apples {0}",evenDigitSum);
        }
        else if (oddDigitSum > evenDigitSum)
        {
            Console.WriteLine("oranges {0}",oddDigitSum);
        }
        else
        {
            Console.WriteLine("both {0}",evenDigitSum);
        }
    }
}