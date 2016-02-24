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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_jogador_dois_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2jop form = new _2jop();
            form.Show();
            
        }

        private void b_jogador_um_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1jop form = new _1jop();
            form.Show();
        }

        private void b_creditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo feito por: Gonçalo Filipe nº5 2ºB e Hugo Palma nº6 2ºB", "BOMBERMAN - Creditos");
        }
    }
}
