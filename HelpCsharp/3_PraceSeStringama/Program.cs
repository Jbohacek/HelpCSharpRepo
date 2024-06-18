namespace _3_PraceSeStringama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Deklarace a inicializace stringu
            //string pozdrav = "Ahoj, světe!";
            //Console.WriteLine(pozdrav);


            //// Spojení (konkatenace) stringů
            //string jmeno = "Martin";
            //string spojenyString = pozdrav + " Já jsem " + jmeno + ".";
            //Console.WriteLine(spojenyString);

            //// Délka stringu
            //int delka = pozdrav.Length;
            //Console.WriteLine("Délka stringu 'pozdrav' je: " + delka);


            //// Přístup k jednotlivým znakům
            //char prvniZnak = pozdrav[5];
            //Console.WriteLine("První znak stringu 'pozdrav' je: " + prvniZnak);




            ////"Ahoj, světe!"

            //// Podstring (substring)
            //string castPozdravu = pozdrav.Substring(2, 3);
            //Console.WriteLine("Podstring od 6. znaku o délce 5 je: " + castPozdravu);





            ////"Ahoj, světe!"

            //// Vyhledávání v stringu

            //// Nenajde = -1
            //// Najde = N
            //int index = pozdrav.IndexOf("s");
            //Console.WriteLine("Řetězec 'světe' začíná na indexu: " + index);




            ////"Ahoj, světe!"

            //// Nahrazení části stringu
            //string novyPozdrav = pozdrav.Replace("světe", "programátore");
            //Console.WriteLine("Nový pozdrav je: " + novyPozdrav);







            //// Rozdělení stringu (split)
            //string veta = "Toto je jednoduchá věta.";
            //string[] slova = veta.Split('o');
            //Console.WriteLine("Rozdělená věta na slova:");
            //foreach (string slovo in slova)
            //{
            //    Console.WriteLine(slovo);
            //}



            //// Trim - odstranění bílých znaků na začátku a na konci
            //string sMezerami = "a";
            //string bezMezer = sMezerami.Trim('a');
            //Console.WriteLine("Bez mezer: '" + bezMezer + "'");



            //// Převod na velká a malá písmena
            //string velkaPismena = pozdrav.ToUpper();
            //string malaPismena = pozdrav.ToLower();
            //Console.WriteLine("Velká písmena: " + velkaPismena);
            //Console.WriteLine("Malá písmena: " + malaPismena);

            PocetSlov a = new PocetSlov();

            int vysledek = a.Spocitej(
                "World War II[b] or the Second World War (1 September 1939 – 2 September 1945) was a global conflict between two alliances: the Allies and the Axis powers. Nearly all of the world's countries, including all of the great powers, participated in the conflict, and many invested all available economic, industrial, and scientific capabilities in pursuit of total war, blurring the distinction between civilian and military resources. Aircraft played a major role, enabling the strategic bombing of population centres and delivery of the only two nuclear weapons ever used in war. It was by far the deadliest conflict in history, resulting in 70–85 million fatalities. Millions died due to genocides, including the Holocaust, as well as starvation, massacres, and disease. In the wake of Axis defeat, Germany, Austria, Japan and Korea were occupied, and war crime tribunals were conducted against German and Japanese leaders.\r\n\r\nThe causes of the war are debated; contributing factors included the rise of fascism in Europe, the Spanish Civil War, the Second Sino-Japanese War, Soviet–Japanese border conflicts, and tensions in the aftermath of World War I. World War II is generally considered to have begun on 1 September 1939, when Nazi Germany, under Adolf Hitler, invaded Poland. The United Kingdom and France declared war on Germany on 3 September. Under the Molotov–Ribbentrop Pact of August 1939, Germany and the Soviet Union had partitioned Poland and marked out their \"spheres of influence\" across Finland, Estonia, Latvia, Lithuania, and Romania. From late 1939 to early 1941, in a series of campaigns and treaties, Germany conquered or controlled much of continental Europe in a military alliance called the Axis with Italy, Japan, and other countries. Following the onset of campaigns in North and East Africa, and the fall of France in mid-1940, the war continued primarily between the European Axis powers and the British Empire, with the war in the Balkans, the aerial Battle of Britain, the Blitz of the UK, and the Battle of the Atlantic. In June 1941, Germany led the European Axis powers in an invasion of the Soviet Union, opening the Eastern Front.\r\n\r\nJapan aimed to dominate East Asia and the Asia-Pacific, and by 1937 was at war with the Republic of China. In December 1941, Japan attacked American and British territories with near-simultaneous offensives against Southeast Asia and the Central Pacific, including an attack on Pearl Harbor which resulted in the United States and the United Kingdom declaring war against Japan. The European Axis powers declared war on the US in solidarity. Japan soon conquered much of the western Pacific, but its advances were halted in 1942 after losing the critical Battle of Midway; Germany and Italy were defeated in North Africa and at Stalingrad in the Soviet Union. Key setbacks in 1943—including German defeats on the Eastern Front, the Allied invasions of Sicily and the Italian mainland, and Allied offensives in the Pacific—cost the Axis powers their initiative and forced them into strategic retreat on all fronts. In 1944, the Western Allies invaded German-occupied France, while the Soviet Union regained its territorial losses and pushed Germany and its allies back. During 1944–1945, Japan suffered reversals in mainland Asia, while the Allies crippled the Japanese Navy and captured key western Pacific islands. The war in Europe concluded with the liberation of German-occupied territories; the invasion of Germany by the Western Allies and the Soviet Union, culminating in the Fall of Berlin to Soviet troops; Hitler's suicide; and the German unconditional surrender on 8 May 1945. Following the refusal of Japan to surrender on the terms of the Potsdam Declaration, the US dropped the first atomic bombs on Hiroshima on 6 August and Nagasaki on 9 August. Faced with imminent invasion of the Japanese archipelago, the possibility of more atomic bombings, and the Soviet Union's declared entry into the war against Japan, on the eve of invading Manchuria, Japan announced on 10 August its intention to surrender, signing a surrender document on 2 September 1945.\r\n\r\nWorld War II changed the political alignment and social structure of the world, and it set the foundation for the international order for the rest of the 20th century and into the 21st century. The United Nations was established to foster international cooperation and prevent conflicts, with the victorious great powers—China, France, the Soviet Union, the UK, and the US—becoming the permanent members of its security council. The Soviet Union and the United States emerged as rival superpowers, setting the stage for the Cold War. In the wake of European devastation, the influence of its great powers waned, triggering the decolonisation of Africa and Asia. Most countries whose industries had been damaged moved towards economic recovery and expansion.",
                "the");

            Console.WriteLine(vysledek);

            

            string palindromTest = "okon";

            Palindrom b = new Palindrom();

            bool JePalindrom = b.JePanlindrom(palindromTest);

            Console.WriteLine(JePalindrom);

            Console.ReadKey();

        }
    }
}
