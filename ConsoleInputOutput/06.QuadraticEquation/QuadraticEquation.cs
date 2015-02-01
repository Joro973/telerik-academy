using System;
//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            if (discriminant==0)
            {
                Console.WriteLine("x1=x2={0}",x1);
            }
            else if (discriminant>=1)
            {
                Console.WriteLine("x1={0} x2={1}",x1,x2);
            }
            else if (discriminant<0)
            {
                Console.WriteLine("No real roots");
            }
        }
    }

