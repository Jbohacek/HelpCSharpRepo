using _0_Postup;

namespace _12_TestProjektu
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void UnitStart()
        {
            kal = new Kalkulaèka();
        }

        private Kalkulaèka? kal;

        [DataRow(4,10)]
        [DataRow(15, 10)]
        [DataRow(4, 140)]
        [DataRow(400, 10)]
        [DataRow(4, -15)]
        [TestMethod]
        public void TestScitani(int a,int b)
        {
            

            int vysledek = kal.Secti(a, b);

            Assert.AreEqual(a+ b, vysledek);
        }

        [TestCleanup]
        public void UnitStop()
        {
            kal = null;
        }
    }
}