using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

    class ConcatenateTextFiles
    {
        static void Main()
        {
            string firstPath = @"..\..\..\txt\02.concatFirst.txt";
            string secondPath = @"..\..\..\txt\02.concatSecond.txt";
            string concatenatedPath = @"..\..\..\txt\02.concatenatedResult.txt";
            try
            {
                string firstString = File.ReadAllText(firstPath);
                string secondString = File.ReadAllText(secondPath);

                File.WriteAllText(concatenatedPath, firstString + secondString);

                Console.WriteLine(@"A {0} file named {1} has been created.",
                    Path.GetExtension(concatenatedPath), Path.GetFileNameWithoutExtension(concatenatedPath));
                Console.WriteLine(Environment.NewLine + "You can find it at " + Path.GetFullPath(concatenatedPath));
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

