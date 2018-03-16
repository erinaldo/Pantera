namespace Presentacion
{
    partial class frmProcValesIngresoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcValesIngresoPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.dgvVales = new System.Windows.Forms.DataGridView();
            this.IDVALEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDALMACEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHALMACEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCORRELATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMONEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMONEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHGUIAREMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFACBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUINSERT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUINSERT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUDELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUDELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnular);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(76, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(348, 12);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(80, 28);
            this.btnAnular.TabIndex = 14;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(4, 12);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(262, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(90, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(176, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(434, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 43);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda";
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Location = new System.Drawing.Point(61, 15);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(574, 20);
            this.txtParametro.TabIndex = 0;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // dgvVales
            // 
            this.dgvVales.AllowUserToAddRows = false;
            this.dgvVales.AllowUserToDeleteRows = false;
            this.dgvVales.BackgroundColor = System.Drawing.Color.White;
            this.dgvVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVALEC,
            this.IDALMACEN,
            this.CHALMACEN,
            this.IDCLASE,
            this.CHCLASE,
            this.IDCORRELATIVO,
            this.CHFECHA,
            this.IDMONEDA,
            this.CHMONEDA,
            this.IDPROVEEDOR,
            this.CHPROVEEDOR,
            this.CHGUIAREMI,
            this.CHFACBOL,
            this.IDMOVIMIENTO,
            this.CHMOVIMIENTO,
            this.CHOBSERVACION,
            this.IDUINSERT,
            this.CHUINSERT,
            this.IDUDELETE,
            this.CHUDELETE,
            this.ESTADO});
            this.dgvVales.Location = new System.Drawing.Point(12, 50);
            this.dgvVales.Name = "dgvVales";
            this.dgvVales.ReadOnly = true;
            this.dgvVales.Size = new System.Drawing.Size(647, 344);
            this.dgvVales.TabIndex = 16;
            // 
            // IDVALEC
            // 
            this.IDVALEC.DataPropertyName = "p_inidvalecebecera";
            this.IDVALEC.HeaderText = "IDVALEC";
            this.IDVALEC.Name = "IDVALEC";
            this.IDVALEC.ReadOnly = true;
            this.IDVALEC.Visible = false;
            // 
            // IDALMACEN
            // 
            this.IDALMACEN.DataPropertyName = "p_inidalamacen";
            this.IDALMACEN.HeaderText = "IDALMACEN";
            this.IDALMACEN.Name = "IDALMACEN";
            this.IDALMACEN.ReadOnly = true;
            this.IDALMACEN.Visible = false;
            // 
            // CHALMACEN
            // 
            this.CHALMACEN.DataPropertyName = "chalamacen";
            this.CHALMACEN.HeaderText = "ALMANCEN";
            this.CHALMACEN.Name = "CHALMACEN";
            this.CHALMACEN.ReadOnly = true;
            this.CHALMACEN.Visible = false;
            // 
            // IDCLASE
            // 
            this.IDCLASE.DataPropertyName = "p_inidclase";
            this.IDCLASE.HeaderText = "IDCLASE";
            this.IDCLASE.Name = "IDCLASE";
            this.IDCLASE.ReadOnly = true;
            this.IDCLASE.Visible = false;
            // 
            // CHCLASE
            // 
            this.CHCLASE.DataPropertyName = "chclase";
            this.CHCLASE.HeaderText = "CHCLASE";
            this.CHCLASE.Name = "CHCLASE";
            this.CHCLASE.ReadOnly = true;
            this.CHCLASE.Visible = false;
            // 
            // IDCORRELATIVO
            // 
            this.IDCORRELATIVO.DataPropertyName = "p_inidcorrevale";
            this.IDCORRELATIVO.HeaderText = "N° VALE";
            this.IDCORRELATIVO.Name = "IDCORRELATIVO";
            this.IDCORRELATIVO.ReadOnly = true;
            this.IDCORRELATIVO.Width = 90;
            // 
            // CHFECHA
            // 
            this.CHFECHA.DataPropertyName = "chvalefecha";
            this.CHFECHA.HeaderText = "FECHA";
            this.CHFECHA.Name = "CHFECHA";
            this.CHFECHA.ReadOnly = true;
            this.CHFECHA.Width = 70;
            // 
            // IDMONEDA
            // 
            this.IDMONEDA.DataPropertyName = "p_inidtipomoneda";
            this.IDMONEDA.HeaderText = "IDMONEDA";
            this.IDMONEDA.Name = "IDMONEDA";
            this.IDMONEDA.ReadOnly = true;
            this.IDMONEDA.Visible = false;
            // 
            // CHMONEDA
            // 
            this.CHMONEDA.DataPropertyName = "chtipomoneda";
            this.CHMONEDA.HeaderText = "CHMODENA";
            this.CHMONEDA.Name = "CHMONEDA";
            this.CHMONEDA.ReadOnly = true;
            this.CHMONEDA.Visible = false;
            // 
            // IDPROVEEDOR
            // 
            this.IDPROVEEDOR.DataPropertyName = "p_inidproveedor";
            this.IDPROVEEDOR.HeaderText = "IDPROVEEDOR";
            this.IDPROVEEDOR.Name = "IDPROVEEDOR";
            this.IDPROVEEDOR.ReadOnly = true;
            this.IDPROVEEDOR.Visible = false;
            // 
            // CHPROVEEDOR
            // 
            this.CHPROVEEDOR.DataPropertyName = "chcodigoproveedor";
            this.CHPROVEEDOR.HeaderText = "CHPROVEEDOR";
            this.CHPROVEEDOR.Name = "CHPROVEEDOR";
            this.CHPROVEEDOR.ReadOnly = true;
            this.CHPROVEEDOR.Visible = false;
            // 
            // CHGUIAREMI
            // 
            this.CHGUIAREMI.DataPropertyName = "chguiaremision";
            this.CHGUIAREMI.HeaderText = "CHGUIAREMI";
            this.CHGUIAREMI.Name = "CHGUIAREMI";
            this.CHGUIAREMI.ReadOnly = true;
            this.CHGUIAREMI.Visible = false;
            // 
            // CHFACBOL
            // 
            this.CHFACBOL.DataPropertyName = "chboletafactura";
            this.CHFACBOL.HeaderText = "CHFACBOL";
            this.CHFACBOL.Name = "CHFACBOL";
            this.CHFACBOL.ReadOnly = true;
            this.CHFACBOL.Visible = false;
            // 
            // IDMOVIMIENTO
            // 
            this.IDMOVIMIENTO.DataPropertyName = "p_inidtipomoviemiento";
            this.IDMOVIMIENTO.HeaderText = "IDMOVIMIENTO";
            this.IDMOVIMIENTO.Name = "IDMOVIMIENTO";
            this.IDMOVIMIENTO.ReadOnly = true;
            this.IDMOVIMIENTO.Visible = false;
            // 
            // CHMOVIMIENTO
            // 
            this.CHMOVIMIENTO.DataPropertyName = "chtipomoviemiento";
            this.CHMOVIMIENTO.HeaderText = "MOVIMIENTO";
            this.CHMOVIMIENTO.Name = "CHMOVIMIENTO";
            this.CHMOVIMIENTO.ReadOnly = true;
            this.CHMOVIMIENTO.Width = 300;
            // 
            // CHOBSERVACION
            // 
            this.CHOBSERVACION.DataPropertyName = "chobservacion";
            this.CHOBSERVACION.HeaderText = "OBSERVACION";
            this.CHOBSERVACION.Name = "CHOBSERVACION";
            this.CHOBSERVACION.ReadOnly = true;
            this.CHOBSERVACION.Width = 300;
            // 
            // IDUINSERT
            // 
            this.IDUINSERT.DataPropertyName = "p_inidusuarioinsert";
            this.IDUINSERT.HeaderText = "IDUINSERT";
            this.IDUINSERT.Name = "IDUINSERT";
            this.IDUINSERT.ReadOnly = true;
            this.IDUINSERT.Visible = false;
            // 
            // CHUINSERT
            // 
            this.CHUINSERT.DataPropertyName = "chusuarioinsert";
            this.CHUINSERT.HeaderText = "CHUINSERT";
            this.CHUINSERT.Name = "CHUINSERT";
            this.CHUINSERT.ReadOnly = true;
            this.CHUINSERT.Visible = false;
            // 
            // IDUDELETE
            // 
            this.IDUDELETE.DataPropertyName = "p_inidusuariodelete";
            this.IDUDELETE.HeaderText = "IDUDELETE";
            this.IDUDELETE.Name = "IDUDELETE";
            this.IDUDELETE.ReadOnly = true;
            this.IDUDELETE.Visible = false;
            // 
            // CHUDELETE
            // 
            this.CHUDELETE.DataPropertyName = "chusuariodelete";
            this.CHUDELETE.HeaderText = "CHUDELETE";
            this.CHUDELETE.Name = "CHUDELETE";
            this.CHUDELETE.ReadOnly = true;
            this.CHUDELETE.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // frmProcValesIngresoPrincipal
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(671, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvVales);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcValesIngresoPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VALES DE INGRESO";
            this.Load += new System.EventHandler(this.frmProcValesIngresoPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvVales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVALEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDALMACEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHALMACEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCORRELATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMONEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMONEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHGUIAREMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFACBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUINSERT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUINSERT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUDELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUDELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}