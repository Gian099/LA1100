using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

using Kingsoft.Easy;

namespace Number_guessing_game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("░▒█▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄░█▀▄▀█░░░▒█▄░▒█░█░▒█░█▀▄▀█░█▀▀▄░█▀▀░█▀▀▄░░░▒█▀▀█░█▀▀░█▀▀▄░█▀▀░█▀▀▄░█▀▀▄░▀█▀░▄▀▀▄░█▀▀▄\r\n░▒█▄▄▀░█▄▄█░█░▒█░█░█░█░░█░█░▀░█░░░▒█▒█▒█░█░▒█░█░▀░█░█▀▀▄░█▀▀░█▄▄▀░░░▒█░▄▄░█▀▀░█░▒█░█▀▀░█▄▄▀░█▄▄█░░█░░█░░█░█▄▄▀\r\n░▒█░▒█░▀░░▀░▀░░▀░▀▀░░░▀▀░░▀░░▒▀░░░▒█░░▀█░░▀▀▀░▀░░▒▀░▀▀▀▀░▀▀▀░▀░▀▀░░░▒█▄▄▀░▀▀▀░▀░░▀░▀▀▀░▀░▀▀░▀░░▀░░▀░░░▀▀░░▀░▀▀\r\n");

            Random rnd = new Random();
            int rndNum = rnd.Next(1, 1000);
            
            Console.WriteLine("Rate eine Zahl von 1 bis 1000");
            Console.WriteLine();
            bool nochmalspielen = false;

            int Versuche = (0);
            string response;

            while (!nochmalspielen)
            {
                try
                {

                    int num = int.Parse(Console.ReadLine());
                    if (num > rndNum)
                    {
                        Utils.PrintLine("zu hoch!, rate eine niedrigere Zahl", ConsoleColor.Red);
                        Versuche++;
                    }

                    else if (num < rndNum)
                    {
                        Utils.PrintLine("zu tief!, rate eine höhere Zahl", ConsoleColor.Red);
                        Versuche++;
                    }

                    else
                    {
                        Utils.PrintLine("Diese Zahl war die richtige. Du hast " + Versuche + " Versuche gebraucht.", ConsoleColor.Green);
                        nochmalspielen = true;
                        Console.WriteLine("Möchtest du noch einmal spielen? J/N");
                        response = Console.ReadLine();
                        response = response.ToUpper(); 

                        if (response == "J")
                        {
                            nochmalspielen = false;
                            Console.WriteLine("Sehr gut, Rate eine weitere Zahl von 1 bis 1000");
                            Console.WriteLine();
                        }
                        else
                        {
                            nochmalspielen = true;
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("Gib Ganze Zahlen und keine Buchstaben ein.");
                }
            }
        }
    }
}