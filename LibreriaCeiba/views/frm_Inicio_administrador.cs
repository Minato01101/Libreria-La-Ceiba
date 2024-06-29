using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaCeiba.views
{
    public partial class frm_Inicio_administrador : MaterialSkin.Controls.MaterialForm
    {
        public frm_Inicio_administrador()
        {
            InitializeComponent();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            frm_Clientes clientes = new frm_Clientes();
            clientes.Show();
            Hide();
            clientes.FormClosing += frm_Inicio_administrador_Shown;
        }

        private void frm_Inicio_administrador_Shown(object? sender, EventArgs e)
        {
            Show();
        }

        private void picVender_Click(object sender, EventArgs e)
        {
            fmr_Inicio_Vendedor vender = new fmr_Inicio_Vendedor();
            vender.Show();
            Hide();
            vender.FormClosing += frm_Inicio_administrador_Shown;
        }

        private void picProductos_Click(object sender, EventArgs e)
        {
            
        }

        private void picLibros_Click(object sender, EventArgs e)
        {
            fmr_Libros libros = new fmr_Libros();
            libros.Show();
            Hide();
            libros.FormClosing += frm_Inicio_administrador_Shown;
            //jkhgbjdasbhsaj
        }

        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            Hide();
            login.FormClosing += frm_Inicio_administrador_Shown;
        }
    }
}
