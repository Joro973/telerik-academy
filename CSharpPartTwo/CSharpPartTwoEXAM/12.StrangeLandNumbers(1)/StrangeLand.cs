using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StrangeLand
{
    static void Main()
    {
        string[] digits = {
 "f"      ,
 "bIN"    ,
 "oBJEC"  ,
 "mNTRAVL",
 "lPVKNQ" ,
 "pNWE"   ,
 "hT"
};
        string number = Console.ReadLine();
        ulong result = 0;

        while (number.Length > 0)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (number.StartsWith(digits[i]))
                {
                    number = number.Remove(0, digits[i].Length);
                    result = result * 7 + (ulong)i;
                }
            }
           
        }
        Console.WriteLine(result);
    }
}

