using System;
//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
    class FrequentNumber
    {
        static void Main()
        {
            Console.Write("Array length ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int count = 1;
            int currentIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[currentIndex])
                    count++;
                else
                    count--;
                if (count == 0)
                {
                    currentIndex = i;
                    count = 1;
                }
            }
            int mostFreq = array[currentIndex];
            Console.WriteLine(mostFreq);
        }
    }
