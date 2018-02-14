namespace Presentacion
{
    partial class frmBusquedaProductoGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProductoGeneral));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRECIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(67, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccion);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(220, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.White;
            this.btnSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSeleccion.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccion.Location = new System.Drawing.Point(11, 19);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(75, 30);
            this.btnSeleccion.TabIndex = 1;
            this.btnSeleccion.Text = "&Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(92, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.BOSERIE,
            this.CHCODIGO,
            this.CHPRODUCTO,
            this.IDMEDIDA,
            this.IDSITUACION,
            this.CHMEDIDAS,
            this.CHSITUACION,
            this.CHPRECIOS});
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 50);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(574, 173);
            this.dgvBusqueda.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            // 
            // BOSERIE
            // 
            this.BOSERIE.DataPropertyName = "req_serie";
            this.BOSERIE.HeaderText = "BOSERIE";
            this.BOSERIE.Name = "BOSERIE";
            this.BOSERIE.ReadOnly = true;
            this.BOSERIE.Visible = false;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "chcodigoproducto";
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 60;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.DataPropertyName = "chnombrecompuesto";
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Width = 400;
            // 
            // IDMEDIDA
            // 
            this.IDMEDIDA.DataPropertyName = "p_inidunidadmedidaproducto";
            this.IDMEDIDA.HeaderText = "IDMEDIDA";
            this.IDMEDIDA.Name = "IDMEDIDA";
            this.IDMEDIDA.ReadOnly = true;
            this.IDMEDIDA.Visible = false;
            // 
            // IDSITUACION
            // 
            this.IDSITUACION.DataPropertyName = "p_inidsituacion";
            this.IDSITUACION.HeaderText = "IDSITUACION";
            this.IDSITUACION.Name = "IDSITUACION";
            this.IDSITUACION.ReadOnly = true;
            this.IDSITUACION.Visible = false;
            // 
            // CHMEDIDAS
            // 
            this.CHMEDIDAS.DataPropertyName = "chunidadmedidaproducto";
            this.CHMEDIDAS.HeaderText = "MEDIDA";
            this.CHMEDIDAS.Name = "CHMEDIDAS";
            this.CHMEDIDAS.ReadOnly = true;
            this.CHMEDIDAS.Width = 70;
            // 
            // CHSITUACION
            // 
            this.CHSITUACION.DataPropertyName = "chsituacion";
            this.CHSITUACION.HeaderText = "SITUACION";
            this.CHSITUACION.Name = "CHSITUACION";
            this.CHSITUACION.ReadOnly = true;
            this.CHSITUACION.Visible = false;
            this.CHSITUACION.Width = 60;
            // 
            // CHPRECIOS
            // 
            this.CHPRECIOS.DataPropertyName = "nuprecio";
            this.CHPRECIOS.HeaderText = "PRECIO";
            this.CHPRECIOS.Name = "CHPRECIOS";
            this.CHPRECIOS.ReadOnly = true;
            this.CHPRECIOS.Visible = false;
            // 
            // frmBusquedaProductoGeneral
            // 
            this.AcceptButton = this.btnSeleccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(599, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaProductoGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BUSQUEDA DE PRODUCTO";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRECIOS;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}