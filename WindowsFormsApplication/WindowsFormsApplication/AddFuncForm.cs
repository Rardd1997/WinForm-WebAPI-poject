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
    public partial class AddFuncForm : Form
    {
        public event Action CloseFormEvent;
        public AddFuncForm()
        {
            InitializeComponent();
        }

        private void AddFuncForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseFormEvent?.Invoke();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button ADD is clicked");
            Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseFormEvent?.Invoke();
            Close();
        }

        private void Clear()
        {
            foreach (var item in Controls.Cast<Control>().Where(item => item.GetType() == typeof(TextBox)))
            {
                item.ResetText();
            }
        }
    }
}
