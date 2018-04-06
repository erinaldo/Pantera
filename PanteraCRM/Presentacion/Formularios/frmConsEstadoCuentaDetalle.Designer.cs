namespace Presentacion
{
    partial class frmConsEstadoCuentaDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsEstadoCuentaDetalle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipdoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListaRegistros = new System.Windows.Forms.DataGridView();
            this.CODREGVTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPODOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCORRELADOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFECHAEMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUEMITIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUPAGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUIMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipdoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.txtRazon);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblTipdoc
            // 
            this.lblTipdoc.AutoSize = true;
            this.lblTipdoc.Location = new System.Drawing.Point(215, 23);
            this.lblTipdoc.Name = "lblTipdoc";
            this.lblTipdoc.Size = new System.Drawing.Size(39, 13);
            this.lblTipdoc.TabIndex = 6;
            this.lblTipdoc.Text = "R.U.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razón. D.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // txtruc
            // 
            this.txtruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtruc.ForeColor = System.Drawing.Color.Blue;
            this.txtruc.Location = new System.Drawing.Point(260, 19);
            this.txtruc.Name = "txtruc";
            this.txtruc.ReadOnly = true;
            this.txtruc.Size = new System.Drawing.Size(225, 20);
            this.txtruc.TabIndex = 3;
            this.txtruc.TabStop = false;
            // 
            // txtRazon
            // 
            this.txtRazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtRazon.ForeColor = System.Drawing.Color.Blue;
            this.txtRazon.Location = new System.Drawing.Point(67, 43);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.ReadOnly = true;
            this.txtRazon.Size = new System.Drawing.Size(634, 20);
            this.txtRazon.TabIndex = 2;
            this.txtRazon.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCodigo.ForeColor = System.Drawing.Color.Blue;
            this.txtCodigo.Location = new System.Drawing.Point(67, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(114, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Location = new System.Drawing.Point(277, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 43);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(7, 10);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 28);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "&Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(93, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaRegistros
            // 
            this.dgvListaRegistros.AllowUserToAddRows = false;
            this.dgvListaRegistros.AllowUserToDeleteRows = false;
            this.dgvListaRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODREGVTA,
            this.CHTIPODOC,
            this.CHCORRELADOC,
            this.CHFECHAEMI,
            this.NUEMITIDO,
            this.NUPAGADO,
            this.NUIMPORTE,
            this.CHESTADO});
            this.dgvListaRegistros.Location = new System.Drawing.Point(12, 79);
            this.dgvListaRegistros.Name = "dgvListaRegistros";
            this.dgvListaRegistros.ReadOnly = true;
            this.dgvListaRegistros.RowHeadersVisible = false;
            this.dgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRegistros.Size = new System.Drawing.Size(707, 275);
            this.dgvListaRegistros.TabIndex = 0;
            this.dgvListaRegistros.TabStop = false;
            // 
            // CODREGVTA
            // 
            this.CODREGVTA.HeaderText = "CODREGVTA";
            this.CODREGVTA.Name = "CODREGVTA";
            this.CODREGVTA.ReadOnly = true;
            this.CODREGVTA.Visible = false;
            // 
            // CHTIPODOC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CHTIPODOC.DefaultCellStyle = dataGridViewCellStyle1;
            this.CHTIPODOC.HeaderText = "T.DOC";
            this.CHTIPODOC.Name = "CHTIPODOC";
            this.CHTIPODOC.ReadOnly = true;
            this.CHTIPODOC.Width = 80;
            // 
            // CHCORRELADOC
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CHCORRELADOC.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHCORRELADOC.HeaderText = "N° DOC";
            this.CHCORRELADOC.Name = "CHCORRELADOC";
            this.CHCORRELADOC.ReadOnly = true;
            this.CHCORRELADOC.Width = 120;
            // 
            // CHFECHAEMI
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.CHFECHAEMI.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHFECHAEMI.HeaderText = "FECHA E.";
            this.CHFECHAEMI.Name = "CHFECHAEMI";
            this.CHFECHAEMI.ReadOnly = true;
            // 
            // NUEMITIDO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.NUEMITIDO.DefaultCellStyle = dataGridViewCellStyle4;
            this.NUEMITIDO.HeaderText = "EMITIDO";
            this.NUEMITIDO.Name = "NUEMITIDO";
            this.NUEMITIDO.ReadOnly = true;
            // 
            // NUPAGADO
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.NUPAGADO.DefaultCellStyle = dataGridViewCellStyle5;
            this.NUPAGADO.HeaderText = "PAGADO";
            this.NUPAGADO.Name = "NUPAGADO";
            this.NUPAGADO.ReadOnly = true;
            // 
            // NUIMPORTE
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.NUIMPORTE.DefaultCellStyle = dataGridViewCellStyle6;
            this.NUIMPORTE.HeaderText = "SALDO";
            this.NUIMPORTE.Name = "NUIMPORTE";
            this.NUIMPORTE.ReadOnly = true;
            // 
            // CHESTADO
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.CHESTADO.DefaultCellStyle = dataGridViewCellStyle7;
            this.CHESTADO.HeaderText = "ESTADO";
            this.CHESTADO.Name = "CHESTADO";
            this.CHESTADO.ReadOnly = true;
            // 
            // frmConsEstadoCuentaDetalle
            // 
            this.AcceptButton = this.btnExcel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(732, 409);
            this.Controls.Add(this.dgvListaRegistros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsEstadoCuentaDetalle";
            this.ShowInTaskbar = false;
            this.Text = "ESTADO DE CUENTA";
            this.Load += new System.EventHandler(this.frmConsEstadoCuentaDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODREGVTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPODOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCORRELADOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHAEMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUEMITIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUPAGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUIMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHESTADO;
    }
}