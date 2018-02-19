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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcSeriesAnadir));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodprod = new System.Windows.Forms.TextBox();
            this.grbAgregadoSerie = new System.Windows.Forms.GroupBox();
            this.txtCodigoSerie = new System.Windows.Forms.TextBox();
            this.txtfecfabri = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dgvListaIngreso = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNombreconpuesto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.grbAgregadoSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIngreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtcodprod
            // 
            this.txtcodprod.CausesValidation = false;
            this.txtcodprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodprod.Location = new System.Drawing.Point(63, 13);
            this.txtcodprod.Name = "txtcodprod";
            this.txtcodprod.Size = new System.Drawing.Size(106, 20);
            this.txtcodprod.TabIndex = 0;
            this.txtcodprod.TextChanged += new System.EventHandler(this.txtcodprod_TextChanged);
            this.txtcodprod.DoubleClick += new System.EventHandler(this.txtcodprod_DoubleClick);
            // 
            // grbAgregadoSerie
            // 
            this.grbAgregadoSerie.Controls.Add(this.txtCodigoSerie);
            this.grbAgregadoSerie.Controls.Add(this.txtfecfabri);
            this.grbAgregadoSerie.Controls.Add(this.btnQuitar);
            this.grbAgregadoSerie.Controls.Add(this.label5);
            this.grbAgregadoSerie.Controls.Add(this.label4);
            this.grbAgregadoSerie.Controls.Add(this.btnAnadir);
            this.grbAgregadoSerie.Controls.Add(this.dgvListaIngreso);
            this.grbAgregadoSerie.Controls.Add(this.txtObs);
            this.grbAgregadoSerie.Controls.Add(this.txtSerie);
            this.grbAgregadoSerie.Location = new System.Drawing.Point(13, 91);
            this.grbAgregadoSerie.Name = "grbAgregadoSerie";
            this.grbAgregadoSerie.Size = new System.Drawing.Size(560, 410);
            this.grbAgregadoSerie.TabIndex = 2;
            this.grbAgregadoSerie.TabStop = false;
            // 
            // txtCodigoSerie
            // 
            this.txtCodigoSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSerie.Location = new System.Drawing.Point(333, 18);
            this.txtCodigoSerie.Name = "txtCodigoSerie";
            this.txtCodigoSerie.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSerie.TabIndex = 8;
            // 
            // txtfecfabri
            // 
            this.txtfecfabri.AutoSize = true;
            this.txtfecfabri.Location = new System.Drawing.Point(287, 21);
            this.txtfecfabri.Name = "txtfecfabri";
            this.txtfecfabri.Size = new System.Drawing.Size(40, 13);
            this.txtfecfabri.TabIndex = 7;
            this.txtfecfabri.Text = "Codigo";
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
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serie";
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
            // dgvListaIngreso
            // 
            this.dgvListaIngreso.AllowUserToAddRows = false;
            this.dgvListaIngreso.AllowUserToDeleteRows = false;
            this.dgvListaIngreso.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHPRODUCTO,
            this.CHSERIE,
            this.CHOBS});
            this.dgvListaIngreso.Enabled = false;
            this.dgvListaIngreso.Location = new System.Drawing.Point(6, 78);
            this.dgvListaIngreso.Name = "dgvListaIngreso";
            this.dgvListaIngreso.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaIngreso.Size = new System.Drawing.Size(548, 303);
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
            this.CHCODIGO.Width = 70;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Width = 300;
            // 
            // CHSERIE
            // 
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 70;
            // 
            // CHOBS
            // 
            this.CHOBS.HeaderText = "OBSERVACION";
            this.CHOBS.Name = "CHOBS";
            this.CHOBS.ReadOnly = true;
            this.CHOBS.Width = 300;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(79, 45);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(354, 20);
            this.txtObs.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(79, 18);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(89, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // txtNombreconpuesto
            // 
            this.txtNombreconpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNombreconpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreconpuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreconpuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreconpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreconpuesto.ForeColor = System.Drawing.Color.Blue;
            this.txtNombreconpuesto.Location = new System.Drawing.Point(178, 13);
            this.txtNombreconpuesto.Name = "txtNombreconpuesto";
            this.txtNombreconpuesto.ReadOnly = true;
            this.txtNombreconpuesto.Size = new System.Drawing.Size(376, 20);
            this.txtNombreconpuesto.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(190, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGrabar.ForeColor = System.Drawing.Color.Black;
            this.btnGrabar.Location = new System.Drawing.Point(11, 18);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 30);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(92, 18);
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
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // txtidcodigo
            // 
            this.txtidcodigo.Location = new System.Drawing.Point(13, 525);
            this.txtidcodigo.Name = "txtidcodigo";
            this.txtidcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtidcodigo.TabIndex = 10;
            this.txtidcodigo.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(63, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(38, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // mskFecha
            // 
            this.mskFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.mskFecha.ForeColor = System.Drawing.Color.Blue;
            this.mskFecha.Location = new System.Drawing.Point(475, 530);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.ReadOnly = true;
            this.mskFecha.Size = new System.Drawing.Size(91, 20);
            this.mskFecha.TabIndex = 12;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.txtNombreconpuesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodprod);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Costo Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sub-Total";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtsubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.txtsubtotal.Location = new System.Drawing.Point(448, 46);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(106, 20);
            this.txtsubtotal.TabIndex = 14;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.White;
            this.txtprecio.ForeColor = System.Drawing.Color.Black;
            this.txtprecio.Location = new System.Drawing.Point(265, 46);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 13;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedida.ForeColor = System.Drawing.Color.Blue;
            this.txtMedida.Location = new System.Drawing.Point(107, 46);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(62, 20);
            this.txtMedida.TabIndex = 12;
            // 
            // frmProcSeriesAnadir
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(584, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.txtidcodigo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbAgregadoSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcSeriesAnadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AÑADIR SERIES";
            this.Load += new System.EventHandler(this.frmProcSeriesAnadir_Load);
            this.grbAgregadoSerie.ResumeLayout(false);
            this.grbAgregadoSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIngreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodprod;
        private System.Windows.Forms.GroupBox grbAgregadoSerie;
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
        private System.Windows.Forms.TextBox txtidcodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtfecfabri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBS;
        private System.Windows.Forms.TextBox txtCodigoSerie;
    }
}