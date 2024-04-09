namespace proyecto_pos
{
    public partial class frm_login : Form
    {
        Usuario usuario = new Usuario();
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario.setUsuario(txtUsuario.Text);
            usuario.setPassword(txtPassword.Text);
            if (usuario.buscarUsuario() <= 0)
            {
                panelError.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
