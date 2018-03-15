namespace Presentacion
{
    partial class frmProcSalidaProductosAnadir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcSalidaProductosAnadir));
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListaValeDetalle = new System.Windows.Forms.DataGridView();
            this.IDITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTipref2 = new System.Windows.Forms.Label();
            this.lblTipref5 = new System.Windows.Forms.Label();
            this.lblTipref4 = new System.Windows.Forms.Label();
            this.lblTipref3 = new System.Windows.Forms.Label();
            this.lblTipref1 = new System.Windows.Forms.Label();
            this.lblNref5 = new System.Windows.Forms.Label();
            this.txtCref5 = new System.Windows.Forms.TextBox();
            this.txtCref2 = new System.Windows.Forms.TextBox();
            this.lblNref1 = new System.Windows.Forms.Label();
            this.txtCref1 = new System.Windows.Forms.TextBox();
            this.txtCref4 = new System.Windows.Forms.TextBox();
            this.txtCref3 = new System.Windows.Forms.TextBox();
            this.lblNref4 = new System.Windows.Forms.Label();
            this.lblNref3 = new System.Windows.Forms.Label();
            this.lblNref2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaValeDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(587, 409);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVer);
            this.groupBox4.Controls.Add(this.btnAnadir);
            this.groupBox4.Controls.Add(this.btnGrabar);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(11, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 48);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(253, 13);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(4, 13);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(336, 13);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(87, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(170, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(419, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvListaValeDetalle);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 200);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // dgvListaValeDetalle
            // 
            this.dgvListaValeDetalle.AllowUserToAddRows = false;
            this.dgvListaValeDetalle.AllowUserToDeleteRows = false;
            this.dgvListaValeDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaValeDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaValeDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaValeDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDITEM,
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHCANTIDAD,
            this.CHMEDIDA,
            this.CHDESCRIPCION,
            this.CHCOSTO,
            this.CHSUBTOTAL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaValeDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaValeDetalle.Location = new System.Drawing.Point(6, 13);
            this.dgvListaValeDetalle.Name = "dgvListaValeDetalle";
            this.dgvListaValeDetalle.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaValeDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaValeDetalle.Size = new System.Drawing.Size(662, 181);
            this.dgvListaValeDetalle.TabIndex = 0;
            // 
            // IDITEM
            // 
            this.IDITEM.HeaderText = "ITEM";
            this.IDITEM.Name = "IDITEM";
            this.IDITEM.ReadOnly = true;
            this.IDITEM.Visible = false;
            this.IDITEM.Width = 40;
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
            this.CHDESCRIPCION.Width = 320;
            // 
            // CHCOSTO
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "00.00";
            this.CHCOSTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHCOSTO.HeaderText = "COSTO";
            this.CHCOSTO.Name = "CHCOSTO";
            this.CHCOSTO.ReadOnly = true;
            this.CHCOSTO.Width = 50;
            // 
            // CHSUBTOTAL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "00.00";
            this.CHSUBTOTAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHSUBTOTAL.HeaderText = "SUB TOTAL";
            this.CHSUBTOTAL.Name = "CHSUBTOTAL";
            this.CHSUBTOTAL.ReadOnly = true;
            this.CHSUBTOTAL.Width = 60;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 106);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(260, 71);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 3;
            // 
            // mskfechareg
            // 
            this.mskfechareg.Location = new System.Drawing.Point(91, 69);
            this.mskfechareg.Mask = "00/00/0000";
            this.mskfechareg.Name = "mskfechareg";
            this.mskfechareg.Size = new System.Drawing.Size(100, 20);
            this.mskfechareg.TabIndex = 2;
            this.mskfechareg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskfechareg.ValidatingType = typeof(System.DateTime);
            // 
            // cboTipoMov
            // 
            this.cboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMov.FormattingEnabled = true;
            this.cboTipoMov.Location = new System.Drawing.Point(509, 42);
            this.cboTipoMov.Name = "cboTipoMov";
            this.cboTipoMov.Size = new System.Drawing.Size(159, 21);
            this.cboTipoMov.TabIndex = 1;
            this.cboTipoMov.SelectedIndexChanged += new System.EventHandler(this.cboTipoMov_SelectedIndexChanged);
            // 
            // txtobs
            // 
            this.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobs.Location = new System.Drawing.Point(509, 69);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(159, 20);
            this.txtobs.TabIndex = 4;
            this.txtobs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobs_KeyPress);
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacen.ForeColor = System.Drawing.Color.Blue;
            this.txtAlmacen.Location = new System.Drawing.Point(509, 17);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(159, 20);
            this.txtAlmacen.TabIndex = 4;
            this.txtAlmacen.TabStop = false;
            this.txtAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNroVale
            // 
            this.txtNroVale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNroVale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroVale.ForeColor = System.Drawing.Color.Blue;
            this.txtNroVale.Location = new System.Drawing.Point(260, 42);
            this.txtNroVale.Name = "txtNroVale";
            this.txtNroVale.ReadOnly = true;
            this.txtNroVale.Size = new System.Drawing.Size(121, 20);
            this.txtNroVale.TabIndex = 5;
            this.txtNroVale.TabStop = false;
            this.txtNroVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtperiodo
            // 
            this.txtperiodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtperiodo.CausesValidation = false;
            this.txtperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperiodo.ForeColor = System.Drawing.Color.Blue;
            this.txtperiodo.Location = new System.Drawing.Point(260, 17);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.ReadOnly = true;
            this.txtperiodo.Size = new System.Drawing.Size(27, 20);
            this.txtperiodo.TabIndex = 6;
            this.txtperiodo.TabStop = false;
            this.txtperiodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClase
            // 
            this.txtClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClase.ForeColor = System.Drawing.Color.Blue;
            this.txtClase.Location = new System.Drawing.Point(91, 42);
            this.txtClase.Name = "txtClase";
            this.txtClase.ReadOnly = true;
            this.txtClase.Size = new System.Drawing.Size(100, 20);
            this.txtClase.TabIndex = 7;
            this.txtClase.TabStop = false;
            this.txtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtejercicio
            // 
            this.txtejercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtejercicio.CausesValidation = false;
            this.txtejercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtejercicio.ForeColor = System.Drawing.Color.Blue;
            this.txtejercicio.Location = new System.Drawing.Point(91, 17);
            this.txtejercicio.Name = "txtejercicio";
            this.txtejercicio.ReadOnly = true;
            this.txtejercicio.Size = new System.Drawing.Size(100, 20);
            this.txtejercicio.TabIndex = 8;
            this.txtejercicio.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTipref2);
            this.groupBox2.Controls.Add(this.lblTipref5);
            this.groupBox2.Controls.Add(this.lblTipref4);
            this.groupBox2.Controls.Add(this.lblTipref3);
            this.groupBox2.Controls.Add(this.lblTipref1);
            this.groupBox2.Controls.Add(this.lblNref5);
            this.groupBox2.Controls.Add(this.txtCref5);
            this.groupBox2.Controls.Add(this.txtCref2);
            this.groupBox2.Controls.Add(this.lblNref1);
            this.groupBox2.Controls.Add(this.txtCref1);
            this.groupBox2.Controls.Add(this.txtCref4);
            this.groupBox2.Controls.Add(this.txtCref3);
            this.groupBox2.Controls.Add(this.lblNref4);
            this.groupBox2.Controls.Add(this.lblNref3);
            this.groupBox2.Controls.Add(this.lblNref2);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 66);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Referencia";
            // 
            // lblTipref2
            // 
            this.lblTipref2.AutoSize = true;
            this.lblTipref2.Location = new System.Drawing.Point(136, 35);
            this.lblTipref2.Name = "lblTipref2";
            this.lblTipref2.Size = new System.Drawing.Size(0, 13);
            this.lblTipref2.TabIndex = 26;
            // 
            // lblTipref5
            // 
            this.lblTipref5.AutoSize = true;
            this.lblTipref5.Location = new System.Drawing.Point(538, 35);
            this.lblTipref5.Name = "lblTipref5";
            this.lblTipref5.Size = new System.Drawing.Size(0, 13);
            this.lblTipref5.TabIndex = 25;
            // 
            // lblTipref4
            // 
            this.lblTipref4.AutoSize = true;
            this.lblTipref4.Location = new System.Drawing.Point(413, 35);
            this.lblTipref4.Name = "lblTipref4";
            this.lblTipref4.Size = new System.Drawing.Size(0, 13);
            this.lblTipref4.TabIndex = 24;
            // 
            // lblTipref3
            // 
            this.lblTipref3.AutoSize = true;
            this.lblTipref3.Location = new System.Drawing.Point(269, 35);
            this.lblTipref3.Name = "lblTipref3";
            this.lblTipref3.Size = new System.Drawing.Size(0, 13);
            this.lblTipref3.TabIndex = 23;
            // 
            // lblTipref1
            // 
            this.lblTipref1.AutoSize = true;
            this.lblTipref1.Location = new System.Drawing.Point(9, 35);
            this.lblTipref1.Name = "lblTipref1";
            this.lblTipref1.Size = new System.Drawing.Size(0, 13);
            this.lblTipref1.TabIndex = 22;
            // 
            // lblNref5
            // 
            this.lblNref5.AutoSize = true;
            this.lblNref5.Location = new System.Drawing.Point(538, 16);
            this.lblNref5.Name = "lblNref5";
            this.lblNref5.Size = new System.Drawing.Size(0, 13);
            this.lblNref5.TabIndex = 21;
            // 
            // txtCref5
            // 
            this.txtCref5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCref5.Location = new System.Drawing.Point(591, 32);
            this.txtCref5.Name = "txtCref5";
            this.txtCref5.Size = new System.Drawing.Size(80, 20);
            this.txtCref5.TabIndex = 4;
            this.txtCref5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCref1_KeyPress);
            // 
            // txtCref2
            // 
            this.txtCref2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCref2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCref2.Location = new System.Drawing.Point(174, 32);
            this.txtCref2.Name = "txtCref2";
            this.txtCref2.Size = new System.Drawing.Size(80, 20);
            this.txtCref2.TabIndex = 1;
            this.txtCref2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCref1_KeyPress);
            // 
            // lblNref1
            // 
            this.lblNref1.AutoSize = true;
            this.lblNref1.Location = new System.Drawing.Point(9, 16);
            this.lblNref1.Name = "lblNref1";
            this.lblNref1.Size = new System.Drawing.Size(0, 13);
            this.lblNref1.TabIndex = 18;
            // 
            // txtCref1
            // 
            this.txtCref1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCref1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCref1.Location = new System.Drawing.Point(35, 32);
            this.txtCref1.Name = "txtCref1";
            this.txtCref1.Size = new System.Drawing.Size(80, 20);
            this.txtCref1.TabIndex = 0;
            this.txtCref1.TextChanged += new System.EventHandler(this.txtCref1_TextChanged);
            this.txtCref1.DoubleClick += new System.EventHandler(this.txtCref1_DoubleClick);
            this.txtCref1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCref1_KeyPress);
            // 
            // txtCref4
            // 
            this.txtCref4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCref4.Location = new System.Drawing.Point(452, 32);
            this.txtCref4.Name = "txtCref4";
            this.txtCref4.Size = new System.Drawing.Size(80, 20);
            this.txtCref4.TabIndex = 3;
            this.txtCref4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCref1_KeyPress);
            // 
            // txtCref3
            // 
            this.txtCref3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCref3.Location = new System.Drawing.Point(323, 32);
            this.txtCref3.Name = "txtCref3";
            this.txtCref3.Size = new System.Drawing.Size(80, 20);
            this.txtCref3.TabIndex = 2;
            this.txtCref3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCref1_KeyPress);
            // 
            // lblNref4
            // 
            this.lblNref4.AutoSize = true;
            this.lblNref4.Location = new System.Drawing.Point(413, 16);
            this.lblNref4.Name = "lblNref4";
            this.lblNref4.Size = new System.Drawing.Size(0, 13);
            this.lblNref4.TabIndex = 3;
            // 
            // lblNref3
            // 
            this.lblNref3.AutoSize = true;
            this.lblNref3.Location = new System.Drawing.Point(269, 16);
            this.lblNref3.Name = "lblNref3";
            this.lblNref3.Size = new System.Drawing.Size(0, 13);
            this.lblNref3.TabIndex = 4;
            // 
            // lblNref2
            // 
            this.lblNref2.AutoSize = true;
            this.lblNref2.Location = new System.Drawing.Point(136, 16);
            this.lblNref2.Name = "lblNref2";
            this.lblNref2.Size = new System.Drawing.Size(0, 13);
            this.lblNref2.TabIndex = 5;
            // 
            // frmProcSalidaProductosAnadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcSalidaProductosAnadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AÑADIR SALIDA";
            this.Load += new System.EventHandler(this.frmProcSalidaProductosAnadir_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaValeDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvListaValeDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.MaskedTextBox mskfechareg;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTipref2;
        private System.Windows.Forms.Label lblTipref5;
        private System.Windows.Forms.Label lblTipref4;
        private System.Windows.Forms.Label lblTipref3;
        private System.Windows.Forms.Label lblTipref1;
        private System.Windows.Forms.Label lblNref5;
        private System.Windows.Forms.TextBox txtCref5;
        private System.Windows.Forms.TextBox txtCref2;
        private System.Windows.Forms.Label lblNref1;
        private System.Windows.Forms.TextBox txtCref1;
        private System.Windows.Forms.TextBox txtCref4;
        private System.Windows.Forms.TextBox txtCref3;
        private System.Windows.Forms.Label lblNref4;
        private System.Windows.Forms.Label lblNref3;
        private System.Windows.Forms.Label lblNref2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSUBTOTAL;
    }
}