using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class GameOver
    {
        public static string[] gameOverArr = new string[]{
            @"",
            @"",
            @"                     _____          ___       ___      ___  _______",
            @"                    /  ___\        /   \     |   \    /   | |  ____|",
            @"                   /  /  ____     /  ^  \    |    \  /    | |  |__",
            @"                  |  |  |   _|   /  /_\  \   |     \/     | |  ___|",
            @"                   \  \_/  /    /  _____  \  |  |\    /|  | |  |___",
            @"                    \_____/    /__/     \__\ |__| \__/ |__| |______|",
            @"                                                                            ",
            @"                     _____   ___      ___  _______   ______  ",
            @"                    /  _  \  \  \    /  /  |  ____| |   _  \ ",
            @"                   /  / \  \  \  \  /  /   |  |__   |  |_)  |",
            @"                  |  |   |  |  \  \/  /    |  ___|  |      / ",
            @"                   \  \_/  /    \    /     |  |___  |  |\  \ ",
            @"                    \_____/      \__/      |______| |__| \__\",
            @"",
            @"",
            };

        public static string[] gameWonArr = new string[]{
            @"",
            @"",
            @"                       ___    ___    _____    ____  ____",
            @"                       \  \  /  /   /  _  \   |  |  |  |",
            @"                        \  \/  /   /  / \  \  |  |  |  |",
            @"                         \    /   |  |   |  | |  |  |  |",
            @"                          /  /     \  \_/  /  \   \/   /",
            @"                         /__/       \_____/    \______/ ",
            @"",
            @"                      ___            ___   _____    ____   ___",
            @"                      \  \    /\    /  /  /  _  \  |    \ |  |",
            @"                       \  \  /  \  /  /  /  / \  \ |  \  \|  |",
            @"                        \  \/    \/  /  |  |   |  ||  |\  \  |",
            @"                         \    /\    /    \  \_/  / |  | \    |",
            @"                          \__/  \__/      \_____/  |__|  \__ |",
            @"",
            @"",
            };

        public static void PrintGameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < GameOver.gameOverArr.Length; i++)
            {
                Console.WriteLine(gameOverArr[i]);
            }
            Console.WriteLine("                                 Your Score is {0}", GameData.score);
            Thread.Sleep(3000);
            Console.ResetColor();
        }

        public static void PrintGameWon()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < gameWonArr.Length; i++)
            {
                Console.WriteLine(gameWonArr[i]);
            }
            Console.WriteLine("                                 Your Score is {0}", GameData.score);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("                       Press ENTER to continue to next level");
            Console.ResetColor();
        }
    } 
}
