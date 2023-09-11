using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DiceGame.Application
{

    public class Compute
    {
        public int dChoice = 0;
        public string ans = "";
        string[] faceSearch = { "6", "d6", "six", "4", "d4", "four", "8", "d8", "eight", "12", "d12", "twelve", "20", "d20", "twenty" };
        string[] d4 = { "D4", "d4", "4", "four" };
        string[] d6 = { "D6", "d6", "6", "six" };
        string[] d8 = { "D8", "d8", "8", "six" };
        string[] d12 = { "D12", "d12", "12", "twelve" };
        string[] d20 = { "D20", "d20", "20", "twenty" };
        string[] faces = { "D4", "D6", "D8", "D12", "D20" };
        string[] answers = { "y", "yes", "n", "no" };
        Random rand = new();
        string picked = "null";
        public int output = 0;

        

        public void answer()
        {
            int j = 0;
            ans = Console.ReadLine().ToLower();
            for (int i = 0; ans != answers[i]; i++) { j = i+1; }
            ans = (j < 2) ? "y" : "n";
            ans = ans.ToLower();
        }

        public void choice()
        {//Allows user to pick what dice they would like to roll and outputs the integer value of faces as "dChoice" as a public variable
            Console.Clear();
            Console.WriteLine("Which Dice would you like to roll?");
            Console.WriteLine();
            foreach (string face in faces)
            {
                Console.Write($"| {face} |");
            }
            Console.WriteLine();
            picked = Console.ReadLine();
            picked = picked.ToLower();
            Console.WriteLine();

            foreach (string result in faceSearch)
            {
                if (result == picked)
                {
                    foreach (string dice in d4)
                    {
                        if (dice == picked)
                        {
                            Console.WriteLine($"You have chosen the {d4[0]}, what a wonderful choice!"); // Add method with arrays for different things to say as args to call elsewhere
                            dChoice = Convert.ToInt32(d4[2]);
                        }
                    }
                    foreach (string dice in d6)
                    {
                        if (dice == picked)
                        {
                            Console.WriteLine($"You have chosen the {d6[0]}, what a wonderful choice!"); // Add method with arrays for different things to say as args to call elsewhere
                            dChoice = Convert.ToInt32(d6[2]);
                        }
                    }
                    foreach (string dice in d8)
                    {
                        if (dice == picked)
                        {
                            Console.WriteLine($"You have chosen the {d8[0]}, what a wonderful choice!"); // Add method with arrays for different things to say as args to call elsewhere
                            dChoice = Convert.ToInt32(d8[2]);
                        }
                    }
                    foreach (string dice in d12)
                    {
                        if (dice == picked)
                        {
                            Console.WriteLine($"You have chosen the {d12[0]}, what a wonderful choice!"); // Add method with arrays for different things to say as args to call elsewhere
                            dChoice = Convert.ToInt32(d12[2]);
                        }
                    }
                    foreach (string dice in d20)
                    {
                        if (dice == picked)
                        {
                            Console.WriteLine($"You have chosen the {d20[0]}, what a wonderful choice!"); // Add method with arrays for different things to say as args to call elsewhere
                            dChoice = Convert.ToInt32(d20[2]);
                        }
                    }
                }
            }
            if (dChoice != 0)
            {
                roll();
            }
            else
            {
                Console.WriteLine("Program failed to provide valid input, please try again");
                Console.WriteLine();
                choice();
            }
        }
        public void roll()
        {
            int randOper = dChoice + 1;
            Console.WriteLine();
            Console.WriteLine();
            do 
            {
                output = rand.Next(1, randOper);
            } while (output > randOper);
            Console.WriteLine($"You have rolled a {output}");
            reroll();
        }

        public void reroll()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to roll the same dice?");
            answer();
            if(ans == "y")
            {
                roll();
            }
            else if (ans == "n")
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to roll a different dice?");
                answer();
                if (ans == "y") 
                {
                    choice();
                }
                else 
                { 
                    Console.WriteLine("Have a wonderful day!"); 
                } 
            }
            
        }
        
        public void play()
        {
            choice();
        }

    }
    
}

