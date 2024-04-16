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
            perfilesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            productosToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(245, 158, 0);
            menuStrip1.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoMenuItem, catalogosMenuItem, operacionesMenuItem, reportesMenuItem, configuracionesMenuItem, salirMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenuItem
            // 
            archivoMenuItem.DropDownItems.AddRange(new ToolStripItem[] { correoMenuItem, salirMenuItem2 });
            archivoMenuItem.Name = "archivoMenuItem";
            archivoMenuItem.Size = new Size(86, 30);
            archivoMenuItem.Text = "Archivo";
            // 
            // correoMenuItem
            // 
            correoMenuItem.Name = "correoMenuItem";
            correoMenuItem.Size = new Size(153, 30);
            correoMenuItem.Text = "Correo";
            // 
            // salirMenuItem2
            // 
            salirMenuItem2.Name = "salirMenuItem2";
            salirMenuItem2.Size = new Size(153, 30);
            salirMenuItem2.Text = "Salir";
            // 
            // catalogosMenuItem
            // 
            catalogosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, perfilesToolStripMenuItem, toolStripSeparator1, productosToolStripMenuItem });
            catalogosMenuItem.Name = "catalogosMenuItem";
            catalogosMenuItem.Size = new Size(105, 30);
            catalogosMenuItem.Text = "Catalogos";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(178, 30);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // perfilesToolStripMenuItem
            // 
            perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            perfilesToolStripMenuItem.Size = new Size(178, 30);
            perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(175, 6);
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(178, 30);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // operacionesMenuItem
            // 
            operacionesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, toolStripSeparator4, comprasToolStripMenuItem, toolStripSeparator3, inventarioToolStripMenuItem });
            operacionesMenuItem.Name = "operacionesMenuItem";
            operacionesMenuItem.Size = new Size(127, 30);
            operacionesMenuItem.Text = "Operaciones";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(224, 30);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(224, 30);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(224, 30);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // reportesMenuItem
            // 
            reportesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem1 });
            reportesMenuItem.Name = "reportesMenuItem";
            reportesMenuItem.Size = new Size(98, 30);
            reportesMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(153, 30);
            ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // configuracionesMenuItem
            // 
            configuracionesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impresoraToolStripMenuItem, cambiarContraseñaToolStripMenuItem });
            configuracionesMenuItem.Name = "configuracionesMenuItem";
            configuracionesMenuItem.Size = new Size(157, 30);
            configuracionesMenuItem.Text = "Configuraciones";
            // 
            // impresoraToolStripMenuItem
            // 
            impresoraToolStripMenuItem.Name = "impresoraToolStripMenuItem";
            impresoraToolStripMenuItem.Size = new Size(261, 30);
            impresoraToolStripMenuItem.Text = "Impresora";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(261, 30);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // salirMenuItem
            // 
            salirMenuItem.Name = "salirMenuItem";
            salirMenuItem.Size = new Size(60, 30);
            salirMenuItem.Text = "Salir";
            salirMenuItem.Click += salirMenuItem_Click;
            // 
            // frm_menu_pincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 232, 231);
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_menu_pincipal";
            Text = "Menu Pincipal";
            WindowState = FormWindowState.Maximized;
            Load += frm_menu_pincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem perfilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem1;
        private ToolStripMenuItem impresoraToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}