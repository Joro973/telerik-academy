using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Array length = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Element on which index you want checked? ");
        int position = int.Parse(Console.ReadLine());
        if (CheckIfLarger(position,arr))
        {
            Console.WriteLine("{0} is greater than {1} and {2}",arr[position],arr[position + 1],arr[position - 1]);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1} and {2}", arr[position], arr[position + 1], arr[position - 1]);
        }
    }
    static bool CheckIfLarger(int position , int[] arr)
    {
        bool largerThan = false;
        if (position < arr.Length && position > 0)
        {
            if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
            {
                largerThan = true;
            }
            else
            {
                Console.WriteLine("There are no neighbours ");
            }         
        }
        return largerThan;
    }
}

