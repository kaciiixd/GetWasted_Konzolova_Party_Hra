using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Upravy
{
    internal class VypisTextu
    {
        /// <summary>
        /// Metoda pro výpis textu s určenými barvami písma a pozadí
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="backgroundcolor"></param>
        public static void VypisText(string text, ConsoleColor foregroundColor, ConsoleColor backgroundcolor)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundcolor;

            Console.Write(text);

            Console.ForegroundColor = originalForegroundColor;
            Console.BackgroundColor = originalBackgroundColor;
        }
    }
}
