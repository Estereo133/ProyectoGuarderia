using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuarderia
{
    internal class Conexion
    {
        // Cadena de conexión
        private static string cadena =
            "Server=localhost;Port=3306;Database=Guarderia;Uid=root;Pwd=root;"
;

        // Método para conectar
        public static MySqlConnection conectar()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            return conexion;
        }
    }
}
