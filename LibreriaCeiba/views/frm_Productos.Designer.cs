namespace LibreriaCeiba.views
{
    partial class frm_Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            picCerrarSesion = new PictureBox();
            label1 = new Label();
            txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtCategotia = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            btnExaminar = new MaterialSkin.Controls.MaterialButton();
            picImagen = new PictureBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnMultiUso = new MaterialSkin.Controls.MaterialButton();
            dgvProductos = new DataGridView();
            btnEditar = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            lblID = new Label();
            nudCantidad = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(76, 175, 80);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(picCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 76);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(678, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 26;
            label2.Text = "LIBRERIA LA CEIBA";
            // 
            // picCerrarSesion
            // 
            picCerrarSesion.Image = Properties.Resources.cerrar_sesion;
            picCerrarSesion.Location = new Point(3, 12);
            picCerrarSesion.Name = "picCerrarSesion";
            picCerrarSesion.Size = new Size(60, 45);
            picCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrarSesion.TabIndex = 24;
            picCerrarSesion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 12);
            label1.Name = "label1";
            label1.Size = new Size(466, 47);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // txtPrecio
            // 
            txtPrecio.AnimateReadOnly = false;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Depth = 0;
            txtPrecio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecio.LeadingIcon = null;
            txtPrecio.Location = new Point(369, 161);
            txtPrecio.MaxLength = 50;
            txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 36);
            txtPrecio.TabIndex = 24;
            txtPrecio.Text = "";
            txtPrecio.TrailingIcon = null;
            txtPrecio.UseTallSize = false;
            txtPrecio.KeyPress += txtCantidad_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(122, 119);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 36);
            txtNombre.TabIndex = 22;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            txtNombre.UseTallSize = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(310, 178);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(53, 19);
            materialLabel3.TabIndex = 27;
            materialLabel3.Text = "Precio: ";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(43, 181);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(73, 19);
            materialLabel2.TabIndex = 26;
            materialLabel2.Text = "Cantidad: ";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(55, 128);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(61, 19);
            materialLabel1.TabIndex = 25;
            materialLabel1.Text = "Nombre:";
            // 
            // txtCategotia
            // 
            txtCategotia.AnimateReadOnly = false;
            txtCategotia.BorderStyle = BorderStyle.None;
            txtCategotia.Depth = 0;
            txtCategotia.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategotia.LeadingIcon = null;
            txtCategotia.Location = new Point(369, 119);
            txtCategotia.MaxLength = 50;
            txtCategotia.MouseState = MaterialSkin.MouseState.OUT;
            txtCategotia.Multiline = false;
            txtCategotia.Name = "txtCategotia";
            txtCategotia.Size = new Size(152, 36);
            txtCategotia.TabIndex = 28;
            txtCategotia.Text = "";
            txtCategotia.TrailingIcon = null;
            txtCategotia.UseTallSize = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(286, 129);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(73, 19);
            materialLabel7.TabIndex = 29;
            materialLabel7.Text = "Categoria:";
            // 
            // btnExaminar
            // 
            btnExaminar.AutoSize = false;
            btnExaminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExaminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExaminar.Depth = 0;
            btnExaminar.HighEmphasis = true;
            btnExaminar.Icon = null;
            btnExaminar.Location = new Point(582, 236);
            btnExaminar.Margin = new Padding(4, 6, 4, 6);
            btnExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnExaminar.Name = "btnExaminar";
            btnExaminar.NoAccentTextColor = Color.Empty;
            btnExaminar.Size = new Size(111, 36);
            btnExaminar.TabIndex = 36;
            btnExaminar.Text = "Examinar";
            btnExaminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExaminar.UseAccentColor = false;
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // picImagen
            // 
            picImagen.Image = Properties.Resources.libros__2_;
            picImagen.Location = new Point(582, 119);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(111, 108);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 35;
            picImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(296, 206);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMultiUso
            // 
            btnMultiUso.AutoSize = false;
            btnMultiUso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMultiUso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMultiUso.Depth = 0;
            btnMultiUso.HighEmphasis = true;
            btnMultiUso.Icon = null;
            btnMultiUso.Location = new Point(416, 206);
            btnMultiUso.Margin = new Padding(4, 6, 4, 6);
            btnMultiUso.MouseState = MaterialSkin.MouseState.HOVER;
            btnMultiUso.Name = "btnMultiUso";
            btnMultiUso.NoAccentTextColor = Color.Empty;
            btnMultiUso.Size = new Size(105, 36);
            btnMultiUso.TabIndex = 37;
            btnMultiUso.Text = "GUARDAR";
            btnMultiUso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnMultiUso.UseAccentColor = false;
            btnMultiUso.UseVisualStyleBackColor = true;
            btnMultiUso.Click += btnMultiUso_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.LightGreen;
            dataGridViewCellStyle4.ForeColor = Color.DarkGreen;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.LightGreen;
            dgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.ForestGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar, ID, Nombre, Categoria, Cantidad, Precio, Foto });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Honeydew;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle6.SelectionBackColor = Color.Green;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(6, 323);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(788, 121);
            dgvProductos.TabIndex = 39;
            dgvProductos.CellContentClick += dgvLibros_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Width = 75;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 75;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cantidad.HeaderText = "Cant";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 75;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(41, 296);
            lblID.Name = "lblID";
            lblID.Size = new Size(17, 15);
            lblID.TabIndex = 40;
            lblID.Text = "id";
            lblID.Visible = false;
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = SystemColors.InfoText;
            nudCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidad.ForeColor = SystemColors.Window;
            nudCantidad.Location = new Point(122, 172);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(152, 33);
            nudCantidad.TabIndex = 42;
            // 
            // frm_Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCantidad);
            Controls.Add(lblID);
            Controls.Add(dgvProductos);
            Controls.Add(btnCancelar);
            Controls.Add(btnMultiUso);
            Controls.Add(btnExaminar);
            Controls.Add(picImagen);
            Controls.Add(txtCategotia);
            Controls.Add(materialLabel7);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "frm_Libros";
            Padding = new Padding(3, 24, 3, 3);
            Text = "frm_Productos";
            Load += frm_Productos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox picCerrarSesion;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCategotia;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton btnExaminar;
        private PictureBox picImagen;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnMultiUso;
        private DataGridView dgvProductos;
        private Label lblID;
        private DataGridViewTextBoxColumn btnEditar;
        private DataGridViewTextBoxColumn btnEliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Foto;
        private NumericUpDown nudCantidad;
    }
}