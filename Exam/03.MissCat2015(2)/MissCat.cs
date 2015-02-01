//using System;

//    class MissCat
//    {
//        static void Main()
//        {
//            int juryNumber = int.Parse(Console.ReadLine());

//            int [] cats =new int  [11];
//            for (int i = 1; i <= juryNumber; i++)
//            {
//                int score = int.Parse(Console.ReadLine());
//                cats[score]++;
//            }
//            int max = 0;
//            int result = 0;
//            for (int i = 0; i <cats.Length; i++)
//            {
//                int currentValue = cats[i];
//                if (max < currentValue)
//                {
//                    max = currentValue;
//                    result = i;

//                }
//            }
//            Console.WriteLine(result);
//        }
//    }

using System;

class MissCat
{
    static void Main()
    {
        int juryNumber = int.Parse(Console.ReadLine());

        int[] cats = new int[11];

        for (int i = 0; i < juryNumber; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            cats[vote]++;
        }
        int max = 0;
        int result = 0;
        for (int i = 0; i < cats.Length; i++)
        {
            int currentValue = cats[i];
            if (max < currentValue)
            {
                max = currentValue;
                result = i;
            }
        }
        Console.WriteLine(result);
    }
}