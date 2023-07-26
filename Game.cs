using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key,out int xChange,out int yChange)
        {
            switch (key)
            {
                case "UpArrow":
                    xChange = 0;
                    yChange = -1;
                    break;
                case "DownArrow":
                    xChange = 0;
                    yChange = 1; 
                    break;
                case "LeftArrow":
                    xChange = -1; 
                    yChange = 0;
                    break;
                case "RightArrow":
                    xChange = 1; 
                    yChange = 0;
                    break;
                case "W":
                    xChange = 0;  
                    yChange = -1;
                    break;
                case "S":
                    xChange = 0;
                    yChange = 1;
                    break;
                case "A":
                    xChange = -1;
                    yChange = 0;
                    break;
                case "D":
                    xChange = 1;
                    yChange = 0;
                    break;
                default:
                    xChange = 0;
                    yChange = 0;
                    break;
            }
        }
    public new static char UpdateCursor(string key)
        {
            switch (key)
            {
                case "UpArrow":
                    return '^';
                case "DownArrow":
                    return 'v';
                case "LeftArrow":
                    return '<';
                case "RightArrow":
                    return '>';
                case "W":
                    return '^';
                case "S":
                    return 'v';
                case "A":
                    return '<';
                case "D":
                    return '>';
                default:
                    return 'X';
            }
        }
    public new static int KeepInBounds(int dimension, int max) //work out how to amend the columns if the number hits the maximum.
        {
            if(dimension < 0)
            {
                return max - 1;//return 0;
            }
            else if(dimension >= max)
            {
                return 0;//return max-1;
            }
            else 
            { 
                return dimension; 
            }

        }
    public new static bool DidScore(int x1, int y1, int x2, int y2)
        {
            if(x1 == x2 & y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    public static void WinnerMessage()
        {
            string l1 = "         _________ _        _        _______  _______  _  _  _ ";
            string l2 = "|\\     /|\\__   __/( (    /|( (    /|(  ____ \\(  ____ )( )( )( )";
            string l3 = "| )   ( |   ) (   |  \\  ( ||  \\  ( || (    \\/| (    )|| || || |";
            string l4 = "| | _ | |   | |   |   \\ | ||   \\ | || (__    | (____)|| || || |";
            string l5 = "| |( )| |   | |   | (\\ \\) || (\\ \\) ||  __)   |     __)| || || |";
            string l6 = "| || || |   | |   | | \\   || | \\   || (      | (\\ (   (_)(_)(_)";
            string l7 = "| () () |___) (___| )  \\  || )  \\  || (____/\\| ) \\ \\__ _  _  _ ";
            string l8 = "(_______)\\_______/|/    )_)|/    )_)(_______/|/   \\__/(_)(_)(_)";
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);
            Console.WriteLine(l6);
            Console.WriteLine(l7);
            Console.WriteLine(l8);
        }
  }
}