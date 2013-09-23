using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Enemy
    {
        static char[] icons = { '\u0001', '\u0002' };
        public static List<List<int>> enemies = new List<List<int>>();
        private int positionX;
        private int positionY;
        private char enemyIcon;

        public Enemy(int posX, int posY, char icon)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.enemyIcon = icon;
        }

        public static void MoveEnemy()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Engine.PrintOnConsole(enemies[i][0], enemies[i][1], ' ');
                int[] change = GetRandomDirection(enemies[i][0], enemies[i][1]);
                enemies[i][0] += change[0];
                enemies[i][1] += change[1];
                Engine.PrintOnConsole(enemies[i][0], enemies[i][1], (char)(enemies[i][2]));
            }
        }

        static int[] GetRandomDirection(int posX, int posY)
        {
            int xChange = Engine.rnd.Next(3) - 1;
            int yChange = Engine.rnd.Next(3) - 1;
            while (Labyrinth.labyrinth[posY + yChange, posX + xChange] != ' ')
            {
                xChange = Engine.rnd.Next(3) - 1;
                yChange = Engine.rnd.Next(3) - 1;
            }
            int[] ofset = { xChange, yChange };
            return ofset;
        }

        public static void GenerateNewEnemy(int enemyGeneratedCount)
        {
            for (int i = 0; i < enemyGeneratedCount; i++)
            {
                List<int> enmy = GetRandomPosition();
                char icon = GetRandomIcon();
                enmy.Add((int)(icon));
                enemies.Add(enmy);
                Enemy bad = new Enemy(enmy[0], enmy[1], icon);
                Engine.PrintOnConsole(enmy[0], enmy[1], icon);
            }  
        }

        static List<int> GetRandomPosition()
        {
            List<int> xy;
            int posX = Engine.rnd.Next(51);
            int posY = Engine.rnd.Next(14);
            while (Labyrinth.labyrinth[posY, posX] != ' ')
            {
                posX = Engine.rnd.Next(51);
                posY = Engine.rnd.Next(14);
            }
            xy = new List<int> { posX, posY };
            return xy;
        }

        static char GetRandomIcon()
        {
            int symbol = Engine.rnd.Next(icons.Length);
            return icons[symbol];
        }

        public static void CollisionEnemyPlayer(Ship player)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (player.XPos == enemies[i][0] && player.YPos == enemies[i][1])
                {
                    Engine.PrintOnConsole(player.XPos, player.YPos, 'X', ConsoleColor.Red);
                    Console.Beep(1200, 150);                   
                    player.XPos = 1;
                    player.YPos = 1;
                    GameData.playerLives--;
                }
            }
        }

        public static void DeleteEnemy(int enemy)
        {
            enemies.RemoveAt(enemy);
            
            //add points to score
            GameData.score += 5 * (GameData.gameDifficulty * 3);
        }
    }
}

