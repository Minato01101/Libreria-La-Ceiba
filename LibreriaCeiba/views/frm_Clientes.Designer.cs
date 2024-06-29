namespace LibreriaCeiba.views
{
    partial class frm_Clientes
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
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mskTel = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnMultiUso = new MaterialSkin.Controls.MaterialButton();
            dgvClientes = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            lblID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            panel1.Location = new Point(-9, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 76);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(678, 1);
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
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(429, 120);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(152, 36);
            txtDireccion.TabIndex = 36;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseTallSize = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(349, 130);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(75, 19);
            materialLabel7.TabIndex = 37;
            materialLabel7.Text = "Direccion: ";
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(182, 165);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 36);
            txtApellido.TabIndex = 31;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            txtApellido.UseTallSize = false;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(182, 120);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 36);
            txtNombre.TabIndex = 30;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            txtNombre.UseTallSize = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(391, 179);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(27, 19);
            materialLabel3.TabIndex = 35;
            materialLabel3.Text = "Tel:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(112, 181);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(66, 19);
            materialLabel2.TabIndex = 34;
            materialLabel2.Text = "Apellido: ";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(115, 129);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(61, 19);
            materialLabel1.TabIndex = 33;
            materialLabel1.Text = "Nombre:";
            // 
            // mskTel
            // 
            mskTel.AllowPromptAsInput = true;
            mskTel.AnimateReadOnly = false;
            mskTel.AsciiOnly = false;
            mskTel.BackgroundImageLayout = ImageLayout.None;
            mskTel.BeepOnError = false;
            mskTel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mskTel.Depth = 0;
            mskTel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mskTel.HidePromptOnLeave = false;
            mskTel.HideSelection = true;
            mskTel.InsertKeyMode = InsertKeyMode.Default;
            mskTel.LeadingIcon = null;
            mskTel.Location = new Point(429, 165);
            mskTel.Mask = "0000-0000";
            mskTel.MaxLength = 32767;
            mskTel.MouseState = MaterialSkin.MouseState.OUT;
            mskTel.Name = "mskTel";
            mskTel.PasswordChar = '\0';
            mskTel.PrefixSuffixText = null;
            mskTel.PromptChar = '_';
            mskTel.ReadOnly = false;
            mskTel.RejectInputOnFirstFailure = false;
            mskTel.ResetOnPrompt = true;
            mskTel.ResetOnSpace = true;
            mskTel.RightToLeft = RightToLeft.No;
            mskTel.SelectedText = "";
            mskTel.SelectionLength = 0;
            mskTel.SelectionStart = 0;
            mskTel.ShortcutsEnabled = true;
            mskTel.Size = new Size(152, 36);
            mskTel.SkipLiterals = true;
            mskTel.TabIndex = 38;
            mskTel.TabStop = false;
            mskTel.Text = "    -";
            mskTel.TextAlign = HorizontalAlignment.Left;
            mskTel.TextMaskFormat = MaskFormat.IncludeLiterals;
            mskTel.TrailingIcon = null;
            mskTel.UseSystemPasswordChar = false;
            mskTel.UseTallSize = false;
            mskTel.ValidatingType = null;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(356, 231);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 40;
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
            btnMultiUso.Location = new Point(476, 231);
            btnMultiUso.Margin = new Padding(4, 6, 4, 6);
            btnMultiUso.MouseState = MaterialSkin.MouseState.HOVER;
            btnMultiUso.Name = "btnMultiUso";
            btnMultiUso.NoAccentTextColor = Color.Empty;
            btnMultiUso.Size = new Size(105, 36);
            btnMultiUso.TabIndex = 39;
            btnMultiUso.Text = "GUARDAR";
            btnMultiUso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnMultiUso.UseAccentColor = false;
            btnMultiUso.UseVisualStyleBackColor = true;
            btnMultiUso.Click += btnMultiUso_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGreen;
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.LightGreen;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.ForestGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar, IdCliente, Nombre, Apellido, Direccion, Tel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(6, 294);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(788, 150);
            dgvClientes.TabIndex = 41;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Width = 70;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 70;
            // 
            // IdCliente
            // 
            IdCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IdCliente.HeaderText = "ID";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.Width = 75;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Tel
            // 
            Tel.HeaderText = "Tel";
            Tel.Name = "Tel";
            Tel.ReadOnly = true;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(115, 252);
            lblID.Name = "lblID";
            lblID.Size = new Size(17, 15);
            lblID.TabIndex = 42;
            lblID.Text = "id";
            lblID.Visible = false;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblID);
            Controls.Add(dgvClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnMultiUso);
            Controls.Add(mskTel);
            Controls.Add(txtDireccion);
            Controls.Add(materialLabel7);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "frm_Clientes";
            Padding = new Padding(3, 24, 3, 3);
            Text = "frm_Clientes";
            Load += frm_Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox picCerrarSesion;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskTel;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnMultiUso;
        private DataGridView dgvClientes;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Tel;
        private Label lblID;
    }
}