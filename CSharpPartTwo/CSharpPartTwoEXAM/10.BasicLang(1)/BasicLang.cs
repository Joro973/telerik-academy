﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BasicLang
{
    private static StringBuilder output = new StringBuilder();
    static List<string> allCommands = new List<string>();

    static void Main()
    {
        ReadInput();
        ConvertInputToCommands();
        RunCommands();
        Console.Write(output.ToString());

    }

    private static void RunCommands()
    {
        output.Clear();
        for (int i = 0; i < allCommands.Count; i++)
        {
            int allLoops = 1;
            string[] subCommands = allCommands[i].Split(new char[] {')'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var command in subCommands)
            {
                string currentCommand = command.TrimStart();

                if (currentCommand.StartsWith("EXIT"))
                {
                    return;
                }

                else if (currentCommand.StartsWith("PRINT"))
                {
                    int paramsStart = currentCommand.IndexOf("(") + 1;
                    string content = currentCommand.Substring(paramsStart);

                    for (int j = 0; j < allLoops; j++)
                    {
                        output.Append(content);
                    }
                }

                else if (currentCommand.StartsWith("FOR"))
                {
                    int paramsStart = currentCommand.IndexOf("(") + 1;
                    string allParams = currentCommand.Substring(paramsStart);

                    if (allParams.Contains(","))
                    {
                        string[] loopParams = allParams.Split(',');

                        int a = int.Parse(loopParams[0]);
                        int b = int.Parse(loopParams[1]);

                        allLoops = allLoops * (b - a + 1);
                    }
                    else
                    {
                        int value = int.Parse(allParams);

                        allLoops = allLoops * value;
                    }
                }
            }
        }
    }

    private static void ConvertInputToCommands()
    {
        string allInput = output.ToString();
        output.Clear();

        foreach (var symbol in allInput)
        {
            output.Append(symbol);
            if (symbol == ';')
            {
                allCommands.Add(output.ToString());
                output.Clear();
            }
        }
    }

    private static void ReadInput()
    {
        while (true)
        {
            string line = Console.ReadLine();
            output.AppendLine(line);
            if (line.Contains("EXIT;"))
            {
                break;
            }
        }       
    }
}

