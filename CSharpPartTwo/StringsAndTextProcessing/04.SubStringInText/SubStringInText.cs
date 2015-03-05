using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

class SubStringInText
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. 
            Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string sub = "in";
        int count = 0;
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text.Substring(i, sub.Length).ToLower() == sub)
            {
                count++;
                i += sub.Length;
            }
        }
        Console.WriteLine(count);
    }
}
