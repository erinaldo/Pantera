namespace Presentacion
{
    partial class frmUbigeoBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCursor = new System.Windows.Forms.DataGridView();
            this.COD_UBIGEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_DISTRITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 22);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(278, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Validated += new System.EventHandler(this.txtDescripcion_Validated);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(241, 316);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(322, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvCursor
            // 
            this.dgvCursor.AllowUserToAddRows = false;
            this.dgvCursor.AllowUserToDeleteRows = false;
            this.dgvCursor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_UBIGEO,
            this.DEPARTAMENTO,
            this.PROVINCIA,
            this.DESC_DISTRITO});
            this.dgvCursor.Location = new System.Drawing.Point(12, 59);
            this.dgvCursor.Name = "dgvCursor";
            this.dgvCursor.Size = new System.Drawing.Size(647, 240);
            this.dgvCursor.TabIndex = 11;
            // 
            // COD_UBIGEO
            // 
            this.COD_UBIGEO.DataPropertyName = "cod_ubigeo";
            this.COD_UBIGEO.HeaderText = "UBIGEO";
            this.COD_UBIGEO.Name = "COD_UBIGEO";
            this.COD_UBIGEO.Visible = false;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.DataPropertyName = "desc_departamento";
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.ReadOnly = true;
            this.DEPARTAMENTO.Width = 200;
            // 
            // PROVINCIA
            // 
            this.PROVINCIA.DataPropertyName = "desc_provincia";
            this.PROVINCIA.HeaderText = "PROVINCA";
            this.PROVINCIA.Name = "PROVINCIA";
            this.PROVINCIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PROVINCIA.Width = 200;
            // 
            // DESC_DISTRITO
            // 
            this.DESC_DISTRITO.DataPropertyName = "desc_distrito";
            this.DESC_DISTRITO.HeaderText = "DISTRITO";
            this.DESC_DISTRITO.Name = "DESC_DISTRITO";
            this.DESC_DISTRITO.ReadOnly = true;
            this.DESC_DISTRITO.Width = 200;
            // 
            // frmUbigeoBuscar
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(671, 351);
            this.Controls.Add(this.dgvCursor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUbigeoBuscar";
            this.ShowInTaskbar = false;
            this.Text = "CONSULTA DE UBIGEO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCursor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_UBIGEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_DISTRITO;
    }
}