using System;

namespace TelerikLogo
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int x = input;
            int z = (x / 2) + 1;
            int y = x;
            int dotsBefore = z - 1;
            int dotsAfter = ((input * 3 - 2) / 2) - z;
            int dotsBetween = 0;

            
          
                
                for (int k = 1; k <= input ; k++)
                {

                    if (k == input)
                    {
                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                    }
                    
                    
                    if ((k >= z + 1) && (k < input))
                    {
                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                        dotsBetween++;                        
                        dotsBefore--;                        
                        dotsAfter--;
                        if (dotsBefore < 0)
                        {
                            dotsBefore = 0;
                        }

                        
                        if (dotsAfter < 0)
                        {
                            dotsAfter = 0;
                        }

                        
                    }

                    
                    if (k == 1)
                    {
                        Console.Write(new string('.', dotsBefore));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));                        
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBefore));
                        dotsBetween++;                        
                        dotsBefore--;
                        dotsAfter--;
                        
                        if (dotsAfter < 0)
                        {
                            dotsAfter = 0;
                        }
                        if (dotsBefore < 0)
                        {
                            dotsBefore = 0;
                        }

                    }
                    else if ((k > 1) && (k <= z))
                    {
                        Console.Write(new string('.', dotsBefore));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBefore));
                        dotsBetween++;
                        dotsBetween++;
                        dotsBefore--;
                        
                        if (dotsBefore < 0)
                        {
                            dotsBefore = 0;
                        }
                        if (dotsBetween < 0)
                        {
                            dotsBetween = 0;
                        }
                        dotsAfter--;
                        
                        if (dotsAfter < 0)
                        {
                            dotsAfter = 0;
                        }

                    }
                    Console.WriteLine();
                }


                dotsBetween--;
                for (int i = 1; i <= input * 2 - 2; i++)
                {
                    if (i < input - 1)
                    {
                        
                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                        dotsAfter++;
                        dotsBetween--;
                    }


                    if ((i >= input - 1) && (i < input * 2 - 2))
                    {

                        Console.Write(new string('.', dotsBetween));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('.', dotsAfter));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('.', dotsBetween));
                        dotsAfter--;
                        dotsBetween++;
                    }
                        if (i == input * 2 - 2)
                        {
                            Console.Write(new string('.', dotsBetween));
                            Console.Write(new string('*', 1));
                            Console.Write(new string('.', dotsBetween));
                        }
                    
                    
                    Console.WriteLine();
                }
        }
    }
}
