namespace Presentacion
{
    partial class frmReportePresupuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtCodigoserie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoserie1 = new System.Windows.Forms.TextBox();
            this.IDPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpuntoventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(753, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToDeleteRows = false;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRESUPUESTO,
            this.IDEMPRESA,
            this.idpuntoventa,
            this.CODIGOSERIE,
            this.NUMEROPRESUPUESTO,
            this.IDPERSONA,
            this.DNI,
            this.NOMBRES,
            this.FECHAPRESUPUESTO,
            this.PLACA,
            this.FECHARQ,
            this.FECHARA,
            this.IDMARCA,
            this.IDMODELO,
            this.TOTAL,
            this.OBSERVACION,
            this.IDSITUPRESUPUESTO,
            this.ESTADOPRESUPUESTO});
            this.dgvPresupuesto.Location = new System.Drawing.Point(16, 15);
            this.dgvPresupuesto.MultiSelect = false;
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.ReadOnly = true;
            this.dgvPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuesto.Size = new System.Drawing.Size(812, 441);
            this.dgvPresupuesto.TabIndex = 11;
            this.dgvPresupuesto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPresupuesto_CellFormatting);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(509, 465);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CustomFormat = "";
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(53, 467);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(83, 20);
            this.dtpfechaini.TabIndex = 1;
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(195, 467);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(84, 20);
            this.dtpfechafin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hasta";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(591, 465);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnular.Location = new System.Drawing.Point(673, 465);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "A&nular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtCodigoserie
            // 
            this.txtCodigoserie.Enabled = false;
            this.txtCodigoserie.Location = new System.Drawing.Point(381, 467);
            this.txtCodigoserie.MaxLength = 3;
            this.txtCodigoserie.Name = "txtCodigoserie";
            this.txtCodigoserie.Size = new System.Drawing.Size(30, 20);
            this.txtCodigoserie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serie";
            // 
            // txtCodigoserie1
            // 
            this.txtCodigoserie1.Enabled = false;
            this.txtCodigoserie1.Location = new System.Drawing.Point(429, 467);
            this.txtCodigoserie1.MaxLength = 3;
            this.txtCodigoserie1.Name = "txtCodigoserie1";
            this.txtCodigoserie1.Size = new System.Drawing.Size(30, 20);
            this.txtCodigoserie1.TabIndex = 6;
            // 
            // IDPRESUPUESTO
            // 
            this.IDPRESUPUESTO.DataPropertyName = "idpresupuesto";
            this.IDPRESUPUESTO.HeaderText = "IDPRESUPUESTO";
            this.IDPRESUPUESTO.Name = "IDPRESUPUESTO";
            this.IDPRESUPUESTO.ReadOnly = true;
            this.IDPRESUPUESTO.Visible = false;
            this.IDPRESUPUESTO.Width = 70;
            // 
            // IDEMPRESA
            // 
            this.IDEMPRESA.DataPropertyName = "idempresa";
            this.IDEMPRESA.HeaderText = "EMPRESA";
            this.IDEMPRESA.Name = "IDEMPRESA";
            this.IDEMPRESA.ReadOnly = true;
            this.IDEMPRESA.Visible = false;
            // 
            // idpuntoventa
            // 
            this.idpuntoventa.DataPropertyName = "idpuntoventa";
            this.idpuntoventa.HeaderText = "IDPUNTOVENTA";
            this.idpuntoventa.Name = "idpuntoventa";
            this.idpuntoventa.ReadOnly = true;
            this.idpuntoventa.Visible = false;
            // 
            // CODIGOSERIE
            // 
            this.CODIGOSERIE.DataPropertyName = "codigoserie";
            this.CODIGOSERIE.HeaderText = "SERIE";
            this.CODIGOSERIE.Name = "CODIGOSERIE";
            this.CODIGOSERIE.ReadOnly = true;
            this.CODIGOSERIE.Width = 45;
            // 
            // NUMEROPRESUPUESTO
            // 
            this.NUMEROPRESUPUESTO.DataPropertyName = "numeropresupuesto";
            this.NUMEROPRESUPUESTO.HeaderText = "PRESUPUESTO";
            this.NUMEROPRESUPUESTO.Name = "NUMEROPRESUPUESTO";
            this.NUMEROPRESUPUESTO.ReadOnly = true;
            this.NUMEROPRESUPUESTO.Width = 90;
            // 
            // IDPERSONA
            // 
            this.IDPERSONA.DataPropertyName = "idpersona";
            this.IDPERSONA.HeaderText = "IDPERSONA";
            this.IDPERSONA.Name = "IDPERSONA";
            this.IDPERSONA.ReadOnly = true;
            this.IDPERSONA.Visible = false;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 80;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "nombres";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 300;
            // 
            // FECHAPRESUPUESTO
            // 
            this.FECHAPRESUPUESTO.DataPropertyName = "fechapresupuesto";
            this.FECHAPRESUPUESTO.HeaderText = "FECHA";
            this.FECHAPRESUPUESTO.Name = "FECHAPRESUPUESTO";
            this.FECHAPRESUPUESTO.ReadOnly = true;
            this.FECHAPRESUPUESTO.Width = 70;
            // 
            // PLACA
            // 
            this.PLACA.DataPropertyName = "placa";
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            this.PLACA.Width = 90;
            // 
            // FECHARQ
            // 
            this.FECHARQ.DataPropertyName = "fecharq";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FECHARQ.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHARQ.HeaderText = "FECHARQ";
            this.FECHARQ.Name = "FECHARQ";
            this.FECHARQ.ReadOnly = true;
            this.FECHARQ.Visible = false;
            // 
            // FECHARA
            // 
            this.FECHARA.DataPropertyName = "fechara";
            this.FECHARA.HeaderText = "FECHARA";
            this.FECHARA.Name = "FECHARA";
            this.FECHARA.ReadOnly = true;
            this.FECHARA.Visible = false;
            // 
            // IDMARCA
            // 
            this.IDMARCA.DataPropertyName = "idmarca";
            this.IDMARCA.HeaderText = "IDMARCA";
            this.IDMARCA.Name = "IDMARCA";
            this.IDMARCA.ReadOnly = true;
            this.IDMARCA.Visible = false;
            // 
            // IDMODELO
            // 
            this.IDMODELO.DataPropertyName = "idmodelo";
            this.IDMODELO.HeaderText = "IDMODELO";
            this.IDMODELO.Name = "IDMODELO";
            this.IDMODELO.ReadOnly = true;
            this.IDMODELO.Visible = false;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle2;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 70;
            // 
            // OBSERVACION
            // 
            this.OBSERVACION.DataPropertyName = "observacion";
            this.OBSERVACION.HeaderText = "OBSERVACION";
            this.OBSERVACION.Name = "OBSERVACION";
            this.OBSERVACION.ReadOnly = true;
            this.OBSERVACION.Visible = false;
            // 
            // IDSITUPRESUPUESTO
            // 
            this.IDSITUPRESUPUESTO.DataPropertyName = "idsitupresupuesto";
            this.IDSITUPRESUPUESTO.HeaderText = "SITUACION";
            this.IDSITUPRESUPUESTO.Name = "IDSITUPRESUPUESTO";
            this.IDSITUPRESUPUESTO.ReadOnly = true;
            this.IDSITUPRESUPUESTO.Visible = false;
            // 
            // ESTADOPRESUPUESTO
            // 
            this.ESTADOPRESUPUESTO.DataPropertyName = "estadopresupuesto";
            this.ESTADOPRESUPUESTO.HeaderText = "ESTADOPRESUPUESTO";
            this.ESTADOPRESUPUESTO.Name = "ESTADOPRESUPUESTO";
            this.ESTADOPRESUPUESTO.ReadOnly = true;
            this.ESTADOPRESUPUESTO.Visible = false;
            // 
            // frmReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(843, 502);
            this.Controls.Add(this.txtCodigoserie1);
            this.Controls.Add(this.txtCodigoserie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPresupuesto);
            this.Controls.Add(this.btnFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePresupuesto";
            this.Text = "REPORTE DE PRESUPUESTOS";
            this.Load += new System.EventHandler(this.frmReportePresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.TextBox txtCodigoserie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoserie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpuntoventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOPRESUPUESTO;
    }
}