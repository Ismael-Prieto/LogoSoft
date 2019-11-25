namespace LogoSoftDesktop
{
    partial class FrmVisorReporte
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
            this.rptViewer = new FastReport.Preview.PreviewControl();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rptViewer.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.PageOffset = new System.Drawing.Point(10, 10);
            this.rptViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rptViewer.SaveInitialDirectory = null;
            this.rptViewer.Size = new System.Drawing.Size(799, 447);
            this.rptViewer.TabIndex = 0;
            // 
            // FrmVisorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewer);
            this.Name = "FrmVisorReporte";
            this.Text = "Visor de Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Preview.PreviewControl rptViewer;
    }
}