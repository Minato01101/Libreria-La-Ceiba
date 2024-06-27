using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeiba.Models
{
    public static class Conexion
    {
        static string server = "127.0.0.1";
        static string port = "3307";
        static string user = "root";
        static string pwd = "";
        static string db = "dblibreria";

        public static MySqlConnection getConexion()
        {
            //Cadena
            string Cadena = $"Server = {server}" +
                $"; Port = {port}" +
                $"; User Id = {user}" +
                $"; Password = {pwd}" +
                $"; Database = {db} ";

            MySqlConnection con = new MySqlConnection(Cadena);
            return con;
        }

    }
}
