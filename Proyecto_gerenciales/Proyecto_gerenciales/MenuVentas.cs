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
    public partial class MenuVentas : Form
    {
        public MenuVentas()
        {
            InitializeComponent();
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            frmCrearPedido fcp = new frmCrearPedido();
            fcp.Show();
        }
    }
}
