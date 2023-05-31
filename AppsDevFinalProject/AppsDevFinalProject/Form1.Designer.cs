namespace AppsDevFinalProject
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
            signIn1 = new SignIn();
            signUp1 = new SignUp();
            receipt1 = new Receipt();
            dashboard1 = new Dashboard();
            SuspendLayout();
            // 
            // signIn1
            // 
            signIn1.Location = new Point(0, -1);
            signIn1.Name = "signIn1";
            signIn1.Size = new Size(938, 694);
            signIn1.TabIndex = 0;
            // 
            // signUp1
            // 
            signUp1.Location = new Point(0, -1);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(938, 750);
            signUp1.TabIndex = 1;
            // 
            // receipt1
            // 
            receipt1.BackColor = Color.FromArgb(226, 207, 207);
            receipt1.Location = new Point(0, -1);
            receipt1.Name = "receipt1";
            receipt1.Size = new Size(938, 750);
            receipt1.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(226, 207, 207);
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(938, 750);
            dashboard1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 749);
            Controls.Add(dashboard1);
            Controls.Add(receipt1);
            Controls.Add(signUp1);
            Controls.Add(signIn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private SignIn signIn1;
        private SignUp signUp1;
        private Receipt receipt1;
        private Dashboard dashboard1;
    }
}