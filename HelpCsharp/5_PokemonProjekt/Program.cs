using _5_PokemonProjekt.PokemonAssets;

namespace _5_PokemonProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* Úkol

            Popis projektu:

            Vytvoř aplikaci, která umožní uživatelům prohlížet seznam pokémonů podle jejich druhů. Uživatel si může vybrat konkrétního pokémona
            a aplikace následně otevře webovou stránku s podrobnými informacemi o vybraném pokémonovi.

            Požadavky:

            Navigace:
            Aplikace musí umožňovat uživatelům snadno procházet seznam pokémonů tam a zpět.


            Bonus:
            Přidat potvrzovací dialog s otázkou "Chcete opravdu otevřít webovou stránku? Ano/Ne".

            */



            // Tohle získá všechna jména pokemonu, podle druhu
            // Bere to z internetu
            // Nešahat dovnitř složky "PokemonAssets"
            string pokemoni = PokemonMenu.GetByType(PokemonMenu.PokemonType.Ghost);
            Console.WriteLine(pokemoni);

            // Tohle získá všechny typy pokémonů, co jsou
            string typyPokemonu = PokemonMenu.GetTypes();

            Console.WriteLine(typyPokemonu);


            // Tohle otevře webovou stánku na pokemona s jménem "fletchinder"
            PokemonMenu.OpenWebsite("fletchinder");

            // POZOR tohle nemusí fungovat vždy, existují pokémoni, který tam jsou jako "extra" a wiki je nanjde. Zkoušejte na jednoduchých jmenách. Jako charmander

            // Have fun


            Console.ReadLine();
        }
    }
}
