using PartyConsoleGame.Upravy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Hra
{
    public class Uvod
    {
        /// <summary>
        /// Metoda pro Úvod do hry a zaznamenání počtu a jmen hráčů
        /// </summary>
        /// <returns></returns>
        public static List<string> GetPlayerNames()
        {
            // ASCII nadpis
            VypisTextu.VypisText("\r\n█▀▀ █▀▀ ▀█▀ █░█░█ ▄▀█ █▀ ▀█▀ █▀▀ █▀▄\r\n█▄█ ██▄ ░█░ ▀▄▀▄▀ █▀█ ▄█ ░█░ ██▄ █▄▀", ConsoleColor.Magenta, ConsoleColor.Black);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Thread.Sleep(3000);
            AnimatorTextu.AnimujText("Vítejte v party hře GetWasted!", ConsoleColor.DarkMagenta, ConsoleColor.White);
            Console.WriteLine("");
            Console.WriteLine("");

            Thread.Sleep(500);

            int playerCount = 0; // Inicializuje proměnnou pro počet hráčů
            List<string> playerNames = new List<string>(); // Inicializuje seznam pro jména hráčů

            while (true) // Nekonečná smyčka, dokud nebude zadán platný vstup
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    VypisTextu.VypisText("Kolik hráčů bude dnes hrát?   ", ConsoleColor.Magenta, ConsoleColor.Black);
                    playerCount = int.Parse(Console.ReadLine()); // Přečte a převede vstup na celé číslo

                    if (playerCount < 2)  // Pokud je počet hráčů menší než 2  - chybová hláška
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        VypisTextu.VypisText("Tuto hru lze hrát ve 2 a více hráčích. Prosím, opravte počet hráčů, nebo si najděte kamarády.", ConsoleColor.Red, ConsoleColor.Black);
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        break; // Ukončí smyčku, pokud je zadán platný vstup
                    }
                }
                catch (FormatException) // Výjimka v případě neplatného formátu vstupu
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    VypisTextu.VypisText("Neplatný vstup.", ConsoleColor.Red, ConsoleColor.Black);
                    Thread.Sleep(1000);
                }
            }

            for (int i = 0; i < playerCount; i++) // Cyklus pro zadání jmen hráčů
            {
                Console.WriteLine("");
                VypisTextu.VypisText($"Jméno {i + 1}. hráče:  ", ConsoleColor.Blue, ConsoleColor.Black);
                string playerName = Console.ReadLine(); // Přečte jméno hráče od uživatele
                playerNames.Add(playerName); // Přidá jméno hráče do seznamu
            }

            return playerNames; // Vrátí seznam jmen hráčů
        }
    }
}
