using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bomberman
{
    public partial class _1jop : Form
    {
        public _1jop()
        {
            InitializeComponent();
        }

        private void _1jop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void b_back_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void _1jop_Load(object sender, EventArgs e)
        {
            cb_map.Text = "DEFAULT - TEST";
            cb_player_model.Text = "DEFAULT - TEST";
            cb_bot_model.Text = "DEFAULT - TEST";

            try{
                Image map_image = Properties.Resources.nomapselected;
                Image model_player_image = Properties.Resources.nomodelselected;
                Image model_bot_image = Properties.Resources.nomodelselected;

                pb_map.Image = map_image;
                pb_player_model.Image = model_player_image;
                pb_bot_model.Image = model_bot_image;
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                }

        }

        private void cb_map_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_map_Click(object sender, EventArgs e)
        {

        }
    }
}
