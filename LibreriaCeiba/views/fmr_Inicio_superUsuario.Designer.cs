namespace LibreriaCeiba.views
{
    partial class fmr_Inicio_superUsuario
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
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            picVender = new PictureBox();
            picAdminUsuarios = new PictureBox();
            picVentas = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            picControlUsuario = new PictureBox();
            picCerrarSesion = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdminUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVentas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picControlUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(materialLabel6);
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(picVender);
            panel2.Controls.Add(picAdminUsuarios);
            panel2.Controls.Add(picVentas);
            panel2.Location = new Point(91, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 311);
            panel2.TabIndex = 14;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(273, 160);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(76, 19);
            materialLabel1.TabIndex = 24;
            materialLabel1.Text = "USUARIOS";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(434, 140);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(61, 19);
            materialLabel6.TabIndex = 23;
            materialLabel6.Text = "VENDER";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(259, 141);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(105, 19);
            materialLabel5.TabIndex = 22;
            materialLabel5.Text = "ADMINISTRAR";
            materialLabel5.Click += materialLabel5_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(85, 141);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(61, 19);
            materialLabel4.TabIndex = 21;
            materialLabel4.Text = "VENTAS";
            // 
            // picVender
            // 
            picVender.Image = Properties.Resources.carrito_de_compras__1_;
            picVender.Location = new Point(434, 34);
            picVender.Name = "picVender";
            picVender.Size = new Size(100, 100);
            picVender.SizeMode = PictureBoxSizeMode.Zoom;
            picVender.TabIndex = 17;
            picVender.TabStop = false;
            picVender.Click += picVender_Click;
            // 
            // picAdminUsuarios
            // 
            picAdminUsuarios.Image = Properties.Resources.grupo__1_;
            picAdminUsuarios.Location = new Point(259, 34);
            picAdminUsuarios.Name = "picAdminUsuarios";
            picAdminUsuarios.Size = new Size(100, 100);
            picAdminUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            picAdminUsuarios.TabIndex = 16;
            picAdminUsuarios.TabStop = false;
            picAdminUsuarios.Click += picAdminUsuarios_Click;
            // 
            // picVentas
            // 
            picVentas.Image = Properties.Resources.grafico_de_barras__1_;
            picVentas.Location = new Point(84, 34);
            picVentas.Name = "picVentas";
            picVentas.Size = new Size(100, 100);
            picVentas.SizeMode = PictureBoxSizeMode.Zoom;
            picVentas.TabIndex = 15;
            picVentas.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(76, 175, 80);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(picControlUsuario);
            panel1.Controls.Add(picCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 71);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(726, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 34);
            label2.TabIndex = 26;
            label2.Text = "Control\r\nUsuario";
            // 
            // picControlUsuario
            // 
            picControlUsuario.Image = Properties.Resources.control_parental;
            picControlUsuario.Location = new Point(724, 31);
            picControlUsuario.Name = "picControlUsuario";
            picControlUsuario.Size = new Size(60, 45);
            picControlUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picControlUsuario.TabIndex = 25;
            picControlUsuario.TabStop = false;
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
            label1.Location = new Point(341, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 47);
            label1.TabIndex = 0;
            label1.Text = "INICIO";
            // 
            // fmr_Inicio_superUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormStyle = FormStyles.ActionBar_None;
            Name = "fmr_Inicio_superUsuario";
            Padding = new Padding(3, 24, 3, 3);
            Text = "fmr_Inicio_superUsuario";
            Shown += fmr_Inicio_superUsuario_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVender).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdminUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picControlUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private PictureBox picVender;
        private PictureBox picAdminUsuarios;
        private PictureBox picVentas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel1;
        private Label label2;
        private PictureBox picControlUsuario;
        private PictureBox picCerrarSesion;
        private Label label1;
    }
}