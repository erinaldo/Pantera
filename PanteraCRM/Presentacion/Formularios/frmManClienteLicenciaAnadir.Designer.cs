namespace Presentacion
{
    partial class frmManClienteLicenciaAnadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManClienteLicenciaAnadir));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechVenci = new System.Windows.Forms.DateTimePicker();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListasTarjetas = new System.Windows.Forms.DataGridView();
            this.IDLICENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHLICENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHVENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListasTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(79, 290);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(165, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechVenci);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtFechVenci
            // 
            this.txtFechVenci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechVenci.Location = new System.Drawing.Point(194, 42);
            this.txtFechVenci.Name = "txtFechVenci";
            this.txtFechVenci.Size = new System.Drawing.Size(100, 20);
            this.txtFechVenci.TabIndex = 4;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(65, 75);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.Window;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(155, 75);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 28);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(74, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(220, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licencia N°";
            // 
            // dgvListasTarjetas
            // 
            this.dgvListasTarjetas.AllowUserToAddRows = false;
            this.dgvListasTarjetas.AllowUserToDeleteRows = false;
            this.dgvListasTarjetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListasTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListasTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLICENCIA,
            this.IDCLIENTE,
            this.CHLICENCIA,
            this.CHVENCIMIENTO,
            this.ESTADO});
            this.dgvListasTarjetas.Location = new System.Drawing.Point(12, 127);
            this.dgvListasTarjetas.Name = "dgvListasTarjetas";
            this.dgvListasTarjetas.ReadOnly = true;
            this.dgvListasTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListasTarjetas.Size = new System.Drawing.Size(300, 153);
            this.dgvListasTarjetas.TabIndex = 6;
            // 
            // IDLICENCIA
            // 
            this.IDLICENCIA.HeaderText = "IDTARJETA";
            this.IDLICENCIA.Name = "IDLICENCIA";
            this.IDLICENCIA.ReadOnly = true;
            this.IDLICENCIA.Visible = false;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.HeaderText = "IDCLIENTE";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.ReadOnly = true;
            this.IDCLIENTE.Visible = false;
            // 
            // CHLICENCIA
            // 
            this.CHLICENCIA.HeaderText = "CODIGO";
            this.CHLICENCIA.Name = "CHLICENCIA";
            this.CHLICENCIA.ReadOnly = true;
            this.CHLICENCIA.Width = 160;
            // 
            // CHVENCIMIENTO
            // 
            this.CHVENCIMIENTO.HeaderText = "FECHA VENCIMIENTO";
            this.CHVENCIMIENTO.Name = "CHVENCIMIENTO";
            this.CHVENCIMIENTO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // frmManClienteLicenciaAnadir
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(330, 332);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListasTarjetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManClienteLicenciaAnadir";
            this.ShowInTaskbar = false;
            this.Text = "AÑADIR LICENCIA";
            this.Load += new System.EventHandler(this.frmManClienteLicenciaAnadir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListasTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFechVenci;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListasTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLICENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHLICENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHVENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}