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

using System.IO;

namespace Proyecto_gerenciales
{
    public partial class Reporte_compras : Form
    {
        public Reporte_compras()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select  b.nombre,sum(a.costo) as costo from compra a inner join Cuentav1 b on b.codigo_cuenta = a.cuentav1_codigo_cuenta group by b.nombre,a.cuentav1_codigo_cuenta;";


                try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje= "<html><h1>REPORTE DE GASTOS</h1><table class=\"egt\"> <tr><th>Categoria</th> <th>Monto Gastado</th></tr>";

                SqlCommand comando = new SqlCommand(cadena,funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    mensaje += "<tr><td>"+lector.GetValue(0).ToString()+ "</td><td>" + lector.GetValue(1).ToString() + "</td></tr> ";


                }
                mensaje += "</table></html>";

                archivo.WriteLine(mensaje);
                archivo.Close();

            }
            catch (Exception ex)
            {

            }





            funciona.cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Visible = true;
            button5.Visible = true;


            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select nombre from Cuentav1;";


            try
            {
                
                SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    comboBox1.Items.Add(lector.GetValue(0).ToString());

                }
         

            }
            catch (Exception ex)
            {

            }

            funciona.cerrar();




            
        }

        private void button5_Click(object sender, EventArgs e)
        {


            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select descripcion,fecha,costo from compra where cuentav1_codigo_cuenta =  (select codigo_cuenta from Cuentav1 where nombre = '"+comboBox1.Text+"');";

            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE GASTOS</h1><h2>"+comboBox1.Text+ "</h2><table class=\"egt\"> <tr><th>Descripcion</th> <th>Fecha</th><th>Monto</th></tr>";

                SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    mensaje += "<tr><td>" + lector.GetValue(0).ToString() + "</td><td>" + lector.GetValue(1).ToString() + "</td><td>" + lector.GetValue(2).ToString() + "</td></tr> ";


                }
                mensaje += "</table></html>";

                archivo.WriteLine(mensaje);
                archivo.Close();

            }
            catch (Exception ex)
            {

            }

            funciona.cerrar();

            comboBox1.Visible = false;
            button5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select  b.nombre,a.descripcion,a.costo as costo from compra a inner join Cuentav1 b on b.codigo_cuenta = a.cuentav1_codigo_cuenta where a.mes ="+richTextBox1.Text+" ;";

            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE GASTOS</h1><h2>Mes: " + richTextBox1.Text + "</h2><table class=\"egt\"> <tr><th>Categoria</th><th>Descripcion</th> <th>Monto</th></tr>";

                SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    mensaje += "<tr><td>" + lector.GetValue(0).ToString() + "</td><td>" + lector.GetValue(1).ToString() + "</td><td>" + lector.GetValue(2).ToString() + "</td></tr> ";


                }
                mensaje += "</table></html>";

                archivo.WriteLine(mensaje);
                archivo.Close();

            }
            catch (Exception ex)
            {

            }

            funciona.cerrar();
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            button4.Visible = false;

        }
    }
}
