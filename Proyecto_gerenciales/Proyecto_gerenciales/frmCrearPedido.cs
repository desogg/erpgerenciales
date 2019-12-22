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
    public partial class frmCrearPedido : Form
    {
        public frmCrearPedido()
        {
            InitializeComponent();
        }

        private void frmCrearPedido_Load(object sender, EventArgs e)
        {
            conexion Conexion = new conexion();
            Conexion.abrir();
            string cadena = "";
            SqlCommand comando;
            SqlDataReader lector;
            DataTable dt;

            try
            {
                // LLENAR EL COMBO DE LOS CLIENTE
                cadena = "select * from cliente";
                comando = new SqlCommand(cadena, Conexion.conetarbase);
                lector = comando.ExecuteReader();

                dt = new DataTable();
                dt.Columns.Add("codigo", typeof(int));
                dt.Columns.Add("nombre_entidad", typeof(string));
                dt.Load(lector);

                cmbCliente.DataSource = dt;
                cmbCliente.ValueMember = "codigo";
                cmbCliente.DisplayMember = "nombre_entidad";

                // LLENAR EL COMBO DE LOS TIPOS DE VENTA
                cadena = "select * from tipo_venta";
                comando = new SqlCommand(cadena, Conexion.conetarbase);
                lector = comando.ExecuteReader();

                dt = new DataTable();
                dt.Columns.Add("codigo_venta", typeof(int));
                dt.Columns.Add("descripcion", typeof(string));
                dt.Load(lector);

                cmbTipoVenta.DataSource = dt;
                cmbTipoVenta.ValueMember = "codigo_venta";
                cmbTipoVenta.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtPrecioUnitario.Text != "" && txtDescripcion.Text != "")
            {
                conexion Conexion = new conexion();
                Conexion.abrir();
                string cadena = "";
                SqlCommand comando;
                SqlDataReader lector;

                Random r = new Random();
                int rInt = r.Next(0, 1000);

                try
                {
                    cadena = "insert into venta(codigo_venta,descripcion,precio,mes,fecha,cliente_codigo,tipo_venta_codigo_venta) values(" + rInt + ",'" + txtDescripcion.Text + "'," + Convert.ToInt32(Math.Floor(Convert.ToDouble(lblTotal.Text))) + "," + dtpFecha.Value.ToString("MM") + ",'" + dtpFecha.Value + "'," + cmbCliente.SelectedValue + "," + cmbTipoVenta.SelectedValue + ")";
                    comando = new SqlCommand(cadena, Conexion.conetarbase);
                    lector = comando.ExecuteReader();
                    MessageBox.Show("Pedido creado con exito...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el pedido...\n\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos...");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = Calcular().ToString();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = Calcular().ToString();
        }

        private double Calcular()
        {

            double dblPrecioUnitario;
            double dblCantidad;

            dblPrecioUnitario = (txtPrecioUnitario.Text == "") ? 0 : double.Parse(txtPrecioUnitario.Text);
            dblCantidad = (txtCantidad.Text == "") ? 0 : double.Parse(txtCantidad.Text);

            return dblPrecioUnitario * dblCantidad;

        }

    }
}
