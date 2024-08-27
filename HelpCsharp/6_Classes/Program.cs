namespace _6_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {


            Dog bb = new Dog();
            bb.Speak();



            Dog cc = new Dog();

            List<IAnimal> dum = new List<IAnimal>();

            dum.Add(bb);
            dum.Add(cc);

        }



    }

    public interface Mamal
    {

    }

    public interface IAnimal
    {
        string Name { get; set; }

        void Speak();
    }

    public abstract class Animal
    {
        public void Jump()
        {
            Console.WriteLine("jump");
        }
    }



    public class Dog : Animal, IAnimal, Mamal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Speak()
        {
            Console.WriteLine("Woof!");
        }

    }

    public class Retriver : Dog
    {

    }

    public class YoungRetriver : Retriver
    {
        public YoungRetriver()
        {
            
        }
    }
}
