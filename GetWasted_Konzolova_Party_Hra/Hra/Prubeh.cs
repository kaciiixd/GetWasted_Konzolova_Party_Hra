using PartyConsoleGame.Otazky;
using PartyConsoleGame.Upravy;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PartyConsoleGame.Hra
{
    public class Prubeh
    {
        /// <summary>
        /// Metoda pro cyklus hry
        /// </summary>
        /// <param name="playerNames"></param>
        public void ZacitHrat(List<string> playerNames)
        {
            //Vytvoří instanci třídy "Generator" s předanými jmény hráčů
            Generator generator = new Generator(playerNames);

            while (true) // Nekonečná smyčka
            {
                generator.Delegates(); // Spustí herní akci

                Thread.Sleep(2000);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                VypisTextu.VypisText("Stiskněte Enter pro pokračování nebo 'K' pro ukončení hry.", ConsoleColor.DarkGray, ConsoleColor.Black); // Display "Next" option
                
                string input = Console.ReadLine(); // Přečte vstup od uživatele
                
                if (input.Trim().ToLower() == "k") // Pokud je vstup "k" (malá nebo velká písmena), ukončí smyčku hry
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Díky za hraní GetWasted!");
                    break; // Ukončí smyčku hry
                }
                Console.Clear();
            }
        }
    }
}
