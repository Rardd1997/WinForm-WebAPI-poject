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
    public partial class ViewUserLevelForm : Form
    {
        public event Action CloseFormEvent;
        public ViewUserLevelForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseFormEvent?.Invoke();
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button SAVE is clicked");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button DELETE is clicked");
            CloseFormEvent?.Invoke();
            Close();
        }

        private void ViewUserLevelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseFormEvent?.Invoke();
        }

    }
}
