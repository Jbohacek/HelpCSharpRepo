namespace _3_PraceSeStringama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Deklarace a inicializace stringu
            string pozdrav = "Ahoj, světe!";
            Console.WriteLine(pozdrav);


            //// Spojení (konkatenace) stringů
            string jmeno = "Martin";
            string spojenyString = pozdrav + " Já jsem " + jmeno + ".";
            Console.WriteLine(spojenyString);

            //// Délka stringu
            int delka = pozdrav.Length;
            Console.WriteLine("Délka stringu 'pozdrav' je: " + delka);


            //// Přístup k jednotlivým znakům
            char prvniZnak = pozdrav[5];
            Console.WriteLine("První znak stringu 'pozdrav' je: " + prvniZnak);




            ////"Ahoj, světe!"

            //// Podstring (substring)
            string castPozdravu = pozdrav.Substring(2, 3);
            Console.WriteLine("Podstring od 6. znaku o délce 5 je: " + castPozdravu);





            ////"Ahoj, světe!"

            //// Vyhledávání v stringu

            //// Nenajde = -1
            //// Najde = N
            int index = pozdrav.IndexOf("s");
            Console.WriteLine("Řetězec 'světe' začíná na indexu: " + index);




            ////"Ahoj, světe!"

            //// Nahrazení části stringu
            string novyPozdrav = pozdrav.Replace("světe", "programátore");
            Console.WriteLine("Nový pozdrav je: " + novyPozdrav);







            //// Rozdělení stringu (split)
            string veta = "Toto je jednoduchá věta.";
            string[] slova = veta.Split('o');
            Console.WriteLine("Rozdělená věta na slova:");
            foreach (string slovo in slova)
            {
                Console.WriteLine(slovo);
            }



            //// Trim - odstranění bílých znaků na začátku a na konci
            string sMezerami = "a";
            string bezMezer = sMezerami.Trim('a');
            Console.WriteLine("Bez mezer: '" + bezMezer + "'");



            //// Převod na velká a malá písmena
            string velkaPismena = pozdrav.ToUpper();
            string malaPismena = pozdrav.ToLower();
            Console.WriteLine("Velká písmena: " + velkaPismena);
            Console.WriteLine("Malá písmena: " + malaPismena);

        }
    }
}
