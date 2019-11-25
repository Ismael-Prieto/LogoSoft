namespace LogoSoftDesktop
{
    partial class FrmFacturacionProductosBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacionProductosBusqueda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Buscar_Producto = new System.Windows.Forms.Button();
            this.Grid_Productos = new System.Windows.Forms.DataGridView();
            this.Producto_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(78, 12);
            this.Txt_Nombre.MaxLength = 100;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(431, 22);
            this.Txt_Nombre.TabIndex = 3;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Buscar_Producto
            // 
            this.Btn_Buscar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar_Producto.Image")));
            this.Btn_Buscar_Producto.Location = new System.Drawing.Point(515, 7);
            this.Btn_Buscar_Producto.Name = "Btn_Buscar_Producto";
            this.Btn_Buscar_Producto.Size = new System.Drawing.Size(105, 32);
            this.Btn_Buscar_Producto.TabIndex = 11;
            this.Btn_Buscar_Producto.Text = "Buscar";
            this.Btn_Buscar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar_Producto.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Producto.Click += new System.EventHandler(this.Btn_Buscar_Producto_Click);
            // 
            // Grid_Productos
            // 
            this.Grid_Productos.AllowUserToAddRows = false;
            this.Grid_Productos.AllowUserToDeleteRows = false;
            this.Grid_Productos.AllowUserToOrderColumns = true;
            this.Grid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto_ID,
            this.Codigo,
            this.Nombre,
            this.Precio});
            this.Grid_Productos.Location = new System.Drawing.Point(13, 47);
            this.Grid_Productos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grid_Productos.Name = "Grid_Productos";
            this.Grid_Productos.ReadOnly = true;
            this.Grid_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Productos.Size = new System.Drawing.Size(607, 202);
            this.Grid_Productos.TabIndex = 12;
            this.Grid_Productos.SelectionChanged += new System.EventHandler(this.Grid_Productos_SelectionChanged);
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
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Location = new System.Drawing.Point(13, 257);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(99, 35);
            this.Btn_Regresar.TabIndex = 13;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // FrmFacturacionProductosBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 299);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Grid_Productos);
            this.Controls.Add(this.Btn_Buscar_Producto);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label2);
            this.Name = "FrmFacturacionProductosBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Productos";
            this.Load += new System.EventHandler(this.FrmFacturacionProductosBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Buscar_Producto;
        private System.Windows.Forms.DataGridView Grid_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button Btn_Regresar;
    }
}