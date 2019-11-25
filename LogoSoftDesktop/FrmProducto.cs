using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoSoftDesktop
{
    public partial class FrmProducto : Form
    {
        #region Variables
        public int _productoID = 0;
        public Boolean _existenCambios = false;
        #endregion

        #region Constructor y Load
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProductoAgregarEditar_Load(object sender, EventArgs e)
        {
            if (_productoID == 0)
            {                
                Btn_Eliminar.Visible = false;
            }
            else
            {
                Consulta_Producto();
            }
        }
        #endregion

        #region Metodos
        private async void Consulta_Producto()
        {
            this.Cursor = Cursors.WaitCursor;

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Globales.Url_API + "productos/consultaproductoid/" + _productoID.ToString()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();

                        var productoJson = JsonConvert.DeserializeObject<typeProducto[]>(jsonString);
                        typeProducto producto = productoJson.FirstOrDefault();
                        Txt_Codigo.Text = producto.Codigo;
                        Txt_Nombre.Text = producto.Nombre;
                        Txt_Precio.Value = producto.Precio;
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

        private async void Agrega_Producto()
        {
            this.Cursor = Cursors.WaitCursor;

            typeProducto producto = new typeProducto();

            producto.Codigo = Txt_Codigo.Text.Trim().ToUpper();
            producto.Nombre = Txt_Nombre.Text.Trim().ToUpper();
            producto.Precio = Txt_Precio.Value;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(producto);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(Globales.Url_API + "productos/agregaproducto", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        this.Cursor = Cursors.Default;
                        _existenCambios = true;
                        MessageBox.Show("Producto agregado");
                        this.Close();
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

        private async void Edita_Producto()
        {
            this.Cursor = Cursors.WaitCursor;

            typeProducto producto = new typeProducto();

            producto.Producto_ID = _productoID;
            producto.Codigo = Txt_Codigo.Text.Trim().ToUpper();
            producto.Nombre = Txt_Nombre.Text.Trim().ToUpper();
            producto.Precio = Txt_Precio.Value;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(producto);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(Globales.Url_API + "productos/editaproducto", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        this.Cursor = Cursors.Default;
                        _existenCambios = true;
                        MessageBox.Show("Producto actualizado");
                        this.Close();
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

        private async void Elimina_Producto()
        {
            this.Cursor = Cursors.WaitCursor;            

            using (var client = new HttpClient())
            {
                var content = new StringContent("", Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(Globales.Url_API + "productos/eliminaproducto/" + _productoID.ToString(), content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        this.Cursor = Cursors.Default;
                        _existenCambios = true;
                        MessageBox.Show("Producto eliminado");
                        this.Close();
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
        #endregion

        #region Eventos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if(Txt_Codigo.Text == "")
            {
                MessageBox.Show("Proporcione el código");
                Txt_Codigo.Focus();
                return;
            }
            else
            {
                Regex regexObj = new Regex(@"^[A-Za-z]*(?:\d[A-Za-z]*){3,3}$", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                if (!regexObj.IsMatch(Txt_Codigo.Text))
                {
                    MessageBox.Show("Código inválido");
                    Txt_Codigo.Focus();
                    return;
                }
            }
            if (Txt_Nombre.Text == "")
            {
                MessageBox.Show("Proporcione el nombre");
                Txt_Nombre.Focus();
                return;
            }
            if (Txt_Precio.Value <= 0)
            {
                MessageBox.Show("Proporcione el precio");
                Txt_Precio.Focus();
                return;
            }

            if(_productoID == 0)
                Agrega_Producto();
            else
                Edita_Producto();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Esta seguro de eliminar el registro?", "LogoSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Elimina_Producto();
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Producto_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        #endregion
    }
}
