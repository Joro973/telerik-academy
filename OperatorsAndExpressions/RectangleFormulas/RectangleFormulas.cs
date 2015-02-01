using System;
//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
namespace RectangleFormulas
{
    class RectangleFormulas
    {
        static void Main()
        {
            Console.Write("Widht: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (width * 2) + (height * 2);        
            Console.WriteLine("Perimeter: {0}",perimeter);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
