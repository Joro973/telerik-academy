//using System;
//using System.Numerics;
//    class Tribonacci
//    {
//        static void Main()
//        {
//            BigInteger x = BigInteger.Parse(Console.ReadLine());
//            BigInteger y = BigInteger.Parse(Console.ReadLine());
//            BigInteger z = BigInteger.Parse(Console.ReadLine());
//            int n = int.Parse(Console.ReadLine());

//                if (n==1)
//            {
//                Console.WriteLine(x);
//            }
//            else if (n == 2)
//            {
//                Console.WriteLine(y);
//            }
//            else if (n==3)
//            {
//                Console.WriteLine(z);
//            }
            
//            else
//            {
//            BigInteger result = 0;
//            for (int i = 3; i < n; i++)
//            {
//                result = x + y + z;
//                x = y;
//                y = z;
//                z = result;
               
//            }
//             Console.WriteLine(result);
//            }
            
//        }
//    }
using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger valueOne = BigInteger.Parse(Console.ReadLine());
        BigInteger valueTwo = BigInteger.Parse(Console.ReadLine());
        BigInteger valueThree = BigInteger.Parse(Console.ReadLine());
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());

        BigInteger result = 0;
        for (int i = 1; i < numberN; i++)
        {

            result = valueOne + valueTwo + valueThree;
            valueOne = valueTwo;
            valueTwo = valueThree;
            valueThree = result;
            
        }
        Console.WriteLine(valueOne);
    }
}