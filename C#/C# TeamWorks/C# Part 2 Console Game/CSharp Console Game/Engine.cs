using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Engine
    {
        //centers the playfield in console
        public static int fieldOffsetX = 8;
        public static int fieldOffsetY = 7;

        //sets the size of field
        public static int fieldSizeX = 51;
        public static int fieldSizeY = 14;

        //sets the coordinates of upper left corner of scoreboard
        public static int gameInfoX = 53;
        public static int gameInfoY = 2;

        //enemies left from previous level
        static int enemiesLeft = 0;

        private static bool isGameOver = false;
        private static bool isGameWon = false;

        //sets the coordinates of endpoint
        private static int endPointX;
        private static int endPointY;

        //resolves conflicts between threads
        private static object flag;

        static Ship userShip;
        static Timer timer;

        //random labyrinth number
        public static int randomLabyrinthNum;

        public static Random rnd = new Random();

        public static void PrintOnConsole(int posX, int posY, char character, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(posX + fieldOffsetX, posY + fieldOffsetY);
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ResetColor();
        }

        public static void PrintStringOnConsole(int posX, int posY, string line, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(posX + fieldOffsetX, posY + fieldOffsetY);
            Console.ForegroundColor = color;
            Console.WriteLine(line);
            Console.ResetColor();
        }

        public static void ShipMoveShoot(Ship player)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (player.XPos - 1 >= 0 && Labyrinth.labyrinth[player.YPos, player.XPos - 1] == ' ')
                    {
                        Engine.PrintOnConsole(player.XPos, player.YPos, ' ');
                        player.XPos = player.XPos - 1;
                        player.shipDirection = 0;
                    }
                    else 
                    {
                        player.shipDirection = 0;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (player.XPos + 1 < Console.WindowWidth && Labyrinth.labyrinth[player.YPos, player.XPos + 1] == ' ')
                    {
                        Engine.PrintOnConsole(player.XPos, player.YPos, ' ');
                        player.XPos = player.XPos + 1;
                        player.shipDirection = 1;
                    }
                    else
                    {
                        player.shipDirection = 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (player.YPos - 1 >= 0 && Labyrinth.labyrinth[player.YPos - 1, player.XPos] == ' ')
                    {
                        Engine.PrintOnConsole(player.XPos, player.YPos, ' ');
                        player.YPos = player.YPos - 1;
                        player.shipDirection = 2;
                    }
                    else
                    {
                        player.shipDirection = 2;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (player.YPos + 1 < Console.WindowHeight && Labyrinth.labyrinth[player.YPos + 1, player.XPos] == ' ')
                    {
                        Engine.PrintOnConsole(player.XPos, player.YPos, ' ');
                        player.YPos = player.YPos + 1;
                        player.shipDirection = 3;
                    }
                    else 
                    {
                        player.shipDirection = 3;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    Shot shooting = new Shot(player);
                    Console.Beep(240, 100);
                }
            }
        }

        public static void InitializeGame()
        {
            userShip = new Ship(1, 1);

            endPointX = 44;
            endPointY = 1;

            Labyrinth.labyrinth = new char[fieldSizeY, fieldSizeX];
            randomLabyrinthNum = rnd.Next(1, 12);

            flag = new object();

            Engine.PrintStringOnConsole(gameInfoX, gameInfoY + 2, "Time left: ", ConsoleColor.Red);
            timer = new Timer(gameInfoX + "Time left: ".Length, gameInfoY + 2);

            isGameOver = false;
            isGameWon = false;

            Labyrinth.ReadLabyrinth();
            Labyrinth.PrintLabyrinth();

            Enemy.GenerateNewEnemy((GameData.gameDifficulty * 3) + enemiesLeft);
        }

        public static void ShootAndMove()
        {
            while (!isGameOver)
            {
                lock (flag)
                {
                    if (!isGameOver)
                    {
                        userShip.PrintShip();
                        //prints the labyrinth exit
                        PrintOnConsole(endPointX, endPointY, '*', ConsoleColor.Yellow);
                        Engine.ShipMoveShoot(userShip);

                        GameData.PrintScore();
                        GameData.PrintLives();
                        GameData.PrintDifficulty();

                        Enemy.CollisionEnemyPlayer(userShip);
                        Shot.MoveBullets();
                        Shot.CollisionEnemy();
                        Shot.CollisionWall();

                        if (userShip.XPos == endPointX && userShip.YPos == endPointY)
                        {
                            PrintOnConsole(endPointX, endPointY, '\u000F', ConsoleColor.Red);
                            isGameWon = true;
                            isGameOver = true;
                            break;
                        }
                        if (GameData.playerLives <= 0)
                        {
                            isGameOver = true;
                            break;
                        }
                    }
                    Monitor.Pulse(flag);
                }
            }
        }

        public static void MoveEnenmiesAndTimer()
        {
            while (!isGameOver)
            {
                lock (flag)
                {
                    if (!isGameOver)
                    {
                        Enemy.MoveEnemy();
                        Timer.PrintTimer(timer);
                        Timer.secondsLeft--;
                        if (Timer.secondsLeft == 0)
                        {
                            isGameOver = true;
                            break;
                        }
                    }
                    Monitor.Pulse(flag);
                }
                Thread.Sleep(1000);
            }
        }

        public static void Music()
        {
            while (!isGameOver)
            {
                Console.Beep(120, 500);
                Console.Beep(140, 500);
                Console.Beep(120, 500);
                Console.Beep(160, 500);
            }
        }

        public static void GameEngine()
        {
            //initial console settings
            Console.OutputEncoding = Encoding.Unicode;
            Console.BufferHeight = Console.WindowHeight = 28;
            Console.BufferWidth = Console.WindowWidth = 80;
            Console.CursorVisible = false;
            Console.Clear();

            while (true)
            {
                StartMenu startMenu = new StartMenu();
                startMenu.Animate();
                startMenu.SelectTask();

                while (GameData.playerLives > 0)
                {
                    InitializeGame();

                    Thread ShipMoveShootThread = new Thread(ShootAndMove);
                    Thread EnemiesMoveAndTimerThread = new Thread(MoveEnenmiesAndTimer);
                    Thread MusicThread = new Thread(Music);

                    ShipMoveShootThread.Start();
                    EnemiesMoveAndTimerThread.Start();
                    MusicThread.Start();

                    ShipMoveShootThread.Join();
                    EnemiesMoveAndTimerThread.Join();
                    MusicThread.Join();

                    if (isGameOver == true && isGameWon == false)
                    {
                        GameData.score += Timer.secondsLeft + (20 * GameData.gameDifficulty);
                        Console.Clear();
                        Console.Beep(200, 300);
                        Console.Beep(260, 800);
                        GameOver.PrintGameOver();
                        GameData.score = 0;
                        Enemy.enemies.Clear();
                        enemiesLeft = 0;
                        Console.Clear();
                        break;
                    }
                    else if (isGameOver == true && isGameWon == true)
                    {
                        GameData.score += Timer.secondsLeft + (20 * GameData.gameDifficulty) + 50;
                        Console.Clear();
                        Console.Beep(440, 200);
                        Console.Beep(594, 200);
                        Console.Beep(330, 800);
                        GameOver.PrintGameWon();
                        enemiesLeft = Enemy.enemies.Count;
                        Enemy.enemies.Clear();
                        GameData.ChangeDifficulty(GameData.gameDifficulty + 1);
                        randomLabyrinthNum = rnd.Next(1, 7);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }

        static void Main()
        {
            try
            {
                GameEngine();
            }
            catch (ArgumentException ae)
            {
                Console.Clear();
                Console.WriteLine(ae.Message);
            }
        }
    }
}
