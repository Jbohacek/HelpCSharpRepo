﻿namespace _10_GDI_Grafika
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            KresliciBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)KresliciBox).BeginInit();
            SuspendLayout();
            // 
            // KresliciBox
            // 
            KresliciBox.BorderStyle = BorderStyle.FixedSingle;
            KresliciBox.Location = new Point(158, 71);
            KresliciBox.Name = "KresliciBox";
            KresliciBox.Size = new Size(595, 564);
            KresliciBox.TabIndex = 0;
            KresliciBox.TabStop = false;
            KresliciBox.Paint += KresliciBox_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 750);
            Controls.Add(label1);
            Controls.Add(KresliciBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)KresliciBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox KresliciBox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
