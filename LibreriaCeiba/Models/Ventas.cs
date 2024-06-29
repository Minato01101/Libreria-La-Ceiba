using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeiba.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public List<Producto> Productos { get; set; }
        public string CodigoOrden { get; set; }

        public static void CrearOrden(List<Producto> productos, int[] cantidades,Usuario vendedor, Cliente cliente)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "INSERT INTO tblordenes_final (idClientes,idUsuario,FechaOrden) VALUES (@Cliente,@Vendedor,@Fecha); SELECT LAST_INSERT_ID();";
            int newID = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Cliente", cliente.Id));
                cmd.Parameters.Add(new MySqlParameter("@Vendedor", vendedor.Id));
                cmd.Parameters.Add(new MySqlParameter("@Fecha", DateTime.Now.Date));
                newID = (int)(ulong)cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }
            CrearVenta(newID, productos, cantidades);
        }
        
        private static void CrearVenta(int idOrden, List<Producto> productos, int[] cantidades)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                int i = 0;
                foreach (var producto in productos)
                {
                    if (producto.Cantidad >= cantidades[i])
                    {
                        int newCantidad = producto.Cantidad - cantidades[i];

                        string queryVenta = $"INSERT INTO (idProducto,idOrdenFinal,Cantidad) VALUE ({producto.Id},{idOrden},{cantidades[i]})";
                        MySqlCommand cmdVenta = new MySqlCommand(queryVenta, con);
                        cmdVenta.ExecuteNonQuery();

                        string queryCantidad = $"UPDATE tblproductos SET Cantidad = {newCantidad} WHERE id = {producto.Id}";
                        MySqlCommand cmdCantidad = new MySqlCommand(queryCantidad, con);
                        cmdCantidad.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                //kaskjdhaskdjhaskd
                Console.WriteLine("Eliminar Productos");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
