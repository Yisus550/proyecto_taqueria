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
    public partial class frm_usuarios : Form
    {
        Usuario usuario = new Usuario();
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.setNombre(txtNombre.Text);
            usuario.setApellidoPaterno(txtApellidoPaterno.Text);
            usuario.setApellidoMaterno(txtApellidoMaterno.Text);
            usuario.setCorreo(txtCorreo.Text);
            usuario.setUsuario(txtUsuario.Text);
            usuario.setPassword(txtPassword.Text);
            usuario.setFechaRegistro(dtRegistro.Value);
            usuario.setPerfil(cbPerfil.Text);
            if (cbActivo.Checked)
            {
                usuario.setEstado(1);
            }
            else
            {
                usuario.setEstado(0);
            }
            usuario.setTelefono(txtTelefono.Text);

            int numRegistros = usuario.insertarUsuario();
            if (numRegistros > 0)
            {
                MessageBox.Show("Usuario guardado exitosamente.");
                txtNombre.ResetText();
                txtApellidoPaterno.ResetText();
                txtApellidoMaterno.ResetText();
                txtCorreo.ResetText();
                txtUsuario.ResetText();
                txtPassword.ResetText();
                dtRegistro.ResetText();
                cbPerfil.ResetText();
                cbActivo.Checked = false;
                txtTelefono.ResetText();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            usuario.setClave(Convert.ToInt32(txtClave.Text));
            usuario.buscarClave();

            txtNombre.Text = usuario.getNombre();
            txtApellidoPaterno.Text = usuario.getApellidoPaterno();
            txtApellidoMaterno.Text = usuario.getApellidoMaterno();
            txtCorreo.Text = usuario.getCorreo();
            txtUsuario.Text = usuario.getUsuario();
            txtPassword.Text = usuario.getPasswprd();
            dtRegistro.Value = Convert.ToDateTime(usuario.getFechaRegistro());
            cbPerfil.Text = usuario.getPerfil();
            if (usuario.getEstado() == 1)
            {
                cbActivo.Checked = true;
            }
            else
            {
                cbActivo.Checked = false;
            }
            txtTelefono.Text = usuario.getTelefono();

            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.setClave(Convert.ToInt32(txtClave.Text));
            usuario.setNombre(txtNombre.Text);
            usuario.setApellidoPaterno(txtApellidoPaterno.Text);
            usuario.setApellidoMaterno(txtApellidoMaterno.Text);
            usuario.setCorreo(txtCorreo.Text);
            usuario.setUsuario(txtUsuario.Text);
            usuario.setPassword(txtPassword.Text);
            usuario.setFechaRegistro(dtRegistro.Value);
            usuario.setPerfil(cbPerfil.Text);
            if (cbActivo.Checked)
            {
                usuario.setEstado(1);
            }
            else
            {
                usuario.setEstado(0);
            }
            usuario.setTelefono(txtTelefono.Text);

            int rows = usuario.actualizarUsuario();
            if (rows > 0)
            {
                txtClave.ResetText();
                txtNombre.ResetText();
                txtApellidoPaterno.ResetText();
                txtApellidoMaterno.ResetText();
                txtCorreo.ResetText();
                txtUsuario.ResetText();
                txtPassword.ResetText();
                dtRegistro.ResetText();
                cbPerfil.ResetText();
                cbActivo.Checked = false;
                txtTelefono.ResetText();

                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;

                MessageBox.Show("Usuario actualizado exitosamente.", "Usuario actualizado");
            }
        }
    }
}
