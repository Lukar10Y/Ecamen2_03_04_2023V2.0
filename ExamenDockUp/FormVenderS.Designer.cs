using System.Windows.Forms;

namespace Vender
{
    partial class FormVenderS
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.dtgvVender = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gBoxNuevoProducto = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBoxProductos = new System.Windows.Forms.GroupBox();
            this.lstvProductos = new System.Windows.Forms.ListView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVender)).BeginInit();
            this.gBoxNuevoProducto.SuspendLayout();
            this.gBoxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvVender
            // 
            this.dtgvVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.dataGridViewTextBoxColumn1});
            this.dtgvVender.Location = new System.Drawing.Point(9, 206);
            this.dtgvVender.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvVender.Name = "dtgvVender";
            this.dtgvVender.RowHeadersWidth = 51;
            this.dtgvVender.RowTemplate.Height = 29;
            this.dtgvVender.Size = new System.Drawing.Size(522, 216);
            this.dtgvVender.TabIndex = 0;
            this.dtgvVender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVender_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 36);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(89, 62);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(95, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 63);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(89, 89);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(95, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 92);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(89, 117);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(95, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 119);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(241, 63);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 29);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(241, 97);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(70, 30);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // gBoxNuevoProducto
            // 
            this.gBoxNuevoProducto.Controls.Add(this.txtPrecio);
            this.gBoxNuevoProducto.Controls.Add(this.lblPrecio);
            this.gBoxNuevoProducto.Controls.Add(this.txtCantidad);
            this.gBoxNuevoProducto.Controls.Add(this.lblCantidad);
            this.gBoxNuevoProducto.Controls.Add(this.txtDescripcion);
            this.gBoxNuevoProducto.Controls.Add(this.lblDescripcion);
            this.gBoxNuevoProducto.Controls.Add(this.txtCodigo);
            this.gBoxNuevoProducto.Controls.Add(this.lblCodigo);
            this.gBoxNuevoProducto.Location = new System.Drawing.Point(19, 51);
            this.gBoxNuevoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxNuevoProducto.Name = "gBoxNuevoProducto";
            this.gBoxNuevoProducto.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxNuevoProducto.Size = new System.Drawing.Size(211, 151);
            this.gBoxNuevoProducto.TabIndex = 13;
            this.gBoxNuevoProducto.TabStop = false;
            this.gBoxNuevoProducto.Text = "Nuevo Producto";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 17);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 15;
            // 
            // gBoxProductos
            // 
            this.gBoxProductos.Controls.Add(this.lstvProductos);
            this.gBoxProductos.Location = new System.Drawing.Point(331, 51);
            this.gBoxProductos.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxProductos.Name = "gBoxProductos";
            this.gBoxProductos.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxProductos.Size = new System.Drawing.Size(200, 151);
            this.gBoxProductos.TabIndex = 16;
            this.gBoxProductos.TabStop = false;
            this.gBoxProductos.Text = "Productos";
            // 
            // lstvProductos
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lstvProductos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstvProductos.HideSelection = false;
            this.lstvProductos.Location = new System.Drawing.Point(4, 15);
            this.lstvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.lstvProductos.Name = "lstvProductos";
            this.lstvProductos.Size = new System.Drawing.Size(187, 134);
            this.lstvProductos.TabIndex = 0;
            this.lstvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(547, 328);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 17;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(547, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormVenderS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.gBoxProductos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.gBoxNuevoProducto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtgvVender);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVenderS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVenderS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVender)).EndInit();
            this.gBoxNuevoProducto.ResumeLayout(false);
            this.gBoxNuevoProducto.PerformLayout();
            this.gBoxProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvVender;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button btnCrear;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private GroupBox gBoxNuevoProducto;
        private Label lblCliente;
        private TextBox textBox1;
        private GroupBox gBoxProductos;
        private ListView lstvProductos;
        private Button btnFacturar;
        private Button btnAgregar;
    }
}