using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaCeiba.Models
{
    public class Libro : Producto
    {
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public static Libro CrearLibro(Libro libro)
        {
            Producto producto = CrearProducto(libro);
            if (producto == null)
            {
                MessageBox.Show("Error", "Error");
                return null;
            }

            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "INSERT INTO tbllibros (idProducto,Autor,Editorial,FechaPublicacion) VALUE (@Producto,@Autor,@Editorial,@Fecha);";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Producto", producto.Id));
                cmd.Parameters.Add(new MySqlParameter("@Autor", libro.Autor));
                cmd.Parameters.Add(new MySqlParameter("@Editorial", libro.Editorial));
                cmd.Parameters.Add(new MySqlParameter("@Fecha", libro.FechaPublicacion));
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error", "Error: " + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

            return GetLibros().Find(l => l.Id == producto.Id);
        }

        public static Libro ModificarLibro(Libro libro)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "UPDATE tbllibros SET Autor = @Autor, Editorial = @Editorial, FechaPublicacion = @FechaPublicacion WHERE idProducto = @Id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Autor", libro.Autor));
                cmd.Parameters.Add(new MySqlParameter("@Editorial", libro.Editorial));
                cmd.Parameters.Add(new MySqlParameter("@FechaPublicacion", libro.FechaPublicacion));
                cmd.Parameters.Add(new MySqlParameter("@Id", libro.Id));
                cmd.ExecuteNonQuery();
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

            ModificarProducto(libro);
            return GetLibros().Find(u => u.Id == libro.Id)!;
        }

        public static bool EliminarLibro(Libro libro)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "DELETE FROM tbllibros WHERE idProducto = @Id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Id", libro.Id));
                var affected = cmd.ExecuteNonQuery();
                if (affected < 1)
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(@"Error: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

            if (!EliminarProducto(libro))
            {
                return false;
            }

            return true;
        }

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
                    Bitmap img = null;
                    if (reader[5] is not DBNull)
                    {
                         img = (Bitmap)TOOLS.ConvertirBinarioImagen((byte[])reader[5]);
                    }
                    list.Add(new Libro()
                    {
                        Id = reader.GetInt32(0),
                        Categoria = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Cantidad = reader.GetInt32(3),
                        Precio = reader.GetDecimal(4),
                        Foto = img,
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
