using LibreriaCeiba.Models;
using MaterialSkin;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibreriaCeiba
{
    public partial class frm_login : MaterialSkin.Controls.MaterialForm
    {
        public string Info = "Registro de ventas la ceiba";

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
            //query
            string query = $"SELECT * FROM tblusers WHERE NombreUsuario = '{nombre}' AND Clave = '{clave}'";

            MySqlConnection connection = Conexion.getConexion();
            connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();
                var scalar= cmd.ExecuteScalar();
                int Datos;

                if (scalar == null)
                {
                    MessageBox.Show("Error: Asegurese de haber ingresado usuario y contraseña correcta", Info, MessageBoxButtons.OK );
                    return;
                }

                Datos = (int)scalar;

                if (Datos > 0)
                {
                    MessageBox.Show("Inicio de seccion exitoso", Info, MessageBoxButtons.OK);
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error:" + ex.Message);
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
    }
}
