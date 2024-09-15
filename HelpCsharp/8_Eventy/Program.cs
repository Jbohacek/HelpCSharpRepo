namespace _8_Eventy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Youtube a = new Youtube();
            //Divak b = new Divak();
            //SkupinaDivaku c = new SkupinaDivaku();

            //a.MojeUdalost += b.DostatOznameni;
            //a.MojeUdalost += c.DostaliViceOznameni;

            //a.SpustitEvent();

  

        }
    }

    public delegate void NaseMetody();

    public class Youtube
    {
        public event NaseMetody MojeUdalost;

        public void SpustitEvent()
        {
            if (MojeUdalost != null)
            {
                MojeUdalost();
            }
        }

    }

    public class Divak
    {
        public void DostatOznameni()
        {
            Console.WriteLine("Huraa nove video");
        }

    }

    public class SkupinaDivaku
    {
        public void DostaliViceOznameni()
        {
            Console.WriteLine("Hura vice videii");
        }
    }
}
