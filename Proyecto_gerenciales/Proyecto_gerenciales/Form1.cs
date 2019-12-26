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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Finanzas MostrarFinanzas = new Finanzas();
            MostrarFinanzas.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuServicios MostrarServicios = new MenuServicios();
            MostrarServicios.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MenuClientes menu = new MenuClientes();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuVentas mv = new MenuVentas();
            mv.Show();
        }
    }
}
