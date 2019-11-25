using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoSoftDesktop
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }         

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductoListado childForm = new FrmProductoListado();
            childForm.MdiParent = this;            
            childForm.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion childForm = new FrmFacturacion();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteVentas childForm = new FrmReporteVentas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            Globales.Url_API = "https://logosoftapi.azurewebsites.net/api/";
        }
    }
}
