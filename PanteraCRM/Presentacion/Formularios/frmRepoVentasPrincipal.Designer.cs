namespace Presentacion
{
    partial class frmRepoVentasPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepoVentasPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfechaf = new System.Windows.Forms.DateTimePicker();
            this.txtfechai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnExcel = new System.Windows.Forms.RadioButton();
            this.rbtnImpresora = new System.Windows.Forms.RadioButton();
            this.rbtnPantalla = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.cbkTodo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfechaf);
            this.groupBox1.Controls.Add(this.txtfechai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // txtfechaf
            // 
            this.txtfechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechaf.Location = new System.Drawing.Point(194, 21);
            this.txtfechaf.Name = "txtfechaf";
            this.txtfechaf.Size = new System.Drawing.Size(96, 20);
            this.txtfechaf.TabIndex = 3;
            // 
            // txtfechai
            // 
            this.txtfechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechai.Location = new System.Drawing.Point(57, 21);
            this.txtfechai.Name = "txtfechai";
            this.txtfechai.Size = new System.Drawing.Size(96, 20);
            this.txtfechai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "al";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbkTodo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboDocumento);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Doc.";
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(88, 44);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(203, 21);
            this.cboDocumento.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnExcel);
            this.groupBox3.Controls.Add(this.rbtnImpresora);
            this.groupBox3.Controls.Add(this.rbtnPantalla);
            this.groupBox3.Location = new System.Drawing.Point(12, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(230, 23);
            this.rbtnExcel.Name = "rbtnExcel";
            this.rbtnExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtnExcel.TabIndex = 2;
            this.rbtnExcel.TabStop = true;
            this.rbtnExcel.Text = "Excel";
            this.rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // rbtnImpresora
            // 
            this.rbtnImpresora.AutoSize = true;
            this.rbtnImpresora.Location = new System.Drawing.Point(118, 23);
            this.rbtnImpresora.Name = "rbtnImpresora";
            this.rbtnImpresora.Size = new System.Drawing.Size(71, 17);
            this.rbtnImpresora.TabIndex = 1;
            this.rbtnImpresora.TabStop = true;
            this.rbtnImpresora.Text = "Impresora";
            this.rbtnImpresora.UseVisualStyleBackColor = true;
            // 
            // rbtnPantalla
            // 
            this.rbtnPantalla.AutoSize = true;
            this.rbtnPantalla.Location = new System.Drawing.Point(14, 23);
            this.rbtnPantalla.Name = "rbtnPantalla";
            this.rbtnPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbtnPantalla.TabIndex = 0;
            this.rbtnPantalla.TabStop = true;
            this.rbtnPantalla.Text = "Pantalla";
            this.rbtnPantalla.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(71, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 48);
            this.groupBox4.TabIndex = 5;
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
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(6, 14);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(80, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(12, 195);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblrespuesta.TabIndex = 6;
            // 
            // cbkTodo
            // 
            this.cbkTodo.AutoSize = true;
            this.cbkTodo.Location = new System.Drawing.Point(9, 19);
            this.cbkTodo.Name = "cbkTodo";
            this.cbkTodo.Size = new System.Drawing.Size(133, 17);
            this.cbkTodo.TabIndex = 7;
            this.cbkTodo.Text = "Todos los documentos";
            this.cbkTodo.UseVisualStyleBackColor = true;
            this.cbkTodo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmRepoVentasPrincipal
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(322, 276);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepoVentasPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRO DE VENTA DE PRODUCTO";
            this.Load += new System.EventHandler(this.frmRepoVentasPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker txtfechaf;
        private System.Windows.Forms.DateTimePicker txtfechai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.RadioButton rbtnExcel;
        private System.Windows.Forms.RadioButton rbtnImpresora;
        private System.Windows.Forms.RadioButton rbtnPantalla;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.CheckBox cbkTodo;
    }
}