namespace Presentacion
{
    partial class frmManVariosAnadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManVariosAnadir));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObbs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAcro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dgvListaDetalle = new System.Windows.Forms.DataGridView();
            this.IDMAESTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObbs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cabecera";
            // 
            // txtObbs
            // 
            this.txtObbs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObbs.Location = new System.Drawing.Point(75, 65);
            this.txtObbs.Name = "txtObbs";
            this.txtObbs.Size = new System.Drawing.Size(264, 20);
            this.txtObbs.TabIndex = 2;
            this.txtObbs.Enter += new System.EventHandler(this.txtObbs_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observación\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCod
            // 
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Location = new System.Drawing.Point(75, 17);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(80, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.Enter += new System.EventHandler(this.txtCod_Enter);
            // 
            // txtDescrip
            // 
            this.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescrip.Location = new System.Drawing.Point(75, 41);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(264, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Enter += new System.EventHandler(this.txtDescrip_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAcro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDetDesc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAnadir);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Detalle";
            // 
            // txtAcro
            // 
            this.txtAcro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAcro.Location = new System.Drawing.Point(75, 48);
            this.txtAcro.Name = "txtAcro";
            this.txtAcro.Size = new System.Drawing.Size(162, 20);
            this.txtAcro.TabIndex = 1;
            this.txtAcro.Enter += new System.EventHandler(this.txtAcro_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Acrónimo";
            // 
            // txtDetDesc
            // 
            this.txtDetDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetDesc.Location = new System.Drawing.Point(75, 22);
            this.txtDetDesc.Name = "txtDetDesc";
            this.txtDetDesc.Size = new System.Drawing.Size(162, 20);
            this.txtDetDesc.TabIndex = 0;
            this.txtDetDesc.Enter += new System.EventHandler(this.txtDetDesc_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.Window;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(259, 46);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 28);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(259, 16);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // dgvListaDetalle
            // 
            this.dgvListaDetalle.AllowUserToAddRows = false;
            this.dgvListaDetalle.AllowUserToDeleteRows = false;
            this.dgvListaDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMAESTRO,
            this.IDDETALLE,
            this.CHCODIGO,
            this.CHITEM,
            this.CHOBS,
            this.ESTADO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaDetalle.Location = new System.Drawing.Point(12, 204);
            this.dgvListaDetalle.Name = "dgvListaDetalle";
            this.dgvListaDetalle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDetalle.Size = new System.Drawing.Size(345, 153);
            this.dgvListaDetalle.TabIndex = 2;
            // 
            // IDMAESTRO
            // 
            this.IDMAESTRO.DataPropertyName = "idmaestro";
            this.IDMAESTRO.HeaderText = "IDMAESTRO";
            this.IDMAESTRO.Name = "IDMAESTRO";
            this.IDMAESTRO.ReadOnly = true;
            // 
            // IDDETALLE
            // 
            this.IDDETALLE.DataPropertyName = "idmaestrodetalle";
            this.IDDETALLE.HeaderText = "IDDETALLE";
            this.IDDETALLE.Name = "IDDETALLE";
            this.IDDETALLE.ReadOnly = true;
            // 
            // CHCODIGO
            // 
            this.CHCODIGO.DataPropertyName = "codigoitem";
            this.CHCODIGO.HeaderText = "CHCODIGO";
            this.CHCODIGO.Name = "CHCODIGO";
            this.CHCODIGO.ReadOnly = true;
            // 
            // CHITEM
            // 
            this.CHITEM.DataPropertyName = "nombreitem";
            this.CHITEM.HeaderText = "DESCRIPCION";
            this.CHITEM.Name = "CHITEM";
            this.CHITEM.ReadOnly = true;
            // 
            // CHOBS
            // 
            this.CHOBS.DataPropertyName = "libre";
            this.CHOBS.HeaderText = "ACRONIMO";
            this.CHOBS.Name = "CHOBS";
            this.CHOBS.ReadOnly = true;
            this.CHOBS.Width = 200;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGrabar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(95, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 48);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(95, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(6, 14);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 28);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmManVariosAnadir
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(371, 423);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvListaDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManVariosAnadir";
            this.Text = "VARIOS AÑADIR";
            this.Load += new System.EventHandler(this.frmManVariosAnadir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtObbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMAESTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}