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
            menuStrip1 = new MenuStrip();
            archivoMenuItem = new ToolStripMenuItem();
            correoMenuItem = new ToolStripMenuItem();
            salirMenuItem2 = new ToolStripMenuItem();
            catalogosMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            operacionesMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            reportesMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem1 = new ToolStripMenuItem();
            configuracionesMenuItem = new ToolStripMenuItem();
            impresoraToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            salirMenuItem = new ToolStripMenuItem();
            panelMenu = new Panel();
            btnSalir2 = new Button();
            panelConfiguraciones = new Panel();
            btnCambiarContra = new Button();
            btnImpresora = new Button();
            btnConfiguraciones = new Button();
            panelReportes = new Panel();
            btnVentas = new Button();
            btnReportes = new Button();
            panelOperaciones = new Panel();
            btnInventario = new Button();
            btnCompras = new Button();
            button2 = new Button();
            btnOperaciones = new Button();
            panelCatalogo = new Panel();
            btnUsuarios = new Button();
            btnCatalogo = new Button();
            panelArchivo = new Panel();
            btnSalir = new Button();
            btnCorreo = new Button();
            btnArchivo = new Button();
            panelLogo = new Panel();
            menuStrip1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelConfiguraciones.SuspendLayout();
            panelReportes.SuspendLayout();
            panelOperaciones.SuspendLayout();
            panelCatalogo.SuspendLayout();
            panelArchivo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(245, 158, 0);
            menuStrip1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoMenuItem, catalogosMenuItem, operacionesMenuItem, reportesMenuItem, configuracionesMenuItem, salirMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenuItem
            // 
            archivoMenuItem.DropDownItems.AddRange(new ToolStripItem[] { correoMenuItem, salirMenuItem2 });
            archivoMenuItem.Name = "archivoMenuItem";
            archivoMenuItem.Size = new Size(79, 24);
            archivoMenuItem.Text = "Archivo";
            // 
            // correoMenuItem
            // 
            correoMenuItem.Name = "correoMenuItem";
            correoMenuItem.Size = new Size(143, 26);
            correoMenuItem.Text = "Correo";
            // 
            // salirMenuItem2
            // 
            salirMenuItem2.Name = "salirMenuItem2";
            salirMenuItem2.Size = new Size(143, 26);
            salirMenuItem2.Text = "Salir";
            salirMenuItem2.Click += salirMenuItem2_Click;
            // 
            // catalogosMenuItem
            // 
            catalogosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem });
            catalogosMenuItem.Name = "catalogosMenuItem";
            catalogosMenuItem.Size = new Size(98, 24);
            catalogosMenuItem.Text = "Catalogos";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(159, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // operacionesMenuItem
            // 
            operacionesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, toolStripSeparator4, comprasToolStripMenuItem, toolStripSeparator3, inventarioToolStripMenuItem });
            operacionesMenuItem.Name = "operacionesMenuItem";
            operacionesMenuItem.Size = new Size(118, 24);
            operacionesMenuItem.Text = "Operaciones";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(164, 26);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += VentasToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(161, 6);
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(164, 26);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(161, 6);
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(164, 26);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // reportesMenuItem
            // 
            reportesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem1 });
            reportesMenuItem.Name = "reportesMenuItem";
            reportesMenuItem.Size = new Size(91, 24);
            reportesMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(144, 26);
            ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // configuracionesMenuItem
            // 
            configuracionesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impresoraToolStripMenuItem, cambiarContraseñaToolStripMenuItem });
            configuracionesMenuItem.Name = "configuracionesMenuItem";
            configuracionesMenuItem.Size = new Size(144, 24);
            configuracionesMenuItem.Text = "Configuraciones";
            // 
            // impresoraToolStripMenuItem
            // 
            impresoraToolStripMenuItem.Name = "impresoraToolStripMenuItem";
            impresoraToolStripMenuItem.Size = new Size(243, 26);
            impresoraToolStripMenuItem.Text = "Impresora";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(243, 26);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // salirMenuItem
            // 
            salirMenuItem.Name = "salirMenuItem";
            salirMenuItem.Size = new Size(57, 24);
            salirMenuItem.Text = "Salir";
            salirMenuItem.Click += salirMenuItem_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(245, 158, 0);
            panelMenu.Controls.Add(btnSalir2);
            panelMenu.Controls.Add(panelConfiguraciones);
            panelMenu.Controls.Add(btnConfiguraciones);
            panelMenu.Controls.Add(panelReportes);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(panelOperaciones);
            panelMenu.Controls.Add(btnOperaciones);
            panelMenu.Controls.Add(panelCatalogo);
            panelMenu.Controls.Add(btnCatalogo);
            panelMenu.Controls.Add(panelArchivo);
            panelMenu.Controls.Add(btnArchivo);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 30);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 626);
            panelMenu.TabIndex = 1;
            // 
            // btnSalir2
            // 
            btnSalir2.Dock = DockStyle.Top;
            btnSalir2.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnSalir2.FlatAppearance.BorderSize = 0;
            btnSalir2.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnSalir2.FlatStyle = FlatStyle.Flat;
            btnSalir2.Location = new Point(0, 553);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Padding = new Padding(10, 0, 0, 0);
            btnSalir2.Size = new Size(250, 29);
            btnSalir2.TabIndex = 11;
            btnSalir2.Text = "Salir";
            btnSalir2.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir2.UseVisualStyleBackColor = true;
            btnSalir2.Click += btnSalir2_Click;
            // 
            // panelConfiguraciones
            // 
            panelConfiguraciones.BackColor = Color.FromArgb(21, 19, 21);
            panelConfiguraciones.Controls.Add(btnCambiarContra);
            panelConfiguraciones.Controls.Add(btnImpresora);
            panelConfiguraciones.Dock = DockStyle.Top;
            panelConfiguraciones.Location = new Point(0, 486);
            panelConfiguraciones.Name = "panelConfiguraciones";
            panelConfiguraciones.Size = new Size(250, 67);
            panelConfiguraciones.TabIndex = 10;
            panelConfiguraciones.Visible = false;
            // 
            // btnCambiarContra
            // 
            btnCambiarContra.Dock = DockStyle.Top;
            btnCambiarContra.FlatAppearance.BorderSize = 0;
            btnCambiarContra.FlatStyle = FlatStyle.Flat;
            btnCambiarContra.ForeColor = Color.FromArgb(238, 238, 238);
            btnCambiarContra.Location = new Point(0, 30);
            btnCambiarContra.Name = "btnCambiarContra";
            btnCambiarContra.Padding = new Padding(35, 0, 0, 0);
            btnCambiarContra.Size = new Size(250, 30);
            btnCambiarContra.TabIndex = 1;
            btnCambiarContra.Text = "Cambiar contraseña";
            btnCambiarContra.TextAlign = ContentAlignment.MiddleLeft;
            btnCambiarContra.UseVisualStyleBackColor = true;
            btnCambiarContra.Click += btnCambiarContra_Click;
            // 
            // btnImpresora
            // 
            btnImpresora.Dock = DockStyle.Top;
            btnImpresora.FlatAppearance.BorderSize = 0;
            btnImpresora.FlatStyle = FlatStyle.Flat;
            btnImpresora.ForeColor = Color.FromArgb(238, 238, 238);
            btnImpresora.Location = new Point(0, 0);
            btnImpresora.Name = "btnImpresora";
            btnImpresora.Padding = new Padding(35, 0, 0, 1);
            btnImpresora.Size = new Size(250, 30);
            btnImpresora.TabIndex = 0;
            btnImpresora.Text = "Impresora";
            btnImpresora.TextAlign = ContentAlignment.MiddleLeft;
            btnImpresora.UseVisualStyleBackColor = true;
            btnImpresora.Click += btnImpresora_Click;
            // 
            // btnConfiguraciones
            // 
            btnConfiguraciones.Dock = DockStyle.Top;
            btnConfiguraciones.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnConfiguraciones.FlatAppearance.BorderSize = 0;
            btnConfiguraciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnConfiguraciones.FlatStyle = FlatStyle.Flat;
            btnConfiguraciones.Location = new Point(0, 457);
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.Padding = new Padding(10, 0, 0, 0);
            btnConfiguraciones.Size = new Size(250, 29);
            btnConfiguraciones.TabIndex = 9;
            btnConfiguraciones.Text = "Configuraciones";
            btnConfiguraciones.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguraciones.UseVisualStyleBackColor = true;
            btnConfiguraciones.Click += btnConfiguraciones_Click;
            // 
            // panelReportes
            // 
            panelReportes.BackColor = Color.FromArgb(21, 19, 21);
            panelReportes.Controls.Add(btnVentas);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 420);
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
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Location = new Point(0, 391);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 0, 0);
            btnReportes.Size = new Size(250, 29);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelOperaciones
            // 
            panelOperaciones.BackColor = Color.FromArgb(21, 19, 21);
            panelOperaciones.Controls.Add(btnInventario);
            panelOperaciones.Controls.Add(btnCompras);
            panelOperaciones.Controls.Add(button2);
            panelOperaciones.Dock = DockStyle.Top;
            panelOperaciones.Location = new Point(0, 291);
            panelOperaciones.Name = "panelOperaciones";
            panelOperaciones.Size = new Size(250, 100);
            panelOperaciones.TabIndex = 6;
            panelOperaciones.Visible = false;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.FromArgb(238, 238, 238);
            btnInventario.Location = new Point(0, 60);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(35, 0, 0, 0);
            btnInventario.Size = new Size(250, 30);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
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
            btnCompras.Click += btnCompras_Click;
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
            button2.Click += button2_Click;
            // 
            // btnOperaciones
            // 
            btnOperaciones.Dock = DockStyle.Top;
            btnOperaciones.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnOperaciones.FlatAppearance.BorderSize = 0;
            btnOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnOperaciones.FlatStyle = FlatStyle.Flat;
            btnOperaciones.Location = new Point(0, 262);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Padding = new Padding(10, 0, 0, 0);
            btnOperaciones.Size = new Size(250, 29);
            btnOperaciones.TabIndex = 5;
            btnOperaciones.Text = "Operaciones";
            btnOperaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = Color.FromArgb(21, 19, 21);
            panelCatalogo.Controls.Add(btnUsuarios);
            panelCatalogo.Dock = DockStyle.Top;
            panelCatalogo.Location = new Point(0, 225);
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
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.Dock = DockStyle.Top;
            btnCatalogo.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Location = new Point(0, 196);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Padding = new Padding(10, 0, 0, 0);
            btnCatalogo.Size = new Size(250, 29);
            btnCatalogo.TabIndex = 3;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // panelArchivo
            // 
            panelArchivo.BackColor = Color.FromArgb(21, 19, 21);
            panelArchivo.Controls.Add(btnSalir);
            panelArchivo.Controls.Add(btnCorreo);
            panelArchivo.Dock = DockStyle.Top;
            panelArchivo.Location = new Point(0, 129);
            panelArchivo.Name = "panelArchivo";
            panelArchivo.Size = new Size(250, 67);
            panelArchivo.TabIndex = 2;
            panelArchivo.Visible = false;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(238, 238, 238);
            btnSalir.Location = new Point(0, 30);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(35, 0, 0, 0);
            btnSalir.Size = new Size(250, 30);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCorreo
            // 
            btnCorreo.Dock = DockStyle.Top;
            btnCorreo.FlatAppearance.BorderSize = 0;
            btnCorreo.FlatStyle = FlatStyle.Flat;
            btnCorreo.ForeColor = Color.FromArgb(238, 238, 238);
            btnCorreo.Location = new Point(0, 0);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Padding = new Padding(35, 0, 0, 1);
            btnCorreo.Size = new Size(250, 30);
            btnCorreo.TabIndex = 0;
            btnCorreo.Text = "Correo";
            btnCorreo.TextAlign = ContentAlignment.MiddleLeft;
            btnCorreo.UseVisualStyleBackColor = true;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.Dock = DockStyle.Top;
            btnArchivo.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            btnArchivo.FlatAppearance.BorderSize = 0;
            btnArchivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 125, 0);
            btnArchivo.FlatStyle = FlatStyle.Flat;
            btnArchivo.Location = new Point(0, 100);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Padding = new Padding(10, 0, 0, 0);
            btnArchivo.Size = new Size(250, 29);
            btnArchivo.TabIndex = 1;
            btnArchivo.Text = "Archivo";
            btnArchivo.TextAlign = ContentAlignment.MiddleLeft;
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // frm_menu_pincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 232, 231);
            ClientSize = new Size(914, 656);
            Controls.Add(panelMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frm_menu_pincipal";
            Text = "Menu Pincipal";
            WindowState = FormWindowState.Maximized;
            Load += frm_menu_pincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelConfiguraciones.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelOperaciones.ResumeLayout(false);
            panelCatalogo.ResumeLayout(false);
            panelArchivo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ventas().ShowDialog();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoMenuItem;
        private ToolStripMenuItem catalogosMenuItem;
        private ToolStripMenuItem operacionesMenuItem;
        private ToolStripMenuItem reportesMenuItem;
        private ToolStripMenuItem configuracionesMenuItem;
        private ToolStripMenuItem salirMenuItem;
        private ToolStripMenuItem correoMenuItem;
        private ToolStripMenuItem salirMenuItem2;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem1;
        private ToolStripMenuItem impresoraToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelArchivo;
        private Button btnArchivo;
        private Button btnSalir;
        private Button btnCorreo;
        private Panel panelOperaciones;
        private Button btnCompras;
        private Button button2;
        private Button btnOperaciones;
        private Panel panelCatalogo;
        private Button btnUsuarios;
        private Button btnCatalogo;
        private Button btnInventario;
        private Panel panelConfiguraciones;
        private Button btnCambiarContra;
        private Button btnImpresora;
        private Button btnConfiguraciones;
        private Panel panelReportes;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnSalir2;
    }
}