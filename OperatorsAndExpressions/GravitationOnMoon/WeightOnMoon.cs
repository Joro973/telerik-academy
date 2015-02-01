using System;
//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    class WeightOnMoon
    {
        static void Main()
        {
            Console.Write("Enter weight: ");
            double weight = double.Parse(Console.ReadLine());
            double result = 0.17 * weight;
            Console.Write("Weight on moon: {0}" ,result);

        }
    }

