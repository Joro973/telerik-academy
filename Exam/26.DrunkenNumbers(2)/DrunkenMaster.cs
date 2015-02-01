using System;

class DrunkenMaster
{
    static void Main()
    {
        long roundsCount = long.Parse(Console.ReadLine());
        long vBeers = 0;
        long mBeers = 0;
        for (int i = 0; i < roundsCount; i++)
        {
            long roundNumber = long.Parse(Console.ReadLine());
            if (roundNumber < 0)
            {
                roundNumber = -roundNumber;
            }
            long tempRoundNumber = roundNumber;
            long digits = 0;
            while (tempRoundNumber > 0)
            {
                tempRoundNumber /=  10;               
                digits++;           
            }
            if (digits % 2 == 0)
            {
                // vlado  - second half
                // mitko  - first half
                for (int j = 0; j < digits / 2; j++)
                {
                    vBeers += roundNumber % 10;
                    roundNumber /= 10;
                }
                for (int j = 0; j < digits / 2; j++)
                {
                    mBeers += roundNumber % 10;
                    roundNumber /= 10;
                }            
            }
            else
            {
                for (int j = 0; j < digits / 2; j++)
                {
                    vBeers += roundNumber % 10;
                    roundNumber /= 10;
                }
                long middleNumber = roundNumber % 10;
                vBeers += middleNumber;
                mBeers += middleNumber;
                roundNumber /= 10;
                for (int j = 0; j < digits / 2; j++)
                {
                    mBeers += roundNumber % 10;
                    roundNumber /= 10;
                }            
                // vladko - second half + midd
                // mitko - first half + midd
            }
        }
        if (mBeers > vBeers)
        {
            Console.WriteLine("M {0}", mBeers - vBeers);
        }
        else if (mBeers < vBeers)
        {
            Console.WriteLine("V {0}", vBeers - mBeers);
        }
        else if (mBeers == vBeers)
        {
            Console.WriteLine("No {0}", vBeers + mBeers);
        }
    }
}