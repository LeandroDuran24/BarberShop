namespace BarbershopTech.UI.Reportes
{
    partial class ReporteFactura
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
            this.reportViewerFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewerFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerFactura
            // 
            this.reportViewerFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerFactura.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFactura.Name = "reportViewerFactura";
            this.reportViewerFactura.Size = new System.Drawing.Size(1017, 379);
            this.reportViewerFactura.TabIndex = 0;
            // 
            // ViewerFactura
            // 
            this.ViewerFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerFactura.Location = new System.Drawing.Point(0, 0);
            this.ViewerFactura.Name = "ViewerFactura";
            this.ViewerFactura.Size = new System.Drawing.Size(1017, 261);
            this.ViewerFactura.TabIndex = 0;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 379);
            this.Controls.Add(this.reportViewerFactura);
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFactura;
        private Microsoft.Reporting.WinForms.ReportViewer ViewerFactura;
    }
}