using PartyConsoleGame.Otazky.Ukoly;
using System;
using System.Collections.Generic;
using PartyConsoleGame.Otazky.TriviaNameSpace;
using PartyConsoleGame.Upravy;

namespace PartyConsoleGame.Otazky
{
    public class Generator
    {
        private List<string> playerNames; // List jmen hřáčů

        // Konstruktor pro předání jmen hráčů Generátoru
        public Generator(List<string> playerNames)
        {
            this.playerNames = playerNames;
        }

        /// <summary>
        /// Vybrání náhodného hráče
        /// </summary>
        /// <returns></returns>
        private string SelectRandomPlayer()
        {
            Random random = new Random();
            int randomIndex = random.Next(playerNames.Count);
            return playerNames[randomIndex];
        }

        /// <summary>
        /// Definice delegátního typu pro metody s návratovým typem void
        /// </summary>
        public delegate void RandomVoidDelegate();

        /// <summary>
        /// Metody pro získání delegátů pro generování otázek a úkolů
        /// </summary>
        /// <returns></returns>
        public static RandomVoidDelegate GetRandomQuestionDelegate()
        {
            Trivia triviaInstance = new Trivia(); // Create an instance of the Trivia class
            return triviaInstance.RunTriviaGame; // Return the void method from Trivia
        }

        /// <summary>
        /// Definice delegátního typu pro metody vracející řetězec
        /// </summary>
        /// <returns></returns>
        public delegate string RandomStringDelegate();

        /// <summary>
        /// Metoda pro získání instance delegáta pro metodu vracející řetězec
        /// </summary>
        /// <returns></returns>
        public static RandomStringDelegate GetRandomStringDelegateForUkolyProVsechny()
        {
            UkolyProVsechny randomStringProvider = new UkolyProVsechny();
            return randomStringProvider.GetRandom;
        }

        /// <summary>
        /// Metoda pro získání instance delegáta pro metodu vracející řetězec
        /// </summary>
        /// <returns></returns>
        public static RandomStringDelegate GetRandomStringDelegateForUkolyIndiv()
        {
            UkolyIndiv randomStringProvider = new UkolyIndiv();
            return randomStringProvider.GetRandom;
        }

        /// <summary>
        /// Metoda pro získání instance delegáta pro metodu vracející řetězec
        /// </summary>
        /// <returns></returns>
        public static RandomStringDelegate GetRandomStringDelegateForPijPokud()
        {
            PijPokud randomStringProvider = new PijPokud();
            return randomStringProvider.GetRandom;
        }

        /// <summary>
        /// Metoda pro získání instance delegáta pro metodu vracející řetězec
        /// </summary>
        /// <returns></returns>
        public static RandomStringDelegate GetRandomStringDelegateForOdvazne()
        {
            Odvazne randomStringProvider = new Odvazne();
            return randomStringProvider.GetRandom;
        }

        public void Delegates()
        {
            // Vytvoření seznamu delegátů zahrnujících jak metody s návratovým typem string, tak i void
            List<Delegate> methods = new List<Delegate>
            {
                Odvazne.GetRandomActionDelegate(),
                PijPokud.CreateRandomTaskGenerator(),
                UkolyIndiv.CreateRandomTaskGenerator(),
                UkolyProVsechny.CreateRandomTaskGenerator(),
                Trivia.CreateTriviaGameRunner()
            };

            Random random = new Random();
            int randomIndex = random.Next(methods.Count);

            Delegate selectedMethod = methods[randomIndex];

            //// Volání vybrané metody
            if (selectedMethod is Trivia.TriviaGameRunner triviaRunner)
            {
                triviaRunner(); // Spuštění hry Trivia
            }
            else if (selectedMethod is UkolyProVsechny.RandomTaskGenerator ukolyProVsechnyDelegate)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                string result = ukolyProVsechnyDelegate();
                AnimatorTextu.AnimujText(result, ConsoleColor.DarkBlue, ConsoleColor.White);
            }
            else if (selectedMethod is UkolyIndiv.RandomTaskGenerator ukolyIndivDelegate)
            {
                // Vybere náhodného hráče
                string randomPlayer = SelectRandomPlayer();

                Console.WriteLine("");
                Console.WriteLine("");
                AnimatorTextu.AnimujText("Na řadě je:  ", ConsoleColor.DarkCyan, ConsoleColor.Black);
                VypisTextu.VypisText(randomPlayer.ToUpper(), ConsoleColor.Black, ConsoleColor.DarkCyan);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Thread.Sleep(1000);
                string result = ukolyIndivDelegate();
                AnimatorTextu.AnimujText(result, ConsoleColor.Yellow, ConsoleColor.Black);
            }
            else if (selectedMethod is PijPokud.RandomTaskGenerator pijPokudDelegate)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                string result = pijPokudDelegate();
                AnimatorTextu.AnimujText(result, ConsoleColor.DarkBlue, ConsoleColor.White);
            }
            else if (selectedMethod is Odvazne.RandomStringDelegate odvazneDelegate) 
            {
                // Vybere náhodného hráče
                string randomPlayer = SelectRandomPlayer();

                Console.WriteLine("");
                Console.WriteLine("");
                AnimatorTextu.AnimujText("Na řadě je:  ", ConsoleColor.DarkCyan, ConsoleColor.Black);
                VypisTextu.VypisText(randomPlayer.ToUpper(), ConsoleColor.Black, ConsoleColor.DarkCyan);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Thread.Sleep(1000);
                string result = odvazneDelegate();
                AnimatorTextu.AnimujText(result, ConsoleColor.Yellow, ConsoleColor.Black);
            }
        }
    }
}
