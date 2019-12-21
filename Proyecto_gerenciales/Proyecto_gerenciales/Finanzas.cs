using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_gerenciales
{
    public partial class Finanzas : Form
    {
        public Finanzas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_compras nueva = new Reporte_compras();
            nueva.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporteventas ventasmostrar = new Reporteventas();
            ventasmostrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();
            
            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string cadena="";
                string mensaje="<html>";
                for (int a = 1; a < 4; a++)
                {

                    if (a == 1)
                    {
                        funciona.abrir();
                        mensaje += "<h2>GASTOS</h2><table class=\"egt\">";
                        cadena = " select  b.nombre,sum(a.costo) as costo from compra a inner join Cuentav1 b on b.codigo_cuenta = a.cuentav1_codigo_cuenta where a.mes =" + richTextBox1.Text + " group by b.nombre,a.cuentav1_codigo_cuenta";


                    }
                    else if (a == 2)
                    {
                        funciona.abrir();
                        mensaje += "<h2>INGRESO</h2><table class=\"egt\">";
                        cadena = " select  b.descripcion,sum(a.precio) as costo from venta a inner join tipo_venta b on a.tipo_venta_codigo_venta = b.codigo_venta  where a.mes = " +richTextBox1.Text +" group by b.descripcion,a.precio;";
                       


                    }
                    else
                    {
                        funciona.abrir();
                        mensaje += "<h2>RESULTADO</h2><table class=\"egt\">";
                        cadena = "select 'Total',(select  sum(a.costo) as costo from compra a where a.mes = "+richTextBox1.Text+") - (select  sum(a.precio) from venta a  where a.mes ="+richTextBox1.Text+")";

            }


                    SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        mensaje += "<tr><td>" + lector.GetValue(0).ToString() + "</td><td>" + lector.GetValue(1).ToString() + "</td></tr> ";


                    }
                    mensaje +="</table>";
                    funciona.cerrar();

                }

                mensaje += "</html>";

                archivo.WriteLine(mensaje);
                archivo.Close();

            }
            catch (Exception ex)
            {

            }

            
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            button4.Visible = false;
        }
    }
}
