using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GagNumbers
{
    static string ConvertGagStringToNumber(string digit)
    {
       string result = "NO";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
            default:
                break;
        }
        return result;
    }
    static ulong PowerOfNine(int power)
    {
        ulong result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }
        return result;
    }

    static void Main()
    {
      var input = Console.ReadLine();

      string partialInput = string.Empty;
      string nineNumber = "";
      for (int i = 0; i < input.Length; i++)
      {
          partialInput += input[i];

          string currDigit = ConvertGagStringToNumber(partialInput);

          if (currDigit != "NO")
          {
              nineNumber += currDigit;
              partialInput = "";
          }
      }

      ulong result = 0;
      for (int i = 0; i < nineNumber.Length; i++)
      {
          ulong digit = ulong.Parse(nineNumber[i].ToString());
          result += digit * PowerOfNine(nineNumber.Length - i - 1);
      }
      Console.WriteLine(result);
    }
}


//using System;

//class NineGagNumber
//{
//    static string[] digits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

//    static void Main()
//    {
//        string number = Console.ReadLine();
//        ulong result = 0;

//        while (number.Length > 0)
//        {
//            for (int i = 0; i < digits.Length; i++)
//            {
//                if(number.StartsWith(digits[i]))
//                {
//                    number = number.Remove(0, digits[i].Length);
//                    result = result * 9 + (ulong)i;
//                }
//            }
//        }

//        Console.WriteLine(result);
//    }
//}