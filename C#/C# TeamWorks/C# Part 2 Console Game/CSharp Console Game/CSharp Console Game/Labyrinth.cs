using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Labyrinth
    {
        public static char[,] labyrinth { get; set; }

        public static void ReadLabyrinth()
        {

            string path = @"../../labyrinthVer" + Engine.randomLabyrinthNum + ".txt";
            try
            {
                StreamReader reader = new StreamReader(path);

                using (reader)
                {
                    string currentLine = reader.ReadLine();
                    int lineNum = 0;
                    while (currentLine != null)
                    {
                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            labyrinth[lineNum, i] = currentLine[i];
                        }
                        currentLine = reader.ReadLine();
                        lineNum++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("Could not find labyrint file named " + path.Substring(6));
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentException("Value of labyrinth file cannot be null");
            }
            catch (DirectoryNotFoundException)
            {
                throw new ArgumentException("Could not find the specified directory of the labyrinth file");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("An I/O error occured and labyrinth file could not be read");
            }
        }

        public static void PrintLabyrinth()
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int k = 0; k < labyrinth.GetLength(1); k++)
                {
                    if (labyrinth[i, k] == 'w')
                    {
                        Engine.PrintOnConsole(k, i, '\u2588');
                    }
                    else if (labyrinth[i, k] == '#')
                    {
                        Engine.PrintOnConsole(k, i, '\u2591');
                    }
                    else
                    {
                        Engine.PrintOnConsole(k, i, labyrinth[i, k]);
                    }
                }
            }
        }

        public static void ChangeChar(int positionX, int positionY, char change)
        {
            labyrinth[positionX, positionY] = change;
        }

    }
}
