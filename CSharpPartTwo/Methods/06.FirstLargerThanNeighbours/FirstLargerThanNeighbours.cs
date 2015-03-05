using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 1, 3, 7, 9, 42, 69, 23, 420, 11 };
        int position = ReturnIndex(arr);
        if (position > 0)
        {
            Console.WriteLine("The index is: {0}",position);
        }
        else
        {
            Console.WriteLine("No such element");
        }
    }


        static int ReturnIndex(int[] arr)
    {
        int position;
        position = -1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i+ 1] && arr[i] > arr[i-1])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}


