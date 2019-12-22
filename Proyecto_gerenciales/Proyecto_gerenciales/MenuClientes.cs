using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_gerenciales
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CrearClientes crearclientes = new CrearClientes();
            crearclientes.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EditarClientes editar = new EditarClientes();
            editar.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            
        }
    }
}
