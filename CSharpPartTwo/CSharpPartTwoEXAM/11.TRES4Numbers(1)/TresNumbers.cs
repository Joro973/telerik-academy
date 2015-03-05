using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TresNumbers
{
    static void Main()
    {
        string[] alphabet ={
"LON+" ,
"VK-"  ,
"*ACAD",
"^MIM" ,
"ERIK|",
"SEY&" ,
"EMY>>",
"/TEL" ,
"<<DON"
};
        ulong number = ulong.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("LON+");
        }

        string result = "";
        while (number != 0)
        {
            result = alphabet[(int)(number % 9)] + result;
            number /= 9;
        }
        Console.WriteLine(result);
    }
}

