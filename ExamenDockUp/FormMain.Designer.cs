namespace ExamenDockUp
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarrasDecoracion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pDatosUsuario = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbConfiguracion = new System.Windows.Forms.PictureBox();
            this.rtbConfiguracion = new System.Windows.Forms.RichTextBox();
            this.pDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguracion)).BeginInit();
            this.SuspendLayout();
            // 
            // BarrasDecoracion
            // 
            this.BarrasDecoracion.BackColor = System.Drawing.Color.DarkBlue;
            this.BarrasDecoracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarrasDecoracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarrasDecoracion.Location = new System.Drawing.Point(0, 340);
            this.BarrasDecoracion.Name = "BarrasDecoracion";
            this.BarrasDecoracion.Size = new System.Drawing.Size(492, 12);
            this.BarrasDecoracion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 12);
            this.label1.TabIndex = 1;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(49, 101);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(124, 50);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(49, 217);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(124, 50);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Gestion de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pDatosUsuario
            // 
            this.pDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pDatosUsuario.Controls.Add(this.lblCargo);
            this.pDatosUsuario.Controls.Add(this.lblNombre);
            this.pDatosUsuario.Controls.Add(this.btnCerrarSesion);
            this.pDatosUsuario.Controls.Add(this.pictureBox1);
            this.pDatosUsuario.Location = new System.Drawing.Point(236, 241);
            this.pDatosUsuario.Name = "pDatosUsuario";
            this.pDatosUsuario.Size = new System.Drawing.Size(256, 94);
            this.pDatosUsuario.TabIndex = 9;
            // 
            // lblCargo
            // 
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(1, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(138, 23);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo del Usuario";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(1, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(138, 23);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre de Usuario";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(43, 59);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(96, 26);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ExamenDockUp.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(145, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ExamenDockUp.Properties.Resources.Carrito;
            this.pictureBox2.Location = new System.Drawing.Point(67, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // gBoxAdmin
            // 
            this.gBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.gBoxAdmin.Controls.Add(this.btnEmpresa);
            this.gBoxAdmin.Controls.Add(this.btnProductos);
            this.gBoxAdmin.Location = new System.Drawing.Point(274, 27);
            this.gBoxAdmin.Name = "gBoxAdmin";
            this.gBoxAdmin.Size = new System.Drawing.Size(196, 134);
            this.gBoxAdmin.TabIndex = 11;
            this.gBoxAdmin.TabStop = false;
            this.gBoxAdmin.Text = "Admin";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(38, 74);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(124, 50);
            this.btnEmpresa.TabIndex = 3;
            this.btnEmpresa.Text = "Gestion de Datos de Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(38, 18);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(124, 50);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Gestion de Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 6);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 6);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(0, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(6, 316);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(486, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(6, 316);
            this.label5.TabIndex = 15;
            // 
            // pbConfiguracion
            // 
            this.pbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfiguracion.Image = global::ExamenDockUp.Properties.Resources.Configuracion;
            this.pbConfiguracion.Location = new System.Drawing.Point(13, 289);
            this.pbConfiguracion.Name = "pbConfiguracion";
            this.pbConfiguracion.Size = new System.Drawing.Size(40, 40);
            this.pbConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfiguracion.TabIndex = 16;
            this.pbConfiguracion.TabStop = false;
            this.pbConfiguracion.Click += new System.EventHandler(this.pbConfiguracion_Click);
            // 
            // rtbConfiguracion
            // 
            this.rtbConfiguracion.BackColor = System.Drawing.Color.White;
            this.rtbConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtbConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConfiguracion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtbConfiguracion.Location = new System.Drawing.Point(56, 297);
            this.rtbConfiguracion.Name = "rtbConfiguracion";
            this.rtbConfiguracion.ReadOnly = true;
            this.rtbConfiguracion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbConfiguracion.Size = new System.Drawing.Size(77, 29);
            this.rtbConfiguracion.TabIndex = 17;
            this.rtbConfiguracion.TabStop = false;
            this.rtbConfiguracion.Text = "Configuracion de Usuario";
            this.rtbConfiguracion.Click += new System.EventHandler(this.rtbConfiguracion_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenDockUp.Properties.Resources.BackgroundLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 352);
            this.Controls.Add(this.rtbConfiguracion);
            this.Controls.Add(this.pbConfiguracion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBoxAdmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pDatosUsuario);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarrasDecoracion);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pDatosUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gBoxAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BarrasDecoracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pDatosUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gBoxAdmin;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbConfiguracion;
        private System.Windows.Forms.RichTextBox rtbConfiguracion;
    }
}

