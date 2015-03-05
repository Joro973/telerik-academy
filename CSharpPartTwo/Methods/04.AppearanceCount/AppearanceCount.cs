using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
class AppearanceCount
{
    static void Main()
    {
        Console.Write("Array length = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter your array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the number");
        int number = int.Parse(Console.ReadLine());
        int count = NumberCounter(arr, number);
        Console.WriteLine("{0} appears {1}times in the array",number,count);


    }
    static int NumberCounter(int[]arr, int counter)
    {
        int numberCounter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == counter)
            {
                numberCounter++;
            }
        }
        return numberCounter;
    }
}

