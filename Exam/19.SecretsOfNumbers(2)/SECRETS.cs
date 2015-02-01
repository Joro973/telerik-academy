//using System;
//using System.Numerics;

//    class SECRETS
//    {
//        static void Main()
//        {
//            BigInteger number = BigInteger.Parse(Console.ReadLine());
//            BigInteger inputNumber = number;

//            if (number < 0)
//            {
//                number = -number;
//            }

//            int specialSum = 0;
//            int currentDigitPosition = 0;
//            while (number > 0)
//            {
//                int currentDigit = (int)(number % 10);
//                currentDigitPosition++;
//                if (currentDigitPosition % 2 ==0)
//                {
//                    specialSum += currentDigit * currentDigit * currentDigitPosition;
//                }
//                else if (currentDigitPosition % 2 != 0)
//                {
//                    specialSum += currentDigit * currentDigitPosition * currentDigitPosition;
//                }
//                number /= 10;
//            }
//            Console.WriteLine(specialSum);

//            int secretLenght = specialSum % 10;
//            if (secretLenght != 0)
//            {
//                char firstSecretLetter = (char)(specialSum % 26 + 'A');
//                for (int i = 0; i < secretLenght; i++)
//                {
//                    char secretLetter = (char)(firstSecretLetter + i);
//                    if (secretLetter > 'Z')
//                    {
//                        secretLetter = (char)(secretLetter - 'Z' + 'A' - 1);
//                    }
//                    Console.Write(secretLetter);
//                }
//                Console.WriteLine();
//            }
//            else
//            {
//                Console.WriteLine("{0} has no secret alpha-sequence",inputNumber);
//            }
//        }
//    }

using System;
using System.Numerics;

class SECRETS
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger inputNumber = number;
        if (number < 0 )
        {
            number = -number;
        }
        int position = 1;
        BigInteger oddDigitSum = 0;
        BigInteger evenDigitSum = 0;
        
        while (number > 0)
        {
            BigInteger lastDigit = number % 10;
            if (position % 2 == 0)
            {
                evenDigitSum += (lastDigit * lastDigit) * position;
            }
            else
            {
                oddDigitSum += lastDigit * (position * position);
            }
            position++;
            number /= 10;
           
            
        }
        BigInteger specialSum = evenDigitSum + oddDigitSum;
        Console.WriteLine(specialSum);

        BigInteger sequenceLength = specialSum % 10;
        if (sequenceLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence",inputNumber);
        }
        BigInteger specialSumRemainder = specialSum % 26;
        for (int i = 0; i < sequenceLength; i++)
        {        
            Console.Write((char)('A'+(specialSumRemainder+i)% 26));
        }
        Console.WriteLine();

     }
}