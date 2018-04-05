namespace Presentacion
{
    partial class frmConsVentasPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsVentasPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.dgvListaRegistros = new System.Windows.Forms.DataGridView();
            this.CODREGVTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPODOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCORRELADOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFECHAEMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUIMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnular);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Location = new System.Drawing.Point(217, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 43);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(177, 10);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(80, 28);
            this.btnAnular.TabIndex = 4;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(91, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(263, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(5, 10);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "&Ver Detalle";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 43);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda";
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Location = new System.Drawing.Point(67, 15);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(684, 20);
            this.txtParametro.TabIndex = 0;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
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
            this.CODCLIENTE,
            this.CHCLIENTE,
            this.CHFECHAEMI,
            this.NUIMPORTE,
            this.CHESTADO});
            this.dgvListaRegistros.Location = new System.Drawing.Point(12, 50);
            this.dgvListaRegistros.Name = "dgvListaRegistros";
            this.dgvListaRegistros.ReadOnly = true;
            this.dgvListaRegistros.RowHeadersVisible = false;
            this.dgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRegistros.Size = new System.Drawing.Size(757, 353);
            this.dgvListaRegistros.TabIndex = 28;
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
            this.CHTIPODOC.Width = 50;
            // 
            // CHCORRELADOC
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CHCORRELADOC.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHCORRELADOC.HeaderText = "N° DOC";
            this.CHCORRELADOC.Name = "CHCORRELADOC";
            this.CHCORRELADOC.ReadOnly = true;
            this.CHCORRELADOC.Width = 80;
            // 
            // CODCLIENTE
            // 
            this.CODCLIENTE.HeaderText = "CODIGO";
            this.CODCLIENTE.Name = "CODCLIENTE";
            this.CODCLIENTE.ReadOnly = true;
            this.CODCLIENTE.Width = 80;
            // 
            // CHCLIENTE
            // 
            this.CHCLIENTE.HeaderText = "CLIENTE";
            this.CHCLIENTE.Name = "CHCLIENTE";
            this.CHCLIENTE.ReadOnly = true;
            this.CHCLIENTE.Width = 300;
            // 
            // CHFECHAEMI
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.CHFECHAEMI.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHFECHAEMI.HeaderText = "EMISION";
            this.CHFECHAEMI.Name = "CHFECHAEMI";
            this.CHFECHAEMI.ReadOnly = true;
            this.CHFECHAEMI.Width = 80;
            // 
            // NUIMPORTE
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.NUIMPORTE.DefaultCellStyle = dataGridViewCellStyle4;
            this.NUIMPORTE.HeaderText = "IMPORTE";
            this.NUIMPORTE.Name = "NUIMPORTE";
            this.NUIMPORTE.ReadOnly = true;
            this.NUIMPORTE.Width = 80;
            // 
            // CHESTADO
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.CHESTADO.DefaultCellStyle = dataGridViewCellStyle5;
            this.CHESTADO.HeaderText = "ESTADO";
            this.CHESTADO.Name = "CHESTADO";
            this.CHESTADO.ReadOnly = true;
            this.CHESTADO.Width = 80;
            // 
            // frmConsVentasPrincipal
            // 
            this.AcceptButton = this.btnVer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(781, 460);
            this.Controls.Add(this.dgvListaRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsVentasPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONSULTA REGISTRO DE VENTA";
            this.Load += new System.EventHandler(this.frmConsVentasPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.DataGridView dgvListaRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODREGVTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPODOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCORRELADOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHAEMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUIMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHESTADO;
    }
}