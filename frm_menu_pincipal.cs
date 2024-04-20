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
    public partial class frm_menu_pincipal : Form
    {
        public frm_menu_pincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_usuarios().ShowDialog();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_menu_pincipal_Load(object sender, EventArgs e)
        {
            new frm_login().ShowDialog();
        }

        //<<<<<<< HEAD
        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_compras().ShowDialog();

        }
    } }
