namespace _9_Forms
{
    partial class Macikos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NasTextBox = new TextBox();
            NasButton = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Jmeno = new DataGridViewTextBoxColumn();
            Elementary = new DataGridViewCheckBoxColumn();
            DateOfneco = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            userBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gratuatedElementarySchoolDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // NasTextBox
            // 
            NasTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NasTextBox.Location = new Point(255, 180);
            NasTextBox.Margin = new Padding(4);
            NasTextBox.Name = "NasTextBox";
            NasTextBox.Size = new Size(120, 39);
            NasTextBox.TabIndex = 0;
            // 
            // NasButton
            // 
            NasButton.Location = new Point(782, 515);
            NasButton.Name = "NasButton";
            NasButton.Size = new Size(120, 73);
            NasButton.TabIndex = 1;
            NasButton.Text = "button1";
            NasButton.UseVisualStyleBackColor = true;
            NasButton.Click += Clickos;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "jedna", "Dva", "Tri", "Ctyry" });
            listBox1.Location = new Point(128, 145);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(120, 264);
            listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "jedna", "dva", "tri", "Ctyry" });
            comboBox1.Location = new Point(254, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Jmeno, Elementary, DateOfneco });
            dataGridView1.Location = new Point(382, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(520, 230);
            dataGridView1.TabIndex = 5;
            // 
            // Jmeno
            // 
            Jmeno.DataPropertyName = "Name";
            Jmeno.HeaderText = "Jmeno";
            Jmeno.Name = "Jmeno";
            Jmeno.ReadOnly = true;
            // 
            // Elementary
            // 
            Elementary.DataPropertyName = "GratuatedElementarySchool";
            Elementary.HeaderText = "Zaklad";
            Elementary.Name = "Elementary";
            Elementary.ReadOnly = true;
            Elementary.Visible = false;
            // 
            // DateOfneco
            // 
            DateOfneco.DataPropertyName = "DateOfBirth";
            DateOfneco.HeaderText = "DatmNarozeni";
            DateOfneco.Name = "DateOfneco";
            DateOfneco.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, gratuatedElementarySchoolDataGridViewCheckBoxColumn, ageDataGridViewTextBoxColumn });
            dataGridView2.DataSource = userBindingSource;
            dataGridView2.Location = new Point(382, 248);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(520, 224);
            dataGridView2.TabIndex = 6;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
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
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Macikos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(NasButton);
            Controls.Add(NasTextBox);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Macikos";
            Text = "Macikos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NasTextBox;
        private Button NasButton;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Jmeno;
        private DataGridViewCheckBoxColumn Elementary;
        private DataGridViewTextBoxColumn DateOfneco;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn gratuatedElementarySchoolDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}