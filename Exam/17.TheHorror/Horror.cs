//using System;

//    class Horror
//    {
//        static void Main()
//        {
//            string text = Console.ReadLine();
//            int counter = 0;
//            int evenCounter = 0;
//            int sum = 0;
//            foreach (char symbol in text)
//            {
//                if (counter % 2 ==0)
//                {
//                    if (char.IsDigit(symbol))
//                    {
//                        evenCounter++;
//                        sum += symbol - '0';
//                    }
                  
//                }
//                counter++;
//            }
//            Console.WriteLine("{0} {1}",evenCounter,sum);
//        }
//    }
using System;

    class Horror
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int position = 0;
            int sum = 0;
            int evenCounter = 0;
            foreach (char symbol in text)
            {
                if (position % 2 ==0)
                {
                    if (char.IsDigit(symbol))
                    {
                        evenCounter++;
                        sum += symbol - '0';
                    }
                   
                }
                position++;
            }
            Console.WriteLine("{0} {1}",evenCounter,sum);

        }
    }