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
    public partial class FormPauseMenu : Form
    {
        public FormPauseMenu()
        {
            InitializeComponent();
        }

        private void ContinuePauseMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuitPauseMenu_Click(object sender, EventArgs e)
        {
            FormCertainQuit AreYouSure = new FormCertainQuit();
            DialogResult result = AreYouSure.ShowDialog();

            if(result == DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}
