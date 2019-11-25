namespace LogoSoftDesktop
{
    partial class FrmProductoListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoListado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Agregar_Producto = new System.Windows.Forms.ToolStripButton();
            this.Grid_Productos = new System.Windows.Forms.DataGridView();
            this.Producto_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Agregar_Producto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Agregar_Producto
            // 
            this.Btn_Agregar_Producto.BackColor = System.Drawing.Color.White;
            this.Btn_Agregar_Producto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Agregar_Producto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Producto.Image")));
            this.Btn_Agregar_Producto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Agregar_Producto.Name = "Btn_Agregar_Producto";
            this.Btn_Agregar_Producto.Size = new System.Drawing.Size(121, 22);
            this.Btn_Agregar_Producto.Text = "Agregar Producto";
            this.Btn_Agregar_Producto.Click += new System.EventHandler(this.Btn_Agregar_Producto_Click);
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
            this.Grid_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Productos.Location = new System.Drawing.Point(0, 25);
            this.Grid_Productos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grid_Productos.Name = "Grid_Productos";
            this.Grid_Productos.ReadOnly = true;
            this.Grid_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Productos.Size = new System.Drawing.Size(1200, 667);
            this.Grid_Productos.TabIndex = 1;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // FrmProductoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Grid_Productos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductoListado";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Agregar_Producto;
        private System.Windows.Forms.DataGridView Grid_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}