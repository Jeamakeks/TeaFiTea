namespace AppsDevFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal void showRegisterForm()
        {
            throw new NotImplementedException();
        }

        internal void SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        internal void SignUp(string firstName)
        {
            throw new NotImplementedException();
        }

        internal void SignUp(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            throw new NotImplementedException();
        }

        internal void SignUp()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signIn1.Show();
            signUp1.Hide();
            receipt1.Hide();
            dashboard1.Hide();
        }
    }
}