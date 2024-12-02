using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para utilizar BD
using System.Data.SqlClient;
namespace Proyecto_Final__Libreria_
{
    internal class ConexionBD
    {
        string cadena = "Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BD_LIBRERIA; Integrated Security=True";
        public SqlConnection conectarBD = new SqlConnection();

        public ConexionBD()
        {
            conectarBD.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarBD.Close();
        }

        public void cargarComboBox()
        {
            
        }
    }
}
