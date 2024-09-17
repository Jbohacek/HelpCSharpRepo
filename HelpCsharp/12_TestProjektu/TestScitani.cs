using _0_Postup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12_TestProjektu
{
    [TestClass]
    public class TestScitani
    {
        [TestInitialize]
        public void PredTest()
        {
            
        }


        [DataRow(4,10)]
        [DataRow(4, 10)]
        [DataRow(4, 15)]
        [DataRow(4, -10)]
        [DataRow(4, 50)]
        [DataRow(4, 100)]
        [TestMethod]
        public void FirstTest(int a, int b)
        {
            Kalkulačka testKal = new Kalkulačka();

            int vysledek = testKal.Secti(a, b);

            Assert.AreEqual(a+b, vysledek);

        }

        [TestCleanup]
        public void PoTestu()
        {
            
        }
    }
}
