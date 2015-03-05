using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        string text = "Email examples example@abv.bg or dwayne.johnson@gmail.com are valid.These emails: example@yahoo.  @academy.com how@you.is. are not valid.";
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

        Console.WriteLine("Extracted e-mail addresses: ");
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], regex))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

