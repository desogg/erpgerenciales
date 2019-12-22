using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_gerenciales
{
    public partial class frmGraficaPedidos : Form
    {
        public frmGraficaPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion Conexion = new conexion();
            Conexion.abrir();
            string cadena = "";
            SqlCommand comando;
            SqlDataReader lector;
            DataTable dt;

            try
            {
                cadena = "select c.nombre_entidad cliente, sum(v.precio) total from venta v inner join cliente c on v.cliente_codigo=c.codigo group by c.nombre_entidad";
                comando = new SqlCommand(cadena, Conexion.conetarbase);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    this.chart1.Series["Total"].Points.AddXY(lector.GetString(0), lector.GetInt32(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
