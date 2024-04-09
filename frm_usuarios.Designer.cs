namespace proyecto_pos
{
    partial class frm_usuarios
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
            panel1 = new Panel();
            txtClave = new TextBox();
            cbActivo = new CheckBox();
            pictureBox2 = new PictureBox();
            txtTelefono = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cbPerfil = new ComboBox();
            label9 = new Label();
            dtRegistro = new DateTimePicker();
            btnBuscar = new Button();
            txtPassword = new TextBox();
            label8 = new Label();
            txtUsuario = new TextBox();
            label7 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtApellidoMaterno = new TextBox();
            label5 = new Label();
            txtApellidoPaterno = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 158, 0);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(cbActivo);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbPerfil);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dtRegistro);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtApellidoMaterno);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtApellidoPaterno);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 346);
            panel1.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Noto Sans", 12F);
            txtClave.Location = new Point(164, 40);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(157, 29);
            txtClave.TabIndex = 31;
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.Font = new Font("Noto Sans", 12F);
            cbActivo.Location = new Point(608, 230);
            cbActivo.Margin = new Padding(3, 2, 3, 2);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(152, 28);
            cbActivo.TabIndex = 30;
            cbActivo.Text = "Activo | Inactivo";
            cbActivo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(626, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 152);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Noto Sans", 12F);
            txtTelefono.Location = new Point(608, 259);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 29);
            txtTelefono.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label12.Location = new Point(519, 262);
            label12.Name = "label12";
            label12.Size = new Size(83, 24);
            label12.TabIndex = 25;
            label12.Text = "Telefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label11.Location = new Point(522, 232);
            label11.Name = "label11";
            label11.Size = new Size(75, 24);
            label11.TabIndex = 24;
            label11.Text = "Estatus:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label10.Location = new Point(539, 196);
            label10.Name = "label10";
            label10.Size = new Size(57, 24);
            label10.TabIndex = 23;
            label10.Text = "Perfil:";
            // 
            // cbPerfil
            // 
            cbPerfil.FormattingEnabled = true;
            cbPerfil.Items.AddRange(new object[] { "Admin", "Usuario" });
            cbPerfil.Location = new Point(608, 198);
            cbPerfil.Name = "cbPerfil";
            cbPerfil.Size = new Size(121, 23);
            cbPerfil.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label9.Location = new Point(435, 161);
            label9.Name = "label9";
            label9.Size = new Size(152, 24);
            label9.TabIndex = 21;
            label9.Text = "Fecha de registro:";
            // 
            // dtRegistro
            // 
            dtRegistro.Location = new Point(608, 162);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(218, 23);
            dtRegistro.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Font = new Font("Noto Sans", 12F);
            btnBuscar.Image = Properties.Resources.lupa;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(327, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Noto Sans", 12F);
            txtPassword.Location = new Point(164, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 29);
            txtPassword.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label8.Location = new Point(49, 266);
            label8.Name = "label8";
            label8.Size = new Size(108, 24);
            label8.TabIndex = 17;
            label8.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Noto Sans", 12F);
            txtUsuario.Location = new Point(164, 229);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(157, 29);
            txtUsuario.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label7.Location = new Point(80, 232);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 15;
            label7.Text = "Usuario:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Noto Sans", 12F);
            txtCorreo.Location = new Point(164, 193);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(157, 29);
            txtCorreo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label6.Location = new Point(90, 196);
            label6.Name = "label6";
            label6.Size = new Size(68, 24);
            label6.TabIndex = 13;
            label6.Text = "Correo:";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Noto Sans", 12F);
            txtApellidoMaterno.Location = new Point(164, 158);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(157, 29);
            txtApellidoMaterno.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label5.Location = new Point(4, 161);
            label5.Name = "label5";
            label5.Size = new Size(154, 24);
            label5.TabIndex = 11;
            label5.Text = "Apellido materno:";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Noto Sans", 12F);
            txtApellidoPaterno.Location = new Point(164, 123);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(157, 29);
            txtApellidoPaterno.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label4.Location = new Point(10, 126);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 9;
            label4.Text = "Apellido paterno:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Noto Sans", 12F);
            txtNombre.Location = new Point(164, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 29);
            txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label2.Location = new Point(64, 91);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label1.Location = new Point(86, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 24);
            label1.TabIndex = 5;
            label1.Text = "Clave:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.informacion;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 28);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 10;
            label3.Text = "Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Noto Sans", 12F);
            btnGuardar.Image = Properties.Resources.guardar_el_archivo;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(483, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImageLayout = ImageLayout.None;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Noto Sans", 12F);
            btnActualizar.Image = Properties.Resources.actualizar__2_;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(609, 455);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 39);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImageLayout = ImageLayout.None;
            btnCerrar.Font = new Font("Noto Sans", 12F);
            btnCerrar.Image = Properties.Resources.salida;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(735, 455);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 39);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label13.Location = new Point(12, 462);
            label13.Name = "label13";
            label13.Size = new Size(165, 24);
            label13.TabIndex = 29;
            label13.Text = "Etiqueta de estatus";
            // 
            // frm_usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 232, 231);
            ClientSize = new Size(867, 506);
            Controls.Add(label13);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "frm_usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo de usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtUsuario;
        private Label label7;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtApellidoMaterno;
        private Label label5;
        private TextBox txtApellidoPaterno;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Label label9;
        private DateTimePicker dtRegistro;
        private Button btnBuscar;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cbPerfil;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnCerrar;
        private PictureBox pictureBox2;
        private Label label13;
        private CheckBox cbActivo;
        private TextBox txtClave;
    }
}