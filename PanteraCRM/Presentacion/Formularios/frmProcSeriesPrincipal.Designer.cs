namespace Presentacion
{
    partial class frmProcSeriesPrincipal
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
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.IDSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSeries
            // 
            this.dgvSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSeries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSERIE,
            this.CHPRODUCTO,
            this.CHSERIE,
            this.CHOBS});
            this.dgvSeries.Location = new System.Drawing.Point(12, 32);
            this.dgvSeries.Name = "dgvSeries";
            this.dgvSeries.ReadOnly = true;
            this.dgvSeries.Size = new System.Drawing.Size(646, 286);
            this.dgvSeries.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(60, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(526, 63);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(10, 21);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(88, 30);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(112, 21);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 30);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(212, 21);
            this.btnVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 30);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(424, 21);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Busqueda de Serie";
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(115, 6);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(145, 20);
            this.textBusqueda.TabIndex = 17;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // IDSERIE
            // 
            this.IDSERIE.DataPropertyName = "p_inidserie";
            this.IDSERIE.HeaderText = "IDSERIE";
            this.IDSERIE.Name = "IDSERIE";
            this.IDSERIE.ReadOnly = true;
            this.IDSERIE.Visible = false;
            // 
            // CHPRODUCTO
            // 
            this.CHPRODUCTO.DataPropertyName = "chnombreproductocompuesto";
            this.CHPRODUCTO.HeaderText = "PRODUCTO";
            this.CHPRODUCTO.Name = "CHPRODUCTO";
            this.CHPRODUCTO.ReadOnly = true;
            this.CHPRODUCTO.Width = 93;
            // 
            // CHSERIE
            // 
            this.CHSERIE.DataPropertyName = "chserie";
            this.CHSERIE.HeaderText = "SERIE";
            this.CHSERIE.Name = "CHSERIE";
            this.CHSERIE.ReadOnly = true;
            this.CHSERIE.Width = 64;
            // 
            // CHOBS
            // 
            this.CHOBS.DataPropertyName = "chobservacion";
            this.CHOBS.HeaderText = "OBSERVACION";
            this.CHOBS.Name = "CHOBS";
            this.CHOBS.ReadOnly = true;
            this.CHOBS.Width = 109;
            // 
            // frmProcSeriesPrincipal
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(670, 401);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSeries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProcSeriesPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO DE PRODUCTOS Y SERIES";
            this.Load += new System.EventHandler(this.frmProcSeriesPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOBS;
    }
}