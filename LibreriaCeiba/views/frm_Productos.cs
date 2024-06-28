using LibreriaCeiba.Models;
using LibreriaCeiba.Properties;
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
    public partial class frm_Productos : MaterialSkin.Controls.MaterialForm
    {
        public frm_Productos()
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            TOOLS.SeleccionarImagen(picImagen);
        }

        private void btnMultiUso_Click(object sender, EventArgs e)
        {
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
        //Funcion para limpiar 
        public void Limpiar()
        {
            lblID.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtCategotia.Text = "";
            picImagen.Image = Resources.libros__2_;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnMultiUso.Text = "GUARDAR";
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                //funcion para editar
                DataGridViewRow Fila = dgvProductos.Rows[e.RowIndex];

                lblID.Text = Fila.Cells[2].Value.ToString();
                txtNombre.Text = Fila.Cells[3].Value.ToString();
                txtCantidad.Text = Fila.Cells[4].Value.ToString();
                txtPrecio.Text = Fila.Cells[5].Value.ToString();
                txtCategotia.Text = Fila.Cells[6].Value.ToString();
                picImagen.Image = (Bitmap)Fila.Cells[7].Value;


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

        private void frm_Productos_Load(object sender, EventArgs e)
        {
            if (dgvProductos.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvProductos.Columns.Add(btnEditar);
            }
            if (dgvProductos.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnELiminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvProductos.Columns.Add(btnEliminar);
            }
        }
    }
}
