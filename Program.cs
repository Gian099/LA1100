using System;
using System.Diagnostics.Metrics;

namespace Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 100);

            Console.WriteLine("Rate eine Zahl von 1 bis 100");

            bool resultFound = false;

            int Versuche = (0);
     
            
            while (!resultFound)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > rndNum)
                { 
                    Console.WriteLine("too high!, tray a lower number");
                     Versuche++;
                }

                else if (num < rndNum)
                {
                    Console.WriteLine("too low!, try a higher number");
                    Versuche++;
                }

                else
                {
                    Console.WriteLine("Diese Zahl war die richtige. Du hast " + Versuche + " Versuche gebraucht.");
                    resultFound = true;
                }

            }

            



        }

    }
                     
}