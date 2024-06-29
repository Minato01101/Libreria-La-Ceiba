using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeiba.Models
{
    public class Libro : Producto
    {
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public static List<Libro> GetLibros()
        {
            List<Libro> list = new List<Libro>();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "SELECT * FROM tblproductos WHERE Categoria = 'Libro'";
            string query2 = "SELECT * FROM tbllibros";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Libro()
                    {
                        Id = reader.GetInt32(0),
                        Categoria = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Cantidad = reader.GetInt32(3),
                        Precio = reader.GetDecimal(4),
                        Foto = (Bitmap)TOOLS.ConvertirBinarioImagen((byte[])reader[5]),
                    });
                }
                con.Close();

                MySqlConnection con2 = Conexion.getConexion();
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                var reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    Libro libro = list.Find(l => l.Id == reader2.GetInt32(1));
                    libro.Autor = reader2.GetString(2);
                    libro.Editorial = reader2.GetString(3);
                    libro.FechaPublicacion = reader2.GetDateTime(4);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(@"Error: " + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
            return list;
        }
    }
}
