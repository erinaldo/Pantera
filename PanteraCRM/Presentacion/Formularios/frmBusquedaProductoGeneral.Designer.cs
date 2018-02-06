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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvProductosBuscados = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBuscados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por Codigo o Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvProductosBuscados
            // 
            this.dgvProductosBuscados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBuscados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHPRODUCTO,
            this.IDMEDIDA,
            this.CHMEDIDA,
            this.IDSITUACION,
            this.CHSITUACION});
            this.dgvProductosBuscados.Location = new System.Drawing.Point(12, 51);
            this.dgvProductosBuscados.Name = "dgvProductosBuscados";
            this.dgvProductosBuscados.Size = new System.Drawing.Size(448, 168);
            this.dgvProductosBuscados.TabIndex = 2;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            this.IDPRODUCTO.Width = 50;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "chcodigoproducto";
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.Width = 74;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.DataPropertyName = "chnombrecompuesto";
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.Width = 93;
            // 
            // IDMEDIDA
            // 
            this.IDMEDIDA.DataPropertyName = "p_inidunidadmedidaproducto";
            this.IDMEDIDA.HeaderText = "IDUNIDA";
            this.IDMEDIDA.Name = "IDMEDIDA";
            this.IDMEDIDA.ReadOnly = true;
            this.IDMEDIDA.Visible = false;
            this.IDMEDIDA.Width = 30;
            // 
            // CHMEDIDA
            // 
            this.CHMEDIDA.DataPropertyName = "chunidadmedidaproducto";
            this.CHMEDIDA.HeaderText = "MEDIDA";
            this.CHMEDIDA.Name = "CHMEDIDA";
            this.CHMEDIDA.Width = 74;
            // 
            // IDSITUACION
            // 
            this.IDSITUACION.DataPropertyName = "p_inidsituacion";
            this.IDSITUACION.HeaderText = "IDSITUACION";
            this.IDSITUACION.Name = "IDSITUACION";
            this.IDSITUACION.ReadOnly = true;
            this.IDSITUACION.Visible = false;
            // 
            // CHSITUACION
            // 
            this.CHSITUACION.DataPropertyName = "chsituacion";
            this.CHSITUACION.HeaderText = "SITUACION PRODUCTO";
            this.CHSITUACION.Name = "CHSITUACION";
            this.CHSITUACION.Width = 141;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccion);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(153, 223);
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
            this.btnSeleccion.Size = new System.Drawing.Size(75, 22);
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
            this.btnSalir.Size = new System.Drawing.Size(75, 22);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmBusquedaProductoGeneral
            // 
            this.AcceptButton = this.btnSeleccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProductosBuscados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBusquedaProductoGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busquedas de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBuscados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvProductosBuscados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSITUACION;
    }
}