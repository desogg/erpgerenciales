using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_gerenciales
{
    public partial class frmQuejas : Form
    {
        public frmQuejas()
        {
            InitializeComponent();
            tipoqueja.Items.Add("Plataforma");
            tipoqueja.Items.Add("Ventas Problema");
            tipoqueja.Items.Add("Error En Graficas");
            tipoqueja.Items.Add("Pedidos Ingreso");
            tipoqueja.Items.Add("Otros..");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmQuejas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoqueja.Text != "" && comentario.Text != "" )
            {
                conexion Conexion = new conexion();
                Conexion.abrir();
                string cadena = "";
                SqlCommand comando;
                SqlDataReader lector;

           

                try
                {
                    cadena = "insert into consulta(descripcion,estado,cliente_codigo) values('" +tipoqueja.Text  + "'," +0+ "," + Convert.ToInt32(textBox1.Text) + ")";
                    comando = new SqlCommand(cadena, Conexion.conetarbase);
                    lector = comando.ExecuteReader();
                    MessageBox.Show("Su queja a sido ingresada con exito...");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la queja...\n\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos...");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Por favor entre un numero no un digito----");
            }
        }
    }
}
