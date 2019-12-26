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
    public partial class Reporteventas : Form
    {
        public Reporteventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select  b.descripcion,sum(a.precio) as costo from venta a inner join tipo_venta b on a.tipo_venta_codigo_venta = b.codigo_venta group by b.descripcion,a.precio;";



            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE INGRESOS</h1><table class=\"egt\"> <tr><th>Tipo Venta</th> <th>Monto Ingreso</th></tr>";

                SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    mensaje += "<tr><td>" + lector.GetValue(0).ToString() + "</td><td>" + lector.GetValue(1).ToString() + "</td></tr> ";


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
            string cadena = "select descripcion from tipo_venta;";


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
            string cadena = "select descripcion,fecha,precio from venta where tipo_venta_codigo_venta = (select codigo_venta from tipo_venta where descripcion = '" + comboBox1.Text + "');";

          

            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE INGRESOS </h1><h2>" + comboBox1.Text + "</h2><table class=\"egt\"> <tr><th>Descripcion</th> <th>Fecha</th><th>Monto</th></tr>";

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

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select  b.descripcion,a.fecha,a.precio as costo from venta a inner join tipo_venta b on a.tipo_venta_codigo_venta = b.codigo_venta where a.mes = " + richTextBox1.Text + ";";
            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE INGRESOS</h1><h2>Mes: " + richTextBox1.Text + "</h2><table class=\"egt\"> <tr><th>Categoria</th><th>Descripcion</th> <th>Monto</th></tr>";

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
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Visible = true;
            button7.Visible = true;

            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select nombre_entidad from cliente;";


            try
            {

                SqlCommand comando = new SqlCommand(cadena, funciona.conetarbase);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    comboBox2.Items.Add(lector.GetValue(0).ToString());

                }


            }
            catch (Exception ex)
            {

            }

            funciona.cerrar();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conexion funciona = new conexion();

            funciona.abrir();
            string cadena = "select descripcion,fecha,precio from venta where cliente_codigo = (select codigo from cliente where nombre_entidad = '" + comboBox2.Text + "');";


            try
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.html");
                string mensaje = "<html><h1>REPORTE DE INGRESOS </h1><h2>" + comboBox2.Text + "</h2><table class=\"egt\"> <tr><th>Descripcion</th> <th>Fecha</th><th>Monto</th></tr>";

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

            comboBox2.Visible = false;
            button7.Visible = false;
        }

        private void Reporteventas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
