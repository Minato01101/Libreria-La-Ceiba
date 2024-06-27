namespace LibreriaCeiba
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            txtClave = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            label1 = new Label();
            btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(72, 174);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 50);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.AnimateReadOnly = false;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Depth = 0;
            txtClave.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClave.LeadingIcon = null;
            txtClave.Location = new Point(72, 277);
            txtClave.MaxLength = 50;
            txtClave.MouseState = MaterialSkin.MouseState.OUT;
            txtClave.Multiline = false;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(253, 50);
            txtClave.TabIndex = 2;
            txtClave.Text = "";
            txtClave.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.None;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(72, 152);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.None;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(72, 255);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(82, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 85);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(126, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 51);
            label1.TabIndex = 0;
            label1.Text = "Logg in";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.None;
            btnSiguiente.AutoSize = false;
            btnSiguiente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSiguiente.Depth = 0;
            btnSiguiente.HighEmphasis = true;
            btnSiguiente.Icon = null;
            btnSiguiente.Location = new Point(118, 371);
            btnSiguiente.Margin = new Padding(4, 6, 4, 6);
            btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.NoAccentTextColor = Color.Empty;
            btnSiguiente.Size = new Size(158, 36);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSiguiente.UseAccentColor = false;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 517);
            Controls.Add(panel1);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(btnSiguiente);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            FormStyle = FormStyles.ActionBar_None;
            HelpButton = true;
            Name = "frm_login";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Libreria la Ceiba";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtClave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Panel panel1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
    }
}
