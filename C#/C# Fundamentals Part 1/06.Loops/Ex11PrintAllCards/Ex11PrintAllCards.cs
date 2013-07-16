using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Cards { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
enum Types { Spades = 1, Hearts, Diamonds, Clubs }

namespace Ex11PrintAllCards
{
    class Ex11PrintAllCards
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                switch ((int)Types.Spades + i)
                {
                    case 1: for (int k = 0; k < 13; k++)
                        {
                            Console.WriteLine((Cards.Ace + k) + " of " + (Types.Spades + i));
                        }
                        break;
                    case 2: for (int k = 0; k < 13; k++)
                        {
                            Console.WriteLine((Cards.Ace + k) + " of " + (Types.Spades + i));
                        };
                        break;
                    case 3: for (int k = 0; k < 13; k++)
                        {
                            Console.WriteLine((Cards.Ace + k) + " of " + (Types.Spades + i));
                        };
                        break;
                    case 4: for (int k = 0; k < 13; k++)
                        {
                            Console.WriteLine((Cards.Ace + k) + " of " + (Types.Spades + i));
                        };
                        break;
                }
            }
        }
    }
}
