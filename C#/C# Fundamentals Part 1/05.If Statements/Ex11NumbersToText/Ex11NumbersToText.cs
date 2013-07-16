using System;

namespace Ex11NumbersToText
{
    class Ex11NumbersToText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char firstLetter = '\u0000';
            char secondLetter = '\u0000';
            char thirdLetter = '\u0000';

            if (input.Length == 2)
            {
                firstLetter = input[0];
                secondLetter = input[1];
            }
            else if (input.Length == 3)
            {
                firstLetter = input[0];
                secondLetter = input[1];
                thirdLetter = input[2];
            }
            else if (input.Length == 1)
            {
                firstLetter = input[0];
            }

            string firstNumLetter = "";
            string secondNumLetter = "";
            string thirdNumLetter = "";

            switch (firstLetter)
            {
                case '1': firstNumLetter = "one";
                    break;
                case '2': firstNumLetter = "two";
                    break;
                case '3': firstNumLetter = "three";
                    break;
                case '4': firstNumLetter = "four";
                    break;
                case '5': firstNumLetter = "five";
                    break;
                case '6': firstNumLetter = "six";
                    break;
                case '7': firstNumLetter = "seven";
                    break;
                case '8': firstNumLetter = "eight";
                    break;
                case '9': firstNumLetter = "nine";
                    break;
                default: firstNumLetter = "zero";
                    break;
            }

            switch (secondLetter)
            {
                case '1': secondNumLetter = "one";
                    break;
                case '2': secondNumLetter = "two";
                    break;
                case '3': secondNumLetter = "three";
                    break;
                case '4': secondNumLetter = "four";
                    break;
                case '5': secondNumLetter = "five";
                    break;
                case '6': secondNumLetter = "six";
                    break;
                case '7': secondNumLetter = "seven";
                    break;
                case '8': secondNumLetter = "eight";
                    break;
                case '9': secondNumLetter = "nine";
                    break;
                default: secondNumLetter = "zero";
                    break;
            }

            switch (thirdLetter)
            {
                case '1': thirdNumLetter = "one";
                    break;
                case '2': thirdNumLetter = "two";
                    break;
                case '3': thirdNumLetter = "three";
                    break;
                case '4': thirdNumLetter = "four";
                    break;
                case '5': thirdNumLetter = "five";
                    break;
                case '6': thirdNumLetter = "six";
                    break;
                case '7': thirdNumLetter = "seven";
                    break;
                case '8': thirdNumLetter = "eight";
                    break;
                case '9': thirdNumLetter = "nine";
                    break;
                default: thirdNumLetter = "zero";
                    break;
            }

            if (Convert.ToInt32(input) < 100)
            {
                if (Convert.ToInt32(input) < 10)
                {
                    Console.WriteLine(firstNumLetter);
                }
                else if (Convert.ToInt32(input) >= 10 && Convert.ToInt32(input) <= 20)
                {
                    if (Convert.ToInt32(input) == 10)
                    {
                        Console.WriteLine("ten");
                    }
                    else if (Convert.ToInt32(input) == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    else if (Convert.ToInt32(input) == 12)
                    {
                        Console.WriteLine("twelve");
                    }
                    else if (Convert.ToInt32(input) == 14)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (Convert.ToInt32(input) == 15)
                    {
                        Console.WriteLine("fifteen");
                    }
                    else if (Convert.ToInt32(input) == 16)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (Convert.ToInt32(input) == 17)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (Convert.ToInt32(input) == 18)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (Convert.ToInt32(input) == 19)
                    {
                        Console.WriteLine("nineteen");
                    }
                    else if (Convert.ToInt32(input) == 20)
                    {
                        Console.WriteLine("twenty");
                    }
                }
                else if (Convert.ToInt32(input) > 20 && Convert.ToInt32(input) < 30)
                {
                    Console.WriteLine("twenty {0}", secondNumLetter);
                }
                else if (Convert.ToInt32(input) >= 30 && Convert.ToInt32(input) < 40)
                {
                    if (secondNumLetter == "zero")
                    {
                        Console.WriteLine("thirty");
                    }
                    else
                    {
                        Console.WriteLine("thirty {0}", secondNumLetter);
                    }
                }
                else if (Convert.ToInt32(input) >= 50 && Convert.ToInt32(input) <= 59)
                {
                    if (secondNumLetter == "zero")
                    {
                        Console.WriteLine("fifty");
                    }
                    else
                    {
                        Console.WriteLine("fifty {0}", secondNumLetter);
                    }

                }
                else
                {
                    Console.WriteLine("{0}ty {1}", firstNumLetter, secondNumLetter);
                }


            }
            else if (secondNumLetter == "zero" && thirdNumLetter == "zero" && Convert.ToInt32(input) < 1000)
            {
                Console.WriteLine("{0} hundret", firstNumLetter);
            }
            else if (Convert.ToInt32(input) > 100 && Convert.ToInt32(input) < 1000)
            {
                if (secondNumLetter == "zero")
                {
                    Console.WriteLine("{0} hundret and {1}", firstNumLetter, thirdNumLetter);
                }
                else if (secondNumLetter == "one")
                {
                    if (Convert.ToInt32(input) % 100 == 10)
                    {
                        Console.WriteLine("{0} hundret and ten", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 11)
                    {
                        Console.WriteLine("{0} hundret and eleven", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 12)
                    {
                        Console.WriteLine("{0} hundret and twelve", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 14)
                    {
                        Console.WriteLine("{0} hundret and fourteen", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 15)
                    {
                        Console.WriteLine("{0} hundret and fifteen", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 16)
                    {
                        Console.WriteLine("{0} hundret and sixteen", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 17)
                    {
                        Console.WriteLine("{0} hundret and seventeen", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 18)
                    {
                        Console.WriteLine("{0} hundret and eighteen", firstNumLetter);
                    }
                    else if (Convert.ToInt32(input) % 100 == 19)
                    {
                        Console.WriteLine("{0} hundret and nineteen", firstNumLetter);
                    }

                }
                else if (secondNumLetter == "two")
                {
                    if (thirdNumLetter == "zero")
                    {
                        Console.WriteLine("hundret and twenty");
                    }
                    else
                    {
                        Console.WriteLine("{0} hundret and twenty {1}", firstNumLetter, thirdNumLetter);
                    }

                }
                else if (secondNumLetter == "three")
                {
                    if (thirdNumLetter == "zero")
                    {
                        Console.WriteLine("hundret and thirty");
                    }
                    else
                    {
                        Console.WriteLine("{0} hundret and thirty {1}", firstNumLetter, thirdNumLetter);
                    }
                }
                else if (secondNumLetter == "five")
                {
                    if (thirdNumLetter == "zero")
                    {
                        Console.WriteLine("hundret and fifty");
                    }
                    else
                    {
                        Console.WriteLine("{0} hundret and fifty {1}", firstNumLetter, thirdNumLetter);
                    }
                }
                else
                {
                    Console.WriteLine("{0} hundret and {1}ty {0}", firstNumLetter, secondNumLetter, thirdNumLetter);
                }
            }
            else if (Convert.ToInt32(input) >= 1000)
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
