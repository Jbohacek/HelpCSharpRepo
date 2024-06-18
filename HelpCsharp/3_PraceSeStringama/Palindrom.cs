using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PraceSeStringama
{
    internal class Palindrom
    {
        public bool JePanlindrom(string text)
        {
            text = text.Replace(" ", "");

            string original = text;

            List<char> chary = text.ToCharArray().Reverse().ToList();

            string palindrom = string.Join("", chary);


            if (original == palindrom)
            {
                return true;
            }
            else
            {
                return false;
            }


            //123456

            //654321

        }
    }
}
