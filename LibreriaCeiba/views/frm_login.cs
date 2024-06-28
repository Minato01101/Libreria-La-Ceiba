using LibreriaCeiba.Models;
using LibreriaCeiba.Properties;
using MaterialSkin;
using MySql.Data.MySqlClient;
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
            string claveEncriptada = EncoderSHA256(clave);
            //query
            string query = $"SELECT COUNT(*) FROM tblusers WHERE NombreUsuario = @nombre AND Clave = @clave";

            MySqlConnection connection = Conexion.getConexion();
            connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@clave", claveEncriptada);

                int Datos = Convert.ToInt32(cmd.ExecuteScalar());

                if (Datos > 0)
                {
                    MessageBox.Show("Inicio de seccion exitoso", Info, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error: Asegúrese de haber ingresado usuario y contraseña correcta", "Info", MessageBoxButtons.OK);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
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
    }
}
