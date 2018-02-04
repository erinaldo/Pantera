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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.ESTADOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDIARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCATEARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIPOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(417, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(324, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Silver;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(230, 22);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 28);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(130, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.Silver;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Location = new System.Drawing.Point(31, 22);
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
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 66);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgvArticulo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulo.BackgroundColor = System.Drawing.Color.White;
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
            this.ESTADOARTICULO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArticulo.Location = new System.Drawing.Point(15, 22);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(534, 398);
            this.dgvArticulo.TabIndex = 12;
            this.dgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulo_CellContentClick);
            // 
            // ESTADOARTICULO
            // 
            this.ESTADOARTICULO.DataPropertyName = "estado";
            this.ESTADOARTICULO.HeaderText = "ESTADOARTICULO";
            this.ESTADOARTICULO.Name = "ESTADOARTICULO";
            this.ESTADOARTICULO.ReadOnly = true;
            this.ESTADOARTICULO.Visible = false;
            // 
            // IDMEDIARTICULO
            // 
            this.IDMEDIARTICULO.DataPropertyName = "p_inidunidadmedidaproducto";
            this.IDMEDIARTICULO.HeaderText = "MEDIDA";
            this.IDMEDIARTICULO.Name = "IDMEDIARTICULO";
            this.IDMEDIARTICULO.ReadOnly = true;
            // 
            // IDCATEARTICULO
            // 
            this.IDCATEARTICULO.DataPropertyName = "p_inidfamiliaproducto";
            this.IDCATEARTICULO.HeaderText = "CATEGORIA";
            this.IDCATEARTICULO.Name = "IDCATEARTICULO";
            this.IDCATEARTICULO.ReadOnly = true;
            // 
            // CATEARTICULO
            // 
            this.CATEARTICULO.DataPropertyName = "p_inidmodelo";
            this.CATEARTICULO.HeaderText = "MODELO";
            this.CATEARTICULO.Name = "CATEARTICULO";
            this.CATEARTICULO.ReadOnly = true;
            // 
            // IDTIPOARTICULO
            // 
            this.IDTIPOARTICULO.DataPropertyName = "p_inidcalibre";
            this.IDTIPOARTICULO.HeaderText = "CALIBRE";
            this.IDTIPOARTICULO.Name = "IDTIPOARTICULO";
            this.IDTIPOARTICULO.ReadOnly = true;
            // 
            // TIPOARTICULO
            // 
            this.TIPOARTICULO.DataPropertyName = "p_inidmarca";
            this.TIPOARTICULO.HeaderText = "MARCA";
            this.TIPOARTICULO.Name = "TIPOARTICULO";
            this.TIPOARTICULO.ReadOnly = true;
            // 
            // NOMBREARTICULO
            // 
            this.NOMBREARTICULO.DataPropertyName = "p_inidtipoproducto";
            this.NOMBREARTICULO.HeaderText = "TIPO";
            this.NOMBREARTICULO.Name = "NOMBREARTICULO";
            this.NOMBREARTICULO.ReadOnly = true;
            // 
            // CODIGOARTICULO
            // 
            this.CODIGOARTICULO.DataPropertyName = "chcodigoproducto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODIGOARTICULO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODIGOARTICULO.HeaderText = "CODIGO";
            this.CODIGOARTICULO.Name = "CODIGOARTICULO";
            this.CODIGOARTICULO.ReadOnly = true;
            // 
            // IDARTICULO
            // 
            this.IDARTICULO.DataPropertyName = "p_inidproducto";
            this.IDARTICULO.HeaderText = "IDARTICULO";
            this.IDARTICULO.Name = "IDARTICULO";
            this.IDARTICULO.ReadOnly = true;
            this.IDARTICULO.Visible = false;
            // 
            // frmArticulo
            // 
            this.AcceptButton = this.btnAnadir;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(563, 508);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MANTENIMIENTO DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIPOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCATEARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDIARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOARTICULO;
    }
}