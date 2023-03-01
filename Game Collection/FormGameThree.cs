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
    public partial class FormGameThree : Form
    {
        public FormGameThree()
        {
            InitializeComponent();
        }

        private void KeyReleased(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FormPauseMenu Pause = new FormPauseMenu();
                    DialogResult result = Pause.ShowDialog();

                    if (result == DialogResult.Abort)
                    {
                        Close();
                    }

                    break;
            }
        }
    }
}
