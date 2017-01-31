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
    public partial class ViewUserForm : Form
    {
        public event Action CloseForm;
        public ViewUserForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm?.Invoke();
            Close();
        }

        private void ViewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button is clicked!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button is clicked!");
            Close();
        }
    }
}
