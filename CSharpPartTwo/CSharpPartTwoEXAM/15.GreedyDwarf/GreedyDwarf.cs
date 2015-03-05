using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
    static void Main()
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

        int[] vallyNumbers = new int[rawNumbers.Length];

        for (int i = 0; i < vallyNumbers.Length; i++)
        {
            vallyNumbers[i] = int.Parse(rawNumbers[i]);
        }

        int numberOfPatterns = int.Parse(Console.ReadLine());
        long bestSum = long.MinValue;

        for (int i = 0; i < numberOfPatterns; i++)
        {
            long sum = ProccessPattern(vallyNumbers);

            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        Console.WriteLine(bestSum);
    }

    static long ProccessPattern (int[] vally)
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[rawNumbers.Length];
        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(rawNumbers[i]);
        }

        bool[] visited = new bool[vally.Length];
        long coinSum = 0;
        coinSum += vally[0];
        visited[0] = true;
        int currentPosition = 0;

        while (true)
        {
              for (int i = 0; i < pattern.Length; i++)
            {
                int nextMove = currentPosition + pattern[i];

                if (nextMove >= 0 
                    && nextMove < vally.Length 
                    && !visited[nextMove])
                {
                    coinSum += vally[nextMove];
                    visited[nextMove] = true;
                    currentPosition = nextMove;
                }

                else
                {
                    return coinSum;
                }
            }
        }


    }
}
  //WITH LINQ
//using System;
//using System.Linq;

//class GreedyDwarf
//{
//    static bool[] visited;
//    static long bestCollection = long.MinValue;

//    static void Main()
//    {
//        int[] numbers = Console.ReadLine().Split(',').Select(n => int.Parse(n)).ToArray();
//        visited = new bool[numbers.Length];

//        int m = int.Parse(Console.ReadLine());

//        int[][] patters = new int[m][];
//        for (int i = 0; i < m; i++)
//        {
//            patters[i] = Console.ReadLine().Split(',').Select(n => int.Parse(n)).ToArray();

//            GetCollectionCoint(numbers, patters[i]);
//        }

//        Console.WriteLine(bestCollection);
//    }

//    static void GetCollectionCoint(int[] numbers, int[] patters)
//    {
//        visited = Enumerable.Repeat(false, visited.Length).ToArray();

//        int currentCollection = 0, index = 0;

//        for (int i = 0; i < patters.Length; i++)
//        {
//            if (index < 0 || index >= numbers.Length || visited[index] == true) break;

//            currentCollection += numbers[index];
//            visited[index] = true;

//            index += patters[i];
            
//            if (i == patters.Length - 1) i = -1; // Starts from the beginning of pattern numbers
//        }

//        if (currentCollection > bestCollection) bestCollection = currentCollection;
//    }
//}