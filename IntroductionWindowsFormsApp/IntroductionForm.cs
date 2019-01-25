using System.Windows.Forms;

namespace IntroductionWindowsFormsApp
{
    public partial class IntroductionForm : Form
    {
        public IntroductionForm()
        {
            InitializeComponent();
        }

        private void IntroductionForm_Load(object sender, System.EventArgs e)
        {
        }

        private void signUpButton_Click(object sender, System.EventArgs e)
        {
            SignUp aSignUp = new SignUp()
            {
                FullName = fullNameTextBox.Text,
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text
            };

            if (aSignUp.FullName != "" && aSignUp.Email != "" && aSignUp.Password != "")
            {
                showSignUpLabel.Text = "Full Name-" + aSignUp.FullName + ", Email-" + aSignUp.Email + " & Password-" + aSignUp.Password;

            }
            else
            {
                showSignUpLabel.Text = "Enter your proper value on text box!";
            }
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            LoginForm aLoginForm = new LoginForm();
            aLoginForm.Show();
            this.Hide();
        }
    }
}