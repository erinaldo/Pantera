namespace Presentacion
{
    partial class frmProcPedidosPedidosDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcPedidosPedidosDetalle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbSerie = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPreUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSeries)).BeginInit();
            this.SuspendLayout();
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
            this.txtCodigo.Location = new System.Drawing.Point(52, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCodigo_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdproducto);
            this.groupBox1.Controls.Add(this.ckbSerie);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.txtCant);
            this.groupBox1.Controls.Add(this.txtDesc2);
            this.groupBox1.Controls.Add(this.txtDesc1);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtPreUnit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 164);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // ckbSerie
            // 
            this.ckbSerie.AutoSize = true;
            this.ckbSerie.Location = new System.Drawing.Point(338, 51);
            this.ckbSerie.Name = "ckbSerie";
            this.ckbSerie.Size = new System.Drawing.Size(15, 14);
            this.ckbSerie.TabIndex = 47;
            this.ckbSerie.UseVisualStyleBackColor = true;
            this.ckbSerie.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fact. Descto. 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Fact. Desto. 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Importe S/.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Precio Vta.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cantidad";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Blue;
            this.txtImporte.Location = new System.Drawing.Point(533, 125);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 41;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Blue;
            this.txtPrecioVenta.Location = new System.Drawing.Point(338, 125);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(63, 20);
            this.txtPrecioVenta.TabIndex = 40;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.ForeColor = System.Drawing.Color.Blue;
            this.txtMedida.Location = new System.Drawing.Point(106, 125);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 39;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(61, 125);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(39, 20);
            this.txtCant.TabIndex = 38;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // txtDesc2
            // 
            this.txtDesc2.Location = new System.Drawing.Point(533, 89);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(100, 20);
            this.txtDesc2.TabIndex = 37;
            this.txtDesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesc2.TextChanged += new System.EventHandler(this.txtDesc2_TextChanged);
            this.txtDesc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc2_KeyPress);
            // 
            // txtDesc1
            // 
            this.txtDesc1.Location = new System.Drawing.Point(106, 86);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(100, 20);
            this.txtDesc1.TabIndex = 36;
            this.txtDesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesc1.TextChanged += new System.EventHandler(this.txtDesc1_TextChanged);
            this.txtDesc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc1_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Blue;
            this.txtStock.Location = new System.Drawing.Point(533, 49);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 35;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPreUnit
            // 
            this.txtPreUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtPreUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreUnit.ForeColor = System.Drawing.Color.Blue;
            this.txtPreUnit.Location = new System.Drawing.Point(106, 49);
            this.txtPreUnit.Name = "txtPreUnit";
            this.txtPreUnit.ReadOnly = true;
            this.txtPreUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPreUnit.TabIndex = 34;
            this.txtPreUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Stock Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Precio Unitario S/.";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Blue;
            this.txtDescripcion.Location = new System.Drawing.Point(158, 13);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(475, 20);
            this.txtDescripcion.TabIndex = 31;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGrabar.Location = new System.Drawing.Point(253, 475);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 32);
            this.btnGrabar.TabIndex = 32;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(334, 475);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaProdSeries
            // 
            this.dgvListaProdSeries.AllowUserToAddRows = false;
            this.dgvListaProdSeries.AllowUserToDeleteRows = false;
            this.dgvListaProdSeries.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvListaProdSeries.Location = new System.Drawing.Point(12, 182);
            this.dgvListaProdSeries.Name = "dgvListaProdSeries";
            this.dgvListaProdSeries.Size = new System.Drawing.Size(639, 287);
            this.dgvListaProdSeries.TabIndex = 34;
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
            this.IDSERIE.Visible = false;
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.Location = new System.Drawing.Point(307, 85);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdproducto.TabIndex = 48;
            this.txtIdproducto.Visible = false;
            // 
            // frmProcPedidosPedidosDetalle
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(663, 519);
            this.Controls.Add(this.dgvListaProdSeries);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcPedidosPedidosDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AÑADIR DETALLE";
            this.Load += new System.EventHandler(this.frmProcPedidosPedidosDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.TextBox txtDesc1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPreUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
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
        private System.Windows.Forms.CheckBox ckbSerie;
        private System.Windows.Forms.TextBox txtIdproducto;
    }
}