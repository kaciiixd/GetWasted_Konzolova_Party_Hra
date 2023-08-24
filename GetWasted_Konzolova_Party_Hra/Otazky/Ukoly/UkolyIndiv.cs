using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Otazky.Ukoly
{
    /// <summary>
    /// Vnitřní třída nazvaná "UkolyIndiv" implementující rozhraní IRandomMethod
    /// </summary>
    internal class UkolyIndiv : IRandomMethod 
    {
        /// <summary>
        /// Seznam "ukoly" obsahující úkoly
        /// </summary>
        List<string> ukoly = new List<string>();

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        public UkolyIndiv()
        {
            // Inicializuje seznam úkolů
            ukoly.Add("Zatwerkuj.");
            ukoly.Add("Zavři oči, otevři pusu a nech ostatní, aby ti dali něco do pusy. Pokud poznáš, co to je, ostatní pijou.");
            ukoly.Add("Vezmi jednu náhodnou věc a snaž se jí někomu prodat.");
            ukoly.Add("Předveď, jak umíš rapovat.");
            ukoly.Add("Předveď nějakou slavnou osobnost. Pokud nikdo neuhádne, všichni pijou.");
            ukoly.Add("Máš 10 vteřin na to, abys vyfotil selfie se všema hráčema.");
            ukoly.Add("Ukaž všem 5 nejnovějších fotek v tvé galerii.");
            ukoly.Add("Ukaž všem tvou historii Google vyhledávání.");
            ukoly.Add("Ukaž všem obsah tvé peněženky.");
            ukoly.Add("Sedni si někomu na klín a buď tam dalších 5 kol.");
            ukoly.Add("Vyber dva hráče, kteří musí dalších 10 kol předstírat, že jsou pár.");
            ukoly.Add("Nauč někoho nějaký taneční pohyb.");
            ukoly.Add("Napiš čtvrté osobě ve tvých zprávách na Instagramu, že máš hrozný průjem. Dokud neodpoví, nic jiného mu / jí napsat nesmíš.");
            ukoly.Add("Udělej stojku.");
            ukoly.Add("Nakrm hráče po tvé pravici.");
            ukoly.Add("Vyměň si tričko s hráčem po tvé levici.");
            ukoly.Add("Ukaž všem tvé poznámky v mobilu.");
            ukoly.Add("[Wholesome] Řekni každému hráči jednu věc, co se ti na něm líbí.");
            ukoly.Add("3 minuty masíruj osobu po tvé pravici.");
            ukoly.Add("Udělej provaz.");
            ukoly.Add("Udělej 5 kliků.");
            ukoly.Add("Napij se vody (stay hydrated queen).");
            ukoly.Add("Napij se vody (stay hydrated queen).");
            ukoly.Add("Napij se vody (stay hydrated queen).");
            ukoly.Add("Napij se vody (stay hydrated queen).");
            ukoly.Add("Přečti ostatním poslední zprávu, kterou jsi poslal/a.");
            ukoly.Add("Zavaž si oči a ostatní se musí potichu poschovávat. Koho najdeš a poznáš jako prvního, pije.");
            ukoly.Add("Udělej 5 žabáků.");
            ukoly.Add("Napij se z drinku někoho z hráčů.");
        }

        /// <summary>
        /// Metoda pro získání náhodného úkolu
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            Random random = new Random();
            int randomIndex = random.Next(ukoly.Count);
            return ukoly[randomIndex];
        }

        /// <summary>
        /// Definuje typ delegáta pro generování úkolů
        /// </summary>
        /// <returns></returns>
        public delegate string RandomTaskGenerator();

        /// <summary>
        /// Vytvoří statickou metodu pro získání instance delegáta
        /// </summary>
        /// <returns></returns>
        public static RandomTaskGenerator CreateRandomTaskGenerator()
        {
            var instance = new UkolyIndiv();

            return instance.GetRandom;
        }
    }
}
