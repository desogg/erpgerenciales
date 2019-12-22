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
    public partial class CrearClientes : Form
    {
        public CrearClientes()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text!="" && txtEncargado.Text!="" && txtDireccion.Text!= "" && txtTelefono.Text!="" && txtEmail.Text != "")
            {
                conexion Conexion = new conexion();
                Conexion.abrir();
                string cadena = "insert into cliente values('" + txtNombre.Text + "','" + txtEncargado.Text + "'," + txtTelefono.Text + ",'" + txtDireccion.Text + "','" + txtEmail.Text + "')";
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, Conexion.conetarbase);
                    SqlDataReader lector = comando.ExecuteReader();
                    MessageBox.Show("Cliente Ingresado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar el cliente");
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientes menu = new MenuClientes();
            menu.Show();
        }
    }
}
