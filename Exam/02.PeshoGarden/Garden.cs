using System;

    class Garden
    {
        static void Main()
        {
            decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());

            decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());

            decimal potatoSeeds = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());

            decimal carrotSeeds = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());

            decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
            decimal cabbageArea = decimal.Parse(Console.ReadLine());

            decimal beanSeeds = decimal.Parse(Console.ReadLine());

            decimal tomatoPrice = tomatoSeeds * 0.5M;
            decimal cucumberPrice = cucumberSeeds * 0.4M;
            decimal potatoPrice = potatoSeeds * 0.25M;
            decimal carrotPrice = carrotSeeds * 0.6M;
            decimal cabbagePrice = cabbageSeeds * 0.3M;
            decimal beanPrice = beanSeeds * 0.4M;

            decimal totalCost = tomatoPrice + cucumberPrice + potatoPrice + carrotPrice + cabbagePrice + beanPrice;
            decimal totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            decimal beanArea = 250 - totalArea;

            Console.WriteLine("Total costs: "+totalCost);

            if (totalArea>0 && totalArea<250)
            {
                Console.WriteLine("Beans area: "+beanArea);
            }
            else if (totalArea>250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea==250)
            {
               
                Console.WriteLine("No area for beans");
            }
        }
    }

