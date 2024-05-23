namespace proyecto_pos
{
    partial class frm_menu_pincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelChildForm = new Panel();
            panelMenu = new Panel();
            panelReportes = new Panel();
            btnVentas = new Button();
            btnReportes = new Button();
            panelOperaciones = new Panel();
            btnCompras = new Button();
            button2 = new Button();
            btnOperaciones = new Button();
            panelCatalogo = new Panel();
            btnUsuarios = new Button();
            btnCatalogo = new Button();
            panelLogo = new Panel();
            btnSalir2 = new Button();
            panelChildForm.SuspendLayout();
            panelMenu.SuspendLayout();
            panelReportes.SuspendLayout();
            panelOperaciones.SuspendLayout();
            panelCatalogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(panelMenu);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(914, 656);
            panelChildForm.TabIndex = 2;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(245, 158, 0);
            panelMenu.Controls.Add(btnSalir2);
            panelMenu.Controls.Add(panelReportes);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(panelOperaciones);
            panelMenu.Controls.Add(btnOperaciones);
            panelMenu.Controls.Add(panelCatalogo);
            panelMenu.Controls.Add(btnCatalogo);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 656);
            panelMenu.TabIndex = 2;
            // 
            // panelReportes
            // 
            panelReportes.BackColor = Color.FromArgb(21, 19, 21);
            panelReportes.Controls.Add(btnVentas);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 296);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(250, 37);
            panelReportes.TabIndex = 8;
            panelReportes.Visible = false;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.FromArgb(238, 238, 238);
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(35, 0, 0, 1);
            btnVentas.Size = new Size(250, 30);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Location = new Point(0, 267);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 0, 0);
            btnReportes.Size = new Size(250, 29);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // panelOperaciones
            // 
            panelOperaciones.BackColor = Color.FromArgb(21, 19, 21);
            panelOperaciones.Controls.Add(btnCompras);
            panelOperaciones.Controls.Add(button2);
            panelOperaciones.Dock = DockStyle.Top;
            panelOperaciones.Location = new Point(0, 195);
            panelOperaciones.Name = "panelOperaciones";
            panelOperaciones.Size = new Size(250, 72);
            panelOperaciones.TabIndex = 6;
            panelOperaciones.Visible = false;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.ForeColor = Color.FromArgb(238, 238, 238);
            btnCompras.Location = new Point(0, 30);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(35, 0, 0, 0);
            btnCompras.Size = new Size(250, 30);
            btnCompras.TabIndex = 1;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(238, 238, 238);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 1);
            button2.Size = new Size(250, 30);
            button2.TabIndex = 0;
            button2.Text = "Ventas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btnOperaciones
            // 
            btnOperaciones.Dock = DockStyle.Top;
            btnOperaciones.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnOperaciones.FlatAppearance.BorderSize = 0;
            btnOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnOperaciones.FlatStyle = FlatStyle.Flat;
            btnOperaciones.Location = new Point(0, 166);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Padding = new Padding(10, 0, 0, 0);
            btnOperaciones.Size = new Size(250, 29);
            btnOperaciones.TabIndex = 5;
            btnOperaciones.Text = "Operaciones";
            btnOperaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click_1;
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = Color.FromArgb(21, 19, 21);
            panelCatalogo.Controls.Add(btnUsuarios);
            panelCatalogo.Dock = DockStyle.Top;
            panelCatalogo.Location = new Point(0, 129);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(250, 37);
            panelCatalogo.TabIndex = 4;
            panelCatalogo.Visible = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.FromArgb(238, 238, 238);
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(35, 0, 0, 1);
            btnUsuarios.Size = new Size(250, 30);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click_1;
            // 
            // btnCatalogo
            // 
            btnCatalogo.Dock = DockStyle.Top;
            btnCatalogo.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Location = new Point(0, 100);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Padding = new Padding(10, 0, 0, 0);
            btnCatalogo.Size = new Size(250, 29);
            btnCatalogo.TabIndex = 3;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // btnSalir2
            // 
            btnSalir2.Dock = DockStyle.Top;
            btnSalir2.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnSalir2.FlatAppearance.BorderSize = 0;
            btnSalir2.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnSalir2.FlatStyle = FlatStyle.Flat;
            btnSalir2.Location = new Point(0, 333);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Padding = new Padding(10, 0, 0, 0);
            btnSalir2.Size = new Size(250, 29);
            btnSalir2.TabIndex = 11;
            btnSalir2.Text = "Salir";
            btnSalir2.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir2.UseVisualStyleBackColor = true;
            // 
            // frm_menu_pincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 232, 231);
            ClientSize = new Size(914, 656);
            Controls.Add(panelChildForm);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frm_menu_pincipal";
            Text = "Menu Pincipal";
            WindowState = FormWindowState.Maximized;
            panelChildForm.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelOperaciones.ResumeLayout(false);
            panelCatalogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ventas().ShowDialog();
        }

        #endregion

        private Panel panelChildForm;
        private Panel panelMenu;
        private Panel panelReportes;
        private Button btnVentas;
        private Button btnReportes;
        private Panel panelOperaciones;
        private Button btnCompras;
        private Button button2;
        private Button btnOperaciones;
        private Panel panelCatalogo;
        private Button btnUsuarios;
        private Button btnCatalogo;
        private Panel panelLogo;
        private Button btnSalir2;
    }
}