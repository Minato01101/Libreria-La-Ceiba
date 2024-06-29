using LibreriaCeiba.Models;
using LibreriaCeiba.Properties;
using MaterialSkin;
using MySql.Data.MySqlClient;
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
    public partial class fmr_Libros : MaterialSkin.Controls.MaterialForm
    {
        //String info para mostrar en mbox
        string info = "SISTEMA DE VENTAS LA CEIBA";

        public fmr_Libros()
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

        private void fmr_Libros_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            TOOLS.SeleccionarImagen(picImagen);
        }

        private void materialTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMultiUso_Click(object sender, EventArgs e)
        {
            ValidarLibros();

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

        private void ValidarLibros()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese cantidad del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, ingrese precio del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtEditorial.Text))
            {
                MessageBox.Show("Por favor, ingrese Editorial del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Por favor, ingrese Autor del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                //funcion para editar
                DataGridViewRow Fila = dgvLibros.Rows[e.RowIndex];

                lblID.Text = Fila.Cells[2].Value.ToString();
                txtNombre.Text = Fila.Cells[3].Value.ToString();
                txtCantidad.Text = Fila.Cells[4].Value.ToString();
                txtPrecio.Text = Fila.Cells[5].Value.ToString();
                txtEditorial.Text = Fila.Cells[6].Value.ToString();
                dtpFecha.Value = (DateTime)Fila.Cells[7].Value;
                txtAutor.Text = Fila.Cells[8].Value.ToString();
                picImagen.Image = (Bitmap)Fila.Cells[9].Value;


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

        //Funcion para limpiar 
        public void Limpiar()
        {
            lblID.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtEditorial.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtAutor.Text = "";
            picImagen.Image = Resources.libros__2_;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnMultiUso.Text = "GUARDAR";
        }
    }
}
