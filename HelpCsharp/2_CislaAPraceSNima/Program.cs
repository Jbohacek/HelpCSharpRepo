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

        private decimal CisloDecimal = 156849.5498m;

        // 1568495498 * 10na-4

        public Cisla()
        {
            cisla[0] = 5;

        }


        private int[] cisla = new int[4];
        


        public double DistanceBetweenTwoPoints(Point a, Point b)
        {
            //d=√((xb – xa)² + (yb – ya)²).
            return 0;
        }

        public double Pythagoras(double distanceA, double distanceB)
        {
            //a2 + b2 = c2


            return 0;
        }


    }
}
