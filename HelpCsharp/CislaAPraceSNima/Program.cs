using System.Drawing;

namespace CislaAPraceSNima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cisla a = new Cisla();

        }
    }

    public class Cisla
    {
        // -128 - 127
        private sbyte MCisloSByte = 127;

        // 0 - 255
        private byte MCisloByte = 255;




        // -32,768 - 32,767
        private short MCisloShort = 32_767;

        // 0 - 65,535
        private ushort CisloUShort = 65_535;

        // -2,147,483,648 - 2,147,483,647
        private int CisloInt = 2_147_483_647;

        // 0 - 4,294,967,295
        private uint CisloUInt = 4_294_967_295;

        // -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807
        private long CisloLong = 9_223_372_036_854_775_807;

        // 0 - 18,446,744,073,709,551,615
        private ulong CisloULong = 18_446_744_073_709_551_615;


        private float CisloFloat = 100.00f;

        private double CisloDouble = 100.000000D;


        private decimal CisloDecimal = 156849.5498M;

        // 1568495498 * 10na-4

        public Cisla()
        {
            Point a = new Point(15,20);
            Point b = new Point(560, 45);

            double vysledk = DistanceBetweenTwoPoints(a, b);

            DistanceBetweenTwoPoints(new Point(10, 20), new Point(30, 40));

            Pythagoras(15, 20);
        }



        public double DistanceBetweenTwoPoints(Point a, Point b)
        {

            //d=√((xb – xa)² + (yb – ya)²).

            double odecteni1 = Math.Pow(b.X - a.X,2);
            double odecteni2 = Math.Pow(b.Y - a.Y,2);
            
            double secteni = odecteni1 + odecteni2;

            double odmocnina = Math.Sqrt(secteni);

            
            return odmocnina;
        }

        public double Pythagoras(double distanceA, double distanceB)
        {
            //a2 + b2 = c2

            double a = Math.Pow(distanceA, 2);
            double b = Math.Pow(distanceB, 2);

            double secteni = a + b;

            double vysledek = Math.Sqrt(secteni);

            return vysledek;
        }


    }
}
