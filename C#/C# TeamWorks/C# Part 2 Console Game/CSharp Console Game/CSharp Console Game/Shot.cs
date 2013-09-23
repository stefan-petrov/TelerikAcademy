using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Shot
    {
        public static List<List<int>> shots = new List<List<int>>();

        private int posX;
        private int posY;
        private int direction;

        public Shot(Ship player)
        {
            this.posX = player.XPos;
            this.posY = player.YPos;
            this.direction = player.shipDirection;
            List<int> shot = new List<int>();
            shot.Add(this.posX);
            shot.Add(this.posY);
            shot.Add(this.direction);
            shots.Add(shot);
        }

        public static void MoveBullets()
        {
            for (int i = 0; i < shots.Count; i++)
            {
                Engine.PrintOnConsole(shots[i][0], shots[i][1], ' ');
                if (shots[i][2] == 0)
                {
                    shots[i][0]--;
                    Engine.PrintOnConsole(shots[i][0], shots[i][1], '-');
                }
                else if (shots[i][2] == 1)
                {
                    shots[i][0]++;
                    Engine.PrintOnConsole(shots[i][0], shots[i][1], '-');
                }
                else if (shots[i][2] == 2)
                {
                    shots[i][1]--;
                    Engine.PrintOnConsole(shots[i][0], shots[i][1], '|');
                }
                else if (shots[i][2] == 3)
                {
                    shots[i][1]++;
                    Engine.PrintOnConsole(shots[i][0], shots[i][1], '|');
                }
            }
        }

        public static void DeleteBullet(int bullet)
        {
            Engine.PrintOnConsole(shots[bullet][0], shots[bullet][1], ' ');
            shots.RemoveAt(bullet);
        }

        public static void CollisionEnemy()
        {
            for (int i = 0; i < Enemy.enemies.Count; i++)
            {
                for (int j = 0; j < shots.Count; j++)
                {
                    if (Enemy.enemies[i][0] == shots[j][0] && Enemy.enemies[i][1] == shots[j][1])
                    {
                        Console.Beep(160, 80);
                        Enemy.DeleteEnemy(i);
                        DeleteBullet(j);
                        break;
                    }
                }
            }
        }

        public static void CollisionWall()
        {
            for (int i = 0; i < shots.Count; i++)
            {
                //the original symbols from the file are used
                if (Labyrinth.labyrinth[shots[i][1], shots[i][0]] == 'w')
                {
                    int X = shots[i][0];
                    int Y = shots[i][1];
                    DeleteBullet(i);
                    Engine.PrintOnConsole(X, Y, '\u2588');

                }
                else if (Labyrinth.labyrinth[shots[i][1], shots[i][0]] == '#')
                {
                    Console.Beep(160, 80);
                    Engine.PrintOnConsole(shots[i][0], shots[i][1], ' ');
                    Labyrinth.ChangeChar(shots[i][1], shots[i][0], ' ');
                    DeleteBullet(i);
                }
            }
        }
    }
}
