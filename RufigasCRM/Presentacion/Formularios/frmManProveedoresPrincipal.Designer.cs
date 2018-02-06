namespace Presentacion
{ 
    partial class frmManProveedoresPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.IDPROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHRAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDIRECION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHRUBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(113, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(417, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(111, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(11, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Añadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROV,
            this.CHRAZON,
            this.TIPODOCU,
            this.NRODOCU,
            this.CHDIRECION,
            this.CHRUBRO,
            this.CHTELEFONO});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(759, 384);
            this.dgvProveedores.TabIndex = 2;
            // 
            // IDPROV
            // 
            this.IDPROV.DataPropertyName = "p_inidcodigoclie";
            this.IDPROV.HeaderText = "CODIGO";
            this.IDPROV.Name = "IDPROV";
            // 
            // CHRAZON
            // 
            this.CHRAZON.DataPropertyName = "razon";
            this.CHRAZON.HeaderText = "NOMBRES";
            this.CHRAZON.Name = "CHRAZON";
            // 
            // TIPODOCU
            // 
            this.TIPODOCU.DataPropertyName = "tipodocu";
            this.TIPODOCU.HeaderText = "DOCUMENTO";
            this.TIPODOCU.Name = "TIPODOCU";
            // 
            // NRODOCU
            // 
            this.NRODOCU.DataPropertyName = "nrodocumento";
            this.NRODOCU.HeaderText = "NUMERO DOCUMENTO";
            this.NRODOCU.Name = "NRODOCU";
            // 
            // CHDIRECION
            // 
            this.CHDIRECION.DataPropertyName = "chdireccion";
            this.CHDIRECION.HeaderText = "DIRECIÓN";
            this.CHDIRECION.Name = "CHDIRECION";
            // 
            // CHRUBRO
            // 
            this.CHRUBRO.DataPropertyName = "tipoclie";
            this.CHRUBRO.HeaderText = "RUBRO";
            this.CHRUBRO.Name = "CHRUBRO";
            // 
            // CHTELEFONO
            // 
            this.CHTELEFONO.DataPropertyName = "telefono";
            this.CHTELEFONO.HeaderText = "TELÉFONO";
            this.CHTELEFONO.Name = "CHTELEFONO";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "&Ver";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmManProveedoresPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(783, 467);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManProveedoresPrincipal";
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.frmManProveedoresPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHRAZON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDIRECION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHRUBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTELEFONO;
        private System.Windows.Forms.Button button5;
    }
}