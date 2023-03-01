using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Collection
{
    public partial class FormCertainQuit : Form
    {
        public FormCertainQuit()
        {
            InitializeComponent();
        }

        private void ButtonYesCertainQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void ButtonNoCertainQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
