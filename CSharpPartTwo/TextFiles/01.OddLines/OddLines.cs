using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.
class OddLines
{
    static void Main()
    {
        try
        {
            using (StreamReader stream = new StreamReader(@"..\..\..\txt\01.randomText.txt"))
            {
                string[] allLines = stream.ReadToEnd().Split('\n');

                StringBuilder result = new StringBuilder();
                for (int line = 1; line < allLines.Length; line += 2)
                {
                    result.AppendLine(allLines[line]);
                }

                if (result.Length == 0)
                {
                    result.AppendLine("No text found!");
                }

                Console.WriteLine(result);
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

