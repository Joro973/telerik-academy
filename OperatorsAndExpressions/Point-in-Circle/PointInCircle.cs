using System;
//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            int r = 2;
            bool inside = true;
            if (x*x+y*y <=r*r)
            {
                Console.WriteLine(inside);
            }
            else
            {
                inside = false;
                Console.WriteLine(inside);
            }
        }
    }

