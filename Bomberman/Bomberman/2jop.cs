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
    public partial class _2jop : Form
    {
        public _2jop()
        {
            InitializeComponent();
        }

        private void _2jop_Load(object sender, EventArgs e)
        {
            cb_map.Text = "DEFAULT - TEST";
            cb_player_1_model.Text = "DEFAULT - TEST";
            cb_player_2_model.Text = "DEFAULT - TEST";
            

            try
            {
                Image map_image = Properties.Resources.nomapselected;
                Image model_player_1_image = Properties.Resources.nomodelselected;
                Image model_player_2_image = Properties.Resources.nomodelselected;

                pb_map.Image = map_image;
                pb_player_1_model.Image = model_player_1_image;
                pb_player_2_model.Image = model_player_2_image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _2jop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cb_player_2_model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void b_start_Click(object sender, EventArgs e)
        {

        }

    }
}