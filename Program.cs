//Dice Game

using DiceGame;
using System.Numerics;
using System.Xml.Serialization;

Menu menu = new Menu();
menu.SetWriteColor(true, ConsoleColor.Green); // Sets default text colour to green, leaves background as black.
menu.Start(0); // Starts menu with the number relating to what menu to start