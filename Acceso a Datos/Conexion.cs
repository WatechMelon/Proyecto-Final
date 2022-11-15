using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Acceso_a_Datos
{
    public class Conexion
    {
        public static MySqlConnection getConnection()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string contra = "ROOT";
            string bd = "watechmelon";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + contra + "; database=" + bd;
            MySqlConnection connection = new MySqlConnection(cadenaConexion);
            return connection;
        }


    }
}
