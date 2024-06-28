namespace LibreriaCeiba.views
{
    partial class fmr_Inicio_Vendedor
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblNombreVendedor = new Label();
            label2 = new Label();
            picCerrarSesion = new PictureBox();
            label1 = new Label();
            dgvCarrito = new DataGridView();
            idCarrito = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtBuscarProductos = new MaterialSkin.Controls.MaterialTextBox();
            dgvProductos = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Tipo2 = new DataGridViewTextBoxColumn();
            Precio2 = new DataGridViewTextBoxColumn();
            btnAñadir = new MaterialSkin.Controls.MaterialButton();
            numericUpDown1 = new NumericUpDown();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btnVender = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(76, 175, 80);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNombreVendedor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(picCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 76);
            panel1.TabIndex = 16;
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreVendedor.ForeColor = Color.White;
            lblNombreVendedor.Location = new Point(708, 17);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(79, 40);
            lblNombreVendedor.TabIndex = 27;
            lblNombreVendedor.Text = "-------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(708, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 26;
            label2.Text = "VENDEDOR";
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
            label1.Location = new Point(252, 12);
            label1.Name = "label1";
            label1.Size = new Size(321, 47);
            label1.TabIndex = 0;
            label1.Text = "PUNTO DE VENTA";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.LightGreen;
            dataGridViewCellStyle9.ForeColor = Color.DarkGreen;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.LightGreen;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(76, 175, 80);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { idCarrito, Detalles, Tipo, Cantidad, Precio, Total });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Honeydew;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle13.SelectionBackColor = Color.Green;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle13;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.Location = new Point(6, 132);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(459, 202);
            dgvCarrito.TabIndex = 17;
            // 
            // idCarrito
            // 
            idCarrito.HeaderText = "ID";
            idCarrito.Name = "idCarrito";
            idCarrito.ReadOnly = true;
            // 
            // Detalles
            // 
            Detalles.FillWeight = 93.27411F;
            Detalles.HeaderText = "Detalles";
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.FillWeight = 93.27411F;
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cantidad.FillWeight = 126.903557F;
            Cantidad.HeaderText = "Cant";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 50;
            // 
            // Precio
            // 
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle11;
            Precio.FillWeight = 93.27411F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle12;
            Total.FillWeight = 93.27411F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Anchor = AnchorStyles.None;
            txtBuscarProductos.AnimateReadOnly = false;
            txtBuscarProductos.BorderStyle = BorderStyle.None;
            txtBuscarProductos.Depth = 0;
            txtBuscarProductos.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProductos.LeadingIcon = null;
            txtBuscarProductos.Location = new Point(495, 115);
            txtBuscarProductos.MaxLength = 50;
            txtBuscarProductos.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarProductos.Multiline = false;
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(284, 50);
            txtBuscarProductos.TabIndex = 18;
            txtBuscarProductos.Text = "";
            txtBuscarProductos.TrailingIcon = Properties.Resources.lupa;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = Color.LightGreen;
            dataGridViewCellStyle14.ForeColor = Color.DarkGreen;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.LightGreen;
            dgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(76, 175, 80);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Detalle, Tipo2, Precio2 });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.Honeydew;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle16.SelectionBackColor = Color.Green;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle16;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(495, 184);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(284, 150);
            dgvProductos.TabIndex = 19;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "ID";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            // 
            // Tipo2
            // 
            Tipo2.HeaderText = "Tipo";
            Tipo2.Name = "Tipo2";
            Tipo2.ReadOnly = true;
            // 
            // Precio2
            // 
            Precio2.HeaderText = "Precio";
            Precio2.Name = "Precio2";
            Precio2.ReadOnly = true;
            // 
            // btnAñadir
            // 
            btnAñadir.AutoSize = false;
            btnAñadir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAñadir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAñadir.Depth = 0;
            btnAñadir.HighEmphasis = true;
            btnAñadir.Icon = Properties.Resources.anadir_al_carrito;
            btnAñadir.Location = new Point(585, 384);
            btnAñadir.Margin = new Padding(4, 6, 4, 6);
            btnAñadir.MouseState = MaterialSkin.MouseState.HOVER;
            btnAñadir.Name = "btnAñadir";
            btnAñadir.NoAccentTextColor = Color.Empty;
            btnAñadir.Size = new Size(98, 36);
            btnAñadir.TabIndex = 20;
            btnAñadir.Text = "Añadir";
            btnAñadir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAñadir.UseAccentColor = false;
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(76, 175, 80);
            numericUpDown1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(585, 349);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(89, 25);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(510, 352);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(69, 19);
            materialLabel1.TabIndex = 22;
            materialLabel1.Text = "Cantidad:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(348, 359);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(70, 19);
            materialLabel2.TabIndex = 23;
            materialLabel2.Text = "SubTotal:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(420, 359);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(29, 19);
            materialLabel3.TabIndex = 24;
            materialLabel3.Text = "- - - -";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(739, 359);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(29, 19);
            materialLabel4.TabIndex = 26;
            materialLabel4.Text = "- - - -";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(691, 356);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(42, 19);
            materialLabel5.TabIndex = 25;
            materialLabel5.Text = "Total:";
            // 
            // btnVender
            // 
            btnVender.AutoSize = false;
            btnVender.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVender.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVender.Depth = 0;
            btnVender.HighEmphasis = true;
            btnVender.Icon = Properties.Resources.carrito_de_compras;
            btnVender.Location = new Point(132, 384);
            btnVender.Margin = new Padding(4, 6, 4, 6);
            btnVender.MouseState = MaterialSkin.MouseState.HOVER;
            btnVender.Name = "btnVender";
            btnVender.NoAccentTextColor = Color.Empty;
            btnVender.Size = new Size(162, 36);
            btnVender.TabIndex = 27;
            btnVender.Text = "Realizar Venta";
            btnVender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVender.UseAccentColor = false;
            btnVender.UseVisualStyleBackColor = true;
            // 
            // fmr_Inicio_Vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVender);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnAñadir);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscarProductos);
            Controls.Add(dgvCarrito);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "fmr_Inicio_Vendedor";
            Padding = new Padding(3, 24, 3, 3);
            Text = "fmr_Inicio_Vendedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox picCerrarSesion;
        private Label label1;
        private Label lblNombreVendedor;
        private DataGridView dgvCarrito;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarProductos;
        private DataGridView dgvProductos;
        private MaterialSkin.Controls.MaterialButton btnAñadir;
        private NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnVender;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Tipo2;
        private DataGridViewTextBoxColumn Precio2;
        private DataGridViewTextBoxColumn idCarrito;
        private DataGridViewTextBoxColumn Detalles;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
    }
}