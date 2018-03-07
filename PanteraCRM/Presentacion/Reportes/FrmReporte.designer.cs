namespace Presentacion.Reportes
{
    partial class FrmReporte
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
            this.CrpViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrpViewer
            // 
            this.CrpViewer.ActiveViewIndex = -1;
            this.CrpViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrpViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrpViewer.DisplayStatusBar = false;
            this.CrpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrpViewer.Location = new System.Drawing.Point(0, 0);
            this.CrpViewer.Name = "CrpViewer";
            this.CrpViewer.Size = new System.Drawing.Size(753, 700);
            this.CrpViewer.TabIndex = 0;
            this.CrpViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 700);
            this.Controls.Add(this.CrpViewer);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrpViewer;
    }
}