using System;
using System.Collections.Generic;
using PartyConsoleGame.Hra;

namespace PartyConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření instance třídy Uvod
            Uvod uvod = new Uvod();
            List<string> playerNames = Uvod.GetPlayerNames(); // Zavolání statické metody pro získání jmen hráčů

            // Zkontrolování, zda jsou hráči připraveni
            AreYouReady.Ready();

            // Vytvoření instance třídy Prubeh
            Prubeh prubeh = new Prubeh();
            prubeh.ZacitHrat(playerNames); // Spuštění smyčky hry
        }
    }
}
