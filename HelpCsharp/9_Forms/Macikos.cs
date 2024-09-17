using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Forms
{
    public partial class Macikos : Form
    {

        BindingList<User> _users = new BindingList<User>();
        public Macikos()
        {
            InitializeComponent();

            _users.Add(new User() {Name = "Jakub"});

            dataGridView1.DataSource = _users;

        }

        public void Clickos(object sender, EventArgs e)
        {
            _users.Add(new User() { Name = "Karel", DateOfBirth = DateTime.Now});
        }
    }
}
