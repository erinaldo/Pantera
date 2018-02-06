namespace Presentacion
{
    partial class frmPerfil
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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
            this.IDPERFIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOPERFIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(150, 385);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.cmdAnadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(249, 385);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(349, 385);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(443, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPERFIL,
            this.DESCRIPCION,
            this.COMENTARIO,
            this.ESTADOPERFIL});
            this.dgvPerfil.Location = new System.Drawing.Point(12, 12);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.ReadOnly = true;
            this.dgvPerfil.Size = new System.Drawing.Size(696, 356);
            this.dgvPerfil.TabIndex = 6;
            // 
            // IDPERFIL
            // 
            this.IDPERFIL.DataPropertyName = "idperfil";
            this.IDPERFIL.HeaderText = "IDPERFIL";
            this.IDPERFIL.Name = "IDPERFIL";
            this.IDPERFIL.ReadOnly = true;
            this.IDPERFIL.Visible = false;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 250;
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.DataPropertyName = "comentarioperfil";
            this.COMENTARIO.HeaderText = "COMENTARIO";
            this.COMENTARIO.Name = "COMENTARIO";
            this.COMENTARIO.ReadOnly = true;
            this.COMENTARIO.Width = 400;
            // 
            // ESTADOPERFIL
            // 
            this.ESTADOPERFIL.DataPropertyName = "estadoperfil";
            this.ESTADOPERFIL.HeaderText = "ESTADOPERFIL";
            this.ESTADOPERFIL.Name = "ESTADOPERFIL";
            this.ESTADOPERFIL.ReadOnly = true;
            this.ESTADOPERFIL.Visible = false;
            // 
            // frmPerfil
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.Controls.Add(this.dgvPerfil);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAnadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPerfil";
            this.Text = "MANTENIMIENTO DE PERFILES DE USUARIO";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERFIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOPERFIL;
    }
}