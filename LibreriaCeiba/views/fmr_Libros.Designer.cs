﻿namespace LibreriaCeiba.views
{
    partial class fmr_Libros
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            picCerrarSesion = new PictureBox();
            label1 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            txtEditorial = new MaterialSkin.Controls.MaterialTextBox();
            txtAutor = new MaterialSkin.Controls.MaterialTextBox();
            dtpFecha = new DateTimePicker();
            picImagen = new PictureBox();
            btnExaminar = new MaterialSkin.Controls.MaterialButton();
            btnMultiUso = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            lblID = new Label();
            dgvLibros = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            nudCantidad = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
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
            panel1.Location = new Point(-6, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 76);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(674, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 27;
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
            label1.Location = new Point(224, 12);
            label1.Name = "label1";
            label1.Size = new Size(375, 47);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIBROS";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(62, 132);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(61, 19);
            materialLabel1.TabIndex = 19;
            materialLabel1.Text = "Nombre:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(50, 185);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(73, 19);
            materialLabel2.TabIndex = 20;
            materialLabel2.Text = "Cantidad: ";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(70, 227);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(53, 19);
            materialLabel3.TabIndex = 21;
            materialLabel3.Text = "Precio: ";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(347, 223);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(47, 19);
            materialLabel4.TabIndex = 22;
            materialLabel4.Text = "Autor: ";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(310, 185);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(84, 19);
            materialLabel5.TabIndex = 25;
            materialLabel5.Text = "Publicacion";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(329, 166);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(65, 19);
            materialLabel6.TabIndex = 24;
            materialLabel6.Text = "Fecha de";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(327, 132);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(67, 19);
            materialLabel7.TabIndex = 23;
            materialLabel7.Text = "Editorial: ";
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(129, 123);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 36);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            txtNombre.UseTallSize = false;
            // 
            // txtPrecio
            // 
            txtPrecio.AnimateReadOnly = false;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Depth = 0;
            txtPrecio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecio.LeadingIcon = null;
            txtPrecio.Location = new Point(129, 210);
            txtPrecio.MaxLength = 50;
            txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 36);
            txtPrecio.TabIndex = 3;
            txtPrecio.Text = "";
            txtPrecio.TrailingIcon = null;
            txtPrecio.UseTallSize = false;
            txtPrecio.KeyPress += materialTextBox2_KeyPress;
            // 
            // txtEditorial
            // 
            txtEditorial.AnimateReadOnly = false;
            txtEditorial.BorderStyle = BorderStyle.None;
            txtEditorial.Depth = 0;
            txtEditorial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEditorial.LeadingIcon = null;
            txtEditorial.Location = new Point(400, 122);
            txtEditorial.MaxLength = 50;
            txtEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtEditorial.Multiline = false;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(152, 36);
            txtEditorial.TabIndex = 4;
            txtEditorial.Text = "";
            txtEditorial.TrailingIcon = null;
            txtEditorial.UseTallSize = false;
            // 
            // txtAutor
            // 
            txtAutor.AnimateReadOnly = false;
            txtAutor.BorderStyle = BorderStyle.None;
            txtAutor.Depth = 0;
            txtAutor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAutor.LeadingIcon = null;
            txtAutor.Location = new Point(400, 210);
            txtAutor.MaxLength = 50;
            txtAutor.MouseState = MaterialSkin.MouseState.OUT;
            txtAutor.Multiline = false;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(152, 36);
            txtAutor.TabIndex = 6;
            txtAutor.Text = "";
            txtAutor.TrailingIcon = null;
            txtAutor.UseTallSize = false;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.CalendarForeColor = Color.Honeydew;
            dtpFecha.CalendarTitleBackColor = Color.FromArgb(76, 175, 80);
            dtpFecha.CalendarTitleForeColor = Color.White;
            dtpFecha.DropDownAlign = LeftRightAlignment.Right;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(400, 168);
            dtpFecha.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(152, 23);
            dtpFecha.TabIndex = 5;
            // 
            // picImagen
            // 
            picImagen.Image = Properties.Resources.libros__2_;
            picImagen.Location = new Point(615, 122);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(111, 108);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 33;
            picImagen.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.AutoSize = false;
            btnExaminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExaminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExaminar.Depth = 0;
            btnExaminar.HighEmphasis = true;
            btnExaminar.Icon = null;
            btnExaminar.Location = new Point(615, 239);
            btnExaminar.Margin = new Padding(4, 6, 4, 6);
            btnExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnExaminar.Name = "btnExaminar";
            btnExaminar.NoAccentTextColor = Color.Empty;
            btnExaminar.Size = new Size(111, 36);
            btnExaminar.TabIndex = 34;
            btnExaminar.Text = "Examinar";
            btnExaminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExaminar.UseAccentColor = false;
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnMultiUso
            // 
            btnMultiUso.AutoSize = false;
            btnMultiUso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMultiUso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMultiUso.Depth = 0;
            btnMultiUso.HighEmphasis = true;
            btnMultiUso.Icon = null;
            btnMultiUso.Location = new Point(447, 270);
            btnMultiUso.Margin = new Padding(4, 6, 4, 6);
            btnMultiUso.MouseState = MaterialSkin.MouseState.HOVER;
            btnMultiUso.Name = "btnMultiUso";
            btnMultiUso.NoAccentTextColor = Color.Empty;
            btnMultiUso.Size = new Size(105, 36);
            btnMultiUso.TabIndex = 7;
            btnMultiUso.Text = "GUARDAR";
            btnMultiUso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnMultiUso.UseAccentColor = false;
            btnMultiUso.UseVisualStyleBackColor = true;
            btnMultiUso.Click += btnMultiUso_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(327, 270);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = SystemColors.Control;
            lblID.Location = new Point(51, 273);
            lblID.Name = "lblID";
            lblID.Size = new Size(17, 15);
            lblID.TabIndex = 37;
            lblID.Text = "id";
            lblID.Visible = false;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGreen;
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.LightGreen;
            dgvLibros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.ForestGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar, ID, Nombre, Cantidad, Precio, Foto, Autor, Editorial, Fecha });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.Location = new Point(6, 323);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(788, 154);
            dgvLibros.TabIndex = 40;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Resizable = DataGridViewTriState.True;
            btnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 65;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = DataGridViewTriState.True;
            btnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 65;
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
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            Editorial.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = SystemColors.InfoText;
            nudCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidad.ForeColor = SystemColors.Window;
            nudCantidad.Location = new Point(129, 171);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(152, 33);
            nudCantidad.TabIndex = 41;
            // 
            // fmr_Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(nudCantidad);
            Controls.Add(dgvLibros);
            Controls.Add(lblID);
            Controls.Add(btnCancelar);
            Controls.Add(btnMultiUso);
            Controls.Add(btnExaminar);
            Controls.Add(picImagen);
            Controls.Add(dtpFecha);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "fmr_Libros";
            Padding = new Padding(3, 24, 3, 3);
            Text = "fmr_Libros";
            Load += fmr_Libros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picCerrarSesion;
        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtEditorial;
        private MaterialSkin.Controls.MaterialTextBox txtAutor;
        private DateTimePicker dtpFecha;
        private PictureBox picImagen;
        private MaterialSkin.Controls.MaterialButton btnExaminar;
        private MaterialSkin.Controls.MaterialButton btnMultiUso;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private Label lblID;
        private Label label2;
        private DataGridView dgvLibros;
        private NumericUpDown nudCantidad;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Fecha;
    }
}