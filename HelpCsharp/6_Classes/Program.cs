using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace _6_Classes
{
    public class Program
    {



        static void Main(string[] args)
        {
            Car a = new Car("Skoda", 70, Color.Azure, 1);
            Car b = new Car("Skoda", 70, Color.Black, 4);
            Car c = new Car("Audi", 60, Color.Blue, 3);
            Car d = new Car("Bettle", 50, Color.Black,2);
            Car e = new Car("Bettle", 50, Color.Black, 9);
            Car f = new Car("Skoda", 20, Color.Black, 10);


            List<Car> listik = new List<Car>();
            listik.Add(a);
            listik.Add(b);
            listik.Add(c);
            listik.Add(d);
            listik.Add(e);
            listik.Add(f);


            List<Car> levny = listik.OrderBy(x => x.Id).ToList();


            Car audi = listik.First(x => x.Name == "Audi");
            Car audidva = listik.Single(x => x.Name == "Audi");

            List<string> jmena = listik.Select(x => x.Name).ToList();
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Car(string name, double price, Color color, int id)
        {
            Name = name;
            Price = price;
            Color = color;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
