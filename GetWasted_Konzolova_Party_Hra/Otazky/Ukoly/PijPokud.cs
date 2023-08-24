using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyConsoleGame.Otazky.Ukoly
{
    /// <summary>
    /// Vnitřní třída nazvaná "PijPokud" implementující rozhraní IRandomMethod
    /// </summary>
    internal class PijPokud : IRandomMethod 
    {
        /// <summary>
        /// Seznam "pijPokud" obsahující úkoly
        /// </summary>
        List<string> pijPokud = new List<string>();

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        public PijPokud() 
        {
            // Inicializuje seznam úkolů
            pijPokud.Add("Napije se ten, kdo byl někdy na nuda pláži.");
            pijPokud.Add("Napije se ten, kdo někdy řekl, že už nikdy nebude pít.");
            pijPokud.Add("Napije se ten, kdo už někdy zkusil být vegeratiánem / veganem.");
            pijPokud.Add("Napije se ten, kdo si někdy přál být opačného pohlaví.");
            pijPokud.Add("Napije se ten, kdo někdy napsal milostný dopis (i ve školce se počítá děcka ;))");
            pijPokud.Add("Napije se ten, kdo někdy čůral ve sprše. I ten kdo tvrdí, že to nedělá, protože my víme, že to dělá.");
            pijPokud.Add("Napije se ten, kdo byl někdy surfovat.");
            pijPokud.Add("Napije se ten, kdo někdy viděl horor a pak byl tak podělaný strachy, že nemohl v noci spát.");
            pijPokud.Add("Napije se ten, kdo si někdy představoval, že má nějakou superschopnost.");
            pijPokud.Add("Napije se ten, kdo už někdy smazal příspěvek na sociální síti, protože měl málo lajků.");
            pijPokud.Add("Napije se ten, kdo už si někdy sám sebe googlil.");
            pijPokud.Add("Napije se ten, kdo už někdy vyhrál nějakou medaili / pohár.");
            pijPokud.Add("Napije se ten, kdo už někdy ochutnal žrádlo pro psy nebo kočky.");
            pijPokud.Add("Napije se ten, kdo někdy dojil krávu.");
            pijPokud.Add("Napije se ten, kdo už někdy napsal \"LOL\" nebo \"LMAO\" a přitom se vůbec nezasmál.");
            pijPokud.Add("Napije se ten, kdo někdy snědl celou tabulku čokolády. A ten kdo ne je divnej.");
            pijPokud.Add("Napije se ten, kdo někdy udělal 'prank call'. A dvakrát se napije ten, kdo to udělal v posledních dvou letech (ne, už to není cool).");
            pijPokud.Add("Napije se ten, kdo někdy jel stopem.");
            pijPokud.Add("Napije se ten, kdo byl v televizi. Mamka je na tebe určitě hrdá.");
            pijPokud.Add("Napije se ten, kdo má tetování.");
            pijPokud.Add("Napije se ten, kdo nemá tetování.");
            pijPokud.Add("Napije se ten, kdo má piercing (ušní lalůčky se nepočítají, to mají i mimina).");
            pijPokud.Add("Napije se ten, kdo nemá žádný piercing.");
            pijPokud.Add("Napije se ten, kdo byl někdy vyhozený z baru / klubu.");
            pijPokud.Add("Napije se ten, kdo někdy prozradil něčí tajemství.");
            pijPokud.Add("Napije se ten, kdo už někdy lhal v party hře.");
            pijPokud.Add("Napije se ten, kdo už někdy dostal pokutu za překročení rychlosti.");
            pijPokud.Add("Napije se ten, kdo má řidičák.");
            pijPokud.Add("Napije se ten, kdo nemá řidičák (koukej si ho udělat).");
            pijPokud.Add("Napije se ten, kdo už někdy použil cizí zubní kartáček (fuj).");
            pijPokud.Add("Napije se ten, kdo byl někdy ve vztahu více než rok.");
            pijPokud.Add("Napije se ten, kdo se někdy nesprchoval déle než týden.");
            pijPokud.Add("Napije se ten, kdo už někdy skoro umřel.");
            pijPokud.Add("Napije se ten, kdo už někdy manifestoval zprávu od svojí crush.");
            pijPokud.Add("Napije se ten, kdo se někdy osobně setkal s někým slavným.");
            pijPokud.Add("Napije se ten, kdo si hrdě prděl ve vztahu.");
            pijPokud.Add("Napije se ten, kdo byl někdy hozen do bazénu v oblečení.");
            pijPokud.Add("Napije se ten, komu někdy spadl mobil do záchodu.");
            pijPokud.Add("Napije se ten, kdo si někdy zabouchl klíče doma.");
            pijPokud.Add("Napije se ten, kdo si někdy zabouchl klíče v autě.");
            pijPokud.Add("Napije se ten, kdo někdy svedl vinu za něco, co udělal, na svého sourozence / mazlíčka.");
            pijPokud.Add("Napije se ten, kdo měl někdy na sobě jedno spodní prádlo 3 dny a déle.");
            pijPokud.Add("Napije se ten, kdo si někdy obarvil vlasy a pak toho litoval.");
            pijPokud.Add("Napije se ten, kdo někdy uklouzl na slupce od banánu. A pak všem řekne, z jakýho animáku přišel.");
            pijPokud.Add("Napije se ten, kdo si někdy nadělal do kalhot.");
            pijPokud.Add("Napije se ten, komu někdy došel benzín při jízdě.");
            pijPokud.Add("Napije se ten, kdo někdy narazil do skleněných dveří / stěny.");
            pijPokud.Add("Napije se ten, kdo někdy poslintal svého přítele / přítelkyni ve spánku.");
            pijPokud.Add("Napije se ten, kdo někdy omylem poslal e-mail bez přílohy.");
            pijPokud.Add("Napije se ten, kdo byl někdy v kině sám.");
            pijPokud.Add("Napije se ten, kdo se někdy koupal v bazénu nahý.");
            pijPokud.Add("Napije se ten, kdo byl někdy tak nervózní, že z toho dostal průjem.");
            pijPokud.Add("Napije se ten, kdo se někdy smál tak moc, že si cvrknul do gatí.");
            pijPokud.Add("Napije se ten, kdo měl někdy strach z nechtěného těhotenství.");
            pijPokud.Add("Napije se ten, kdo někdy řekl \"miluju tě\" a nemyslel to vážně. (Big oof)");
            pijPokud.Add("Napije se ten, kdo měl někdy alergickou reakci na nějaké jídlo / pití.");
            pijPokud.Add("Napije se ten, kdo měl někdy mořskou nemoc.");
            pijPokud.Add("Napije se ten, kdo někdy zkusil drogy.");
            pijPokud.Add("Napije se ten, kdo někdy omdlel.");
            pijPokud.Add("Napije se ten, kdo někdy zkusil skok padákem nebo bungee jumping (blázne).");
            pijPokud.Add("Napije se ten, kdo někdy dostal padáka.");
            pijPokud.Add("Napije se ten, kdo se někdy s někým porval.");
            pijPokud.Add("Napije se ten, kdo někdy chodil s někým, s kým zároveň pracoval.");
            pijPokud.Add("Napije se ten, kdo někdy flirtoval se svým učitelem / učitelkou.");
            pijPokud.Add("Napije se ten, kdo byl někdy na seznamce.");
            pijPokud.Add("Napije se ten, kdo někdy někomu připravil snídani do postele.");
            pijPokud.Add("Napije se ten, kdo někdy za jeden večer sbalil více lidí.");
            pijPokud.Add("Napije se ten, kdo někdy chodil s někým jen kvuli vzhledu.");
            pijPokud.Add("Napije se ten, kdo nikdy nechce děti.");
            pijPokud.Add("Napije se ten, kdo chce někdy děti. Dvakrát se napije ten, kdo je chce v horizontu pěti let.");
            pijPokud.Add("Napije se ten, kdo někdy měl sladěné oblečení s partnerem.");
            pijPokud.Add("Napije se ten, kdo někdy litoval, že s někým randil.");
            pijPokud.Add("Napije se ten, kdo šel někdy na slepé rande.");
            pijPokud.Add("Napije se ten, kdo byl někdy ve vztahu a myslel si, že si toho partnera jednou vezme. Dvakrát se napij, pokud jste se rozešli.");
            pijPokud.Add("Napije se ten, kdo někdy pro někoho udělal striptease.");
            pijPokud.Add("Napije se ten, kdo někdy někoho vyghostoval.");
            pijPokud.Add("Napije se ten, kdo měl někdy crush na někom z hráčů.");
            pijPokud.Add("Napije se ten, kdo někdy hrál svlékací hru,.");
            pijPokud.Add("Napije se ten, kdo se někdy rozešel přes chat.");
            pijPokud.Add("Napije se ten, kdo měl někdy více partnerů najednou.");
            pijPokud.Add("Napije se ten, kdo měl někdy prázdninový románek.");
            pijPokud.Add("Napije se ten, kdo někdy kouřil cigaretu.");
            pijPokud.Add("Napije se ten, kdo si někdy holil nohy.");
            pijPokud.Add("Napije se ten, kdo jel někdy na motorce.");
            pijPokud.Add("Napije se ten, kdo měl někdy něco zlomeného.");
            pijPokud.Add("Napije se ten, komu museli v nemocnici vyplachovat žaludek.");
            pijPokud.Add("Napije se ten, kdo dal někdy někomu falešné číslo / instagram apod.");
            pijPokud.Add("Napije se ten, kdo někdy usnul v práci.");
            pijPokud.Add("Napije se ten, kdo někdy chodil s někým, koho jeho rodiče neschvalovali.");
            pijPokud.Add("Napije se ten, kdo někdy zapomněl na něčí narozeniny / výročí.");
            pijPokud.Add("Napije se ten, kdo někdy cestoval do zahraničí úplně sám.");
            pijPokud.Add("Napije se ten, kdo někdy chodil s někým, kdo je o více než 6 let mladší / starší.");
            pijPokud.Add("Napije se ten, kdo někdy políbil někoho stejného pohlaví.");
            pijPokud.Add("Napije se ten, kdo někdy předstíral, že je nemocný, aby nemusel do školy / práce.");
            pijPokud.Add("Napije se ten, kdo někdy dostal naplácáno.");
            pijPokud.Add("Napije se ten, kdo má nejdříve narozeniny.");
            pijPokud.Add("Napije se ten, kdo byl někdy v otevřeném vztahu.");
            pijPokud.Add("Napije se ten, koho partner/ka ve vztahu podvedl/a.");
            pijPokud.Add("Napije se ten, kdo byl někdy nevěrný.");
            pijPokud.Add("Napije se ten, kdo byl někdy zamilovaný.");
            pijPokud.Add("Napije se ten, kdo někdy políbil svého nejlepšího kamaráda / svou nejlepší kamarádku.");
            pijPokud.Add("Napije se ten, kdo byl ve vztahu, který netrval ani měsíc.");
            pijPokud.Add("Napije se ten, kdo někdy stalkoval svého/svojí ex na sociálních sítích.");
            pijPokud.Add("Napije se ten, kdo se někdy hrabal svému partnerovi v mobilu.");
            pijPokud.Add("Napije se ten, kdo byl někdy s někým jen kvůli penězům.");
            pijPokud.Add("Napije se ten, kdo někdy jedl z těla někoho jiného.");
            pijPokud.Add("Napije se ten, kdo nikdy neviděl Star Wars.");
            pijPokud.Add("Napije se ten, kdo se někdy musel po sexu dodělat sám.");
            pijPokud.Add("Napije se ten, kdo někdy posílal zprávy, když byl opilý, a pak toho litoval.");
            pijPokud.Add("Napijou se všichni hetero hráči.");
            pijPokud.Add("Napije se ten, kdo si myslí, že na velikosti záleží.");
            pijPokud.Add("Napije se ten, kdo někdy chodil na vysokou školu.");
            pijPokud.Add("Napije se ten, kdo někdy mačkal pupínky někomu jinému.");
            pijPokud.Add("Napije se ten, kdo má momentálně na někoho crush.");
        }

        /// <summary>
        /// Metoda pro získání náhodného úkolu
        /// </summary>
        /// <returns></returns>
        public string GetRandom() 
        {
            Random random = new Random();
            int randomIndex = random.Next(pijPokud.Count);
            return pijPokud[randomIndex];
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
            var instance = new PijPokud();

            return instance.GetRandom;
        }
    }
}
