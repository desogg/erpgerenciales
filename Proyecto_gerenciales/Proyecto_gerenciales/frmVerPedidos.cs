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
    public partial class frmVerPedidos : Form
    {
        public frmVerPedidos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            conexion Conexion = new conexion();
            Conexion.abrir();
            string cadena = "";
            SqlCommand comando;
            SqlDataReader lector;
            DataTable dt;

            try
            {
                cadena = "select v.codigo_venta codigo, v.descripcion, v.precio, v.fecha, c.nombre_entidad cliente, tv.descripcion tipo from venta v inner join cliente c on v.cliente_codigo=c.codigo inner join tipo_venta tv on v.tipo_venta_codigo_venta=tv.codigo_venta";
                comando = new SqlCommand(cadena, Conexion.conetarbase);
                lector = comando.ExecuteReader();

                dt = new DataTable();
                dt.Columns.Add("codigo", typeof(int));
                dt.Columns.Add("descripcion", typeof(string));
                dt.Columns.Add("precio", typeof(int));
                dt.Columns.Add("fecha", typeof(string));
                dt.Columns.Add("cliente", typeof(string));
                dt.Columns.Add("tipo", typeof(string));
                dt.Load(lector);

                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
