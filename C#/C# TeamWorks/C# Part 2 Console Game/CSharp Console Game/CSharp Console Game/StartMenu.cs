using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class StartMenu
    {
        bool notSelected = true;
        int cursorPositionLeft;
        int cursorPositionTop;
        int difficultyLevel = 1;   // value for difficulty by default

        public static string[] startMenu = new string[]{
            @"",
            @"",
            @"",
            @"                        ____ ____  ____    _____   _________",
            @"                        |  | |  |  |  |   /   __| |__    __|",
            @"                        |  | |  |  |  |   |  (       |  |",
            @"                        |  | |  |  |  |    \  \      |  |",
            @"                    __ /  /  \   \/   /  ___)  |     |  |",
            @"                   |____/     \______/  |______/     |__|",
            @"                                                                            ",
            @"                          Start Game",
            @"                          Set Difficulty",            
            @"                          Help",
            @"                          Quit",
            @"",
            @"                                                                            ",
            @"  ___         ___     ._____  ___    ___  ______    __   ____   ___  ________",
            @" |  |        /   \    |     \ \  \  /  / |   _  \  |__| |    \ |  | |__    __|",
            @" |  |       /  ^  \   |  |>  | \  \/  /  |  |_)  |  __  |  \  \|  |    |  |",
            @" |  |      /  /_\  \  |     /   \    /   |      /  |  | |  |\  \  |    |  |",
            @" |  |___  /  _____  \ |  |>  \   /  /    |  |\  \  |  | |  | \    |    |  |",
            @" |______|/__/     \__\|______/  /__/     |__| \__\ |__| |__|  \__ |    |__|", 
        };

        public static string[] difficultyMenu = new string[]{
            @"",
            @"",
            @"",
            @"                        ____ ____  ____    _____   _________",
            @"                        |  | |  |  |  |   /   __| |__    __|",
            @"                        |  | |  |  |  |   |  (       |  |",
            @"                        |  | |  |  |  |    \  \      |  |",
            @"                    __ /  /  \   \/   /  ___)  |     |  |",
            @"                   |____/     \______/  |______/     |__|",
            @"                                                                            ",
            @"                          Easy",
            @"                          Medium",
            @"                          Hard",
            @"                          Hell",
            @"                                                                            ",
            @"  ___         ___     ._____  ___    ___  ______    __   ____   ___  ________",
            @" |  |        /   \    |     \ \  \  /  / |   _  \  |__| |    \ |  | |__    __|",
            @" |  |       /  ^  \   |  |>  | \  \/  /  |  |_)  |  __  |  \  \|  |    |  |",
            @" |  |      /  /_\  \  |     /   \    /   |      /  |  | |  |\  \  |    |  |",
            @" |  |___  /  _____  \ |  |>  \   /  /    |  |\  \  |  | |  | \    |    |  |",
            @" |______|/__/     \__\|______/  /__/     |__| \__\ |__| |__|  \__ |    |__|", 
        };

        public void Animate()
        {
            for (int i = 0; i < StartMenu.startMenu.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.WriteLine(StartMenu.startMenu[StartMenu.startMenu.Length - 1 - j]);
                }

                Thread.Sleep(100);
                if (i != StartMenu.startMenu.Length - 1)
                {
                    Console.Clear();
                }
            }
        }

        public static void PrintMenu()
        {
            for (int i = 0; i < StartMenu.startMenu.Length; i++)
            {
                Console.WriteLine(StartMenu.startMenu[i]);
            }
        }

        public void SelectTask()
        {
            cursorPositionLeft = 23;
            cursorPositionTop = 10;


            while (notSelected)
            {
                Console.Clear();
                
                StartMenu.PrintMenu();
                Console.SetCursorPosition(cursorPositionLeft, cursorPositionTop);
                Console.Write('>');
                Thread.Sleep(100);

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (cursorPositionTop + 1 <= 13)
                        {
                            cursorPositionTop++;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (cursorPositionTop - 1 >= 10)
                        {
                            cursorPositionTop--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {                      
                        if (cursorPositionTop == 10)
                        {                   
                            notSelected = false;
                            GameData.ChangeDifficulty(difficultyLevel); 
                        }
                        else if (cursorPositionTop == 11)
                        {                         
                            cursorPositionLeft = 23;
                            cursorPositionTop = 10;

                            while (notSelected)
                            {
                                Console.Clear();

                                for (int i = 0; i < StartMenu.difficultyMenu.Length; i++)
                                {
                                    Console.WriteLine(StartMenu.difficultyMenu[i]);
                                }

                                Console.SetCursorPosition(cursorPositionLeft, cursorPositionTop);
                                Console.Write('>');
                                Thread.Sleep(100);

                                while (Console.KeyAvailable)
                                {
                                    ConsoleKeyInfo anotherPressedKey = Console.ReadKey();
                                    if (anotherPressedKey.Key == ConsoleKey.DownArrow)
                                    {
                                        if (cursorPositionTop + 1 <= 13)
                                        {
                                            cursorPositionTop++;
                                        }
                                    }
                                    else if (anotherPressedKey.Key == ConsoleKey.UpArrow)
                                    {
                                        if (cursorPositionTop - 1 >= 10)
                                        {
                                            cursorPositionTop--;
                                        }
                                    }
                                    else if (pressedKey.Key == ConsoleKey.Enter)
                                    {
                                        notSelected = false;
                                        if (cursorPositionTop == 10)
                                        {
                                            GameData.ChangeDifficulty(1);
                                        }
                                        else if (cursorPositionTop == 11)
                                        {
                                            GameData.ChangeDifficulty(2);
                                        }
                                        else if (cursorPositionTop == 12)
                                        {
                                            GameData.ChangeDifficulty(3);
                                        }
                                        else if (cursorPositionTop == 13)
                                        {
                                            GameData.ChangeDifficulty(4);
                                        }
                                    }
                                }
                            }
                        }

                        else if (cursorPositionTop == 12)
                        {
                            Console.Clear();
                            Engine.PrintStringOnConsole(8, 1, "You are a captain of a space ship. You got caught");
                            Engine.PrintStringOnConsole(8, 2, "in a labyrinth with a lot of enemies. Your mission");
                            Engine.PrintStringOnConsole(8, 3, "is to reach the exit (*), while killing as much ");
                            Engine.PrintStringOnConsole(8, 4, "enemies as you can. Some of the walls can be  ");
                            Engine.PrintStringOnConsole(8, 5, "destroyed by your weapon. If you touch an enemy");
                            Engine.PrintStringOnConsole(8, 6, "it kills you. ");
                            Engine.PrintStringOnConsole(8, 8, "Controls:");
                            Engine.PrintStringOnConsole(8, 9, "Navigate ship with arrow keys");
                            Engine.PrintStringOnConsole(8, 10, "Shoot with spacebar");
                            Engine.PrintStringOnConsole(8, 12, "Back",ConsoleColor.Red);
                            Console.ReadKey();
                        }
                            
                        else if (cursorPositionTop == 13)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}
