namespace Presentacion
{
    partial class frmProcSeparacionExhibicionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcSeparacionExhibicionPrincipal));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListaExhibicion = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOEXHIBICION = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CHINFORME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINFORMEOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINFORMEFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGOSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIDENTIFICADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExhibicion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 43);
            this.groupBox2.TabIndex = 23;
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
            this.txtParametro.Location = new System.Drawing.Point(67, 15);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(574, 20);
            this.txtParametro.TabIndex = 0;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(154, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 54);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(186, 16);
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
            this.btnModificar.Location = new System.Drawing.Point(8, 16);
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
            this.btnVer.Location = new System.Drawing.Point(97, 16);
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
            this.btnSalir.Location = new System.Drawing.Point(275, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaExhibicion
            // 
            this.dgvListaExhibicion.AllowUserToAddRows = false;
            this.dgvListaExhibicion.AllowUserToDeleteRows = false;
            this.dgvListaExhibicion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaExhibicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaExhibicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaExhibicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHPRODUCTO,
            this.CHDESCRIPCION,
            this.IDSERIE,
            this.CHSERIE,
            this.BOESTADO,
            this.BOEXHIBICION,
            this.CHINFORME,
            this.CHINFORMEOBS,
            this.CHINFORMEFECHA,
            this.CHCODIGOSERIE,
            this.CHIDENTIFICADOR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaExhibicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaExhibicion.Location = new System.Drawing.Point(12, 50);
            this.dgvListaExhibicion.Name = "dgvListaExhibicion";
            this.dgvListaExhibicion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaExhibicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaExhibicion.Size = new System.Drawing.Size(647, 344);
            this.dgvListaExhibicion.TabIndex = 25;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.DataPropertyName = "chcodigoproducto";
            this.CHPRODUCTO.HeaderText = "CODIGO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Width = 70;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.DataPropertyName = "chdescripcion";
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Width = 370;
            // 
            // IDSERIE
            // 
            this.IDSERIE.DataPropertyName = "p_inidserie";
            this.IDSERIE.HeaderText = "IDSERIE";
            this.IDSERIE.Name = "IDSERIE";
            this.IDSERIE.ReadOnly = true;
            this.IDSERIE.Visible = false;
            // 
            // CHSERIE
            // 
            this.CHSERIE.DataPropertyName = "chcodigoserie";
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 70;
            // 
            // BOESTADO
            // 
            this.BOESTADO.DataPropertyName = "estado";
            this.BOESTADO.HeaderText = "BOESTADO";
            this.BOESTADO.Name = "BOESTADO";
            this.BOESTADO.ReadOnly = true;
            this.BOESTADO.Visible = false;
            // 
            // BOEXHIBICION
            // 
            this.BOEXHIBICION.DataPropertyName = "boexhibicion";
            this.BOEXHIBICION.HeaderText = "EXHIBICION";
            this.BOEXHIBICION.Name = "BOEXHIBICION";
            this.BOEXHIBICION.ReadOnly = true;
            this.BOEXHIBICION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BOEXHIBICION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BOEXHIBICION.Width = 80;
            // 
            // CHINFORME
            // 
            this.CHINFORME.DataPropertyName = "chinforme";
            this.CHINFORME.HeaderText = "CHINFORME";
            this.CHINFORME.Name = "CHINFORME";
            this.CHINFORME.ReadOnly = true;
            this.CHINFORME.Visible = false;
            // 
            // CHINFORMEOBS
            // 
            this.CHINFORMEOBS.DataPropertyName = "chinformeobs";
            this.CHINFORMEOBS.HeaderText = "CHINFORMEOBS";
            this.CHINFORMEOBS.Name = "CHINFORMEOBS";
            this.CHINFORMEOBS.ReadOnly = true;
            this.CHINFORMEOBS.Visible = false;
            // 
            // CHINFORMEFECHA
            // 
            this.CHINFORMEFECHA.DataPropertyName = "chinformefecha";
            this.CHINFORMEFECHA.HeaderText = "CHINFORMEFECHA";
            this.CHINFORMEFECHA.Name = "CHINFORMEFECHA";
            this.CHINFORMEFECHA.ReadOnly = true;
            this.CHINFORMEFECHA.Visible = false;
            // 
            // CHCODIGOSERIE
            // 
            this.CHCODIGOSERIE.DataPropertyName = "chcodigo";
            this.CHCODIGOSERIE.HeaderText = "CHCODIGOSERIE";
            this.CHCODIGOSERIE.Name = "CHCODIGOSERIE";
            this.CHCODIGOSERIE.ReadOnly = true;
            this.CHCODIGOSERIE.Visible = false;
            // 
            // CHIDENTIFICADOR
            // 
            this.CHIDENTIFICADOR.DataPropertyName = "identificador";
            this.CHIDENTIFICADOR.HeaderText = "CHIDENTIFICADOR";
            this.CHIDENTIFICADOR.Name = "CHIDENTIFICADOR";
            this.CHIDENTIFICADOR.ReadOnly = true;
            this.CHIDENTIFICADOR.Visible = false;
            // 
            // frmProcSeparacionExhibicionPrincipal
            // 
            this.AcceptButton = this.btnModificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(671, 478);
            this.Controls.Add(this.dgvListaExhibicion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcSeparacionExhibicionPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SEPARACION PARA EXHIBICION";
            this.Load += new System.EventHandler(this.frmProcSeparacionexhibicionPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExhibicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaExhibicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOESTADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BOEXHIBICION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORMEOBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINFORMEFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGOSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIDENTIFICADOR;
    }
}