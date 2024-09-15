namespace _9_Forms
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            tx_Name = new TextBox();
            DTP_DateOfBirth = new DateTimePicker();
            cb_Elementary = new CheckBox();
            nud_age = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Ok = new Button();
            btn_Close = new Button();
            DejError = new ErrorProvider(components);
            DejTrue = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DejError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DejTrue).BeginInit();
            SuspendLayout();
            // 
            // tx_Name
            // 
            tx_Name.Location = new Point(12, 49);
            tx_Name.MaxLength = 16;
            tx_Name.Name = "tx_Name";
            tx_Name.Size = new Size(200, 23);
            tx_Name.TabIndex = 0;
            // 
            // DTP_DateOfBirth
            // 
            DTP_DateOfBirth.Location = new Point(12, 100);
            DTP_DateOfBirth.MaxDate = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            DTP_DateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DTP_DateOfBirth.Name = "DTP_DateOfBirth";
            DTP_DateOfBirth.Size = new Size(200, 23);
            DTP_DateOfBirth.TabIndex = 1;
            // 
            // cb_Elementary
            // 
            cb_Elementary.AutoSize = true;
            cb_Elementary.Location = new Point(13, 140);
            cb_Elementary.Name = "cb_Elementary";
            cb_Elementary.Size = new Size(128, 19);
            cb_Elementary.TabIndex = 2;
            cb_Elementary.Text = "Elementary school?";
            cb_Elementary.UseVisualStyleBackColor = true;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(12, 192);
            nud_age.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            nud_age.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(120, 23);
            nud_age.TabIndex = 3;
            nud_age.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(13, 256);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 7;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(303, 256);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // DejError
            // 
            DejError.ContainerControl = this;
            // 
            // DejTrue
            // 
            DejTrue.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            DejTrue.ContainerControl = this;
            DejTrue.Icon = (Icon)resources.GetObject("DejTrue.Icon");
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 291);
            Controls.Add(btn_Close);
            Controls.Add(btn_Ok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nud_age);
            Controls.Add(cb_Elementary);
            Controls.Add(DTP_DateOfBirth);
            Controls.Add(tx_Name);
            Name = "InputForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)DejError).EndInit();
            ((System.ComponentModel.ISupportInitialize)DejTrue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_Name;
        private DateTimePicker DTP_DateOfBirth;
        private CheckBox cb_Elementary;
        private NumericUpDown nud_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Ok;
        private Button btn_Close;
        private ErrorProvider DejError;
        private ErrorProvider DejTrue;
    }
}