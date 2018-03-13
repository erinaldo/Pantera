namespace Presentacion
{
    partial class frmBusClientePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusClientePrincipal));
            this.dgvListaclientes = new System.Windows.Forms.DataGridView();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPOCODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNRODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPOCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParametroBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaclientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaclientes
            // 
            this.dgvListaclientes.AllowUserToAddRows = false;
            this.dgvListaclientes.AllowUserToDeleteRows = false;
            this.dgvListaclientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCLIENTE,
            this.CHCODIGO,
            this.CHDESCRIPCION,
            this.CHTIPOCODU,
            this.CHNRODOCU,
            this.CHDIRECCION,
            this.CHTIPOCLIENTE,
            this.CHTELEFONO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaclientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaclientes.Location = new System.Drawing.Point(12, 54);
            this.dgvListaclientes.Name = "dgvListaclientes";
            this.dgvListaclientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaclientes.Size = new System.Drawing.Size(638, 148);
            this.dgvListaclientes.TabIndex = 0;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.DataPropertyName = "p_inidcodigoclie";
            this.IDCLIENTE.HeaderText = "IDCLIENTE";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.ReadOnly = true;
            this.IDCLIENTE.Visible = false;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "chcodigocliente";
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 70;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.DataPropertyName = "razon";
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Width = 300;
            // 
            // CHTIPOCODU
            // 
            this.CHTIPOCODU.DataPropertyName = "tipodocu";
            this.CHTIPOCODU.HeaderText = "TIPO";
            this.CHTIPOCODU.Name = "CHTIPOCODU";
            this.CHTIPOCODU.ReadOnly = true;
            this.CHTIPOCODU.Visible = false;
            // 
            // CHNRODOCU
            // 
            this.CHNRODOCU.DataPropertyName = "nrodocumento";
            this.CHNRODOCU.HeaderText = "RUC o DNI";
            this.CHNRODOCU.Name = "CHNRODOCU";
            this.CHNRODOCU.ReadOnly = true;
            this.CHNRODOCU.Width = 110;
            // 
            // CHDIRECCION
            // 
            this.CHDIRECCION.DataPropertyName = "chdireccion";
            this.CHDIRECCION.HeaderText = "DIRECCION";
            this.CHDIRECCION.Name = "CHDIRECCION";
            this.CHDIRECCION.ReadOnly = true;
            this.CHDIRECCION.Visible = false;
            // 
            // CHTIPOCLIENTE
            // 
            this.CHTIPOCLIENTE.DataPropertyName = "tipoclie";
            this.CHTIPOCLIENTE.HeaderText = "TIPO CLIENTE";
            this.CHTIPOCLIENTE.Name = "CHTIPOCLIENTE";
            this.CHTIPOCLIENTE.ReadOnly = true;
            this.CHTIPOCLIENTE.Width = 110;
            // 
            // CHTELEFONO
            // 
            this.CHTELEFONO.DataPropertyName = "telefono";
            this.CHTELEFONO.HeaderText = "TELEFONO";
            this.CHTELEFONO.Name = "CHTELEFONO";
            this.CHTELEFONO.ReadOnly = true;
            this.CHTELEFONO.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParametroBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusqueda.Location = new System.Drawing.Point(67, 16);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Size = new System.Drawing.Size(565, 20);
            this.txtParametroBusqueda.TabIndex = 1;
            this.txtParametroBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(6, 11);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.Text = "&Seleccionar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(178, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(198, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 44);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(92, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 28);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmBusClientePrincipal
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnGrabar;
            this.ClientSize = new System.Drawing.Size(662, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListaclientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusClientePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BUSQUEDA DE CLIENTES";
            this.Load += new System.EventHandler(this.frmBusClientePrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaclientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaclientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParametroBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPOCODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNRODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPOCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTELEFONO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
    }
}