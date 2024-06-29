using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LibreriaCeiba.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


        public static Cliente CrearCliente(Cliente cliente)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "INSERT INTO tblclientes (Nombre,Apellido,Direccion,Telefono) VALUE (@Nombre,@Apellido,@Direccion,@Telefono); SELECT LAST_INSERT_ID();";
            int newId;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Nombre", cliente.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Apellido", cliente.Apellido));
                cmd.Parameters.Add(new MySqlParameter("@Direccion", cliente.Direccion));
                cmd.Parameters.Add(new MySqlParameter("@Telefono", cliente.Telefono));
                newId = (int)(ulong)cmd.ExecuteScalar();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return GetClientes().Find(c => c.Id == newId)!;
        }

        public static Cliente ModificarCliente(Cliente cliente)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "UPDATE tblclientes SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Nombre", cliente.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Apellido", cliente.Apellido));
                cmd.Parameters.Add(new MySqlParameter("@Direccion", cliente.Direccion));
                cmd.Parameters.Add(new MySqlParameter("@Telefono", cliente.Telefono));
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

            return GetClientes().Find(u => u.Id == cliente.Id)!;
        }

        public bool EliminarCliente(Cliente cliente)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "DELETE FROM tblclientes WHERE idClientes = @Id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Id", cliente.Id));
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

        public static List<Cliente> GetClientes()
        {
            List<Cliente> list = new List<Cliente>();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "SELECT * FROM tblclientes";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Cliente()
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Direccion = reader.GetString(3),
                        Telefono = reader.GetString(4)
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
