using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevFinalProject
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string address = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Text;
            string confirmPassword = textBox6.Text;

            var parent = this.Parent as Form1;
            if (parent != null)
            {
                parent.SignUp(firstName, lastName, email, password, confirmPassword);
                ClearAllTextBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form1;

            if (parent != null)
            {
                parent.SignUp();

            }
        }

        public void ClearAllTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
