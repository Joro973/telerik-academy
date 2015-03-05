using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class MovingLetters
//{
//    static void Main()
//    {
//        //Input
//        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        //Find longest word
//        var maxLength = 0;
//        foreach (var word in words)
//        {
//            maxLength = Math.Max(maxLength, word.Length);
//        }
//        //ExtractLetters
//        var result = new StringBuilder();
//        for (int i = 0; i < maxLength; i++)
//        {
//            foreach (var word in words)
//            {
//                if (word.Length > i)
//                {
//                    int lastLetter = word.Length - i - 1;
//                    result.Append(word[lastLetter]);
//                }
//            }
//        }
//        //MovingLetters
//        for (int i = 0; i < result.Length; i++)
//        {
//            char currentSymbol = result[i];
//            int transition = char.ToLower(currentSymbol) - 'a' + 1;

//            result.Remove(i, 1);
//            int nextPosition = (i + transition) % (result.Length + 1);
//            result.Insert(nextPosition, currentSymbol);
//        }
//        Console.WriteLine(result);
//    }
//}



class MovingLetters
{
    static void Main()
    {
        //Input 
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //MaxLength
        var maxLength = 0;
        foreach (var word in words)
        {
            maxLength = Math.Max(word.Length, maxLength);
        }
        //ExtracLetters
        var result = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i )
                {
                    var lastLetter = word.Length - i - 1;
                    result.Append(word[lastLetter]);
                }
            }
        }
       //MovingLetters
        for (int i = 0; i < result.Length; i++)
        {
            var currentSymbol = result[i];
            var transition = char.ToLower(currentSymbol) - 'a' + 1;
            result.Remove(i, 1);
            var nextPosition = (i + transition) % (result.Length + 1);
            result.Insert(nextPosition, currentSymbol);
        }
        Console.WriteLine(result);
    }
}


















//static StringBuilder ExtractLetters(string[] words)
//{
//    int maxWordLength = 0;
//    StringBuilder result = new StringBuilder();

//    for (int i = 0; i < words.Length; i++)
//    {
//        string currentWord = words[i];
//        if (maxWordLength < currentWord.Length)
//        {
//            maxWordLength = currentWord.Length;
//        }
//    }

//    for (int i = 0; i < maxWordLength; i++)
//    {
//        for (int j = 0; j < words.Length; j++)
//        {
//            string currentWord = words[j];
//            if (i < currentWord.Length)
//            {
//                int lastLetter = currentWord.Length - i - 1;
//                result.Append(currentWord[lastLetter]);
//            }
//        }
//    }
//    return result;
//}

//static string MoveLetters(StringBuilder strangePieceOfWords)
//{
//    for (int i = 0; i < strangePieceOfWords.Length; i++)
//    {
//        char currentSymbol = strangePieceOfWords[i];
//        int transition = char.ToLower(currentSymbol) - 'a' + 1;

//        strangePieceOfWords.Remove(i, 1);
//        int nextPosition = (i + transition) % (strangePieceOfWords.Length + 1);
//        strangePieceOfWords.Insert(nextPosition, currentSymbol);
//    }
//    return strangePieceOfWords.ToString();
//}

//static void Main()
//{
//    string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//    StringBuilder strangeCombinationOfLetters = ExtractLetters(words);
//    string final = MoveLetters(strangeCombinationOfLetters);
//    Console.WriteLine(final);

//}