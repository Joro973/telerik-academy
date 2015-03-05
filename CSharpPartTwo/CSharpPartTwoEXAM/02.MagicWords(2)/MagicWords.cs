using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class MagicWords
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        var words = new List<string>();
//        for (int i = 0; i < n; i++)
//        {
//            words.Add(Console.ReadLine());
//        }
//        //Reorder
//        for (int i = 0; i < n; i++)
//        {
//            var word = words[i];
//            var newIndex = word.Length % (n + 1);

//            words[i] = null;
//            words.Insert(newIndex, word);
//            words.Remove(null);
//        }
//        //Print
//        var maxLength = 0;
//        foreach (var word in words)
//        {
//            maxLength = Math.Max(maxLength, word.Length);
//        }
//        var result = new StringBuilder();
//        for (int i = 0; i < maxLength; i++)
//        {
//            foreach (var word in words)
//            {
//                if (word.Length > i)
//                {
//                    result.Append(word[i]);
//                }
               
//            }
//        }
//        Console.WriteLine(result.ToString());
//    }
//}


//class MagicWords
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        var words = new List<string>();
//        for (int i = 0; i < n; i++)
//        {
//            words.Add(Console.ReadLine());
//        }
//        //Reorder
//        for (int i = 0; i < n; i++)
//        {
//            var word = words[i];
//            var newIndex = word.Length % (n + 1);

//            words[i] = null;
//            words.Insert(newIndex, word);
//            words.Remove(null);
//        }
//        //Print 
//        var maxLength = 0;
//        foreach (var word in words)
//        {
//            maxLength = Math.Max(maxLength, word.Length);
//        }
//        var result = new StringBuilder();
//        for (int i = 0; i < maxLength; i++)
//        {
//            foreach (var word in words)
//            {
//                if (word.Length > i)
//                {
//                    result.Append(word[i]);
//                }
//            }
//        }
//        Console.WriteLine(result);
//    }
//}



class MagicWords
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        //Reorder
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            var place = word.Length % (n + 1);
            words[i] = null;
            words.Insert(place, word);
            words.Remove(null);
        }
        //MaxLength
        var maxLength = 0;
        foreach (var word in words)
        {
            maxLength = Math.Max(maxLength, word.Length);
        }
        //Print
        var result = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i )
                {
                    result.Append(word[i]);
                }
            }
        }
        Console.WriteLine(result);
    }
}







//int n = int.Parse(Console.ReadLine());
//var words = new List<string>();
//for (int i = 0; i < n; i++)
//{
//    words.Add(Console.ReadLine());
//}
////Reorder
//for (int i = 0; i < n; i++)
//{
//    var word = words[i];
//    var newIndex = word.Length % (n + 1);

//    words[i] = null;
//    words.Insert(newIndex, word);
//    words.Remove(null);
//}
////Print
//var maxLength = 0;
//foreach (var word in words)
//{
//    maxLength = Math.Max(maxLength, word.Length);
//}
//var result = new StringBuilder();
//for (int i = 0; i < maxLength; i++)
//{
//    foreach (var letter in words)
//    {
//        if (letter.Length > i)
//        {
//            result.Append(letter[i]);
//        }

//    }
//}
//Console.WriteLine(result);



   //int n = int.Parse(Console.ReadLine());
   //     var words = new List<string>();
   //     for (int i = 0; i < n; i++)
   //     {
   //         words.Add(Console.ReadLine());
   //     }
   //     //Reorder
   //     for (int i = 0; i < n; i++)
   //     {
   //         var word = words[i];
   //         var nextIndex = word.Length % (n + 1);

   //         words[i] = null;
   //         words.Insert(nextIndex, word);
   //         words.Remove(null);
   //     }
   //     //Print
   //     var maxLength = 0;
   //     foreach (var word in words)
   //     {
   //          maxLength = Math.Max(maxLength, word.Length);
   //     }
   //     var result = new StringBuilder();
   //     for (int i = 0; i < maxLength; i++)
   //     {
   //         foreach (var word in words)
   //         {
   //             if (word.Length > i)
   //             {
   //                 result.Append(word[i]);
   //             }
   //         }
   //     }
   //     Console.WriteLine(result);