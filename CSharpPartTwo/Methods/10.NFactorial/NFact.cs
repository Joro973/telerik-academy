using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

class NFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = NumberArray(n);
        int nFactorial = NumberFactorial(array);
        Console.WriteLine(nFactorial);
    }
    static int[] NumberArray(int n)
    {
        int[] arr = new int[n];
        for (int i = 1; i <=arr.Length; i++)
        {
            arr[i - 1] = i;
        }
        return arr;
    }
    static int NumberFactorial(int[] arr)
    {
        int result = 1;
        for (int i = 1; i <= arr.Length; i++)
        {
            result *= i;
        }
        return result;
    }
}

