namespace proyecto_pos
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            labelDate = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelError = new Panel();
            label5 = new Label();
            btnSalir = new Button();
            btnIngresar = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelError.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 158, 0);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 224);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelDate);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(697, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 224);
            panel5.TabIndex = 12;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Microsoft Sans Serif", 9F);
            labelDate.Location = new Point(68, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(100, 18);
            labelDate.TabIndex = 10;
            labelDate.Text = "DD/MM/AAAA";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(228, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 224);
            panel4.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F);
            label3.Location = new Point(18, 89);
            label3.Name = "label3";
            label3.Size = new Size(437, 46);
            label3.TabIndex = 8;
            label3.Text = "Sistema punto de venta";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 224);
            panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.desconocido;
            pictureBox1.Location = new Point(50, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 171);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelError);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnIngresar);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 376);
            panel2.TabIndex = 1;
            // 
            // panelError
            // 
            panelError.BackColor = Color.FromArgb(213, 43, 30);
            panelError.Controls.Add(label5);
            panelError.Location = new Point(0, 201);
            panelError.Margin = new Padding(3, 4, 3, 4);
            panelError.Name = "panelError";
            panelError.Size = new Size(915, 37);
            panelError.TabIndex = 17;
            panelError.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(213, 43, 30);
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(310, 3);
            label5.Name = "label5";
            label5.Size = new Size(347, 25);
            label5.TabIndex = 8;
            label5.Text = "Usuario y/o contraseña incorrectos";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Image = Properties.Resources.salida;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(490, 261);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(153, 59);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Image = Properties.Resources.ingresar;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(282, 261);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(153, 59);
            btnIngresar.TabIndex = 15;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(464, 143);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 30);
            txtPassword.TabIndex = 14;
            txtPassword.Text = "admin123";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.Location = new Point(464, 57);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 30);
            txtUsuario.TabIndex = 13;
            txtUsuario.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label2.Location = new Point(293, 143);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 12;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label1.Location = new Point(331, 57);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 11;
            label1.Text = "Usuario:";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 232, 231);
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            Load += frm_login_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelError.ResumeLayout(false);
            panelError.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelError;
        private Label label5;
        private Button btnSalir;
        private Button btnIngresar;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Label labelDate;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
