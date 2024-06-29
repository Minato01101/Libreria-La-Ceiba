﻿using MaterialSkin;
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
    public partial class fmr_Inicio_superUsuario : MaterialSkin.Controls.MaterialForm
    {

        public fmr_Inicio_superUsuario()
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

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void picVender_Click(object sender, EventArgs e)
        {
            fmr_Inicio_Vendedor vender = new fmr_Inicio_Vendedor();
            vender.Show();
            Hide();
            vender.FormClosing += fmr_Inicio_superUsuario_Shown;
        }

        private void fmr_Inicio_superUsuario_Shown(object? sender, EventArgs e)
        {
            Show();
        }

        private void picAdminUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
