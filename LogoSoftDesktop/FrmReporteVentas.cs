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
    public partial class FrmReporteVentas : Form
    {
        #region Constructor y Load
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos
        private async void Consultar_Reporte()
        {
            string filtroInicial = Txt_Comprobante_Inicial.Text.Trim() == "" ? "NULL" : Txt_Comprobante_Inicial.Text.Trim();
            string filtroFinal = Txt_Comprobante_Final.Text.Trim() == "" ? "NULL" : Txt_Comprobante_Final.Text.Trim();
            string cliente = Txt_Cliente.Text.Trim() == "" ? "NULL" : Txt_Cliente.Text.Trim();

            this.Cursor = Cursors.WaitCursor;

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Globales.Url_API + "facturacion/consultaventas/" + filtroInicial + "/" + filtroFinal + "/" + cliente))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();

                        Grid_Ventas.AutoGenerateColumns = false;
                        Grid_Ventas.DataSource = JsonConvert.DeserializeObject<typeReporteVentas[]>(jsonString).ToList();

                        Grid_Ventas.ClearSelection();
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
        #endregion

        #region Eventos
        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Consultar_Reporte();
        }

        private void Btn_Limpiar_Filtro_Click(object sender, EventArgs e)
        {
            Txt_Comprobante_Inicial.Text = "";
            Txt_Comprobante_Final.Text = "";
            Txt_Cliente.Text = "";
            Grid_Ventas.DataSource = null;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Comprobante_Inicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Txt_Comprobante_Final_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        
    }
}
