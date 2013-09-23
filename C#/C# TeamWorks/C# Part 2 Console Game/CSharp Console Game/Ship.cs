using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Ship
    {
        int xPos;
        int yPos;
        char shipIcon;
        public int shipDirection;

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

        public Ship(int xPos = 0, int yPos = 0, int shipDirection = 3, char shipIcon = '#')
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.shipIcon = shipIcon;
            this.shipDirection = shipDirection;
        }
        
        public void PrintShip()
        {
            switch (this.shipDirection)
            {
                case 0:
                    Engine.PrintOnConsole(this.XPos, this.YPos, '\u0011', ConsoleColor.Cyan);
                    break;
                case 1:
                    Engine.PrintOnConsole(this.XPos, this.YPos, '\u0010', ConsoleColor.Cyan);
                    break;
                case 2:
                    Engine.PrintOnConsole(this.XPos, this.YPos, '\u001E', ConsoleColor.Cyan);
                    break;
                case 3:
                    Engine.PrintOnConsole(this.XPos, this.YPos, '\u001F', ConsoleColor.Cyan);
                    break;
                default:
                    Console.WriteLine("incorrect direction value of ship");
                    break;
            }
        }
    }
}
