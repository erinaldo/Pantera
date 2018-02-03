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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(540, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvArticulo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvArticulo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArticulo.Location = new System.Drawing.Point(12, 73);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(759, 411);
            this.dgvArticulo.TabIndex = 12;
            this.dgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulo_CellContentClick);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODIGOARTICULO.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(447, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(353, 22);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 28);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(253, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Location = new System.Drawing.Point(154, 22);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 28);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 66);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mantenimiento Principal Producto";
            // 
            // frmArticulo
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(785, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MANTENIMIENTO DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}