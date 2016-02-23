using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class ingame : Form
    {
        public ingame()
        {
            InitializeComponent();
        }

        private void ingame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
