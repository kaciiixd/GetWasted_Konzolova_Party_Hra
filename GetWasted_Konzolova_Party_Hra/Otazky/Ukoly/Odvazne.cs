using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Otazky
{
    /// <summary>
    /// Vnitřní třída nazvaná "Odvazne" implementující rozhraní IRandomMethod
    /// </summary>
    internal class Odvazne : IRandomMethod 
    {
        /// <summary>
        /// Seznam odvážných úkolů
        /// </summary>
        List<string> odvazne = new List<string>();

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        public Odvazne() 
        {
            // Inicializuje seznam úkolů
            odvazne.Add("Předveď svůj striptérský move.");
            odvazne.Add("Sundej si podprsenku. Pokud jsi kluk, sundej jí nějaké holce.");
            odvazne.Add("Vyber 2 hráče, které pošleš na 10 minut pryč. Můžou si dělat, co chtějí. Nezapomeň nastavit stopky.");
            odvazne.Add("Ocucej někomu prst a dívej se mu při tom do očí.");
            odvazne.Add("Nahlas zavzdychej.");
            odvazne.Add("Vyber si osobu a s ní předveďte tvou nejoblíbenější polohu.");
            odvazne.Add("Kousni někoho do rtu.");
            odvazne.Add("Vyber dva hráče, se kterými by sis dal trojku.");
            odvazne.Add("Polib osobu nalevo na krk.");
            odvazne.Add("Ostatní vyberou, kdo ti udělá / komu uděláš body shot.");
            odvazne.Add("Ostatní vyberou hráče, který ti kostkou ledu může ochladit jakékoliv místo na těle.");
        }

        /// <summary>
        /// Metoda pro získání náhodného odvážného úkolu
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            Random random = new Random();
            int randomIndex = random.Next(odvazne.Count);
            return odvazne[randomIndex];
        }

        /// <summary>
        /// Definuje typ delegáta pro metody vracející řetězec
        /// </summary>
        /// <returns></returns>
        public delegate string RandomStringDelegate();

        /// <summary>
        /// Vytvoří statickou metodu pro vrácení instance delegáta
        /// </summary>
        /// <returns></returns>
        public static RandomStringDelegate GetRandomActionDelegate()
        {
            Odvazne odvazneInstance = new Odvazne();
            return odvazneInstance.GetRandom;
        }
    }
}
