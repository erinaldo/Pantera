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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.CrpViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtCorrePedi = new System.Windows.Forms.TextBox();
            this.txtCorrePrimario = new System.Windows.Forms.TextBox();
            this.txtCorreSecundario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorrePrimario = new System.Windows.Forms.Label();
            this.lblCorreSecundario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.CrpViewer.ShowCloseButton = false;
            this.CrpViewer.ShowCopyButton = false;
            this.CrpViewer.ShowExportButton = false;
            this.CrpViewer.ShowGotoPageButton = false;
            this.CrpViewer.ShowGroupTreeButton = false;
            this.CrpViewer.ShowLogo = false;
            this.CrpViewer.ShowParameterPanelButton = false;
            this.CrpViewer.ShowPrintButton = false;
            this.CrpViewer.ShowRefreshButton = false;
            this.CrpViewer.ShowTextSearchButton = false;
            this.CrpViewer.ShowZoomButton = false;
            this.CrpViewer.Size = new System.Drawing.Size(753, 700);
            this.CrpViewer.TabIndex = 0;
            this.CrpViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 114);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(135, 28);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Comprobantes";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCorrePedi
            // 
            this.txtCorrePedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCorrePedi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorrePedi.ForeColor = System.Drawing.Color.Blue;
            this.txtCorrePedi.HideSelection = false;
            this.txtCorrePedi.Location = new System.Drawing.Point(165, 115);
            this.txtCorrePedi.Name = "txtCorrePedi";
            this.txtCorrePedi.ReadOnly = true;
            this.txtCorrePedi.Size = new System.Drawing.Size(100, 20);
            this.txtCorrePedi.TabIndex = 6;
            this.txtCorrePedi.TabStop = false;
            this.txtCorrePedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorrePrimario
            // 
            this.txtCorrePrimario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCorrePrimario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorrePrimario.ForeColor = System.Drawing.Color.Blue;
            this.txtCorrePrimario.HideSelection = false;
            this.txtCorrePrimario.Location = new System.Drawing.Point(165, 157);
            this.txtCorrePrimario.Name = "txtCorrePrimario";
            this.txtCorrePrimario.ReadOnly = true;
            this.txtCorrePrimario.Size = new System.Drawing.Size(100, 20);
            this.txtCorrePrimario.TabIndex = 7;
            this.txtCorrePrimario.TabStop = false;
            this.txtCorrePrimario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreSecundario
            // 
            this.txtCorreSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCorreSecundario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreSecundario.ForeColor = System.Drawing.Color.Blue;
            this.txtCorreSecundario.HideSelection = false;
            this.txtCorreSecundario.Location = new System.Drawing.Point(165, 201);
            this.txtCorreSecundario.Name = "txtCorreSecundario";
            this.txtCorreSecundario.ReadOnly = true;
            this.txtCorreSecundario.Size = new System.Drawing.Size(100, 20);
            this.txtCorreSecundario.TabIndex = 8;
            this.txtCorreSecundario.TabStop = false;
            this.txtCorreSecundario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(162, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "N° PEDIDO";
            // 
            // lblCorrePrimario
            // 
            this.lblCorrePrimario.AutoSize = true;
            this.lblCorrePrimario.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrePrimario.Location = new System.Drawing.Point(162, 141);
            this.lblCorrePrimario.Name = "lblCorrePrimario";
            this.lblCorrePrimario.Size = new System.Drawing.Size(22, 13);
            this.lblCorrePrimario.TabIndex = 10;
            this.lblCorrePrimario.Text = "N° ";
            // 
            // lblCorreSecundario
            // 
            this.lblCorreSecundario.AutoSize = true;
            this.lblCorreSecundario.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreSecundario.Location = new System.Drawing.Point(162, 185);
            this.lblCorreSecundario.Name = "lblCorreSecundario";
            this.lblCorreSecundario.Size = new System.Drawing.Size(19, 13);
            this.lblCorreSecundario.TabIndex = 11;
            this.lblCorreSecundario.Text = "N°";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(12, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(165, 72);
            this.txtfecha.Mask = "00/00/0000";
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 13;
            this.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(162, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha";
            // 
            // FrmReporte
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(753, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCorreSecundario);
            this.Controls.Add(this.lblCorrePrimario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreSecundario);
            this.Controls.Add(this.txtCorrePrimario);
            this.Controls.Add(this.txtCorrePedi);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.CrpViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VISTA PREVIA :: COMPROBANTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrpViewer;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtCorrePedi;
        private System.Windows.Forms.TextBox txtCorrePrimario;
        private System.Windows.Forms.TextBox txtCorreSecundario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorrePrimario;
        private System.Windows.Forms.Label lblCorreSecundario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox txtfecha;
        private System.Windows.Forms.Label label2;
    }
}