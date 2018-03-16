namespace Presentacion
{
    partial class frmManListaPrecioPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManListaPrecioPrincipal));
            this.dgvListaPrecios = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaPrecios
            // 
            this.dgvListaPrecios.AllowUserToAddRows = false;
            this.dgvListaPrecios.AllowUserToDeleteRows = false;
            this.dgvListaPrecios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPrecios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CHCODIGO,
            this.CHDESCRIPCION,
            this.CHPRECIO,
            this.CHMEDIDA,
            this.IDUNIDAD,
            this.IDSITUACION,
            this.CHSITUACION,
            this.REQSERIE});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPrecios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaPrecios.Location = new System.Drawing.Point(12, 57);
            this.dgvListaPrecios.Name = "dgvListaPrecios";
            this.dgvListaPrecios.ReadOnly = true;
            this.dgvListaPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPrecios.Size = new System.Drawing.Size(647, 335);
            this.dgvListaPrecios.TabIndex = 1;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "chcodigoproducto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHCODIGO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHCODIGO.HeaderText = "CODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            this.CHCODIGO.Width = 60;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.DataPropertyName = "chnombrecompuesto";
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Width = 400;
            // 
            // CHPRECIO
            // 
            this.CHPRECIO.DataPropertyName = "nuprecio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.CHPRECIO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHPRECIO.HeaderText = "PRECIO";
            this.CHPRECIO.Name = "CHPRECIO";
            this.CHPRECIO.ReadOnly = true;
            this.CHPRECIO.Width = 60;
            // 
            // CHMEDIDA
            // 
            this.CHMEDIDA.DataPropertyName = "chunidadmedidaproducto";
            this.CHMEDIDA.HeaderText = "MEDIDA";
            this.CHMEDIDA.Name = "CHMEDIDA";
            this.CHMEDIDA.ReadOnly = true;
            this.CHMEDIDA.Width = 60;
            // 
            // IDUNIDAD
            // 
            this.IDUNIDAD.DataPropertyName = "p_inidunidadmedidaproducto";
            this.IDUNIDAD.HeaderText = "IDUNIDAD";
            this.IDUNIDAD.Name = "IDUNIDAD";
            this.IDUNIDAD.ReadOnly = true;
            this.IDUNIDAD.Visible = false;
            // 
            // IDSITUACION
            // 
            this.IDSITUACION.DataPropertyName = "p_inidsituacion";
            this.IDSITUACION.HeaderText = "IDISUTACION";
            this.IDSITUACION.Name = "IDSITUACION";
            this.IDSITUACION.ReadOnly = true;
            this.IDSITUACION.Visible = false;
            // 
            // CHSITUACION
            // 
            this.CHSITUACION.DataPropertyName = "chsituacion";
            this.CHSITUACION.HeaderText = "CHSITUACION";
            this.CHSITUACION.Name = "CHSITUACION";
            this.CHSITUACION.ReadOnly = true;
            this.CHSITUACION.Visible = false;
            // 
            // REQSERIE
            // 
            this.REQSERIE.DataPropertyName = "req_serie";
            this.REQSERIE.HeaderText = "REQSERIE";
            this.REQSERIE.Name = "REQSERIE";
            this.REQSERIE.ReadOnly = true;
            this.REQSERIE.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(278, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(11, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 28);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(100, 14);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(189, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bsqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Location = new System.Drawing.Point(67, 17);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(574, 20);
            this.txtParametro.TabIndex = 0;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnVer);
            this.groupBox2.Location = new System.Drawing.Point(151, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // frmManListaPrecioPrincipal
            // 
            this.AcceptButton = this.btnModificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(671, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListaPrecios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManListaPrecioPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTAS DE PRECIOS";
            this.Load += new System.EventHandler(this.frmManListaPrecioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPrecios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUNIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQSERIE;
    }
}