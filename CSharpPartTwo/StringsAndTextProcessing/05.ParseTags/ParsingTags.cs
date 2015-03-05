using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class ParsingTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder uppercaseText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                i += 8;
                while (text[i] != '<')
                {
                    uppercaseText.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                uppercaseText.Append(text[i]);
            }
        }
        Console.WriteLine(uppercaseText.ToString());      
    }
}

