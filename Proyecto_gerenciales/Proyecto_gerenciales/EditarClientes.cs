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
    public partial class EditarClientes : Form
    {
        public EditarClientes()
        {
            InitializeComponent();
        }

        private String codigoCliente = "";
        private void EditarClientes_Load(object sender, EventArgs e)
        {
            conexion Conexion = new conexion();
            Conexion.abrir();
            string cadena = "select * from cliente";
            SqlCommand command = new SqlCommand(cadena, Conexion.conetarbase);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataReader sqlDataReader = reader;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("codigo");
            dataTable.Columns.Add("nombre_entidad");
            dataTable.Columns.Add("nombre_encargado");
            dataTable.Columns.Add("telefono");
            dataTable.Columns.Add("direccion");
            dataTable.Columns.Add("email");
            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["codigo"] = sqlDataReader["codigo"];
                row["nombre_entidad"] = sqlDataReader["nombre_entidad"];
                row["nombre_encargado"] = sqlDataReader["nombre_encargado"];
                row["telefono"] = sqlDataReader["telefono"];
                row["direccion"] = sqlDataReader["direccion"];
                row["email"] = sqlDataReader["email"];
                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;

            Conexion.cerrar();
        

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientes menu = new MenuClientes();
            menu.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEncargado.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "")
            {
                conexion Conexion = new conexion();
                Conexion.abrir();
                string cadena = "update cliente SET nombre_entidad= '" + txtNombre.Text + "', nombre_encargado='" + txtEncargado.Text + "',telefono=" + txtTelefono.Text + ", direccion='" + txtDireccion.Text + "', email='" + txtEmail.Text + "' WHERE codigo = " + codigoCliente;
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, Conexion.conetarbase);
                    SqlDataReader lector = comando.ExecuteReader();
                    MessageBox.Show("Cliente Actualizado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente");
                }
            }
        }

      

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("El nombre del cliente solo puede contener letras");
                return;
            }


        }

        private void TxtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("El nombre del encargado solo puede contener letras");
                return;
            }

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;
                MessageBox.Show("El número de teléfono solo puede contener números");
                return;

            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

           

        private void DataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                codigoCliente = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtEncargado.Text = row.Cells[2].Value.ToString();
                txtTelefono.Text = row.Cells[3].Value.ToString();
                txtDireccion.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                //...
            }
        }
    }
}
