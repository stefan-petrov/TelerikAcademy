using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class GameData
    {
        public static int playerLives;
        public static int score;               
        public static int gameDifficulty;

        public static void ChangeDifficulty(int difficultyLevel)
        {
            if (difficultyLevel == 1)
            {
                GameData.playerLives = 4;
                Timer.secondsLeft = 45;
                GameData.gameDifficulty = difficultyLevel;
            }
            else if (difficultyLevel == 2)
            {
                GameData.playerLives = 3;
                Timer.secondsLeft = 35;
                GameData.gameDifficulty = difficultyLevel;
            }
            else if (difficultyLevel == 3)
            {
                GameData.playerLives = 2;
                Timer.secondsLeft = 25;
                GameData.gameDifficulty = difficultyLevel;
            }
            else if (difficultyLevel == 4)
            {
                GameData.playerLives = 1;
                Timer.secondsLeft = 15;
                GameData.gameDifficulty = difficultyLevel;
            }
        }      

        public static void PrintScore()
        {
            Engine.PrintStringOnConsole(Engine.gameInfoX, Engine.gameInfoY, "Score: "+ GameData.score, ConsoleColor.Red);   
        }

        public static void PrintLives()
        {
            Engine.PrintStringOnConsole(Engine.gameInfoX, Engine.gameInfoY + 4, "Lives: " + GameData.playerLives, ConsoleColor.Red);
        }

        public static void PrintDifficulty()
        {
            Engine.PrintStringOnConsole(Engine.gameInfoX, Engine.gameInfoY + 6, 
                "Difficulty: " + (GameData.gameDifficulty == 1 ? "Easy" : 
                                  GameData.gameDifficulty == 2 ? "Medium" : 
                                  GameData.gameDifficulty == 3 ? "Hard" : "Hell"), ConsoleColor.Red);
        }
    }
}
