//using System;

//class BatGoiko
//{
//    static void Main()
//    {
//        int h = int.Parse(Console.ReadLine());
//        //..../\....
//        //.../--\...
//        //../....\..                    
//        //./------\.
//        ///........\
        
//        for (int i = 0; i < h; i++)
//        {
          
//            for (int j = 0; j < h - i - 1; j++)
//            {
//                Console.Write(".");
//            }
//            Console.Write("/");

        
//            for (int j = 0; j < i*2; j++)
//            {
//                //Console.Write("-");
//            }
      
//            Console.Write("\\");
//            for (int j = 0; j < h - i - 1; j++)
//            {
//                Console.Write(".");
//            }
//            Console.WriteLine();
           
//        }        
//    }
//}

//........../\..........
//........./--\.........
//......../....\........
//......./------\.......
//....../........\......
//...../..........\.....
//..../------------\....
//.../..............\...
//../................\..
//./..................\.
///--------------------\
using System;

public class GoikoTower
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int width = h * 2;

        int towerWidth = 2;
        int nextCrossbeamRow = 2;
        int currentStep = 2;
        for (int row = 1; row <= h; row++)
        {
            string sidePoints = new string('.', (width - towerWidth) / 2);
            string middleSymbols;
            if (row % nextCrossbeamRow == 0)
            {
                middleSymbols = new string('-', width - (sidePoints.Length * 2) - 2);
                nextCrossbeamRow += currentStep;
                currentStep++;
            }
            else
            {
                middleSymbols = new string('.', width - (sidePoints.Length * 2) - 2);
            }
            Console.WriteLine(sidePoints + "/" + middleSymbols + "\\" + sidePoints);

            towerWidth += 2;
        }
    }    
}
