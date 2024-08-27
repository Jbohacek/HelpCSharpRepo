namespace _4_Typy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            plosina a = new plosina();


            for (int i = 0; i <= 640; i++)
            {

                a.x += i <= 320 ? 0.1m : -0.1m;



                //if (i <= 320)
                //{
                //    a.x += 0.1m;
                //}
                //else
                //{
                //    a.x -= 0.1m;
                //}


                //switch (i)
                //{
                //    case <= 320:
                //        a.x += 0.1m;
                //        break;
                //    case > 320:
                //        a.x -= 0.1m;
                //        break;
                //}


                //if (i <= 320)
                //{
                //    a.x += 0.1m;
                //}

                //if (i > 320)
                //{
                //    a.x -= 0.1m;
                //}
                Console.WriteLine(a);
            }

            

            //Console.ReadLine();

            var h = new DirectoryInfo("P:\\!PixelArt\\Učení\\pacman");

            var g = h.GetFiles();
        }

        public class plosina
        {
            public decimal x { get; set; } = 0;
            public decimal y { get; set; } = 0;

            public override string ToString()
            {

                //Thread.Sleep(1);
                return $"x = {x}\ny = {y}\n-------------";
            }
        }
    }
}
