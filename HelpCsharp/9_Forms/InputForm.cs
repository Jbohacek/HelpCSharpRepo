using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Forms
{
    public partial class InputForm : Form
    {
        public TextBox ProsimVyplnit;





        public InputForm()
        {
            InitializeComponent();
        }
        public List<User> users { get; set; }

        public User final = new User();

        private Regex regName = new Regex(@"^[A-Z]\w");

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DejError.Clear();
            DejTrue.Clear();

            User a = new User();

            a.Name = tx_Name.Text;
            a.DateOfBirth = DTP_DateOfBirth.Value;
            a.GratuatedElementarySchool = cb_Elementary.Checked;
            a.Age = Convert.ToInt32(nud_age.Value);

            bool isValid = true;

            if (!regName.IsMatch(tx_Name.Text))
            {
                DejError.SetError(tx_Name,"Musi velke pismeno");
                isValid = false;
            }
            else
            {
                DejTrue.SetError(tx_Name," ");
            }

            if (nud_age.Value < 18)
            {
                DejError.SetError(nud_age,"Musi byt 18");
                isValid = false;
            }
            else
            {
                DejTrue.SetError(nud_age, "");
            }

            if (isValid == false)
            {
                return;
            }

            final = a;

            this.DialogResult = DialogResult.OK;
            this.ProsimVyplnit.Text = final.Name;
            this.Close();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    
    }
}
