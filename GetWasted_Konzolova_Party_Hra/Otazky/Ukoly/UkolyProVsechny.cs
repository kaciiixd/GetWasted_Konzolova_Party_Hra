using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Otazky.Ukoly
{
    /// <summary>
    /// Vnitřní třída nazvaná "UkolyProVsechny" implementující rozhraní IRandomMethod
    /// </summary>
    internal class UkolyProVsechny : IRandomMethod
    {
        /// <summary>
        /// Seznam "ukolyProVsechny" obsahující úkoly pro všechny hráče
        /// </summary>
        List<string> ukolyProVsechny = new List<string>();

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        public UkolyProVsechny()
        {
            // Inicializuje seznam úkolů pro všechny hráče
            ukolyProVsechny.Add("Každý hráč řekne jeho oblíbenou porno kategorii.");
            ukolyProVsechny.Add("Kdo jako první řekne 'vole' si dá panáka.");
            ukolyProVsechny.Add("Přizná se, kdo má daddy kink.");
        }

        /// <summary>
        /// Metoda pro získání náhodného úkolu pro všechny hráče
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            Random random = new Random();
            int randomIndex = random.Next(ukolyProVsechny.Count);
            return ukolyProVsechny[randomIndex];
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
            var instance = new UkolyProVsechny();

            return instance.GetRandom;
        }
    }
}
