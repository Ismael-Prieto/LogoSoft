using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoSoftDesktop
{
    public partial class FrmFacturacionProductosBusqueda : Form
    {
        #region Variables
        public int _productoID = 0;
        public string _codigo = "";
        public string _nombre = "";
        public decimal _precio = 0;
        public Boolean _existenCambios = false;
        private Boolean IsLoaded = false;
        #endregion

        #region Constructor y Load
        public FrmFacturacionProductosBusqueda()
        {
            InitializeComponent();
        }

        private void FrmFacturacionProductosBusqueda_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos
        private async void Buscar_Productos()
        {
            IsLoaded = false;

            string busqueda = Txt_Nombre.Text.Trim() == "" ? "NULL" : Txt_Nombre.Text.Trim();

            this.Cursor = Cursors.WaitCursor;

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Globales.Url_API + "productos/consultaproductos/" + busqueda))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();

                        Grid_Productos.AutoGenerateColumns = false;
                        Grid_Productos.DataSource = JsonConvert.DeserializeObject<typeProducto[]>(jsonString).ToList();

                        Grid_Productos.ClearSelection();
                    }
                }
            }

            this.Cursor = Cursors.Default;

            IsLoaded = true;
        }
        #endregion

        #region Eventos
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Producto_Click(object sender, EventArgs e)
        {
            Buscar_Productos();
        }             

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if(e.KeyChar == (char)Keys.Enter)
            {
                Buscar_Productos();
            }
        }

        private void Grid_Productos_SelectionChanged(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;

            DataGridView dg = sender as DataGridView;

            if(dg != null && dg.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dg.SelectedRows[0];
                if(row != null)
                {
                    _productoID = (int)row.Cells["Producto_ID"].Value;
                    _codigo = row.Cells["Codigo"].Value.ToString();
                    _nombre = row.Cells["Nombre"].Value.ToString();
                    _precio = (decimal)row.Cells["Precio"].Value;

                    _existenCambios = true;
                    this.Close();
                }
            }
        }
        #endregion   
    }
}
