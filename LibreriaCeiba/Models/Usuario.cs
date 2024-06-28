using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace LibreriaCeiba.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private string Clave { get; set; }
        public Permisos Permiso { get; set; }

        public Usuario(string nombre, string clave, Permisos permiso, int id = -1)
        {
            this.Nombre = nombre;
            this.Clave = clave;
            this.Permiso = permiso;
            this.Id = id;
        }

        public void SetClave(string Clave)
        {
            this.Clave = Clave;
        }

        protected string GetClave()
        {
            return Clave;
        }

        public static Usuario CrearUsuario(Usuario user)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "INSERT INTO tblusers (NombreUsuario,Clave,Permisos) VALUE (@Nombre,@Clave,@Permisos); SELECT CAST(scope_identity() AS int);";
            int newId;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Nombre", user.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Clave", user.GetClave()));
                cmd.Parameters.Add(new MySqlParameter("@Permisos", (int)user.Permiso));
                newId = (int)cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(@"Error: "+ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
            return GetUsuarios().Find(u => u.Id == newId)!;
        }

        public bool EliminarUsuario(Usuario user)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "DELETE FROM tblusers WHERE idUsuario = @Id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Id", user.Id));
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

        public static Usuario ModificarUsuario(Usuario user)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "UPDATE tblusers SET NombreUsuario = @Nombre, Clave = @Clave, Permisos = @Permisos";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@Nombre", user.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Clave", user.GetClave()));
                cmd.Parameters.Add(new MySqlParameter("@Permisos", (int)user.Permiso));
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

            return GetUsuarios().Find(u => u.Id == user.Id)!;
        }

        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> list = new List<Usuario>();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string query = "SELECT * FROM tblusers";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Usuario(
                        reader.GetString(1),
                        reader.GetString(2),
                        (Permisos)reader.GetInt32(3),
                        reader.GetInt32(0)));
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
