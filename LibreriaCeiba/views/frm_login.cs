using LibreriaCeiba.Models;
using LibreriaCeiba.Properties;
using LibreriaCeiba.views;
using MaterialSkin;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibreriaCeiba
{
    public partial class frm_login : MaterialSkin.Controls.MaterialForm
    {
        //Variables que serviran mas adelate
        public string Info = "Registro de ventas la ceiba";
        //
        bool Mostrar = false;


        public frm_login()
        {
            InitializeComponent();

            this.BackColor=Color.Black;
            MaterialSkinManager theme = MaterialSkinManager.Instance;
            theme.Theme  = MaterialSkinManager.Themes.DARK;
            theme.ColorScheme = new ColorScheme(
                Primary.Green300,
                Primary.Green500,
                Primary.Green800,
                Accent.Green700,
                TextShade.BLACK);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string clave = txtClave.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Info", MessageBoxButtons.OK);
                return;
            }

            string claveEncriptada = EncoderSHA256(clave);
            int idUsuario = -1;
            int numeroPermiso = -1;

            string query = $"SELECT IdUsuario, Permisos FROM tblusers WHERE NombreUsuario = @nombre AND Clave = @clave";

            MySqlConnection connection = Conexion.getConexion();
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@clave", claveEncriptada);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idUsuario = reader.GetInt32("IdUsuario");
                        numeroPermiso = reader.GetInt32("Permisos");
                        MessageBox.Show($"Inicio de sesión exitoso. ID de usuario: {idUsuario}, Permiso: {numeroPermiso}", "Info", MessageBoxButtons.OK);

                        if (numeroPermiso == 0)
                        {
                            fmr_Inicio_superUsuario superUsuario = new fmr_Inicio_superUsuario();
                            superUsuario.Show();
                            Hide();
                            superUsuario.FormClosing += frm_login_Shown;
                        }

                        if(numeroPermiso == 1)
                        {
                            frm_Inicio_administrador administrador = new frm_Inicio_administrador();
                            administrador.Show();
                            Hide();
                            administrador.FormClosing += frm_login_Shown;
                        }

                        if (numeroPermiso == 2)
                        {
                            fmr_Inicio_Vendedor vendedor = new fmr_Inicio_Vendedor();
                            vendedor.Show();
                            Hide();
                            vendedor.FormClosing += frm_login_Shown;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Usuario o contraseña incorrectos.", "Info", MessageBoxButtons.OK);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public static string EncoderSHA256(string input)
        {
            SHA256 newSHA = SHA256.Create();
            string result = "";

            var hash = newSHA.ComputeHash(Encoding.ASCII.GetBytes(input));

            foreach (var item in hash)
            {
                result += item.ToString("x2");
            }
            return result;
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            Mostrar =!Mostrar;

            if (Mostrar)
            {
                pbShow.Image = Resources.ojo__1_;
                txtClave.Password = false;
            }
            else
            {
                pbShow.Image = Resources.invisible__1_;
                txtClave.Password = true;
            }
        }

        private void frm_login_Shown(object? sender, EventArgs e)
        {
            Show();
        }
    }
}
