using System;
//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

    class CircleFormulas
    {
        static void Main()
        {
            Console.Write("r=");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * (r * r);
            Console.Write("Peremiter= {0:F2} ",perimeter);
            Console.Write("Area= {0:F2}", area);

        }
    }

