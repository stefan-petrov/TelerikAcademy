using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slides
{
    class Ball
    {
        public int BallWidth { get; set; }
        public int BallHeight { get; set; }
        public int BallDepth { get; set; }

        public Ball(int width, int height, int depth)
        {
            this.BallWidth = width;
            this.BallHeight = height;
            this.BallDepth = depth;
        }

        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }
    }

    class Program
    {
        private static int width;
        private static int height;
        private static int depth;
        private static string[, ,] cube;
        private static Ball cubeBall;

        static void Main(string[] args)
        {
            ReadInput();
            ProcessBallComands();
        }

        private static void ProcessBallComands()
        {
            while (true)
            {
                string currentCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];
                string[] splittedCell = currentCell.Split();
                string command = splittedCell[0];
                switch (command)
                {
                    case "S": ProccessBallSlides(splittedCell[1]);
                        break;
                    case "T": cubeBall.BallWidth = int.Parse(splittedCell[1]);
                        cubeBall.BallDepth = int.Parse(splittedCell[2]);
                        break;
                    case "B":
                        PrintMessage();
                        return;
                        
                    case "E":
                        if (cubeBall.BallHeight == height - 1)
                        {
                            PrintMessage();
                            return;
                        }
                        else
                        {
                            cubeBall.BallHeight++;
                        }
                            break;
                    default: throw new Exception("Wrong command");

                }
            }
        }

        private static void ProccessBallSlides(string command)
        {
            Ball ghostBall = new Ball(cubeBall);

            switch (command)
            {
                case "R": ghostBall.BallHeight++;
                    ghostBall.BallWidth++;
                    break;
                case "L": ghostBall.BallHeight++;
                    ghostBall.BallWidth--;
                    break;
                case "F": ghostBall.BallHeight++;
                    ghostBall.BallDepth--;
                    break;
                case "B": ghostBall.BallHeight++;
                    ghostBall.BallDepth++;
                    break;
                case "FL": ghostBall.BallHeight++;
                    ghostBall.BallDepth--;
                    ghostBall.BallWidth--;
                    break;
                case "FR": ghostBall.BallHeight++;
                    ghostBall.BallDepth--;
                    ghostBall.BallWidth++;
                    break;
                case "BL": ghostBall.BallHeight++;
                    ghostBall.BallDepth++;
                    ghostBall.BallWidth--;
                    break;
                case "BR": ghostBall.BallHeight++;
                    ghostBall.BallDepth++;
                    ghostBall.BallWidth++;
                    break;
                default: throw new ArgumentException("Wrong slide command");
            }

            if (IsPassable(ghostBall))
            {
                cubeBall = new Ball(ghostBall);
            }
            else
            {
                PrintMessage();
                Environment.Exit(0);
            }
        }

        private static void PrintMessage()
        {
            string currentCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

            if (currentCell == "B" || cubeBall.BallHeight != height - 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine("{0} {1} {2}", cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth);
        }

        private static bool IsPassable(Ball ball)
        {
            if (ball.BallWidth >= 0 && ball.BallHeight >= 0 &&
                ball.BallDepth >= 0 && ball.BallWidth < width &&
                ball.BallHeight < height && ball.BallDepth < depth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ReadInput()
        {
            string[] rawNumbers = Console.ReadLine().Split();
            width = int.Parse(rawNumbers[0]);
            height = int.Parse(rawNumbers[1]);
            depth = int.Parse(rawNumbers[2]);

            cube = new string[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }

            }
            string[] rawBallCoords = Console.ReadLine().Split();
            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);

            cubeBall = new Ball(ballWidth, 0, ballDepth);
        }
    }
}
