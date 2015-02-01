using System;
//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

class PlayCardDeck
{
    static void Main()
    {
        for (int i = 1; i < 14; i++)
        {
            string cards = i + "";
            switch (i)
            {
                case 1:
                    cards = "2";
                    break;
                case 2:
                    cards = "3";
                    break;
                case 3:
                    cards = "4";
                    break;
                case 4:
                    cards = "5";
                    break;
                case 5:
                    cards = "6";
                    break;
                case 6:
                    cards = "7";
                    break;
                case 7:
                    cards = "8";
                    break;
                case 8:
                    cards = "9";
                    break;
                case 9:
                    cards = "10";
                    break;
                case 10:
                    cards = "J";
                    break;
                case 11:
                    cards = "Q";
                    break;
                case 12:
                    cards = "K";
                    break;
                case 13:
                    cards = "A";
                    break;

            }
            for (int k = 1; k <= 4; k++)
            {
                switch (k)
                {
                    case 1:
                        Console.Write(cards + "♠" + " ");
                        break;
                    case 2:
                        Console.Write(cards + "♥" + " ");
                        break;
                    case 3:
                        Console.Write(cards + "♦" + " ");
                        break;
                    case 4:
                        Console.Write(cards + "♣" + " ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

