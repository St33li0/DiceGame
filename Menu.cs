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

        string message;

        public void Start(int directMenu = 0)
        {
            switch(directMenu)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    RollDiceMenu();
                    break; 
                case 2:
                    GamesMenu();
                    break; 
                case 3:
                    OptionsMenu();
                    break;
            }
        }

        public void MainMenu() // Menu 0
        {

            var mainMenuItems = new List<Tuple<int, bool, string>>
            {
                // Menu options || int itemNumber, bool isAvailable, string itemText ||
                Tuple.Create(0, true, "Main Menu"),
                Tuple.Create(1, true, "Roll Dice"),
                Tuple.Create(2, false, "Games"),
                Tuple.Create(3, true, "Options"),
            };

            Console.Clear();
            Thread.Sleep(250);
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("Please select a number from the list:");
            foreach (var item in mainMenuItems)
            {
                switch (item.Item2)
                {
                    case false:
                        message = $"[{item.Item1}] - [{item.Item3}]";
                        break;
                    case true:
                        message = $"{item.Item1} - {item.Item3}";
                        break;
                }
                WriteColor(message, ConsoleColor.DarkGray);
            }

            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 0:
                    Thread.Sleep(100);
                    MainMenu();
                    break;
                case 1:
                    Thread.Sleep(100);
                    RollDiceMenu();
                    break;
                case 2:
                    Thread.Sleep(100);
                    GamesMenu();
                    break;
                case 3:
                    Thread.Sleep(100);
                    OptionsMenu();
                    break;

            }

        }

        public void OptionsMenu()
        {

            var optionsMenuItems = new List<Tuple<int, bool, string>>
            {
                // Menu options || int itemNumber, bool isAvailable, string itemText ||
                Tuple.Create(0, true, "MainMenu"),
                Tuple.Create(1, false, "Colour"),
                Tuple.Create(2, false, "Time"),
                Tuple.Create(3, false, "Profile"),
                Tuple.Create(4 ,false, "Language"),
            };

            Console.Clear();
            Console.WriteLine("Options\n");
            Console.WriteLine("Please select a number from the list:");
            foreach (var item in optionsMenuItems)
            {
                switch (item.Item2)
                {
                    case false:
                        message = $"[{item.Item1}] - [{item.Item3}]";
                        break;
                    case true:
                        message = $"{item.Item1} - {item.Item3}";
                        break;
                }
                WriteColor(message, ConsoleColor.DarkGray);

            }
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 0:
                    Thread.Sleep(100);
                    MainMenu();
                    break;
                case 1:
                    Thread.Sleep(100);
                    OptionsColour();
                    break;
                case 2:
                    Thread.Sleep(100);
                    OptionsTime();
                    break;
                case 3:
                    Thread.Sleep(100);
                    OptionsProfile();
                    break;
                case 4:
                    Thread.Sleep(100);
                    OptionsLanguage();
                    break;
                case 5:
                    Thread.Sleep(100);
                    HelpMenu();
                    break;
                case 6:
                    Thread.Sleep(100);
                    AboutMenu();
                    break;
            }
        }

        public void RollDiceMenu()
        {
            // Menu for selecting dice and displaying output
            //NotImplemented();
            Compute compute = new Compute();
            compute.play();
            Thread.Sleep(3000);
            MainMenu();
            // Temporary implementation of old code
            // Rewrite
        }

        public void OptionsColour()
        {
            // Change default colours for foreground and background
            NotImplemented();
        }

        public void OptionsTime()
        {
            // Change time intervals between menus and typed characters
            NotImplemented();
        }

        public void OptionsProfile()
        {
            // Edit profile options, add, change, remove, user and pass?, encrypted? user file
            NotImplemented();
        }

        public void OptionsLanguage()
        {
            // Pick language || Not planned for now ||
            NotImplemented();
        }

        

        public void GamesMenu()
        {
            // Menu for displaying games available for play
            NotImplemented();
        }

        public void HelpMenu()
        {
            // Menu for displaying help about application
            // Make custom commands to display here
            NotImplemented();
        }

        public void AboutMenu()
        {
            // Just opens readme?
            // Maybe a bit of spiel about me or something idk
            NotImplemented();
        }

        public void NotImplemented()
        {
            Console.WriteLine("Not implemented yet");
            Thread.Sleep(2000);
            MainMenu();
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
