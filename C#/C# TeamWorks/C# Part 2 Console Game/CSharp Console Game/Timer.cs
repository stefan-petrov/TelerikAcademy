using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Timer
    {
        int xPos;
        int yPos;
        public static int secondsLeft;
        ConsoleColor color;

        public int XPos
        {
            get { return this.xPos; }
            set { this.xPos = value; }
        }

        public int YPos
        {
            get { return this.yPos; }
            set { this.yPos = value; }
        }

        public ConsoleColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Timer(int xPos, int yPos, ConsoleColor color = ConsoleColor.Red)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.color = color;
        }

        public static void PrintTimer(Timer timer)
        {
            if (Timer.secondsLeft <= 9)
            {
                Engine.PrintOnConsole(timer.xPos + 1, timer.yPos, ' ');
            }
            Console.SetCursorPosition(timer.xPos + Engine.fieldOffsetX, timer.yPos + Engine.fieldOffsetY);
            Console.ForegroundColor = timer.color;
            Console.Write(Timer.secondsLeft);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
