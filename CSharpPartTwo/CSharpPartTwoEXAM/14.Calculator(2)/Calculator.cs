using System;
using System.Collections.Generic;
using System.Text;

class SegmentDigits
{
    static int counterCombos = 0;
    static StringBuilder sb = new StringBuilder();
    static List<int>[] comboLists;

    static int numberOfLoops;
    static int numberOfIterations = 1;
    static int[] loops;

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            counterCombos++;
            AddPrintLoops();
            return;
        }

        for (int i = currentLoop; i < comboLists.Length; i++)
        {

            for (int counter = 0; counter < comboLists[i].Count; counter++)
            {
                loops[i] = comboLists[i][counter];
                NestedLoops(currentLoop + 1);
            }
            return;
        }
    }

    static void AddPrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            sb.Append(loops[i]);
        }
        sb.AppendLine();
    }


    static void Main()
    {
        int inputN = int.Parse(Console.ReadLine());
        string[] inputLines = new string[inputN];
        //inputLines[0] = "1011111";                                   
        int[] currentNumber = new int[inputN];
        //currentNumber[0] = GetNumberFromInput(inputLines[0]);       
        comboLists = new List<int>[inputN];
        for (int i = 0; i < inputLines.Length; i++)
        {
            comboLists[i] = new List<int>();
            inputLines[i] = Console.ReadLine();
            currentNumber[i] = GetNumberFromInput(inputLines[i]);
            AddComboList(i, currentNumber[i], inputLines[i]);
            numberOfIterations = numberOfIterations * comboLists[i].Count;
        }
        numberOfLoops = inputN;
        loops = new int[numberOfLoops];
        NestedLoops(0);
        string allCombsStr = sb.ToString();
        //Console.WriteLine(numberOfIterations);
        Console.WriteLine(counterCombos);
        Console.WriteLine(allCombsStr);

    }

    private static void AddComboList(int i, int number, string currentLine)
    {
        switch (number)
        {
            case 11:
                comboLists[i].Add(0); comboLists[i].Add(1); comboLists[i].Add(2); comboLists[i].Add(3); comboLists[i].Add(4); comboLists[i].Add(5);
                comboLists[i].Add(6); comboLists[i].Add(7); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 1:
                comboLists[i].Add(0); comboLists[i].Add(3); comboLists[i].Add(4); comboLists[i].Add(7); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 2:
                comboLists[i].Add(2); comboLists[i].Add(8);
                return;
            case 3:
                comboLists[i].Add(3); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 4:
                comboLists[i].Add(4); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 5:
                comboLists[i].Add(5); comboLists[i].Add(6); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 6:
                comboLists[i].Add(6); comboLists[i].Add(8);
                return;
            case 7:
                comboLists[i].Add(0); comboLists[i].Add(3); comboLists[i].Add(7); comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 8:
                comboLists[i].Add(8);
                return;
            case 9:
                comboLists[i].Add(8); comboLists[i].Add(9);
                return;
            case 0:
                comboLists[i].Add(0); comboLists[i].Add(8);
                return;
            case 10:
                AddListSecondCase(currentLine, i);
                return;
            default:
                return;
        }
    }

    private static void AddListSecondCase(string currentLine, int row)
    {
        string[] numbers = { "1111110", "0110000", "1101101", "1111001", "0110011", "1011011", "1011111", 
                           "1110000", "1111111", "1111011" };
        //string zero = "1111110";
        //string one = "0110000";
        //string two = "1101101";
        //string three = "1111001";
        //string four = "0110011";
        //string five = "1011011";
        //string six = "1011111";
        //string seven = "1110000";
        //string eight = "1111111";
        //string nine = "1111011";

        List<int> positions = new List<int>();
        for (int i = 0; i < currentLine.Length; i++)
        {

            if (currentLine[i] == '1')
            {
                positions.Add(i);
            }
        }
        bool countNumber = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            countNumber = true;
            for (int j = 0; j < positions.Count; j++)
            {
                if (numbers[i][positions[j]] != '1')
                {
                    countNumber = false;
                    break;
                }
            }
            if (countNumber == true)
            {
                comboLists[row].Add(i);
            }
        }

    }

    private static int GetNumberFromInput(string currentLine)
    {
        switch (currentLine)
        {
            case "0000000":
                return 11;
            case "0110000":
                return 1;
            case "1101101":
                return 2;
            case "1111001":
                return 3;
            case "0110011":
                return 4;
            case "1011011":
                return 5;
            case "1011111":
                return 6;
            case "1110000":
                return 7;
            case "1111111":
                return 8;
            case "1111011":
                return 9;
            case "1111110":
                return 0;
            default:
                return 10;
        }
    }
}