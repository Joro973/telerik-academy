using System;
//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
    class ArraySort
    {
        static void Main()
        {
            Console.Write("Array length ");
            int n = int.Parse(Console.ReadLine());
            int[] myIntArray = new int[n];
            for (int p = 0; p < n; p++)
            {
                Console.Write("Array[{0}] = ",p);
                myIntArray[p] = int.Parse(Console.ReadLine());
            }
            //Array.Sort(myIntArray);

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                { 
                    if (myIntArray[i] > myIntArray[j])
                    {
                        int temp = myIntArray[i];
                        myIntArray[i] = myIntArray[j];
                        myIntArray[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sorted array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(myIntArray[i] + " ");
            }
            Console.WriteLine();
        }
    }

