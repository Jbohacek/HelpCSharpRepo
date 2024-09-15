using System.ComponentModel;
using System.Diagnostics;

namespace _9_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = users;





        }

        public BindingList<User> users = new BindingList<User>();

        private void KliknulJsem(object sender, EventArgs e)
        {

            users.Add(new()
            {
                Age = 15,
                DateOfBirth = DateTime.Now,
                GratuatedElementarySchool = true,
                Name = "Jakub"
            });


        }

        private void KliknulJsemDva(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void OpenForm_Click(object sender, EventArgs e)
        {
            InputForm a = new InputForm();

            a.FormClosing += GetData;
            a.Show();


        }

        private void GetData(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
      

            User item = (User)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem;
        }
    }
}
