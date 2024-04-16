namespace proyecto_pos
{
    partial class frm_compras
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
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 158, 0);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 107);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 461);
            panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Noto Sans", 11F);
            richTextBox1.Location = new Point(102, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 171);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label2.Location = new Point(98, 46);
            label2.Name = "label2";
            label2.Size = new Size(269, 30);
            label2.TabIndex = 32;
            label2.Text = "Descripcion de la compra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 30);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.canasta;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 11;
            label1.Text = "Compras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans", 12F, FontStyle.Bold);
            label4.Location = new Point(98, 304);
            label4.Name = "label4";
            label4.Size = new Size(218, 30);
            label4.TabIndex = 34;
            label4.Text = "Monto de la compra:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Noto Sans", 11F);
            numericUpDown1.Location = new Point(102, 337);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 32);
            numericUpDown1.TabIndex = 35;
            // 
            // frm_compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 675);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "frm_compras";
            Text = "Compras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
    }
}