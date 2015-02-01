using System;

    class CoffeeMachine
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal amountPut = decimal.Parse(Console.ReadLine());
            decimal drinkPrice = decimal.Parse(Console.ReadLine());

            decimal tray1 = n1 * 0.05M;
            decimal tray2 = n2 * 0.10M;
            decimal tray3 = n3 * 0.20M;
            decimal tray4 = n4 * 0.50M;
            decimal tray5 = n5 * 1.00M;

            decimal machineTotal = tray1 + tray2 + tray3 + tray4 + tray5;
            decimal changeGiven = amountPut - drinkPrice;
            decimal moneyLeft = machineTotal - changeGiven;
            decimal moneyNeeded = amountPut - drinkPrice;

            if (amountPut >= drinkPrice)
            {
                if (machineTotal>=changeGiven)
                {
                    Console.WriteLine("Yes {0}", moneyLeft);
                }
                else
                {
                    Console.WriteLine("No {0}",moneyNeeded-machineTotal);
                }
                
            }
            else if (amountPut<drinkPrice)
            {
                Console.WriteLine("More {0}",-moneyNeeded);
            }
        

            
        }
    }

