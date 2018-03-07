namespace Presentacion.Reportes
{
    partial class FrmReportesM
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
            this.crpViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpViewer
            // 
            this.crpViewer.ActiveViewIndex = -1;
            this.crpViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpViewer.Location = new System.Drawing.Point(0, 0);
            this.crpViewer.Name = "crpViewer";
            this.crpViewer.Size = new System.Drawing.Size(591, 360);
            this.crpViewer.TabIndex = 0;
            // 
            // FrmReportesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 360);
            this.Controls.Add(this.crpViewer);
            this.Name = "FrmReportesM";
            this.Text = "FrmReportesM";
            this.Load += new System.EventHandler(this.FrmReportesM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpViewer;
    }
}