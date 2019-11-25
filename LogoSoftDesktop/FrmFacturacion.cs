using FastReport;
using LogoSoftDesktop.Datasets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace LogoSoftDesktop
{
    public partial class FrmFacturacion : Form
    {
        #region Variables
        List<typeDetalles> detallesProductos = new List<typeDetalles>();
        #endregion

        #region Constructor y Load
        public FrmFacturacion()
        {
            InitializeComponent();

            Grid_Productos.AutoGenerateColumns = false;
            Txt_Subtotal.Text = "0.00";
            Txt_Descuento.Text = "0.00";
            Txt_Total.Text = "0.00";
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            Dtp_Fecha.Value = DateTime.Now;
            Txt_Numero_Comprobante.Text = "Consecutivo se obtiene al guardar";
        }
        #endregion

        #region Metodos
        private async void Alta_Factura()
        {
            this.Cursor = Cursors.WaitCursor;

            typeFactura factura = new typeFactura();

            factura.Fecha = Dtp_Fecha.Value;
            factura.Cedula = Txt_Cedula.Text.Trim();
            factura.Cliente = Txt_Cliente.Text.Trim();
            decimal Subtotal = 0;
            decimal.TryParse(Txt_Subtotal.Text.Replace(",",""), out Subtotal);
            factura.Subtotal = Subtotal;
            decimal Descuento = 0;
            decimal.TryParse(Txt_Descuento.Text.Replace(",", ""), out Descuento);
            factura.Descuento = Descuento;
            decimal Total = 0;
            decimal.TryParse(Txt_Total.Text.Replace(",", ""), out Total);
            factura.Total = Total;
            factura.Detalles = detallesProductos;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(factura);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(Globales.Url_API + "facturacion/agregafactura", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var a = response.Content.ReadAsStringAsync();
                        var contents = JsonConvert.DeserializeObject<typeResponse>(response.Content.ReadAsStringAsync().Result);
                        Txt_Numero_Comprobante.Text = contents.Message;

                        DsFactura dsFactura1 = new DsFactura();
                        DataRow Registro;
                        
                        Registro = dsFactura1.Tables["Encabezado"].NewRow();
                        Registro["Numero_Documento"] = Txt_Numero_Comprobante.Text;
                        Registro["Fecha"] = Dtp_Fecha.Value;
                        Registro["Cedula"] = Txt_Cedula.Text;
                        Registro["Cliente"] = Txt_Cliente.Text;
                        Registro["SubTotal"] = Subtotal;
                        Registro["Descuento"] = Descuento;
                        Registro["Total"] = Total;
                        dsFactura1.Tables["Encabezado"].Rows.Add(Registro);

                        foreach (var detalle in detallesProductos)
                        {
                            Registro = dsFactura1.Tables["Detalles"].NewRow();
                            Registro["Cantidad"] = detalle.Cantidad;
                            Registro["Codigo"] = detalle.Codigo;
                            Registro["Nombre"] = detalle.Nombre;
                            Registro["Precio"] = detalle.Precio;
                            Registro["Importe"] = detalle.Importe;
                            dsFactura1.Tables["Detalles"].Rows.Add(Registro);
                        }


                        //rptFactura.Show();
                        //using (Report report = new Report())
                        //{
                        //    report.Load(AppDomain.CurrentDomain.BaseDirectory + "\\Reportes\\RptFormatoFactura.frx");
                        //    report.RegisterData(dsFactura1);
                        //    report.Show();
                        //}

                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Factura registrada");
                        Dtp_Fecha.Value = DateTime.Now;
                        Txt_Numero_Comprobante.Text = "Consecutivo se obtiene al guardar";
                        Txt_Cedula.Text = "";
                        Txt_Cliente.Text = "";
                        Txt_Subtotal.Text = "0.00";
                        Txt_Descuento.Text = "0.00";
                        Txt_Total.Text = "0.00";
                        detallesProductos.Clear();
                        Grid_Productos.DataSource = null;
                        Grid_Productos.DataSource = detallesProductos;                        
                        Txt_Codigo.Text = "";
                        Txt_Cedula.Focus();
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        var contents = JsonConvert.DeserializeObject<typeResponse>(response.Content.ReadAsStringAsync().Result);
                        MessageBox.Show(contents.Message);
                    }
                }
            }
        }

        private async void Buscar_Producto_Codigo()
        {
            Boolean encontroProducto = false;
            int indexProducto = 0;

            if (Txt_Codigo.Text.Trim() == "")
                return;

            this.Cursor = Cursors.WaitCursor;

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Globales.Url_API + "productos/consultaproductocodigo/" + Txt_Codigo.Text.Trim()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();

                        var productoJson = JsonConvert.DeserializeObject<typeProducto[]>(jsonString);
                        typeProducto producto = productoJson.FirstOrDefault();
                        if (producto != null)
                        {
                            foreach (var item in detallesProductos)
                            {
                                if (item.Producto_ID == producto.Producto_ID)
                                {
                                    encontroProducto = true;
                                    break;
                                }
                                indexProducto += 1;
                            }

                            if (!encontroProducto)
                            {
                                detallesProductos.Add(new typeDetalles { Producto_ID = producto.Producto_ID, Codigo = producto.Codigo, Nombre = producto.Nombre, Precio = producto.Precio, Cantidad = 1, Importe = producto.Precio });
                            }
                            else
                            {
                                var item = detallesProductos[indexProducto];
                                item.Cantidad += 1;
                                item.Importe = item.Cantidad * item.Precio;
                            }

                            Grid_Productos.DataSource = null;
                            Grid_Productos.DataSource = detallesProductos;

                            Calcula_Totales();

                        }
                        else
                        {
                            this.Cursor = Cursors.Default;                            
                            MessageBox.Show("Producto no encontrado");
                        }
                        Txt_Codigo.Text = "";
                        Txt_Codigo.Focus();
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        var contents = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(contents);
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void Calcula_Totales()
        {
            decimal Subtotal = 0;
            decimal Descuento = 0;
            foreach (var detalle in detallesProductos)
            {
                Subtotal += detalle.Importe;
            }
            Txt_Subtotal.Text = Subtotal.ToString("N2");
            decimal.TryParse(Txt_Descuento.Text.Replace(",", ""), out Descuento);
            Txt_Total.Text = (Subtotal - Descuento).ToString("N2");
        }
        #endregion

        #region Eventos
        private void Btn_Buscar_Producto_Click(object sender, EventArgs e)
        {
            FrmFacturacionProductosBusqueda frm = new FrmFacturacionProductosBusqueda();            
            frm.ShowDialog();
            if (frm._existenCambios)
            {
                if (frm._existenCambios)
                {
                    Boolean encontroProducto = false;
                    int indexProducto = 0;

                    foreach (var item in detallesProductos)
                    {
                        if (item.Producto_ID == frm._productoID)
                        {
                            encontroProducto = true;
                            break;
                        }
                        indexProducto += 1;
                    }

                    if (!encontroProducto)
                    {
                        detallesProductos.Add(new typeDetalles { Producto_ID = frm._productoID, Codigo = frm._codigo, Nombre = frm._nombre, Precio = frm._precio, Cantidad = 1, Importe = frm._precio });
                    }
                    else
                    {
                        var item = detallesProductos[indexProducto];
                        item.Cantidad += 1;
                        item.Importe = item.Cantidad * item.Precio;
                    }

                    Grid_Productos.DataSource = null;
                    Grid_Productos.DataSource = detallesProductos;

                    Calcula_Totales();

                    Txt_Codigo.Text = "";
                    Txt_Codigo.Focus();
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if(Txt_Cedula.Text.Trim() == "")
            {
                MessageBox.Show("Proporcione la cédula");
                Txt_Cedula.Focus();
                return;
            }
            if (Txt_Cliente.Text.Trim() == "")
            {
                MessageBox.Show("Proporcione el cliente");
                Txt_Cliente.Focus();
                return;
            }
            if(detallesProductos.Count == 0)
            {
                MessageBox.Show("Debe de agregar productos al listado");
                Txt_Codigo.Focus();
                return;
            }
            decimal total = 0;
            decimal.TryParse(Txt_Total.Text.Replace(",", ""), out total);
            if(total <= 0)
            {
                MessageBox.Show("El importe total no puede ser cero ni menor que cero");
                Txt_Codigo.Focus();
                return;
            }

            Alta_Factura();
        }        

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if(e.KeyChar == (char)Keys.Enter)
            {
                Buscar_Producto_Codigo();
            }
        }

        private void Txt_Descuento_TextChanged(object sender, EventArgs e)
        {
            Calcula_Totales();
        }

        private void Txt_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back ||

                e.KeyChar.ToString() == "."

                )

                e.Handled = false;

            else

                e.Handled = true;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Grid_Productos.CurrentCell == null)
                return;

            if (MessageBox.Show(this, "¿Esta seguro de eliminar la partida?", "LogoSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Grid_Productos.CurrentCell.RowIndex >= 0)
                {                    
                    detallesProductos.RemoveAt(Grid_Productos.CurrentCell.RowIndex);

                    Grid_Productos.DataSource = null;
                    Grid_Productos.DataSource = detallesProductos;

                    Calcula_Totales();

                    Txt_Codigo.Text = "";
                    Txt_Codigo.Focus();
                }
            }
        }
        #endregion
    }
}
