using PartyConsoleGame.Upravy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Hra
{
    internal class AreYouReady
    {
        /// <summary>
        /// Metoda pro přechod mezi úvodem a hrou 
        /// </summary>
        public static void Ready()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Hráči byli úspěšně upsáni Ďáblu.", ConsoleColor.Green, ConsoleColor.Black);
            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Až budete připraveni, stiskněte libovolnou klávesu.", ConsoleColor.Cyan, ConsoleColor.Black);
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //ASCII sklenička
            VypisTextu.VypisText("()   ()      ()    /\r\n  ()      ()  ()  /\r\n   ______________/___\r\n   \\            /   /\r\n    \\^^^^^^^^^^/^^^/\r\n     \\     ___/   /\r\n      \\   (   )  /\r\n       \\  (___) /\r\n        \\ /    /\r\n         \\    /\r\n          \\  /\r\n           \\/\r\n           ||\r\n           ||\r\n           ||\r\n           ||\r\n           ||\r\n           /\\\r\n          /;;\\\r\n     ==============", ConsoleColor.DarkRed, ConsoleColor.Black);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Nalijte si drinky, hra začíná!", ConsoleColor.Yellow, ConsoleColor.Black);
            Thread.Sleep(3000);

            Console.Clear();
        }
    }
}
