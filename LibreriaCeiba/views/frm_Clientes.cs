using MaterialSkin;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class frm_Clientes : MaterialSkin.Controls.MaterialForm
    {

        //String info para mostrar en mbox
        string info = "SISTEMA DE VENTAS LA CEIBA";

        public frm_Clientes()
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

        private void btnMultiUso_Click(object sender, EventArgs e)
        {
            ValidarClientes();

            if (btnMultiUso.Text == "GUARDAR")
            {

            }
            else if (btnMultiUso.Text == "ACTUALIZAR")
            {
                //Funcion para Guardar un nuevo libro

                btnMultiUso.Text = "GUARDAR";
                Limpiar();
            }
        }

        private void ValidarClientes()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre del Cliente", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Por favor, ingrese apellido del Cliente", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, ingrese direccion del Cliente", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mskTel.Text == "")
            {
                MessageBox.Show("Por favor, ingrese tel del Cliente", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            mskTel.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnMultiUso.Text = "GUARDAR";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                //funcion para editar
                DataGridViewRow Fila = dgvClientes.Rows[e.RowIndex];

                lblID.Text = Fila.Cells[2].Value.ToString();
                txtNombre.Text = Fila.Cells[3].Value.ToString();
                txtApellido.Text = Fila.Cells[4].Value.ToString();
                txtDireccion.Text = Fila.Cells[5].Value.ToString();
                mskTel.Text = Fila.Cells[5].Value.ToString(); ;




                btnMultiUso.Text = "ACTUALIZAR";
                btnCancelar.Visible = true;
            }

            if (e.ColumnIndex == 1)
            {
                var respuesta = MessageBox.Show("Esta seguro que quiere eliminar el producto", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (respuesta == DialogResult.Yes)
                {
                    //Funcion para eliminar 

                }
            }
        }
    }
}
