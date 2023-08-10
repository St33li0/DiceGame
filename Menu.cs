using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Menu
    {
        string menuDisplay;

        public Menu(string menuPicked = "MainMenu")
        {
            menuDisplay = menuPicked;
        }

        public void SetMenu(string menuPicked = "MainMenu")
        {
            menuDisplay = menuPicked;
        }

        public string GetMenu(string menuPicked = "MainMenu")
        {
            SetMenu(menuPicked);
            return menuDisplay;
        }

        public void MainMenu()
        {
            var mainMenuItems = new List<Tuple<int, bool, string>>
            {
                // Menu options || int itemNumber, bool isAvailable, string itemText ||
                Tuple.Create( 1, false, "Roll Dice"),
                Tuple.Create(2, false,"Games"),
                Tuple.Create(3, false, "Options"),
            };

            Console.WriteLine("Main Menu\n");
            Console.WriteLine("Please select a number from the list:");
            foreach (var item in mainMenuItems)
            {
                if (item.Item2 == false)
                {
                    string message = $"[{item.Item1}] - [{item.Item3}]";
                    WriteColor(message,ConsoleColor.DarkGray);
                }
                else
                {
                    Console.WriteLine("{0} - {1}", item.Item1, item.Item3);
                }
            }

        }



        // https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net
        // https://stackoverflow.com/a/60492990
        static void WriteColor(string message, ConsoleColor color)
        {
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }
        //
        //
    }
}
