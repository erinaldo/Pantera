namespace Presentacion
{
    partial class frmArticulo
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.IDARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIPOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCATEARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDIARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHACREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AllowUserToOrderColumns = true;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDARTICULO,
            this.CODIGOARTICULO,
            this.NOMBREARTICULO,
            this.TIPOARTICULO,
            this.IDTIPOARTICULO,
            this.CATEARTICULO,
            this.IDCATEARTICULO,
            this.IDMEDIARTICULO,
            this.FECHACREACION,
            this.PRECIO,
            this.IDUSUARIO,
            this.IDSITUARTICULO,
            this.ESTADOARTICULO});
            this.dgvArticulo.Location = new System.Drawing.Point(12, 12);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(759, 411);
            this.dgvArticulo.TabIndex = 12;
            // 
            // IDARTICULO
            // 
            this.IDARTICULO.DataPropertyName = "idarticulo";
            this.IDARTICULO.HeaderText = "IDARTICULO";
            this.IDARTICULO.Name = "IDARTICULO";
            this.IDARTICULO.ReadOnly = true;
            this.IDARTICULO.Visible = false;
            // 
            // CODIGOARTICULO
            // 
            this.CODIGOARTICULO.DataPropertyName = "codigoarticulo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODIGOARTICULO.DefaultCellStyle = dataGridViewCellStyle1;
            this.CODIGOARTICULO.HeaderText = "CODIGO";
            this.CODIGOARTICULO.Name = "CODIGOARTICULO";
            this.CODIGOARTICULO.ReadOnly = true;
            // 
            // NOMBREARTICULO
            // 
            this.NOMBREARTICULO.DataPropertyName = "nombrearticulo";
            this.NOMBREARTICULO.HeaderText = "NOMBRE";
            this.NOMBREARTICULO.Name = "NOMBREARTICULO";
            this.NOMBREARTICULO.ReadOnly = true;
            this.NOMBREARTICULO.Width = 300;
            // 
            // TIPOARTICULO
            // 
            this.TIPOARTICULO.DataPropertyName = "tipoarticulo";
            this.TIPOARTICULO.HeaderText = "TIPO";
            this.TIPOARTICULO.Name = "TIPOARTICULO";
            this.TIPOARTICULO.ReadOnly = true;
            // 
            // IDTIPOARTICULO
            // 
            this.IDTIPOARTICULO.DataPropertyName = "idtipoarticulo";
            this.IDTIPOARTICULO.HeaderText = "IDTIPOARTICULO";
            this.IDTIPOARTICULO.Name = "IDTIPOARTICULO";
            this.IDTIPOARTICULO.ReadOnly = true;
            this.IDTIPOARTICULO.Visible = false;
            this.IDTIPOARTICULO.Width = 150;
            // 
            // CATEARTICULO
            // 
            this.CATEARTICULO.DataPropertyName = "catearticulo";
            this.CATEARTICULO.HeaderText = "CATEGORÍA";
            this.CATEARTICULO.Name = "CATEARTICULO";
            this.CATEARTICULO.ReadOnly = true;
            // 
            // IDCATEARTICULO
            // 
            this.IDCATEARTICULO.DataPropertyName = "idcatearticulo";
            this.IDCATEARTICULO.HeaderText = "IDCATEARTICULO";
            this.IDCATEARTICULO.Name = "IDCATEARTICULO";
            this.IDCATEARTICULO.ReadOnly = true;
            this.IDCATEARTICULO.Visible = false;
            this.IDCATEARTICULO.Width = 200;
            // 
            // IDMEDIARTICULO
            // 
            this.IDMEDIARTICULO.DataPropertyName = "idmediarticulo";
            this.IDMEDIARTICULO.HeaderText = "IDMEDIARTICULO";
            this.IDMEDIARTICULO.Name = "IDMEDIARTICULO";
            this.IDMEDIARTICULO.ReadOnly = true;
            this.IDMEDIARTICULO.Visible = false;
            // 
            // FECHACREACION
            // 
            this.FECHACREACION.DataPropertyName = "fechacreacion";
            this.FECHACREACION.HeaderText = "FECHACREACION";
            this.FECHACREACION.Name = "FECHACREACION";
            this.FECHACREACION.ReadOnly = true;
            this.FECHACREACION.Visible = false;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // IDUSUARIO
            // 
            this.IDUSUARIO.DataPropertyName = "idusuario";
            this.IDUSUARIO.HeaderText = "IDUSUARIO";
            this.IDUSUARIO.Name = "IDUSUARIO";
            this.IDUSUARIO.ReadOnly = true;
            this.IDUSUARIO.Visible = false;
            // 
            // IDSITUARTICULO
            // 
            this.IDSITUARTICULO.DataPropertyName = "idsituarticulo";
            this.IDSITUARTICULO.HeaderText = "IDSITUARTICULO";
            this.IDSITUARTICULO.Name = "IDSITUARTICULO";
            this.IDSITUARTICULO.ReadOnly = true;
            this.IDSITUARTICULO.Visible = false;
            // 
            // ESTADOARTICULO
            // 
            this.ESTADOARTICULO.DataPropertyName = "estadoarticulo";
            this.ESTADOARTICULO.HeaderText = "ESTADOARTICULO";
            this.ESTADOARTICULO.Name = "ESTADOARTICULO";
            this.ESTADOARTICULO.ReadOnly = true;
            this.ESTADOARTICULO.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(438, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(344, 433);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(244, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(145, 433);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // frmArticulo
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(783, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAnadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmArticulo";
            this.Text = "MANTENIMIENTO DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIPOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCATEARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDIARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOARTICULO;
    }
}