namespace Presentacion
{
    partial class frmBusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParametroBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.IDPROVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHRAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPROVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSeleccion);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(209, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 58);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.White;
            this.btnSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSeleccion.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccion.Location = new System.Drawing.Point(11, 15);
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
            this.btnSalir.Location = new System.Drawing.Point(92, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtParametroBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 44);
            this.groupBox1.TabIndex = 10;
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
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.AllowUserToAddRows = false;
            this.dgvListaProveedores.AllowUserToDeleteRows = false;
            this.dgvListaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROVE,
            this.CHRAZON,
            this.TIPODOCU,
            this.NRODOCU,
            this.CHDIRECCION,
            this.TIPOPROVE,
            this.TELEFONO});
            this.dgvListaProveedores.Location = new System.Drawing.Point(12, 51);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.ReadOnly = true;
            this.dgvListaProveedores.Size = new System.Drawing.Size(572, 170);
            this.dgvListaProveedores.TabIndex = 12;
            // 
            // IDPROVE
            // 
            this.IDPROVE.DataPropertyName = "p_inidcodigoclie";
            this.IDPROVE.HeaderText = "IDPROVE";
            this.IDPROVE.Name = "IDPROVE";
            this.IDPROVE.ReadOnly = true;
            this.IDPROVE.Visible = false;
            // 
            // CHRAZON
            // 
            this.CHRAZON.DataPropertyName = "razon";
            this.CHRAZON.HeaderText = "RAZON SOCIAL";
            this.CHRAZON.Name = "CHRAZON";
            this.CHRAZON.ReadOnly = true;
            this.CHRAZON.Width = 330;
            // 
            // TIPODOCU
            // 
            this.TIPODOCU.DataPropertyName = "tipodocu";
            this.TIPODOCU.HeaderText = "TIPODOCU";
            this.TIPODOCU.Name = "TIPODOCU";
            this.TIPODOCU.ReadOnly = true;
            // 
            // NRODOCU
            // 
            this.NRODOCU.DataPropertyName = "nrodocumento";
            this.NRODOCU.HeaderText = "NUMERO";
            this.NRODOCU.Name = "NRODOCU";
            this.NRODOCU.ReadOnly = true;
            // 
            // CHDIRECCION
            // 
            this.CHDIRECCION.DataPropertyName = "chdireccion";
            this.CHDIRECCION.HeaderText = "DIRECCION";
            this.CHDIRECCION.Name = "CHDIRECCION";
            this.CHDIRECCION.ReadOnly = true;
            this.CHDIRECCION.Visible = false;
            // 
            // TIPOPROVE
            // 
            this.TIPOPROVE.DataPropertyName = "tipoclie";
            this.TIPOPROVE.HeaderText = "TIPO";
            this.TIPOPROVE.Name = "TIPOPROVE";
            this.TIPOPROVE.ReadOnly = true;
            this.TIPOPROVE.Visible = false;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "telefono";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Visible = false;
            // 
            // frmBusquedaProveedor
            // 
            this.AcceptButton = this.btnSeleccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(598, 301);
            this.Controls.Add(this.dgvListaProveedores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BUSCAR PROVEEDOR";
            this.Load += new System.EventHandler(this.frmBusquedaProveedor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParametroBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHRAZON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPROVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
    }
}