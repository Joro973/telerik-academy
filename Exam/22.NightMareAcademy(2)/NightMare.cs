//using System;

//    class NightMare
//    {
//        static void Main()
//        {
//            string text = Console.ReadLine();

//            long position = 0;
//            long oddPositionCounter = 0;
//            long result = 0;

//            foreach (char c in text)
//            {
//                if (position % 2 !=0)
//                {
//                    if (char.IsDigit(c))
//                    {
//                        oddPositionCounter++;
//                        result += c - '0';
//                    }
//                }
//                    position++;
//            }
//            Console.WriteLine("{0} {1}",oddPositionCounter,result);
//        }
//    }
using System;

class Horror
{
    static void Main()
    {
        string text = Console.ReadLine();

        int position = 0;
        int oddCounter = 0;
        int sum = 0;
        foreach (char symbol in text)
        {
            if (position % 2 != 0)
            {
                if (char.IsDigit(symbol))
                {
                    oddCounter++;
                    sum += symbol - '0';
                }
            }
            position++;
        }
        Console.WriteLine("{0} {1}",oddCounter,sum);
    }
}
