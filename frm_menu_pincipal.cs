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
            openChildForm(new frm_login());
        }

        public static Form MainForm { get; set; }

        private static Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            if (panelCatalogo.Visible == true)
                panelCatalogo.Visible = false;
            if (panelOperaciones.Visible == true)
                panelOperaciones.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
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

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frm_usuarios());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frm_ventas());
        }

        private void btnCompras_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frm_compras());
        }

        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            if (panelCatalogo.Visible)
            {
                panelCatalogo.Visible = false;
            }
            else
            {
                panelCatalogo.Visible = true;
            }
        }

        private void btnOperaciones_Click_1(object sender, EventArgs e)
        {
            if (panelOperaciones.Visible)
            {
                panelOperaciones.Visible = false;
            }
            else
            {
                panelOperaciones.Visible = true;
            }
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            if (panelReportes.Visible)
            {
                panelReportes.Visible = false;
            }
            else
            {
                panelReportes.Visible = true;
            }
        }

        private void btnConfiguraciones_Click_1(object sender, EventArgs e)
        {

        }
    }
}
