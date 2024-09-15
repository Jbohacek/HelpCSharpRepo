using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _11_Webikos.Models
{
    public class User
    {
        [DisplayName("Jmeno")][StringLength(10)]public string name { get; set; }
        public int vek { get; set; }
        public bool zije { get; set; }
    }
}
