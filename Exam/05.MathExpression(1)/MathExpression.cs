using System;

    class MathExpression
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double gornaChast = n * n + (1 / (m * p)) + 1337;
            double dolnaChast = n - (128.523123123 * p);
            double angle = (int)m % 180;
            double krainaChast = Math.Sin(angle);

            double result = (gornaChast / dolnaChast) + krainaChast;

            Console.WriteLine("{0:F6}", result);
            //decimal angle = 5.99M % 3;
            //Console.WriteLine(angle);
        }
    }

