using DiceGame.Application;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace DiceGame
{
    internal class Menu
    {

        string message;
        bool defaultSet = false;
        ConsoleColor defaultForegroundColour;
        ConsoleColor defaultBackgroundColour;

        public void Start(int directMenu = 0)
        {
            WriteColor(true, ConsoleColor.White, ConsoleColor.Black);

            switch (directMenu)
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
                Tuple.Create(4, true, "About"),
            };

            Console.Clear();
            Thread.Sleep(250);
            Console.WriteLine("  __  __       _         __  __                  \r\n |  \\/  |     (_)       |  \\/  |                 \r\n | \\  / | __ _ _ _ __   | \\  / | ___ _ __  _   _ \r\n | |\\/| |/ _` | | '_ \\  | |\\/| |/ _ \\ '_ \\| | | |\r\n | |  | | (_| | | | | | | |  | |  __/ | | | |_| |\r\n |_|  |_|\\__,_|_|_| |_| |_|  |_|\\___|_| |_|\\__,_|\r\n                                                 \r\n                                                 ");
            Console.WriteLine("Please select a number from the list:\n");
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
                case 4:
                    Thread.Sleep(100);
                    AboutMenu();
                    break;
            }

        }

        public void OptionsMenu()
        {

            var optionsMenuItems = new List<Tuple<int, bool, string>>
            {
                // Menu options || int itemNumber, bool isAvailable, string itemText ||
                Tuple.Create(0, true, "Main Menu"),
                Tuple.Create(1, false, "Colour"),
                Tuple.Create(2, false, "Time"),
                Tuple.Create(3, false, "Profile"),
                Tuple.Create(4 ,false, "Language"),
            };

            Console.Clear();
            Console.WriteLine("   ____        _   _                 \r\n  / __ \\      | | (_)                \r\n | |  | |_ __ | |_ _  ___  _ __  ___ \r\n | |  | | '_ \\| __| |/ _ \\| '_ \\/ __|\r\n | |__| | |_) | |_| | (_) | | | \\__ \\\r\n  \\____/| .__/ \\__|_|\\___/|_| |_|___/\r\n        | |                          \r\n        |_|                          ");
            Console.WriteLine("\nPlease select a number from the list:\n");
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

            var optionsColourMenuItems = new List<Tuple<int, string, string>>
            {
                // Menu options || int itemNumber, string itemText, string colorCode ||
                Tuple.Create(0, "Black", "Black"),
                Tuple.Create(1, "Dark Blue", "DarkBlue"),
                Tuple.Create(2, "Dark Green", "DarkGreen"),
                Tuple.Create(3, "Dark Cyan", "DarkCyan"),
                Tuple.Create(4, "Dark Red", "DarkRed"),
                Tuple.Create(5, "Dark Magenta", "DarkMagenta"),
                Tuple.Create(6, "Dark Yellow", "DarkYellow"),
                Tuple.Create(7, "Gray", "Gray"),
                Tuple.Create(8, "Dark Gray", "DarkGray"),
                Tuple.Create(9, "Blue", "Blue"),
                Tuple.Create(10, "Green", "Green"),
                Tuple.Create(11, "Cyan", "Cyan"),
                Tuple.Create(12, "Red", "Red"),
                Tuple.Create(13, "Magenta", "Magenta"),
                Tuple.Create(14, "Yellow", "Yellow"),
                Tuple.Create(15, "White", "White"),
            };

            Console.Clear();
            Console.WriteLine("Options\\Colours\n");
            Console.WriteLine("Please select a number from the list:");
            foreach (var item in optionsColourMenuItems)
            {
                message = $"{item.Item1} - [{item.Item2}]";
                ConsoleColor colour = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.Item3, true);
                WriteColor(message, (ConsoleColor)colour);

            }
            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            foreach (var item in optionsColourMenuItems)
            {
                if (item.Item1 == userChoice) { 
                    ConsoleColor colour1 = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.Item3, true);
                    WriteColor("Set Default",colour1);
                }

                switch (userChoice)
                {
                    case 0:
                        Thread.Sleep(100);
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
            //NotImplemented();
            Thread.Sleep(1000);
            Console.Clear();

            string[] aboutMenuText = {
                "DiceGame V2 Dev Branch 12/08/23",
                "   _____ __ __________ ___ ____ \r\n  / ___// /|__  /__  // (_) __ \\\r\n  \\__ \\/ __//_ < /_ </ / / / / /\r\n ___/ / /____/ /__/ / / / /_/ / \r\n/____/\\__/____/____/_/_/\\____/  \r\n\n",
                "           __   __   __      __  ___  ___  ___      \r\n   |  /\\  /  ` /  \\ |__)    /__`  |  |__  |__  |    \r\n\\__/ /~~\\ \\__, \\__/ |__)    .__/  |  |___ |___ |___ \r\n\n",
                "\n\n\n",
                "Welcome! This piece of code was a project started during my Software Development course and is considered my first 'finished' script. Please enjoy.\r\nPlease also report any found bugs and give suggestions in the issues tab.\r\n\r\nThis branch of DiceGame is specifically for source control of development of version 2 of DiceGame.\r\nHow many times do I want to say of haha",
                "\n\n",
                "Thanks for checking this out, it means a lot to me!"
            };
            int count = 0;

            foreach (string line in aboutMenuText)
            {
                switch(count){
                    case > 3:
                        Console.WriteLine(line); 
                        break;
                    case < 3:
                        Console.WriteLine(line); 
                        break;

                }
                count++;
            }
            Console.ReadLine();
            MainMenu();

        }

        private void NotImplemented()
        {
            Console.WriteLine("Not implemented yet");
            Thread.Sleep(2000);
            MainMenu();
        }


        // https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net
        // https://stackoverflow.com/a/60492990
        static void WriteColor(string message, ConsoleColor foregroundColour = ConsoleColor.White, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            ColorConverter conv = new ColorConverter();



            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    if (foregroundColour ==  backgroundColour)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = foregroundColour;
                        Console.BackgroundColor = backgroundColour;
                    }
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        public void WriteColor(bool setDefault,ConsoleColor foreGroundColour = ConsoleColor.White, ConsoleColor backGroundColour = ConsoleColor.Black)
            {
                defaultForegroundColour = foreGroundColour;
                defaultBackgroundColour = backGroundColour;
            }

        internal void SetWriteColor(bool v, ConsoleColor green)
        {
            throw new NotImplementedException();
        }
        //
        //
    }
}
