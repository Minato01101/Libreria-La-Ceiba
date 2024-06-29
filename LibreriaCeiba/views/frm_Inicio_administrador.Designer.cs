namespace LibreriaCeiba.views
{
    partial class frm_Inicio_administrador
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
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            picVender = new PictureBox();
            picClientes = new PictureBox();
            picVentas = new PictureBox();
            picInventario = new PictureBox();
            picProductos = new PictureBox();
            picLibros = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            picControlUsuario = new PictureBox();
            picCerrarSesion = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLibros).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picControlUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(materialLabel6);
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(picVender);
            panel2.Controls.Add(picClientes);
            panel2.Controls.Add(picVentas);
            panel2.Controls.Add(picInventario);
            panel2.Controls.Add(picProductos);
            panel2.Controls.Add(picLibros);
            panel2.Location = new Point(90, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 311);
            panel2.TabIndex = 13;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(435, 279);
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
            materialLabel5.Location = new Point(260, 279);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(73, 19);
            materialLabel5.TabIndex = 22;
            materialLabel5.Text = "CLIENTES";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(86, 280);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(61, 19);
            materialLabel4.TabIndex = 21;
            materialLabel4.Text = "VENTAS";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(435, 126);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(91, 19);
            materialLabel3.TabIndex = 20;
            materialLabel3.Text = "INVENTARIO";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(260, 126);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(94, 19);
            materialLabel2.TabIndex = 19;
            materialLabel2.Text = "PRODUCTOS";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(86, 125);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "LIBROS";
            // 
            // picVender
            // 
            picVender.Image = Properties.Resources.carrito_de_compras__1_;
            picVender.Location = new Point(435, 174);
            picVender.Name = "picVender";
            picVender.Size = new Size(100, 100);
            picVender.SizeMode = PictureBoxSizeMode.Zoom;
            picVender.TabIndex = 17;
            picVender.TabStop = false;
            picVender.Click += picVender_Click;
            // 
            // picClientes
            // 
            picClientes.Image = Properties.Resources.grupo__1_;
            picClientes.Location = new Point(260, 174);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(100, 100);
            picClientes.SizeMode = PictureBoxSizeMode.Zoom;
            picClientes.TabIndex = 16;
            picClientes.TabStop = false;
            picClientes.Click += picClientes_Click;
            // 
            // picVentas
            // 
            picVentas.Image = Properties.Resources.grafico_de_barras__1_;
            picVentas.Location = new Point(85, 174);
            picVentas.Name = "picVentas";
            picVentas.Size = new Size(100, 100);
            picVentas.SizeMode = PictureBoxSizeMode.Zoom;
            picVentas.TabIndex = 15;
            picVentas.TabStop = false;
            // 
            // picInventario
            // 
            picInventario.Image = Properties.Resources.inventario__1_;
            picInventario.Location = new Point(435, 17);
            picInventario.Name = "picInventario";
            picInventario.Size = new Size(100, 100);
            picInventario.SizeMode = PictureBoxSizeMode.Zoom;
            picInventario.TabIndex = 14;
            picInventario.TabStop = false;
            // 
            // picProductos
            // 
            picProductos.Image = Properties.Resources.deberes__1_;
            picProductos.Location = new Point(260, 17);
            picProductos.Name = "picProductos";
            picProductos.Size = new Size(100, 100);
            picProductos.SizeMode = PictureBoxSizeMode.Zoom;
            picProductos.TabIndex = 13;
            picProductos.TabStop = false;
            picProductos.Click += picProductos_Click;
            // 
            // picLibros
            // 
            picLibros.Image = Properties.Resources.libros__2_;
            picLibros.Location = new Point(85, 17);
            picLibros.Name = "picLibros";
            picLibros.Size = new Size(100, 100);
            picLibros.SizeMode = PictureBoxSizeMode.Zoom;
            picLibros.TabIndex = 12;
            picLibros.TabStop = false;
            picLibros.Click += picLibros_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(76, 175, 80);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(picControlUsuario);
            panel1.Controls.Add(picCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 71);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(743, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 34);
            label2.TabIndex = 26;
            label2.Text = "Control\r\nUsuario";
            // 
            // picControlUsuario
            // 
            picControlUsuario.Image = Properties.Resources.control_parental;
            picControlUsuario.Location = new Point(740, 31);
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
            picCerrarSesion.Click += picCerrarSesion_Click;
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
            // frm_Inicio_administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormStyle = FormStyles.ActionBar_None;
            Name = "frm_Inicio_administrador";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Inicio";
            Shown += frm_Inicio_administrador_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVender).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLibros).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox picVender;
        private PictureBox picClientes;
        private PictureBox picVentas;
        private PictureBox picInventario;
        private PictureBox picProductos;
        private PictureBox picLibros;
        private Panel panel1;
        private Label label1;
        private PictureBox picCerrarSesion;
        private Label label2;
        private PictureBox picControlUsuario;
    }
}