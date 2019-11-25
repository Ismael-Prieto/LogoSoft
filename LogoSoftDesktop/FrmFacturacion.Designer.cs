namespace LogoSoftDesktop
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Numero_Comprobante = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Buscar_Producto = new System.Windows.Forms.Button();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Descuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Grid_Productos = new System.Windows.Forms.DataGridView();
            this.Producto_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cedula.Location = new System.Drawing.Point(88, 55);
            this.Txt_Cedula.MaxLength = 15;
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(135, 22);
            this.Txt_Cedula.TabIndex = 3;
            this.Txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cedula_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cliente.Location = new System.Drawing.Point(390, 57);
            this.Txt_Cliente.MaxLength = 15;
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(398, 22);
            this.Txt_Cliente.TabIndex = 4;
            this.Txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cliente_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Enabled = false;
            this.Dtp_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(88, 27);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(135, 22);
            this.Dtp_Fecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Comprobante";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Numero_Comprobante
            // 
            this.Txt_Numero_Comprobante.Enabled = false;
            this.Txt_Numero_Comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Numero_Comprobante.Location = new System.Drawing.Point(390, 29);
            this.Txt_Numero_Comprobante.MaxLength = 15;
            this.Txt_Numero_Comprobante.Name = "Txt_Numero_Comprobante";
            this.Txt_Numero_Comprobante.Size = new System.Drawing.Size(398, 22);
            this.Txt_Numero_Comprobante.TabIndex = 2;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(88, 107);
            this.Txt_Codigo.MaxLength = 6;
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(135, 22);
            this.Txt_Codigo.TabIndex = 9;
            this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Codigo_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Buscar_Producto
            // 
            this.Btn_Buscar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar_Producto.Image")));
            this.Btn_Buscar_Producto.Location = new System.Drawing.Point(617, 102);
            this.Btn_Buscar_Producto.Name = "Btn_Buscar_Producto";
            this.Btn_Buscar_Producto.Size = new System.Drawing.Size(171, 32);
            this.Btn_Buscar_Producto.TabIndex = 10;
            this.Btn_Buscar_Producto.Text = "Buscar por Producto";
            this.Btn_Buscar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar_Producto.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Producto.Click += new System.EventHandler(this.Btn_Buscar_Producto_Click);
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.Enabled = false;
            this.Txt_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subtotal.Location = new System.Drawing.Point(653, 357);
            this.Txt_Subtotal.MaxLength = 20;
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.Size = new System.Drawing.Size(135, 22);
            this.Txt_Subtotal.TabIndex = 12;
            this.Txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "SubTotal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Descuento
            // 
            this.Txt_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descuento.Location = new System.Drawing.Point(653, 385);
            this.Txt_Descuento.MaxLength = 20;
            this.Txt_Descuento.Name = "Txt_Descuento";
            this.Txt_Descuento.Size = new System.Drawing.Size(135, 22);
            this.Txt_Descuento.TabIndex = 14;
            this.Txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Descuento.TextChanged += new System.EventHandler(this.Txt_Descuento_TextChanged);
            this.Txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descuento_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descuento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Enabled = false;
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(653, 413);
            this.Txt_Total.MaxLength = 20;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(135, 22);
            this.Txt_Total.TabIndex = 16;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(215, 400);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(145, 35);
            this.Btn_Guardar.TabIndex = 17;
            this.Btn_Guardar.Text = "Guardar Factura";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Grid_Productos
            // 
            this.Grid_Productos.AllowUserToAddRows = false;
            this.Grid_Productos.AllowUserToDeleteRows = false;
            this.Grid_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto_ID,
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.Grid_Productos.Location = new System.Drawing.Point(15, 137);
            this.Grid_Productos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grid_Productos.Name = "Grid_Productos";
            this.Grid_Productos.ReadOnly = true;
            this.Grid_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Productos.Size = new System.Drawing.Size(772, 212);
            this.Grid_Productos.TabIndex = 18;
            // 
            // Producto_ID
            // 
            this.Producto_ID.DataPropertyName = "Producto_ID";
            this.Producto_ID.HeaderText = "ID";
            this.Producto_ID.Name = "Producto_ID";
            this.Producto_ID.ReadOnly = true;
            this.Producto_ID.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle6;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Location = new System.Drawing.Point(390, 401);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(145, 35);
            this.Btn_Regresar.TabIndex = 19;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(15, 353);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(138, 37);
            this.Btn_Eliminar.TabIndex = 20;
            this.Btn_Eliminar.Text = "Eliminar Partida";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Grid_Productos);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Descuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Subtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Buscar_Producto);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Numero_Comprobante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Numero_Comprobante;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Buscar_Producto;
        private System.Windows.Forms.TextBox Txt_Subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridView Grid_Productos;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}