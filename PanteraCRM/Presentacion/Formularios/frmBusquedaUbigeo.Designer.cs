namespace Presentacion
{
    partial class frmBusquedaUbigeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaUbigeo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListaUbigeo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParametroBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDUBIGEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDISTRITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUbigeo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccion);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(208, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 55);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.White;
            this.btnSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSeleccion.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccion.Location = new System.Drawing.Point(11, 12);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(75, 34);
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
            this.btnSalir.Location = new System.Drawing.Point(92, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaUbigeo
            // 
            this.dgvListaUbigeo.AllowUserToAddRows = false;
            this.dgvListaUbigeo.AllowUserToDeleteRows = false;
            this.dgvListaUbigeo.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUbigeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUbigeo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUBIGEO,
            this.CHDEPARTAMENTO,
            this.CHPROVINCIA,
            this.CHDISTRITO});
            this.dgvListaUbigeo.Location = new System.Drawing.Point(12, 51);
            this.dgvListaUbigeo.Name = "dgvListaUbigeo";
            this.dgvListaUbigeo.ReadOnly = true;
            this.dgvListaUbigeo.Size = new System.Drawing.Size(572, 136);
            this.dgvListaUbigeo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParametroBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusqueda.Location = new System.Drawing.Point(75, 13);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Size = new System.Drawing.Size(491, 20);
            this.txtParametroBusqueda.TabIndex = 1;
            this.txtParametroBusqueda.TextChanged += new System.EventHandler(this.txtParametroBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // IDUBIGEO
            // 
            this.IDUBIGEO.DataPropertyName = "cod_ubigeo";
            this.IDUBIGEO.HeaderText = "CODIGO";
            this.IDUBIGEO.Name = "IDUBIGEO";
            this.IDUBIGEO.ReadOnly = true;
            this.IDUBIGEO.Width = 70;
            // 
            // CHDEPARTAMENTO
            // 
            this.CHDEPARTAMENTO.DataPropertyName = "desc_departamento";
            this.CHDEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.CHDEPARTAMENTO.Name = "CHDEPARTAMENTO";
            this.CHDEPARTAMENTO.ReadOnly = true;
            this.CHDEPARTAMENTO.Width = 150;
            // 
            // CHPROVINCIA
            // 
            this.CHPROVINCIA.DataPropertyName = "desc_provincia";
            this.CHPROVINCIA.HeaderText = "PROVINCIA";
            this.CHPROVINCIA.Name = "CHPROVINCIA";
            this.CHPROVINCIA.ReadOnly = true;
            this.CHPROVINCIA.Width = 150;
            // 
            // CHDISTRITO
            // 
            this.CHDISTRITO.DataPropertyName = "desc_distrito";
            this.CHDISTRITO.HeaderText = "DISTRITO";
            this.CHDISTRITO.Name = "CHDISTRITO";
            this.CHDISTRITO.ReadOnly = true;
            this.CHDISTRITO.Width = 150;
            // 
            // frmBusquedaUbigeo
            // 
            this.AcceptButton = this.btnSeleccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(597, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListaUbigeo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaUbigeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BUSQUEDA UBIGEO";
            this.Load += new System.EventHandler(this.frmBusquedaUbigeo_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUbigeo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaUbigeo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParametroBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUBIGEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDISTRITO;
    }
}