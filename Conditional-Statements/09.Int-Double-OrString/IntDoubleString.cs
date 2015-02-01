using System;
//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
    class IntDoubleString
    {
        static void Main()
        {
            Console.Write("Please choose a type(1 for int , 2 for double ,3 for string) ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter an int ");
                    int choiceOne = int.Parse(Console.ReadLine());
                    Console.WriteLine(choiceOne + 1);
                    break;
                case 2:
                    Console.Write("Enter a double ");
                    double choiceTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine(choiceTwo + 1);
                    break;
                case 3:
                    Console.Write("Enter a string ");
                    string choiceThree = Console.ReadLine();
                    Console.WriteLine(choiceThree + "*");
                    break;
                default:
                    Console.Write("Wrong number");
                    break;
            }           //WITH IF
            //if (choice == 1)
            //{
            //    Console.Write("Enter an int ");
            //    int choiceOne = int.Parse(Console.ReadLine());
            //    Console.WriteLine(choiceOne + 1);
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Enter a double ");
            //    double choiceTwo = double.Parse(Console.ReadLine());
            //    Console.WriteLine(choiceTwo + 1);
            //}
            //else if (choice == 3)
            //{
            //    Console.Write("Enter a string ");
            //    string choiceThree = Console.ReadLine();
            //    Console.WriteLine(choiceThree + "*");
            //}
        }
    }

