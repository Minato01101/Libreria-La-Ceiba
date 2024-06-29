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
    public partial class fmr_Inicio_Vendedor : MaterialSkin.Controls.MaterialForm
    {
        public fmr_Inicio_Vendedor()
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

        private void txtBuscarProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
