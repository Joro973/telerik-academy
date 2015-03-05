using System;
//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
class LetterIndex
{
    static void Main()
    {
        char[] letterArray = { 'A', 'B', 'C','D','E','F',	'G',	
                                 'H' , 'I',	'J',	'K',	'L',	'M',	'N',	'O',	'P',	
                                 'Q',	'R',	'S',	'T',	'U',	'V',	'W',	'X',	'Y',	'Z'};
        string inputWord = Console.ReadLine();

        foreach (char letter in inputWord)
        {
            Console.WriteLine("Letter '{0}' -> index: {1} / ASCII Index: {2}",
                 letter, Array.IndexOf(letterArray, char.ToUpperInvariant(letter)), (int)letter);
        }
    }
}
