namespace LogoSoftDesktop
{
    partial class FrmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_Comprobante_Inicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Comprobante_Final = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Limpiar_Filtro = new System.Windows.Forms.Button();
            this.Grid_Ventas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Comprobante_Inicial
            // 
            this.Txt_Comprobante_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Comprobante_Inicial.Location = new System.Drawing.Point(176, 12);
            this.Txt_Comprobante_Inicial.MaxLength = 6;
            this.Txt_Comprobante_Inicial.Name = "Txt_Comprobante_Inicial";
            this.Txt_Comprobante_Inicial.Size = new System.Drawing.Size(135, 22);
            this.Txt_Comprobante_Inicial.TabIndex = 1;
            this.Txt_Comprobante_Inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Comprobante_Inicial_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Comprobante Inicial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Comprobante_Final
            // 
            this.Txt_Comprobante_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Comprobante_Final.Location = new System.Drawing.Point(474, 12);
            this.Txt_Comprobante_Final.MaxLength = 6;
            this.Txt_Comprobante_Final.Name = "Txt_Comprobante_Final";
            this.Txt_Comprobante_Final.Size = new System.Drawing.Size(135, 22);
            this.Txt_Comprobante_Final.TabIndex = 3;
            this.Txt_Comprobante_Final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Comprobante_Final_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Comprobante Final";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cliente.Location = new System.Drawing.Point(176, 40);
            this.Txt_Cliente.MaxLength = 15;
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(433, 22);
            this.Txt_Cliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Location = new System.Drawing.Point(903, 24);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(102, 35);
            this.Btn_Regresar.TabIndex = 21;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.Location = new System.Drawing.Point(615, 24);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(108, 35);
            this.Btn_Reporte.TabIndex = 20;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Limpiar_Filtro
            // 
            this.Btn_Limpiar_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Filtro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Filtro.Image")));
            this.Btn_Limpiar_Filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Filtro.Location = new System.Drawing.Point(742, 24);
            this.Btn_Limpiar_Filtro.Name = "Btn_Limpiar_Filtro";
            this.Btn_Limpiar_Filtro.Size = new System.Drawing.Size(108, 35);
            this.Btn_Limpiar_Filtro.TabIndex = 22;
            this.Btn_Limpiar_Filtro.Text = "Limpiar";
            this.Btn_Limpiar_Filtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar_Filtro.UseVisualStyleBackColor = true;
            this.Btn_Limpiar_Filtro.Click += new System.EventHandler(this.Btn_Limpiar_Filtro_Click);
            // 
            // Grid_Ventas
            // 
            this.Grid_Ventas.AllowUserToAddRows = false;
            this.Grid_Ventas.AllowUserToDeleteRows = false;
            this.Grid_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Numero_Comprobante,
            this.Cliente,
            this.SubTotal,
            this.Descuento,
            this.Total});
            this.Grid_Ventas.Location = new System.Drawing.Point(15, 70);
            this.Grid_Ventas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grid_Ventas.Name = "Grid_Ventas";
            this.Grid_Ventas.ReadOnly = true;
            this.Grid_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Ventas.Size = new System.Drawing.Size(990, 366);
            this.Grid_Ventas.TabIndex = 23;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Numero_Comprobante
            // 
            this.Numero_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero_Comprobante.DataPropertyName = "Numero_Comprobante";
            this.Numero_Comprobante.HeaderText = "No. Comprobante";
            this.Numero_Comprobante.Name = "Numero_Comprobante";
            this.Numero_Comprobante.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nombre_Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle7;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.Grid_Ventas);
            this.Controls.Add(this.Btn_Limpiar_Filtro);
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Comprobante_Final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Comprobante_Inicial);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Comprobante_Inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Comprobante_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Limpiar_Filtro;
        private System.Windows.Forms.DataGridView Grid_Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}