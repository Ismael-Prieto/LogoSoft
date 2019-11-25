using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace LogoSoftDesktop
{
    public partial class FrmProductoListado : Form
    {
        #region Variables       
        private Boolean IsLoaded = false;
        #endregion

        #region Constructor y Load
        public FrmProductoListado()
        {
            InitializeComponent();            
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Cargar_Productos();
        }
        #endregion

        #region Métodos
        private async void Cargar_Productos()
        {
            IsLoaded = false;

            this.Cursor = Cursors.WaitCursor;

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Globales.Url_API + "productos/consultaproductos/NULL"))
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
        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm._productoID = 0;
            frm.ShowDialog();
            if (frm._existenCambios)
            {
                Cargar_Productos();
            }
        }        

        private void Grid_Productos_SelectionChanged(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;

            DataGridView dg = sender as DataGridView;

            if (dg != null && dg.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dg.SelectedRows[0];
                if (row != null)
                {
                    FrmProducto frm = new FrmProducto();
                    frm._productoID = (int)row.Cells["Producto_ID"].Value;
                    frm.ShowDialog();
                    if (frm._existenCambios)
                    {
                        Cargar_Productos();
                    }
                }
            }
        }
        #endregion
    }
}
