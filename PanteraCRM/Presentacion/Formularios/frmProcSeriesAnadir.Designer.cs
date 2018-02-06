namespace Presentacion
{
    partial class frmProcSeriesAnadir
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbAgregadoSerie = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreconpuesto = new System.Windows.Forms.TextBox();
            this.dgvListaIngreso = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbSerie = new System.Windows.Forms.CheckBox();
            this.txtidcodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.grbAgregadoSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIngreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(108, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // grbAgregadoSerie
            // 
            this.grbAgregadoSerie.Controls.Add(this.btnQuitar);
            this.grbAgregadoSerie.Controls.Add(this.label5);
            this.grbAgregadoSerie.Controls.Add(this.label4);
            this.grbAgregadoSerie.Controls.Add(this.btnAnadir);
            this.grbAgregadoSerie.Controls.Add(this.txtObs);
            this.grbAgregadoSerie.Controls.Add(this.txtSerie);
            this.grbAgregadoSerie.Enabled = false;
            this.grbAgregadoSerie.Location = new System.Drawing.Point(12, 68);
            this.grbAgregadoSerie.Name = "grbAgregadoSerie";
            this.grbAgregadoSerie.Size = new System.Drawing.Size(560, 73);
            this.grbAgregadoSerie.TabIndex = 2;
            this.grbAgregadoSerie.TabStop = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Location = new System.Drawing.Point(456, 41);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 26);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serie de Producto";
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.White;
            this.btnAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnadir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAnadir.ForeColor = System.Drawing.Color.Black;
            this.btnAnadir.Location = new System.Drawing.Point(456, 14);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 26);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(178, 30);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(212, 20);
            this.txtObs.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(9, 30);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Producto";
            // 
            // txtNombreconpuesto
            // 
            this.txtNombreconpuesto.Enabled = false;
            this.txtNombreconpuesto.Location = new System.Drawing.Point(108, 42);
            this.txtNombreconpuesto.Name = "txtNombreconpuesto";
            this.txtNombreconpuesto.Size = new System.Drawing.Size(464, 20);
            this.txtNombreconpuesto.TabIndex = 4;
            // 
            // dgvListaIngreso
            // 
            this.dgvListaIngreso.AllowUserToAddRows = false;
            this.dgvListaIngreso.AllowUserToDeleteRows = false;
            this.dgvListaIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaIngreso.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHPRODUCTO,
            this.CHSERIE,
            this.CHOBS});
            this.dgvListaIngreso.Enabled = false;
            this.dgvListaIngreso.Location = new System.Drawing.Point(13, 147);
            this.dgvListaIngreso.Name = "dgvListaIngreso";
            this.dgvListaIngreso.ReadOnly = true;
            this.dgvListaIngreso.Size = new System.Drawing.Size(560, 233);
            this.dgvListaIngreso.TabIndex = 5;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            this.IDPRODUCTO.Width = 104;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 74;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Width = 93;
            // 
            // CHSERIE
            // 
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 64;
            // 
            // CHOBS
            // 
            this.CHOBS.HeaderText = "OBSERVACION";
            this.CHOBS.Name = "CHOBS";
            this.CHOBS.ReadOnly = true;
            this.CHOBS.Width = 109;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(200, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGrabar.ForeColor = System.Drawing.Color.Black;
            this.btnGrabar.Location = new System.Drawing.Point(11, 22);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 30);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(92, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // ckbSerie
            // 
            this.ckbSerie.AutoSize = true;
            this.ckbSerie.Enabled = false;
            this.ckbSerie.Location = new System.Drawing.Point(434, 14);
            this.ckbSerie.Name = "ckbSerie";
            this.ckbSerie.Size = new System.Drawing.Size(96, 17);
            this.ckbSerie.TabIndex = 9;
            this.ckbSerie.Text = "Requiere Serie";
            this.ckbSerie.UseVisualStyleBackColor = true;
            this.ckbSerie.CheckedChanged += new System.EventHandler(this.ckbSerie_CheckedChanged);
            // 
            // txtidcodigo
            // 
            this.txtidcodigo.Location = new System.Drawing.Point(37, 419);
            this.txtidcodigo.Name = "txtidcodigo";
            this.txtidcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtidcodigo.TabIndex = 10;
            this.txtidcodigo.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(302, 8);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(46, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.LostFocus += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // frmProcSeriesAnadir
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(584, 465);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtidcodigo);
            this.Controls.Add(this.ckbSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListaIngreso);
            this.Controls.Add(this.txtNombreconpuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbAgregadoSerie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmProcSeriesAnadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cantidad de Productos y Series";
            this.grbAgregadoSerie.ResumeLayout(false);
            this.grbAgregadoSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIngreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbAgregadoSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreconpuesto;
        private System.Windows.Forms.DataGridView dgvListaIngreso;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBS;
        private System.Windows.Forms.TextBox txtidcodigo;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
    }
}