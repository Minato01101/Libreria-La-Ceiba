using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeiba.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Bitmap Foto { get; set; }

        public static Producto CrearProducto(Producto product)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "INSERT INTO tblproductos (Categoria,Nombre,Cantidad,Precio,Foto) VALUE (@Categoria,@Nombre,@Cantidad,@Precio,@Foto); SELECT LAST_INSERT_ID();";
            int newId;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Categoria", product.Categoria));
                cmd.Parameters.Add(new MySqlParameter("@Nombre", product.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Cantidad", product.Cantidad));
                cmd.Parameters.Add(new MySqlParameter("@Precio", product.Precio));
                cmd.Parameters.Add(new MySqlParameter("@Foto", TOOLS.ConvertirImagenBinario(product.Foto)));
                newId = (int)(ulong)cmd.ExecuteScalar();
                MessageBox.Show(newId.ToString(),"asds");
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
            return GetProductos().Find(p => p.Id == newId)!;
        }

        public bool EliminarProducto(Producto product)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "DELETE FROM tblproductos WHERE idProducto = @Id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Id", product.Id));
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
            return true;
        }

        public Producto ModificarProducto(Producto producto)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "UPDATE tblproductos SET Categoria = @Categoria, Nombre = @Nombre, Cantidad = @Cantidad, Precio = @Precio, Foto = @Foto";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Categoria", producto.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Nombre", producto.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Cantidad", producto.Cantidad));
                cmd.Parameters.Add(new MySqlParameter("@Precio", producto.Precio));
                cmd.Parameters.Add(new MySqlParameter("@Foto", "producto.Foto"));
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

            return GetProductos().Find(u => u.Id == producto.Id)!;
        }

        public static List<Producto> GetProductos(bool libros = false)
        {
            List<Producto> list = new List<Producto>();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = libros ? "SELECT * FROM tblproductos WHERE Categoria != 'Libro'" : "SELECT * FROM tblproductos";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Producto()
                    {
                        Id = reader.GetInt32(0),
                        Categoria = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Cantidad = reader.GetInt32(3),
                        Precio = reader.GetDecimal(4),
                        Foto = (Bitmap)TOOLS.ConvertirBinarioImagen((byte[]) reader[5])
                    });
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
