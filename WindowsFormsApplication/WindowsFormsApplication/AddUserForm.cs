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
    public partial class AddUserForm : Form
    {
        public event Action CloseForm;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm?.Invoke();
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button ADD is clicked");
            Clear();
        }

        private void Clear()
        {
            
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof (TextBox))
                {
                    item.ResetText();
                }
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke();
        }
    }
}
