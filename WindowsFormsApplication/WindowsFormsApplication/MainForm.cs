using System;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonViewUser_Click(object sender, EventArgs e)
        {
            var viewUserForm = new ViewUserForm();
            viewUserForm.CloseForm += () => Enabled = true;
            viewUserForm.Show();
            Enabled = false;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.CloseForm += () => Enabled = true;
            addUserForm.Show();
            Enabled = false;
        }

        private void buttonViewUserLevel_Click(object sender, EventArgs e)
        {
            var viewUserLevelForm = new ViewUserLevelForm();
            viewUserLevelForm.CloseFormEvent += () => Enabled = true;
            viewUserLevelForm.Show();
            Enabled = false;
        }

        private void buttonAddUserLevel_Click(object sender, EventArgs e)
        {
            var addUserLevelForm = new AddUserLevelForm();
            addUserLevelForm.CloseFormEvent += () => Enabled = true;
            addUserLevelForm.Show();
            Enabled = false;
        }

        private void buttonAddUserLevelAccess_Click(object sender, EventArgs e)
        {
            var addFuncForm = new AddFuncForm();
            addFuncForm.CloseFormEvent += () => Enabled = true;
            addFuncForm.Show();
            Enabled = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
