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

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_compras().ShowDialog();

        }

        private void salirMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            Application.Exit();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            new frm_usuarios().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            new frm_ventas().ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            new frm_compras().ShowDialog();
        }

        private void hideSubmenus()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelCatalogo.Visible == true)
                panelCatalogo.Visible = false;
            if (panelOperaciones.Visible == true)
                panelOperaciones.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelConfiguraciones.Visible == true)
                panelConfiguraciones.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelArchivo);
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            /*
             Instructions . . .
             */
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCatalogo);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            showSubmenu(panelOperaciones);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            /*
             Instructions . . .
             */
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubmenu(panelReportes);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            /*
             Instructions . . .
             */
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            showSubmenu(panelConfiguraciones);
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            /*
             Instructions . . .
             */
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            /*
             Instructions . . .
             */
        }
    }
}
