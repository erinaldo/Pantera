﻿namespace Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcSeriesAnadir));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodprod = new System.Windows.Forms.TextBox();
            this.grbAgregadoSerie = new System.Windows.Forms.GroupBox();
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.txtfecfabri = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dgvListaIngreso = new System.Windows.Forms.DataGridView();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNombreconpuesto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcodigo = new System.Windows.Forms.TextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIDENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOEXHIBICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINFORME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINFORMEFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINFORMEOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtcodprod.Enter += new System.EventHandler(this.txtcodprod_Enter);
            // 
            // grbAgregadoSerie
            // 
            this.grbAgregadoSerie.Controls.Add(this.txtidentificador);
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
            this.grbAgregadoSerie.Size = new System.Drawing.Size(560, 389);
            this.grbAgregadoSerie.TabIndex = 1;
            this.grbAgregadoSerie.TabStop = false;
            // 
            // txtidentificador
            // 
            this.txtidentificador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidentificador.Location = new System.Drawing.Point(264, 18);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(169, 20);
            this.txtidentificador.TabIndex = 6;
            this.txtidentificador.Enter += new System.EventHandler(this.txtcodprod_Enter);
            this.txtidentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentificador_KeyPress);
            // 
            // txtfecfabri
            // 
            this.txtfecfabri.AutoSize = true;
            this.txtfecfabri.Location = new System.Drawing.Point(188, 21);
            this.txtfecfabri.Name = "txtfecfabri";
            this.txtfecfabri.Size = new System.Drawing.Size(65, 13);
            this.txtfecfabri.TabIndex = 78;
            this.txtfecfabri.Text = "Identificador";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Location = new System.Drawing.Point(473, 44);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 28);
            this.btnQuitar.TabIndex = 9;
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
            this.label5.TabIndex = 48;
            this.label5.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Serie";
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.White;
            this.btnAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnadir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAnadir.ForeColor = System.Drawing.Color.Black;
            this.btnAnadir.Location = new System.Drawing.Point(473, 13);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // dgvListaIngreso
            // 
            this.dgvListaIngreso.AllowUserToAddRows = false;
            this.dgvListaIngreso.AllowUserToDeleteRows = false;
            this.dgvListaIngreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHPRODUCTO,
            this.CHSERIE,
            this.CHIDENT,
            this.CHOBS,
            this.BOEXHIBICION,
            this.CHINFORME,
            this.CHINFORMEFECHA,
            this.CHINFORMEOBS});
            this.dgvListaIngreso.Location = new System.Drawing.Point(6, 78);
            this.dgvListaIngreso.Name = "dgvListaIngreso";
            this.dgvListaIngreso.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaIngreso.RowHeadersVisible = false;
            this.dgvListaIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaIngreso.Size = new System.Drawing.Size(548, 303);
            this.dgvListaIngreso.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(79, 45);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(354, 20);
            this.txtObs.TabIndex = 7;
            this.txtObs.Enter += new System.EventHandler(this.txtcodprod_Enter);
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(79, 18);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(89, 20);
            this.txtSerie.TabIndex = 5;
            this.txtSerie.Enter += new System.EventHandler(this.txtcodprod_Enter);
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // txtNombreconpuesto
            // 
            this.txtNombreconpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNombreconpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreconpuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreconpuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreconpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreconpuesto.ForeColor = System.Drawing.Color.Blue;
            this.txtNombreconpuesto.Location = new System.Drawing.Point(178, 13);
            this.txtNombreconpuesto.Name = "txtNombreconpuesto";
            this.txtNombreconpuesto.ReadOnly = true;
            this.txtNombreconpuesto.Size = new System.Drawing.Size(376, 20);
            this.txtNombreconpuesto.TabIndex = 18;
            this.txtNombreconpuesto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(204, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGrabar.ForeColor = System.Drawing.Color.Black;
            this.btnGrabar.Location = new System.Drawing.Point(6, 13);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 0;
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
            this.btnSalir.Location = new System.Drawing.Point(92, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 1;
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
            this.txtidcodigo.Location = new System.Drawing.Point(13, 496);
            this.txtidcodigo.Name = "txtidcodigo";
            this.txtidcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtidcodigo.TabIndex = 10;
            this.txtidcodigo.Visible = false;
            // 
            // mskFecha
            // 
            this.mskFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.mskFecha.ForeColor = System.Drawing.Color.Blue;
            this.mskFecha.Location = new System.Drawing.Point(481, 507);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.ReadOnly = true;
            this.mskFecha.Size = new System.Drawing.Size(91, 20);
            this.mskFecha.TabIndex = 12;
            this.mskFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.txtNombreconpuesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodprod);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.CausesValidation = false;
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.Location = new System.Drawing.Point(63, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(38, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtcodprod_Enter);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
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
            this.txtsubtotal.TabStop = false;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.White;
            this.txtprecio.ForeColor = System.Drawing.Color.Black;
            this.txtprecio.Location = new System.Drawing.Point(265, 46);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 2;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.Enter += new System.EventHandler(this.txtcodprod_Enter);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            this.txtprecio.Validated += new System.EventHandler(this.txtprecio_Validated);
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
            this.txtMedida.TabStop = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirma.Enabled = false;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirma.Location = new System.Drawing.Point(11, 545);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 15;
            this.btnConfirma.UseVisualStyleBackColor = true;
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
            this.CHCODIGO.HeaderText = "ORDEN";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 70;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Visible = false;
            this.CHPRODUCTO.Width = 300;
            // 
            // CHSERIE
            // 
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 150;
            // 
            // CHIDENT
            // 
            this.CHIDENT.HeaderText = "IDENTIFICADOR";
            this.CHIDENT.Name = "CHIDENT";
            this.CHIDENT.ReadOnly = true;
            this.CHIDENT.Width = 150;
            // 
            // CHOBS
            // 
            this.CHOBS.HeaderText = "OBSERVACION";
            this.CHOBS.Name = "CHOBS";
            this.CHOBS.ReadOnly = true;
            this.CHOBS.Width = 250;
            // 
            // BOEXHIBICION
            // 
            this.BOEXHIBICION.HeaderText = "BOEXHIBICION";
            this.BOEXHIBICION.Name = "BOEXHIBICION";
            this.BOEXHIBICION.ReadOnly = true;
            this.BOEXHIBICION.Visible = false;
            // 
            // CHINFORME
            // 
            this.CHINFORME.HeaderText = "CHINFORME";
            this.CHINFORME.Name = "CHINFORME";
            this.CHINFORME.ReadOnly = true;
            this.CHINFORME.Visible = false;
            // 
            // CHINFORMEFECHA
            // 
            this.CHINFORMEFECHA.HeaderText = "CHINFORMEFECHA";
            this.CHINFORMEFECHA.Name = "CHINFORMEFECHA";
            this.CHINFORMEFECHA.ReadOnly = true;
            this.CHINFORMEFECHA.Visible = false;
            // 
            // CHINFORMEOBS
            // 
            this.CHINFORMEOBS.HeaderText = "CHINFORMEOBS";
            this.CHINFORMEOBS.Name = "CHINFORMEOBS";
            this.CHINFORMEOBS.ReadOnly = true;
            this.CHINFORMEOBS.Visible = false;
            // 
            // frmProcSeriesAnadir
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(584, 543);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.txtidcodigo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbAgregadoSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcSeriesAnadir";
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtfecfabri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIDENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOEXHIBICION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORMEFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORMEOBS;
    }
}