using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Forms
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool GratuatedElementarySchool { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
