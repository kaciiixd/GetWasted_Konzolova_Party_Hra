using PartyConsoleGame.Upravy;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Otazky.TriviaNameSpace
{
    internal class Trivia : IRandomMethod
    {
        List<Otazka> triviaOtazky = new List<Otazka> // Seznam otázek pro kvíz
        {
            // Seznam otázek s odpovědmi
            new Otazka
            {
                TextOtazky = "Která země má největší počet obyvatel?",
                SpravnaOdpoved = "Čína",
                SpatneOdpovedi = new string[] {"Rusko", "Indie", "USA"}
            },

            new Otazka
            {
                TextOtazky = "Ve kterém městě se nachází Španělské schody?",
                SpravnaOdpoved = "Řím",
                SpatneOdpovedi = new string[] {"Barcelona", "Praha", "Milano"}
            },

            new Otazka
            {
                TextOtazky = "Které příjmení je nejčastější ve Spojených státech Amerických?",
                SpravnaOdpoved = "Smith",
                SpatneOdpovedi = new string[] {"Johnson", "Williams", "Brown"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenuje nejvyšší z bohů řecké mytologie?",
                SpravnaOdpoved = "Zeus",
                SpatneOdpovedi = new string[] {"Dio", "Hades", "Ares"}
            },

            new Otazka
            {
                TextOtazky = "V jakém roce nabylo Česko samostatnosti?",
                SpravnaOdpoved = "1993",
                SpatneOdpovedi = new string[] {"1999", "1991", "1989"}
            },

            new Otazka
            {
                TextOtazky = "V jakých horách se nachází nejvyšší hora Česka?",
                SpravnaOdpoved = "Krkonoše",
                SpatneOdpovedi = new string[] {"Orlické Hory", "Lužické Hory", "Beskydy"}
            },

            new Otazka
            {
                TextOtazky = "Ve kterém roce proběhla Sametová revoluce?",
                SpravnaOdpoved = "1989",
                SpatneOdpovedi = new string[] {"1987", "1969", "1995"}
            },

            new Otazka
            {
                TextOtazky = "Kolik prvků je v Periodické tabulce prvků?",
                SpravnaOdpoved = "118",
                SpatneOdpovedi = new string[] {"100", "87", "91"}
            },

            new Otazka
            {
                TextOtazky = "Kolik duchů honí Pac-Mana na začátku každé hry?",
                SpravnaOdpoved = "4",
                SpatneOdpovedi = new string[] {"3", "2", "5"}
            },

            new Otazka
            {
                TextOtazky = "Jaké křestní jméno na spolupracovník Sherlocka Holmese Dr. Watson?",
                SpravnaOdpoved = "John",
                SpatneOdpovedi = new string[] {"Jack", "Adam", "Emma"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá páta planeta Sluneční soustavy?",
                SpravnaOdpoved = "Jupiter",
                SpatneOdpovedi = new string[] {"Mars", "Saturn", "Země"}
            },

            new Otazka
            {
                TextOtazky = "Ve kterém roce vyhrál český hokejový tým na Zimních Olympijských hrách v Naganu zlatou medaili?",
                SpravnaOdpoved = "1998",
                SpatneOdpovedi = new string[] {"1999", "1989", "1987"}
            },

            new Otazka
            {
                TextOtazky = "Kolik teček je dohromady na 2 hracích kostkách?",
                SpravnaOdpoved = "42",
                SpatneOdpovedi = new string[] {"21", "40", "52"}
            },

            new Otazka
            {
                TextOtazky = "Která část těla jako jediná od narození neroste?",
                SpravnaOdpoved = "Oči",
                SpatneOdpovedi = new string[] {"Uši", "Palce u nohou", "Nos"}
            },

            new Otazka
            {
                TextOtazky = "Která planeta Sluneční soustavy je nejblíže Slunci?",
                SpravnaOdpoved = "Merkur",
                SpatneOdpovedi = new string[] {"Venuše", "Mars", "Uran"}
            },

            new Otazka
            {
                TextOtazky = "Se kteou zemí nesousedí Česko?: Německo, Rakousko, Maďarsko, Polsko",
                SpravnaOdpoved = "Maďarsko",
                SpatneOdpovedi = new string[] {"Německo", "Rakousko", "Polsko"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá nejdelší řeka na území Česka?",
                SpravnaOdpoved = "Vltava",
                SpatneOdpovedi = new string[] {"Labe", "Morava", "Dunaj"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá hlavní město Islandu?",
                SpravnaOdpoved = "Reykjavík",
                SpatneOdpovedi = new string[] { "Akureyri", "Akranes", "Selfoss" }
            },

            new Otazka
            {
                TextOtazky = "Mohu hasit olej vodou?",
                SpravnaOdpoved = "Ne",
                SpatneOdpovedi = new string[] {"Ano", " ", " "}
            },

            new Otazka
            {
                TextOtazky = "Jakou barvu získám, když smíchám žlutou a modrou?",
                SpravnaOdpoved = "Zelenou",
                SpatneOdpovedi = new string[] {"Světle modrou", "Fialovou", "Hnědou"}
            },

            new Otazka
            {
                TextOtazky = "V jakém státě se nachází město Las Vegas?",
                SpravnaOdpoved = "Nevada",
                SpatneOdpovedi = new string[] {"USA", "Kalifornie", "Florida"}
            },

            new Otazka
            {
                TextOtazky = "Jaká řeka protéká Londýnem?",
                SpravnaOdpoved = "Temže",
                SpatneOdpovedi = new string[] {"Dunaj", "Volha", "Visla"}
            },

            new Otazka
            {
                TextOtazky = "Na jakém kontinentu nalezneme město Sydney?",
                SpravnaOdpoved = "Austrálie",
                SpatneOdpovedi = new string[] {"Evropa", "Afrika", "Amerika"}
            },

            new Otazka
            {
                TextOtazky = "Jaký je nejmenší kontinent na světě?",
                SpravnaOdpoved = "Austrálie",
                SpatneOdpovedi = new string[] {"Antarktida", "Evropa", "Amerika"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá největší ostrov na světě?",
                SpravnaOdpoved = "Grónsko",
                SpatneOdpovedi = new string[] { "Nová Guinea", "Madagaskar", "Island"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenuje nejmenší stát světa?",
                SpravnaOdpoved = "Vatikán",
                SpatneOdpovedi = new string[] {"Monako", "San Marino", "Malta"}
            },

            new Otazka
            {
                TextOtazky = "Je zvuk rychlejší než světlo?",
                SpravnaOdpoved = "Ne",
                SpatneOdpovedi = new string[] {"Ano", " ", " "}
            },

            new Otazka
            {
                TextOtazky = "Kolik stupňů Celsia musí mít voda aby se vařila?",
                SpravnaOdpoved = "100",
                SpatneOdpovedi = new string[] {"99", "80", "110"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenuje hlavní město Finska?",
                SpravnaOdpoved = "Helsinky",
                SpatneOdpovedi = new string[] {"Kodaň", "Stockholm", "Tallin"}
            },

            new Otazka
            {
                TextOtazky = "Kolik států má USA?",
                SpravnaOdpoved = "50",
                SpatneOdpovedi = new string[] {"48", "55", "60"}
            },

            new Otazka
            {
                TextOtazky = "V jakém hlavním evropském městě najdeme sochu Malé mořské víly?",
                SpravnaOdpoved = "Kodaň",
                SpatneOdpovedi = new string[] {"Vídeň", "Bratislava", "Lisabon"}
            },

            new Otazka
            {
                TextOtazky = "Jakou barvu mají boty Mickey Mouse?",
                SpravnaOdpoved = "Žlutou",
                SpatneOdpovedi = new string[] {"Červenou", "Modrou", "Černou"}
            },

            new Otazka
            {
                TextOtazky = "Který legendární surrealistický umělec je známý malováním tavicích hodin?",
                SpravnaOdpoved = "Salvador Dalí",
                SpatneOdpovedi = new string[] {"Leonardo DaVinci", "Andy Warhol", "André Breton " }
            },

            new Otazka
            {
                TextOtazky = "Kdo napsal Othella?",
                SpravnaOdpoved = "William Shakespeare",
                SpatneOdpovedi = new string[] { "J. R. R. Tolkien", "Dante Alighieri", "G. Boccaccio" }
            },

            new Otazka
            {
                TextOtazky = "Kolik je pi (2 desetinná místa)?",
                SpravnaOdpoved = "3,14",
                SpatneOdpovedi = new string[] {"3,41", "3,13", "13,14"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenovala první žena, která získala Nobelovu cenu?",
                SpravnaOdpoved = "Marie Curie",
                SpatneOdpovedi = new string[] { "Gerty Cori", "Pearl Buck", "Matka Teresa" }
            },

            new Otazka
            {
                TextOtazky = "Kolik existuje filmů Pán prstenů?",
                SpravnaOdpoved = "3",
                SpatneOdpovedi = new string[] {"4", "1", "6"}
            },

            new Otazka
            {
                TextOtazky = "Jaké je příjmení Spongeboba?",
                SpravnaOdpoved = "Squarepants",
                SpatneOdpovedi = new string[] { "Squareboots", "Squarehands", "Nemá příjmení"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá národní jídlo Španělska?",
                SpravnaOdpoved = "Paella",
                SpatneOdpovedi = new string[] { "Gazpacho", "Chorizo", "Tapas" }
            },

            new Otazka
            {
                TextOtazky = "Z kolika procent je lidské tělo tvořeno vodou?",
                SpravnaOdpoved = "60-65%",
                SpatneOdpovedi = new string[] {"70-75%", "80-85%", "50-55%"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenuje nejdelší řeka světa?",
                SpravnaOdpoved = "Amazonka",
                SpatneOdpovedi = new string[] {"Nil", "Jang-c’-ťiang", "Niger"}
            },

            new Otazka
            {
                TextOtazky = "Kolik pyramid je v Gíze?",
                SpravnaOdpoved = "3",
                SpatneOdpovedi = new string[] {"1", "2", "4"}
            },

            new Otazka
            {
                TextOtazky = "Ve které zemi se narodil Hitler?",
                SpravnaOdpoved = "Rakousko",
                SpatneOdpovedi = new string[] {"Německo", "Polsko", "Československo"}
            },

            new Otazka
            {
                TextOtazky = "Jak se nazývá domov řeckých bohů?",
                SpravnaOdpoved = "Olymp",
                SpatneOdpovedi = new string[] {"Athény", "Delfy ", "Corinth " }
            },

            new Otazka
            {
                TextOtazky = "Thor je syn kterého boha?",
                SpravnaOdpoved = "Odin",
                SpatneOdpovedi = new string[] {"Zeus", "Imhotep", "Loki"}
            },

            new Otazka
            {
                TextOtazky = "Romulus a Remus se pojí se založením kterého města?",
                SpravnaOdpoved = "Řím",
                SpatneOdpovedi = new string[] {"Benátky", "Barcelona", "Riga"}
            },

            new Otazka
            {
                TextOtazky = "Kolik srdcí má chobotnice?",
                SpravnaOdpoved = "3",
                SpatneOdpovedi = new string[] {"5", "8", "1"}
            },

            new Otazka
            {
                TextOtazky = "Jak se jmenovalo turecké město Istanbul před rokem 1930?",
                SpravnaOdpoved = "Konstantinopol",
                SpatneOdpovedi = new string[] {"Vždycky to byl Istanbul", "Babylon", "Cařihrad"}
            },

            new Otazka
            {
                TextOtazky = "Kolik lidských hráčů je na pólu na každé straně?",
                SpravnaOdpoved = "4",
                SpatneOdpovedi = new string[] {"2", "3", "5"}
            },

            new Otazka
            {
                TextOtazky = "Jaké je hlavní město Nového Zélandu?",
                SpravnaOdpoved = "Wellington",
                SpatneOdpovedi = new string[] { "Auckland", "Queenstown", "Sydney"}
            }
        };

        private Random random = new Random(); // Instance generátoru náhodných čísel

        /// <summary>
        /// Metoda pro získání náhodné otázky
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            return GenerateRandomQuestion().TextOtazky;
        }

        /// <summary>
        /// Metoda pro generování náhodné otázky
        /// </summary>
        /// <returns></returns>
        public Otazka GenerateRandomQuestion()
        {
            int randomIndex = random.Next(triviaOtazky.Count);
            return triviaOtazky[randomIndex];
        }

        /// <summary>
        /// Metoda pro spuštění kvízu
        /// </summary>
        public void RunTriviaGame()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");

            AnimatorTextu.AnimujText("HRÁČI POZOR, JE TU KVÍZ PRO VŠECHNY!", ConsoleColor.Black, ConsoleColor.Red);
            Thread.Sleep(1000);

            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Všichni si připravte papír a tužku.", ConsoleColor.Yellow, ConsoleColor.Black);
            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Až budou všichni připraveni, stiskněte libovolnou klávesu.", ConsoleColor.Blue, ConsoleColor.Black);
            Console.ReadKey();
            Console.Clear();


            Otazka randomQuestion = GenerateRandomQuestion();

            Thread.Sleep(500);
            VypisTextu.VypisText(randomQuestion.TextOtazky, ConsoleColor.DarkMagenta, ConsoleColor.White);
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(200);

            string[] allAnswers = ShuffleAnswers(randomQuestion.SpravnaOdpoved, randomQuestion.SpatneOdpovedi);

            for (int i = 0; i < allAnswers.Length; i++)
            {
                Console.WriteLine("");
                VypisTextu.VypisText($"\r\n{i + 1}. {allAnswers[i]}", ConsoleColor.White, ConsoleColor.Black);
            }

            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            AnimatorTextu.AnimujText("Každý si zapíše svou odpověď na papír.", ConsoleColor.DarkMagenta, ConsoleColor.Gray);
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            VypisTextu.VypisText("Pro odhalení správné odpovědi stiskněte libovolnou klávesu.", ConsoleColor.Yellow, ConsoleColor.Black);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            VypisTextu.VypisText("Správná odpověď:", ConsoleColor.White, ConsoleColor.DarkGreen);
            Console.Write("  ");
            AnimatorTextu.AnimujText(randomQuestion.SpravnaOdpoved, ConsoleColor.Green, ConsoleColor.Black);
            //Console.WriteLine($"Správná odpověď: {randomQuestion.SpravnaOdpoved}");
            Thread.Sleep(1000);

            Console.WriteLine("");
            Console.WriteLine("");
            VypisTextu.VypisText("Hráči, kteří odpověděli nesprávně pijí.", ConsoleColor.White, ConsoleColor.DarkGray);

        }

        /// <summary>
        /// Metoda pro zamíchání odpovědí
        /// </summary>
        /// <param name="correctAnswer"></param>
        /// <param name="incorrectAnswers"></param>
        /// <returns></returns>
        private string[] ShuffleAnswers(string correctAnswer, string[] incorrectAnswers)
        {
            string[] allAnswers = new string[incorrectAnswers.Length + 1];
            allAnswers[0] = correctAnswer;

            int insertIndex = random.Next(1, allAnswers.Length);

            for (int i = 0; i < incorrectAnswers.Length; i++)
            {
                if (i < insertIndex - 1)
                {
                    allAnswers[i + 1] = incorrectAnswers[i];
                }
                else
                {
                    allAnswers[i + 1] = incorrectAnswers[i];
                }
            }

            return allAnswers;
        }


        // Delegate type pro spuštění kvízu
        public delegate void TriviaGameRunner();

        // Statická metoda pro vytvoření instance delegáta
        public static TriviaGameRunner CreateTriviaGameRunner()
        {
            var instance = new Trivia();

            return instance.RunTriviaGame;
        }
    }
}





