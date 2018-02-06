namespace Presentacion
{
    partial class frmRegistroPresupuesto
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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.IDPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUNTOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(167, 459);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.cmdAnadir_Click);
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToDeleteRows = false;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRESUPUESTO,
            this.IDEMPRESA,
            this.CODIGOSERIE,
            this.PUNTOVENTA,
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
            this.dgvPresupuesto.Location = new System.Drawing.Point(12, 12);
            this.dgvPresupuesto.MultiSelect = false;
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.ReadOnly = true;
            this.dgvPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuesto.Size = new System.Drawing.Size(812, 441);
            this.dgvPresupuesto.TabIndex = 5;
            this.dgvPresupuesto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPresupuesto_CellFormatting);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(264, 459);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(462, 459);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 4;
            this.btnAnular.Text = "A&nular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(565, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(361, 459);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            // CODIGOSERIE
            // 
            this.CODIGOSERIE.DataPropertyName = "codigoserie";
            this.CODIGOSERIE.HeaderText = "SERIE";
            this.CODIGOSERIE.Name = "CODIGOSERIE";
            this.CODIGOSERIE.ReadOnly = true;
            this.CODIGOSERIE.Width = 45;
            // 
            // PUNTOVENTA
            // 
            this.PUNTOVENTA.DataPropertyName = "idpuntoventa";
            this.PUNTOVENTA.HeaderText = "PUNTOVENTA";
            this.PUNTOVENTA.Name = "PUNTOVENTA";
            this.PUNTOVENTA.ReadOnly = true;
            this.PUNTOVENTA.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle1;
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
            // frmRegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(836, 493);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPresupuesto);
            this.Controls.Add(this.btnAnadir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroPresupuesto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "REGISTRO DE PRESUPUESTO";
            this.Load += new System.EventHandler(this.frmRegistroPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUNTOVENTA;
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