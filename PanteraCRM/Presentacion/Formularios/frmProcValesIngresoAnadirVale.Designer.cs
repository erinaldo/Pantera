﻿namespace Presentacion
{
    partial class frmProcIngresoValesAnadir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.mskfechareg = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoMov = new System.Windows.Forms.ComboBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.txtNroVale = new System.Windows.Forms.TextBox();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.txtejercicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFacBol = new System.Windows.Forms.TextBox();
            this.txtguiarem = new System.Windows.Forms.TextBox();
            this.txtCodprov = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvListaValeDetalle = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaValeDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMoneda);
            this.groupBox1.Controls.Add(this.mskfechareg);
            this.groupBox1.Controls.Add(this.cboTipoMov);
            this.groupBox1.Controls.Add(this.txtobs);
            this.groupBox1.Controls.Add(this.txtAlmacen);
            this.groupBox1.Controls.Add(this.txtNroVale);
            this.groupBox1.Controls.Add(this.txtperiodo);
            this.groupBox1.Controls.Add(this.txtClase);
            this.groupBox1.Controls.Add(this.txtejercicio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(260, 71);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 0;
            // 
            // mskfechareg
            // 
            this.mskfechareg.Location = new System.Drawing.Point(91, 69);
            this.mskfechareg.Mask = "00/00/0000";
            this.mskfechareg.Name = "mskfechareg";
            this.mskfechareg.Size = new System.Drawing.Size(100, 20);
            this.mskfechareg.TabIndex = 1;
            this.mskfechareg.ValidatingType = typeof(System.DateTime);
            // 
            // cboTipoMov
            // 
            this.cboTipoMov.FormattingEnabled = true;
            this.cboTipoMov.Location = new System.Drawing.Point(509, 42);
            this.cboTipoMov.Name = "cboTipoMov";
            this.cboTipoMov.Size = new System.Drawing.Size(159, 21);
            this.cboTipoMov.TabIndex = 2;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(509, 69);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(159, 20);
            this.txtobs.TabIndex = 3;
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtAlmacen.ForeColor = System.Drawing.Color.Blue;
            this.txtAlmacen.Location = new System.Drawing.Point(509, 17);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(159, 20);
            this.txtAlmacen.TabIndex = 4;
            this.txtAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNroVale
            // 
            this.txtNroVale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNroVale.ForeColor = System.Drawing.Color.Blue;
            this.txtNroVale.Location = new System.Drawing.Point(260, 42);
            this.txtNroVale.Name = "txtNroVale";
            this.txtNroVale.ReadOnly = true;
            this.txtNroVale.Size = new System.Drawing.Size(121, 20);
            this.txtNroVale.TabIndex = 5;
            this.txtNroVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtperiodo
            // 
            this.txtperiodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtperiodo.CausesValidation = false;
            this.txtperiodo.ForeColor = System.Drawing.Color.Blue;
            this.txtperiodo.Location = new System.Drawing.Point(260, 17);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.ReadOnly = true;
            this.txtperiodo.Size = new System.Drawing.Size(27, 20);
            this.txtperiodo.TabIndex = 6;
            this.txtperiodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClase
            // 
            this.txtClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtClase.ForeColor = System.Drawing.Color.Blue;
            this.txtClase.Location = new System.Drawing.Point(91, 42);
            this.txtClase.Name = "txtClase";
            this.txtClase.ReadOnly = true;
            this.txtClase.Size = new System.Drawing.Size(100, 20);
            this.txtClase.TabIndex = 7;
            this.txtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtejercicio
            // 
            this.txtejercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtejercicio.CausesValidation = false;
            this.txtejercicio.ForeColor = System.Drawing.Color.Blue;
            this.txtejercicio.Location = new System.Drawing.Point(91, 17);
            this.txtejercicio.Name = "txtejercicio";
            this.txtejercicio.ReadOnly = true;
            this.txtejercicio.Size = new System.Drawing.Size(100, 20);
            this.txtejercicio.TabIndex = 8;
            this.txtejercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Observacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de Movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Almacen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "N° Vale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clase";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFacBol);
            this.groupBox2.Controls.Add(this.txtguiarem);
            this.groupBox2.Controls.Add(this.txtCodprov);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Referencia";
            // 
            // txtFacBol
            // 
            this.txtFacBol.Location = new System.Drawing.Point(422, 32);
            this.txtFacBol.Name = "txtFacBol";
            this.txtFacBol.Size = new System.Drawing.Size(246, 20);
            this.txtFacBol.TabIndex = 0;
            // 
            // txtguiarem
            // 
            this.txtguiarem.Location = new System.Drawing.Point(200, 32);
            this.txtguiarem.Name = "txtguiarem";
            this.txtguiarem.Size = new System.Drawing.Size(178, 20);
            this.txtguiarem.TabIndex = 1;
            // 
            // txtCodprov
            // 
            this.txtCodprov.Location = new System.Drawing.Point(9, 32);
            this.txtCodprov.Name = "txtCodprov";
            this.txtCodprov.Size = new System.Drawing.Size(160, 20);
            this.txtCodprov.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Factura - Boleta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Guia Remisión";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Proveedor";
            // 
            // dgvListaValeDetalle
            // 
            this.dgvListaValeDetalle.AllowUserToAddRows = false;
            this.dgvListaValeDetalle.AllowUserToDeleteRows = false;
            this.dgvListaValeDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaValeDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaValeDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHCANTIDAD,
            this.CHMEDIDA,
            this.CHDESCRIPCION,
            this.CHCOSTO,
            this.CHSUBTOTAL});
            this.dgvListaValeDetalle.Location = new System.Drawing.Point(6, 13);
            this.dgvListaValeDetalle.Name = "dgvListaValeDetalle";
            this.dgvListaValeDetalle.ReadOnly = true;
            this.dgvListaValeDetalle.Size = new System.Drawing.Size(662, 181);
            this.dgvListaValeDetalle.TabIndex = 0;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 60;
            // 
            // CHCANTIDAD
            // 
            this.CHCANTIDAD.HeaderText = "CANTIDAD";
            this.CHCANTIDAD.Name = "CHCANTIDAD";
            this.CHCANTIDAD.ReadOnly = true;
            this.CHCANTIDAD.Width = 70;
            // 
            // CHMEDIDA
            // 
            this.CHMEDIDA.HeaderText = "MEDIDA";
            this.CHMEDIDA.Name = "CHMEDIDA";
            this.CHMEDIDA.ReadOnly = true;
            this.CHMEDIDA.Width = 60;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Width = 340;
            // 
            // CHCOSTO
            // 
            this.CHCOSTO.HeaderText = "COSTO";
            this.CHCOSTO.Name = "CHCOSTO";
            this.CHCOSTO.ReadOnly = true;
            this.CHCOSTO.Width = 50;
            // 
            // CHSUBTOTAL
            // 
            this.CHSUBTOTAL.HeaderText = "SUB TOTAL";
            this.CHSUBTOTAL.Name = "CHSUBTOTAL";
            this.CHSUBTOTAL.ReadOnly = true;
            this.CHSUBTOTAL.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvListaValeDetalle);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAnadir);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnVer);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 66);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(9, 17);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(73, 35);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(96, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(181, 17);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(73, 35);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(363, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(587, 428);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "TOTAL";
            // 
            // frmProcIngresoValesAnadir
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(703, 473);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmProcIngresoValesAnadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AÑADIR MOVIMIENTO";
            this.Load += new System.EventHandler(this.frmProcIngresoValesAnadir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaValeDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaValeDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTipoMov;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.TextBox txtNroVale;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.TextBox txtejercicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacBol;
        private System.Windows.Forms.TextBox txtguiarem;
        private System.Windows.Forms.TextBox txtCodprov;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskfechareg;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSUBTOTAL;
    }
}