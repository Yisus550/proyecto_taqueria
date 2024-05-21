using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_pos
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            pnl_bebidas.Visible = false;
            btn_tacos.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_bebidas_Click(object sender, EventArgs e)
        {
            pnl_tacos.Visible = false;
            pnl_bebidas.Visible = true;
        }

        private void btn_tacos_Click(object sender, EventArgs e)
        {
            pnl_bebidas.Visible = false;
            pnl_tacos.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BEBIDAS
            num_coca.Value = 0;
            num_fre.Value = 0;
            num_jam.Value = 0;
            num_lim.Value = 0;
            num_horchata.Value = 0;
            num_man.Value = 0;

            //TACOS
            num_barbacoa.Value = 0;
            num_burritos.Value = 0;
            num_cabeza.Value = 0;
            num_carnitas.Value = 0;
            num_dorados.Value = 0;
            num_pastor.Value = 0;
        }
    }
}
