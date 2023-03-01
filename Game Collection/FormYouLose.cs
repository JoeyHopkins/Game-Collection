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
    public partial class FormYouLose : Form
    {
        public FormYouLose()
        {
            InitializeComponent();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            FormCertainQuit AreYouSure = new FormCertainQuit();
            DialogResult result = AreYouSure.ShowDialog();

            if (result == DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void ButtonRetry_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
