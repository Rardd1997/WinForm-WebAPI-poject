using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class ForgotPasswordForm : Form
    {
        public event Action CloseFormEvent;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button SUBMIT is clicked");
            CloseFormEvent?.Invoke();
            Close();
        }

        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseFormEvent?.Invoke();
        }
    }
}
