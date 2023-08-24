using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Upravy
{
    internal class AnimatorTextu
    {
        /// <summary>
        /// Metoda pro animaci textu s určenými barvami písma a pozadí
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="backgroundColor"></param>
        public static void AnimujText(string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }

            Console.ForegroundColor = originalForegroundColor;
            Console.BackgroundColor = originalBackgroundColor;
        }
    }
}
