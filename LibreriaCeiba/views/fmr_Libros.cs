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
using MaterialSkin.Controls;

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
            ReloadTable();
        }

        private void ReloadTable()
        {
            dgvLibros.Rows.Clear();
            foreach (var libro in Libro.GetLibros())
            {
                dgvLibros.Rows.Add(
                    "","",
                    libro.Id,
                    libro.Nombre,
                    libro.Cantidad,
                    libro.Precio,
                    libro.Foto,
                    libro.Autor,
                    libro.Editorial,
                    libro.FechaPublicacion.ToShortDateString());
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            TOOLS.SeleccionarImagen(picImagen);
        }

        private void materialTextBox2_KeyPress(object? sender, KeyPressEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (textBox.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void btnMultiUso_Click(object sender, EventArgs e)
        {
            if (!ValidarLibros())
            {
                return;
            }

            if (btnMultiUso.Text == "GUARDAR")
            {
                Libro libro = Libro.CrearLibro(new Libro
                {
                    Id = -1,
                    Nombre = txtNombre.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    Cantidad = (int)nudCantidad.Value,
                    Editorial = txtEditorial.Text.Trim(),
                    Categoria = "Libro",
                    FechaPublicacion = dtpFecha.Value,
                    Foto = (Bitmap)picImagen.Image,
                    Precio = decimal.Parse(txtPrecio.Text.Trim())
                });
                if (libro != null)
                {
                    MessageBox.Show("Correcto", "Libro Añadido correctamente");
                    ReloadTable();
                    Limpiar();
                }
            }
            else if (btnMultiUso.Text == "ACTUALIZAR")
            {
                MessageBox.Show("Edit");
                //Funcion para Guardar un nuevo libro
                Libro libro = Libro.ModificarLibro(new Libro
                {
                    Id = int.Parse(lblID.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    Cantidad = (int)nudCantidad.Value,
                    Editorial = txtEditorial.Text.Trim(),
                    Categoria = "Libro",
                    FechaPublicacion = dtpFecha.Value,
                    Foto = (Bitmap)picImagen.Image,
                    Precio = decimal.Parse(txtPrecio.Text.Trim())
                });
                ReloadTable();

                btnMultiUso.Text = "GUARDAR";
                Limpiar();
            }
        }

        private bool ValidarLibros()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, ingrese precio del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtEditorial.Text))
            {
                MessageBox.Show("Por favor, ingrese Editorial del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Por favor, ingrese Autor del libro", info, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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
                nudCantidad.Value = decimal.Parse(Fila.Cells[4].Value.ToString());
                txtPrecio.Text = Fila.Cells[5].Value.ToString();
                txtEditorial.Text = Fila.Cells[8].Value.ToString();
                dtpFecha.Value = DateTime.Parse(Fila.Cells[9].Value.ToString());
                txtAutor.Text = Fila.Cells[7].Value.ToString();
                picImagen.Image = (Bitmap)Fila.Cells[6].Value;


                btnMultiUso.Text = "ACTUALIZAR";
                btnCancelar.Visible = true;
            }

            if (e.ColumnIndex == 1)
            {
                var respuesta = MessageBox.Show("Esta seguro que quiere eliminar el producto", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (respuesta == DialogResult.Yes)
                {
                    Libro libro = new Libro()
                    {
                        Id = (int)dgvLibros.Rows[e.RowIndex].Cells[2].Value,
                    };
                    //Funcion para eliminar 
                    Libro.EliminarLibro(libro);
                    ReloadTable();
                }
            }
        }

        //Funcion para limpiar 
        public void Limpiar()
        {
            lblID.Text = "";
            txtNombre.Text = "";
            nudCantidad.Value = 0;
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
