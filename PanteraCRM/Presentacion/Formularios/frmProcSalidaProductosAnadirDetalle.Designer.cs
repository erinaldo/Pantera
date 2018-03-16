namespace Presentacion
{
    partial class frmProcSalidaProductosAnadirDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcSalidaProductosAnadirDetalle));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListaProdSeries = new System.Windows.Forms.DataGridView();
            this.REQSERIE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPreComp = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSeries)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(248, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 41);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(1, 9);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 32;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(83, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaProdSeries
            // 
            this.dgvListaProdSeries.AllowUserToAddRows = false;
            this.dgvListaProdSeries.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProdSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProdSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REQSERIE,
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHDESCRIPCION,
            this.CHMEDIDA,
            this.CHPRECIO,
            this.CHSERIE,
            this.IDSERIE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProdSeries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProdSeries.Location = new System.Drawing.Point(13, 166);
            this.dgvListaProdSeries.Name = "dgvListaProdSeries";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProdSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProdSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProdSeries.Size = new System.Drawing.Size(639, 166);
            this.dgvListaProdSeries.TabIndex = 38;
            // 
            // REQSERIE
            // 
            this.REQSERIE.DataPropertyName = "req_serie";
            this.REQSERIE.HeaderText = "ITEM";
            this.REQSERIE.Name = "REQSERIE";
            this.REQSERIE.Width = 40;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.Visible = false;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "chcodigoproducto";
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 60;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.DataPropertyName = "chnombrecompuesto";
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Width = 350;
            // 
            // CHMEDIDA
            // 
            this.CHMEDIDA.DataPropertyName = "chunidadmedidaproducto";
            this.CHMEDIDA.HeaderText = "MEDIDA";
            this.CHMEDIDA.Name = "CHMEDIDA";
            this.CHMEDIDA.ReadOnly = true;
            this.CHMEDIDA.Width = 60;
            // 
            // CHPRECIO
            // 
            this.CHPRECIO.DataPropertyName = "nuprecio";
            this.CHPRECIO.HeaderText = "PRECIO";
            this.CHPRECIO.Name = "CHPRECIO";
            this.CHPRECIO.ReadOnly = true;
            this.CHPRECIO.Visible = false;
            // 
            // CHSERIE
            // 
            this.CHSERIE.DataPropertyName = "chserie";
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 90;
            // 
            // IDSERIE
            // 
            this.IDSERIE.DataPropertyName = "p_inidserie";
            this.IDSERIE.HeaderText = "IDSERIE";
            this.IDSERIE.Name = "IDSERIE";
            this.IDSERIE.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.txtCant);
            this.groupBox1.Controls.Add(this.txtPreComp);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Blue;
            this.txtStock.Location = new System.Drawing.Point(61, 40);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(91, 20);
            this.txtStock.TabIndex = 45;
            this.txtStock.TabStop = false;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Importe S/.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Precio Compra.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cantidad";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Blue;
            this.txtImporte.Location = new System.Drawing.Point(533, 66);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 41;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.ForeColor = System.Drawing.Color.Blue;
            this.txtMedida.Location = new System.Drawing.Point(106, 66);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 39;
            this.txtMedida.TabStop = false;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(61, 66);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(39, 20);
            this.txtCant.TabIndex = 3;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            this.txtCant.Validated += new System.EventHandler(this.txtCant_Validated);
            // 
            // txtPreComp
            // 
            this.txtPreComp.Location = new System.Drawing.Point(318, 66);
            this.txtPreComp.Name = "txtPreComp";
            this.txtPreComp.Size = new System.Drawing.Size(100, 20);
            this.txtPreComp.TabIndex = 1;
            this.txtPreComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreComp.TextChanged += new System.EventHandler(this.txtPreComp_TextChanged);
            this.txtPreComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreComp_KeyPress);
            this.txtPreComp.Validated += new System.EventHandler(this.txtPreComp_Validated);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Blue;
            this.txtDescripcion.Location = new System.Drawing.Point(158, 13);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(475, 20);
            this.txtDescripcion.TabIndex = 31;
            this.txtDescripcion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(61, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.DoubleClick += new System.EventHandler(this.txtCodigo_DoubleClick);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // frmProcSalidaProductosAnadirDetalle
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListaProdSeries);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcSalidaProductosAnadirDetalle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AÑADIR SALIDA";
            this.Load += new System.EventHandler(this.frmProcSalidaProductosAnadirDetalle_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSeries)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaProdSeries;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REQSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERIE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPreComp;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
    }
}