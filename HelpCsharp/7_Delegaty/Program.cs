using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _7_Delegaty
{
    public class Photo { }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 50; i++)
            {
                Car a = new Car(Color.Blue, "Ford");
                cars.Add(a);
            }

     

            for (int i = 0; i < 50; i++)
            {
                Car a = new Car(Color.Red,"Audi");
                cars.Add(a);
            }

            Car b = new Car(Color.Yellow,"Lamborgini");
            cars.Add(b);

            for (int i = 0; i < 50; i++)
            {
                Car a = new Car(Color.Green,"Skoda");
                cars.Add(a);
            }

            List<Car> modreAuta = cars.Where(JednoAuto => JednoAuto.color == Color.Blue).ToList();

            Car c = cars.Single(x => x.color == Color.Yellow);

            List<string> vysledek = cars.Where(x => x.color == Color.Green).Select(x => x.Name).ToList();



        }

        

    }

    public class Car
    {
        public Color color { get; set; }
        public string Name { get; set; }

        public Car(Color _color, string name)
        {
            color = _color;
            Name = name;
        }
    }



}
