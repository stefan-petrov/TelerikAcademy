using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KukataIsDancing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[, ,] cube = new string[3, 3, 3];
            cube[0, 1, 1] = "G";
            cube[1, 1, 0] = "G";
            cube[1, 2, 1] = "G";
            cube[1, 0, 1] = "G";
            cube[2, 1, 1] = "G";
            cube[1, 1, 2] = "G";
            cube[0, 0, 0] = "R";
            cube[0, 2, 0] = "R";
            cube[0, 0, 2] = "R";
            cube[0, 2, 2] = "R";
            cube[2, 0, 0] = "R";
            cube[2, 2, 0] = "R";
            cube[2, 0, 2] = "R";
            cube[2, 2, 2] = "R";

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (cube[i,k,j] != "G" & cube[i,k,j] != "R")
                        {
                            cube[i, k, j] = "B";
                        }
                    }
                }
            }
            string[] directions = new string[4] { "front", "left", "back", "right" };
            int index= 0 ;
            string direction = directions[index];

            int input = int.Parse(Console.ReadLine());
            int w = 1;
            int h = 0;
            int d = 1;
            List<string> result = new List<string>();
            for (int n = 0; n < input; n++)
            {
                string moves = Console.ReadLine();
                string currentTail = cube[h, w, d];

                for (int i = 0; i < moves.Length; i++)
                {

                    char command = moves[i];
                    switch (command)
                    {
                        case 'L':
                            index++;
                            if (index > 3)
                            {
                                index = 0;
                            }
                            direction = directions[index];
                            break;
                        case 'R':
                            index--;
                            if (index < 0)
                            {
                                index = 3;
                            }
                            direction = directions[index];
                            break;
                        case 'W': 
                            if (direction == "front")
                            {
                                d++;
                                if (d >= 3)
                                {
                                    d = 0;
                                }
                                if (d < 0)
                                {
                                    d = 2;
                                }
                                
                            }
                            else if (direction == "left")
                            {
                                w--; ;
                                if (w >= 3)
                                {
                                    w = 0;
                                }
                                if (w < 0)
                                {
                                    w = 2;
                                }

                            }
                            else if (direction == "back")
                            {
                                d--;
                                if (d >= 3)
                                {
                                    d = 0;
                                }
                                if (d < 0)
                                {
                                    d = 2;
                                }

                            }
                            if (direction == "right")
                            {
                                w++;
                                if (w >= 3)
                                {
                                    w = 0;
                                }
                                if (w < 0)
                                {
                                    w = 2;
                                }

                            }
                            break;
                        default: Console.WriteLine("Error in switch box"); break;

                    }
                }
                currentTail = cube[h, w, d];
                if (currentTail == "B")
                {
                    result.Add("BLUE");
                }
                else if (currentTail == "R")
                {
                    result.Add("RED");
                }
                else
                {
                    result.Add("GREEN");
                }
                
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
