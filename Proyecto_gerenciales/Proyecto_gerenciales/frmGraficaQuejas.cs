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
    public partial class frmGraficaQuejas : Form
    {
        public frmGraficaQuejas()
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
                cadena = "SELECT descripcion,count(*) as frecuencia from Proyecto_gerenciales.dbo.consulta group by Proyecto_gerenciales.dbo.consulta.descripcion";
                comando = new SqlCommand(cadena, Conexion.conetarbase);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    this.chart1.Series["Frecuencia"].Points.AddXY(lector.GetString(0), lector.GetInt32(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
