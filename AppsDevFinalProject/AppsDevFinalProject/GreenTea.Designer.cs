﻿namespace AppsDevFinalProject
{
    partial class GreenTea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(283, 29);
            label1.TabIndex = 0;
            label1.Text = "Orders and Reordering";
            // 
            // panel1
            // 
            panel1.Location = new Point(121, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 414);
            panel1.TabIndex = 1;
            // 
            // GreenTea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 207, 207);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "GreenTea";
            Size = new Size(938, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}
