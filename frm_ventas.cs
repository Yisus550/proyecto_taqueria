using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace proyecto_pos
{
    public partial class frm_ventas : Form
    {
        public frm_ventas()
        {
            InitializeComponent();
            pnl_bebidas.Visible = false;
            btn_tacos.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_bebidas_Click(object sender, EventArgs e)
        {
            pnl_tacos.Visible = false;
            pnl_bebidas.Visible = true;
        }

        private void btn_tacos_Click(object sender, EventArgs e)
        {
            pnl_bebidas.Visible = false;
            pnl_tacos.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vaciarNumericUP() {
            //BEBIDAS
            num_coca.Value = 0;
            num_fre.Value = 0;
            num_jam.Value = 0;
            num_lim.Value = 0;
            num_horchata.Value = 0;
            num_man.Value = 0;

            //TACOS
            num_barbacoa.Value = 0;
            num_burritos.Value = 0;
            num_cabeza.Value = 0;
            num_carnitas.Value = 0;
            num_dorados.Value = 0;
            num_pastor.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vaciarNumericUP();  
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            //TACOS
            int ctbarbacoa = Convert.ToInt32(num_barbacoa.Value);
            int ctburritos = Convert.ToInt32(num_burritos.Value);
            int ctcabeza = Convert.ToInt32(num_cabeza.Value);
            int ctcarnitas = Convert.ToInt32(num_carnitas.Value);
            int ctdorados = Convert.ToInt32(num_dorados.Value);
            int ctpastor = Convert.ToInt32(num_pastor.Value);

            //BEBIDAS
            int ctcoca = Convert.ToInt32(num_coca.Value);
            int ctfresca = Convert.ToInt32(num_fre.Value);
            int ctmanz = Convert.ToInt32(num_man.Value);
            int cthor = Convert.ToInt32(num_horchata.Value);
            int ctjam = Convert.ToInt32(num_jam.Value);
            int ctlim = Convert.ToInt32(num_lim.Value);

            //CALCULO DE COBRO
            int tottacos = ctbarbacoa + ctburritos + ctcabeza + ctcarnitas + ctdorados + ctpastor;
            int totbebidas = ctcoca + ctfresca + ctmanz + cthor + ctjam + ctlim;
;           int preciotaco = 25, preciobebida = 20;
            int totalfinal = (tottacos * preciotaco)+(totbebidas * preciobebida);

            //VALIDACION
            if (totalfinal == 0)
            {
                MessageBox.Show("NO SELECCIONASTE NINGUN PRODUCTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //TICKET 
                MessageBox.Show("*** TACONTENTO ***" + "\n\n" + "CANTIDAD DE TACOS: " + tottacos + "\n" + "CANTIDAD DE BEBIDAS: " + totbebidas
                    + "\n" + "TOTAL A PAGAR: " + totalfinal, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CONEXION A LA BASE DE DATOS  
                string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO ventas (tacos, bebidas, total) VALUES (@tacos, @bebidas, @total)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tacos", tottacos);
                        command.Parameters.AddWithValue("@bebidas", totbebidas);
                        command.Parameters.AddWithValue("@total", totalfinal);
                        command.ExecuteNonQuery();
                    }
                }
                //REGRESAR LOS A VALORES FINALES
                vaciarNumericUP();         
            }






        }
    }
}
