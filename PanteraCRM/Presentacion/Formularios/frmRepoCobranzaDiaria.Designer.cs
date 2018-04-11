namespace Presentacion
{
    partial class frmRepoCobranzaDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepoCobranzaDiaria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfechaf = new System.Windows.Forms.DateTimePicker();
            this.txtfechai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rbtnExcel = new System.Windows.Forms.RadioButton();
            this.rbtnImpresora = new System.Windows.Forms.RadioButton();
            this.rbtnPantalla = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CHUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOVALIDAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfechaf);
            this.groupBox1.Controls.Add(this.txtfechai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // txtfechaf
            // 
            this.txtfechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechaf.Location = new System.Drawing.Point(70, 48);
            this.txtfechaf.Name = "txtfechaf";
            this.txtfechaf.Size = new System.Drawing.Size(97, 20);
            this.txtfechaf.TabIndex = 7;
            // 
            // txtfechai
            // 
            this.txtfechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechai.Location = new System.Drawing.Point(71, 21);
            this.txtfechai.Name = "txtfechai";
            this.txtfechai.Size = new System.Drawing.Size(96, 20);
            this.txtfechai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.rbtnExcel);
            this.groupBox2.Controls.Add(this.rbtnImpresora);
            this.groupBox2.Controls.Add(this.rbtnPantalla);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(105, 75);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(105, 34);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(80, 28);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(16, 93);
            this.rbtnExcel.Name = "rbtnExcel";
            this.rbtnExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtnExcel.TabIndex = 5;
            this.rbtnExcel.TabStop = true;
            this.rbtnExcel.Text = "Excel";
            this.rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // rbtnImpresora
            // 
            this.rbtnImpresora.AutoSize = true;
            this.rbtnImpresora.Location = new System.Drawing.Point(16, 62);
            this.rbtnImpresora.Name = "rbtnImpresora";
            this.rbtnImpresora.Size = new System.Drawing.Size(71, 17);
            this.rbtnImpresora.TabIndex = 4;
            this.rbtnImpresora.TabStop = true;
            this.rbtnImpresora.Text = "Impresora";
            this.rbtnImpresora.UseVisualStyleBackColor = true;
            // 
            // rbtnPantalla
            // 
            this.rbtnPantalla.AutoSize = true;
            this.rbtnPantalla.Location = new System.Drawing.Point(16, 31);
            this.rbtnPantalla.Name = "rbtnPantalla";
            this.rbtnPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbtnPantalla.TabIndex = 3;
            this.rbtnPantalla.TabStop = true;
            this.rbtnPantalla.Text = "Pantalla";
            this.rbtnPantalla.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(218, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHUSUARIO,
            this.BOVALIDAR});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(311, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // CHUSUARIO
            // 
            this.CHUSUARIO.HeaderText = "NOMBRE";
            this.CHUSUARIO.Name = "CHUSUARIO";
            this.CHUSUARIO.ReadOnly = true;
            this.CHUSUARIO.Width = 250;
            // 
            // BOVALIDAR
            // 
            this.BOVALIDAR.HeaderText = "";
            this.BOVALIDAR.Name = "BOVALIDAR";
            this.BOVALIDAR.ReadOnly = true;
            this.BOVALIDAR.Width = 50;
            // 
            // frmRepoCobranzaDiaria
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(553, 228);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepoCobranzaDiaria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRepoCobranzaDiaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txtfechaf;
        private System.Windows.Forms.DateTimePicker txtfechai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RadioButton rbtnExcel;
        private System.Windows.Forms.RadioButton rbtnImpresora;
        private System.Windows.Forms.RadioButton rbtnPantalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUSUARIO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BOVALIDAR;
    }
}