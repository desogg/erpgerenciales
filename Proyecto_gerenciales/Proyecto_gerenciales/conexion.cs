using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto_gerenciales
{
    class conexion
    {
        string cadena = "server = localhost; database = Proyecto_gerenciales; integrated security = true ";
        public SqlConnection conetarbase = new SqlConnection();

        public void conexionbd()
        {
            conetarbase.ConnectionString = cadena;
        
        }

        public void abrir()
        {
            conexionbd();
            try
            {
                conetarbase.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch(Exception ex)
            {

                Console.WriteLine("Error conexion");
            }
        }

        public void cerrar()
        {

            conetarbase.Close();
            Console.WriteLine("Conexion cerrada");

        }

    }
}
