using System;
//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.


    class Divider
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool divider = true;
            if (n % 5==0 && n % 7 ==0 && n!=0)
            {
                
            }
            else
            {
                divider = false;
            }
            Console.WriteLine(divider);
        }
    }

