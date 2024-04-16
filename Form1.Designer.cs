namespace proyecto_pos
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            num_barbacoa = new NumericUpDown();
            num_pastor = new NumericUpDown();
            num_dorados = new NumericUpDown();
            num_cabeza = new NumericUpDown();
            num_burritos = new NumericUpDown();
            num_carnitas = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_barbacoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_pastor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_dorados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_cabeza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_burritos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_carnitas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 158, 0);
            panel1.Controls.Add(num_carnitas);
            panel1.Controls.Add(num_burritos);
            panel1.Controls.Add(num_cabeza);
            panel1.Controls.Add(num_dorados);
            panel1.Controls.Add(num_pastor);
            panel1.Controls.Add(num_barbacoa);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 548);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold);
            label1.Location = new Point(283, 37);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 0;
            label1.Text = "MENU DE VENTA";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BARBACOA_modified;
            pictureBox1.Location = new Point(27, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CANASTA_modified;
            pictureBox2.Location = new Point(402, 223);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PASTOR_modified;
            pictureBox4.Location = new Point(402, 46);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.CARNITAS_modified;
            pictureBox5.Location = new Point(27, 223);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.BURRITOS_modified;
            pictureBox3.Location = new Point(402, 398);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.DORADOS_modified;
            pictureBox6.Location = new Point(27, 398);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 120);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(173, 19);
            label2.TabIndex = 7;
            label2.Text = "TACOS DE BARBACOA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label3.Location = new Point(390, 14);
            label3.Name = "label3";
            label3.Size = new Size(148, 19);
            label3.TabIndex = 8;
            label3.Text = "TACOS DE PASTOR";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label5.Location = new Point(419, 366);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 10;
            label5.Text = "BURRITOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label6.Location = new Point(380, 201);
            label6.Name = "label6";
            label6.Size = new Size(165, 19);
            label6.TabIndex = 11;
            label6.Text = "TACOS DE CARNITAS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label7.Location = new Point(17, 366);
            label7.Name = "label7";
            label7.Size = new Size(142, 19);
            label7.TabIndex = 12;
            label7.Text = "TACOS DORADOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label8.Location = new Point(15, 201);
            label8.Name = "label8";
            label8.Size = new Size(147, 19);
            label8.TabIndex = 13;
            label8.Text = "TACOS DE CABEZA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(527, 57);
            label9.Name = "label9";
            label9.Size = new Size(149, 100);
            label9.TabIndex = 14;
            label9.Text = "TRONPO HECHO\r\nCON BISTEC DE\r\nPUERCO Y ADOBO. \r\nSE LE AÑADE PIÑA\r\n Y CILANTRO.";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(527, 232);
            label10.Name = "label10";
            label10.Size = new Size(161, 100);
            label10.TabIndex = 15;
            label10.Text = "PUEDEN SER \r\nDE SUADERO,\r\nCUERITO, TRIPA. \r\nSON LOS MAS\r\nPEDIDOS DEL LOCAL.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(153, 398);
            label11.Name = "label11";
            label11.Size = new Size(154, 120);
            label11.TabIndex = 16;
            label11.Text = "TORTILLA GRANDE \r\nFRITA, RELLENA DE\r\nRES O POLLO.  SE \r\nACOMPAÑAN CON \r\nLECHUGA, QUESO,\r\nCREMA Y SALSA.";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(528, 409);
            label12.Name = "label12";
            label12.Size = new Size(194, 80);
            label12.TabIndex = 17;
            label12.Text = "TRADICIONALMENTE \r\nSON DE CHICHARRON \r\nY FRIOLES. SE PUEDEN\r\nPEDIR CON OTRA CARNE.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(152, 232);
            label13.Name = "label13";
            label13.Size = new Size(172, 100);
            label13.TabIndex = 18;
            label13.Text = "TORTILLA DE MAIZ \r\nCON CARNE DE RES, \r\nCOCIDA AL VAPOR,\r\nSE AGREGA CILANTRO\r\nY CEBOLLA.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(153, 46);
            label14.Name = "label14";
            label14.Size = new Size(160, 120);
            label14.TabIndex = 19;
            label14.Text = "TORTILLA DE MAIZ \r\nCON CARNE DE RES, \r\nGUISADA EN SALSA \r\nDE LA CASA. SE \r\nAGREGA CILANTRO\r\nY CEBOLLA.";
            // 
            // num_barbacoa
            // 
            num_barbacoa.Location = new Point(333, 139);
            num_barbacoa.Name = "num_barbacoa";
            num_barbacoa.Size = new Size(44, 27);
            num_barbacoa.TabIndex = 20;
            // 
            // num_pastor
            // 
            num_pastor.Location = new Point(729, 130);
            num_pastor.Name = "num_pastor";
            num_pastor.Size = new Size(44, 27);
            num_pastor.TabIndex = 21;
            // 
            // num_dorados
            // 
            num_dorados.Location = new Point(333, 491);
            num_dorados.Name = "num_dorados";
            num_dorados.Size = new Size(44, 27);
            num_dorados.TabIndex = 22;
            // 
            // num_cabeza
            // 
            num_cabeza.Location = new Point(333, 305);
            num_cabeza.Name = "num_cabeza";
            num_cabeza.Size = new Size(44, 27);
            num_cabeza.TabIndex = 23;
            // 
            // num_burritos
            // 
            num_burritos.Location = new Point(729, 491);
            num_burritos.Name = "num_burritos";
            num_burritos.Size = new Size(44, 27);
            num_burritos.TabIndex = 24;
            // 
            // num_carnitas
            // 
            num_carnitas.Location = new Point(729, 305);
            num_carnitas.Name = "num_carnitas";
            num_carnitas.Size = new Size(44, 27);
            num_carnitas.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "VENTA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_barbacoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_pastor).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_dorados).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_cabeza).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_burritos).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_carnitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label13;
        private NumericUpDown num_carnitas;
        private NumericUpDown num_burritos;
        private NumericUpDown num_cabeza;
        private NumericUpDown num_dorados;
        private NumericUpDown num_pastor;
        private NumericUpDown num_barbacoa;
        private Label label14;
    }
}