namespace _9_Forms
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            OpenForm = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NameCollum = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gratuatedElementarySchoolDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            AgeCollum = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "dasdas", "a", "a", "a" });
            listBox1.Location = new Point(53, 65);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(120, 274);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "F", "D", "E", "F", "G" });
            comboBox1.Location = new Point(52, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(53, 382);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += KliknulJsem;
            // 
            // button2
            // 
            button2.Location = new Point(179, 382);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += KliknulJsemDva;
            // 
            // OpenForm
            // 
            OpenForm.Location = new Point(654, 382);
            OpenForm.Name = "OpenForm";
            OpenForm.Size = new Size(134, 56);
            OpenForm.TabIndex = 4;
            OpenForm.Text = "Otevrit formular";
            OpenForm.UseVisualStyleBackColor = true;
            OpenForm.Click += OpenForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameCollum, nameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, gratuatedElementarySchoolDataGridViewCheckBoxColumn, AgeCollum });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(388, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(969, 323);
            dataGridView1.TabIndex = 6;
            // 
            // NameCollum
            // 
            NameCollum.DataPropertyName = "Name";
            NameCollum.HeaderText = "Jmeno";
            NameCollum.Name = "NameCollum";
            NameCollum.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gratuatedElementarySchoolDataGridViewCheckBoxColumn
            // 
            gratuatedElementarySchoolDataGridViewCheckBoxColumn.DataPropertyName = "GratuatedElementarySchool";
            gratuatedElementarySchoolDataGridViewCheckBoxColumn.HeaderText = "GratuatedElementarySchool";
            gratuatedElementarySchoolDataGridViewCheckBoxColumn.Name = "gratuatedElementarySchoolDataGridViewCheckBoxColumn";
            gratuatedElementarySchoolDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // AgeCollum
            // 
            AgeCollum.DataPropertyName = "Age";
            AgeCollum.HeaderText = "Vek";
            AgeCollum.Name = "AgeCollum";
            AgeCollum.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // button3
            // 
            button3.Location = new Point(1211, 406);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "GetPerson";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 450);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(OpenForm);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button OpenForm;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn NameCollum;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn gratuatedElementarySchoolDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn AgeCollum;
        private Button button3;
    }
}
