using System.Windows.Forms;

namespace IntroductionWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            loginLabel.Text = "Test";
            LoginRichTextBox.Text += "Something Text on Rich TestBox";



        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}