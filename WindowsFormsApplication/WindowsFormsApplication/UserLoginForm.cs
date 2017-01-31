using System;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonForgotPass_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.CloseFormEvent += () => Enabled = true;
            forgotPasswordForm.Show();
            Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Visible = false;
        }
    }
}
