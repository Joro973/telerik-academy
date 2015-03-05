using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Zerg
{
    static void Main()
    {
        string zergMessage = Console.ReadLine();
        var alphabet = new List<string> {
"Rawr",
"Rrrr",
"Hsst",
"Ssst",
"Grrr",
"Rarr",
"Mrrr",
"Psst",
"Uaah",
"Uaha",
"Zzzz",
"Bauu",
"Djav",
"Myau",
"Gruh"
};

        var decimalRepre = 0L;
        for (int i = 0; i < zergMessage.Length; i+=4)
        {
            var digit = zergMessage.Substring(i, 4);
            var decimalValue = alphabet.IndexOf(digit);
            decimalRepre *= 15;
            decimalRepre += decimalValue;
        }
        Console.WriteLine(decimalRepre);
    }
}

