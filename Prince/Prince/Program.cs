using System;

namespace Prince
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 1");
            Console.ReadKey();

            Console.WriteLine("Welcome young sir, your adventure is about to start.");
            Console.ReadKey();

            Console.Write("Please [Enter Name] to get started.");
            string childName = Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Hello Prince {0}! Today is the day you have been waiting for!", childName);
            Console.ReadKey();

            Console.WriteLine("Your new Dragon Adventure awaits.");
            Console.ReadKey();

            Console.WriteLine("First, Prince {0}, you must choose your dragon.", childName);
            Console.ReadKey();

            //Three dragons appear.
            Console.WriteLine("The first Dragon is the Red Fire Dragon.");
            Console.ReadKey();

            Console.WriteLine("The Second Dragon is the Blue Water Dragon.");
            Console.ReadKey();

            Console.WriteLine("The Third Dragon is the Yellow Sun Dragon.");
            Console.ReadKey();

            Console.WriteLine("Please choose your dragon.");
            Console.ReadKey();

            Console.Write("Enter dragon name here:[Enter Name]");
            string dragonName = Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Prince {0}, you have chosen {1}, an excellent choice!", childName, dragonName);
            Console.ReadKey();

            Console.WriteLine("Prince {0} before you start on your adventure, you need to choose a path.", childName);
            Console.ReadKey();

            Console.WriteLine("Each path will take you on a different adventure.", childName);
            Console.ReadKey();

            Console.WriteLine("There are three different paths to choose from.");
            Console.ReadKey();

            Console.WriteLine("Please choose your path wisely.");
            Console.ReadKey();

            Console.Write("Please enter your path number:[Enter Number]");
            string pathNumber = Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Prince {0}, you have chosen Path {1}.", childName, pathNumber);
            Console.ReadKey();

            Console.WriteLine("Prince {0}, your new adventure awaits.", childName);
            Console.ReadKey();

            Console.WriteLine("Chapter 2");
            Console.ReadKey();

            Console.WriteLine("Prince {0} you are walking down your path and you hear loud foot steps behind you!", childName);
            Console.ReadKey();

            Console.WriteLine("Oh no! There is a troll behind you. What do you do?");
            Console.ReadKey();

            Console.WriteLine("Ask the troll his name.");
            Console.ReadKey();

            Console.WriteLine("Prince {0}: What is your name troll?", childName);
            Console.ReadKey();

            Console.WriteLine("The troll said his name is [Enter Name]");
            string trollName = Console.ReadLine();
            Console.ReadKey();

            Troll storyTroll = new Troll(trollName, 100, "blue");
            int Strength = storyTroll._strength;
            storyTroll._strength = 100;
            storyTroll._color = "blue";

            Console.WriteLine("{0} I am here to take over the town!", trollName);
            Console.ReadKey();

            Console.WriteLine("I have the strength of {0} and I am the color {1}.", storyTroll._strength, storyTroll._color);
            Console.ReadKey();

            Console.WriteLine("I am Prince {0}, and I am here to stop you.", childName);
            Console.ReadKey();

            Console.WriteLine("{0}: You cannot stop me. I have the help of my son.", trollName);
            Console.ReadKey();

            Console.Write("And my son will help me take over your town. My son's name is [Enter Name].");
            string tName = Console.ReadLine();

            babyTroll btroll = new babyTroll(tName, 10, "yellow", 25);
            Console.ReadKey();
        }
    }
}
