using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TestProjektu
{
    internal class MockDatabaze
    {
        public int GetLenghtDataDatabaze()
        {
            Random rnd = new Random();

            return rnd.Next(1201,156789);

        }
    }
}
