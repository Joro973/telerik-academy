using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class BunnyFactory
    {
        static void Main()
        {
            var cages = Input();

            for (int stepNumber = 1; ; stepNumber++)
            {
                if (cages.Count < stepNumber)
                {
                    break;
                }              
                var cagesCount = (int)SumListValuesInRange(cages, 0, stepNumber - 1);

                if (cages.Count < stepNumber + cagesCount)
                {
                    break;
                }

                var sum = SumListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
                var product = ProductListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
                string result = sum.ToString() + product.ToString();

                for (int i = cagesCount + stepNumber; i < cages.Count; i++)
                {
                    result += cages[i];
                }
                var newCages = new List<int>();

                foreach (var ch in result)
                {
                    if (ch != '0' && ch != '1')
                    {
                        newCages.Add(ch - '0');
                    }
                }

                cages = newCages;
            }
            Console.WriteLine(string.Join(" ",cages));
        }


        static BigInteger SumListValuesInRange (List<int> list, int startIndex , int endIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
			{
                sum += list[i];
			}
            return sum;

        }

        static BigInteger ProductListValuesInRange(List<int> list ,int startIndex, int endIndex)
        {
            BigInteger product = 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= list[i];
            }
            return product;
        }

        static List<int> Input ()
        {
            var cages = new List<int>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var cage = int.Parse(line);
                cages.Add(cage);
            }
            return cages;
        }
    }




//static void Main()
//    {
//        List<int> numbers = new List<int>();
//        while (true)
//        {
//            string input = Console.ReadLine();
//            if (input == "END")
//            {
//                break;
//            }
//            int number = int.Parse(input);
//            numbers.Add(number);
//        }
 
//        int i = 0;
 
//        while (true)
//        {
//            StringBuilder temp = new StringBuilder();
 
//            if (i >= numbers.Count)
//            {
//                break;
//            }
 
//            int startSum = 0;
//            BigInteger sum = 0;
//            BigInteger product = 1;
//            for (int j = 0; j <= i; j++)
//            {
//                startSum += numbers[j];
//            }
//            if (startSum >= numbers.Count - i)
//            {
//                break;
//            }
 
//            for (int j = i + 1; j <= startSum + i; j++) // added to  i + 1
//            {
//                sum += numbers[j];
//                product *= numbers[j];
//            }
//            temp.Append(sum);
//            temp.Append(product);
 
//            for (int j = startSum + i + 1; j < numbers.Count; j++)
//            {
//                temp.Append(numbers[j]);
//            }
 
//            numbers.Clear();
 
//            for (int j = 0; j < temp.Length; j++)
//            {
//                if (temp[j] != '0' && temp[j] != '1')
//                {
//                    numbers.Add(int.Parse(temp[j].ToString()));
//                }
//            }
//            i++;
//        }
 
//        Console.WriteLine(string.Join(" ", numbers));
//    }