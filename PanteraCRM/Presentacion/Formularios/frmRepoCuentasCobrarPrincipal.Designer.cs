namespace Presentacion
{
    partial class frmRepoCuentasCobrarPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepoCuentasCobrarPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.rbtVendedor = new System.Windows.Forms.RadioButton();
            this.rbtGeneral = new System.Windows.Forms.RadioButton();
            this.lblNroIden = new System.Windows.Forms.Label();
            this.cboVendedores = new System.Windows.Forms.ComboBox();
            this.txtNomClie = new System.Windows.Forms.TextBox();
            this.txtNroDocuIden = new System.Windows.Forms.TextBox();
            this.txtClieCod = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtOrdVendedor = new System.Windows.Forms.RadioButton();
            this.rbtOrdCorrelativo = new System.Windows.Forms.RadioButton();
            this.rbtDesPantalla = new System.Windows.Forms.RadioButton();
            this.rbtDesImpresora = new System.Windows.Forms.RadioButton();
            this.rbtDesExcel = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCliente);
            this.groupBox1.Controls.Add(this.rbtVendedor);
            this.groupBox1.Controls.Add(this.rbtGeneral);
            this.groupBox1.Controls.Add(this.lblNroIden);
            this.groupBox1.Controls.Add(this.cboVendedores);
            this.groupBox1.Controls.Add(this.txtNomClie);
            this.groupBox1.Controls.Add(this.txtNroDocuIden);
            this.groupBox1.Controls.Add(this.txtClieCod);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Location = new System.Drawing.Point(6, 62);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(74, 17);
            this.rbtCliente.TabIndex = 11;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Un Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            this.rbtCliente.CheckedChanged += new System.EventHandler(this.rbtCliente_CheckedChanged);
            // 
            // rbtVendedor
            // 
            this.rbtVendedor.AutoSize = true;
            this.rbtVendedor.Location = new System.Drawing.Point(6, 40);
            this.rbtVendedor.Name = "rbtVendedor";
            this.rbtVendedor.Size = new System.Drawing.Size(88, 17);
            this.rbtVendedor.TabIndex = 10;
            this.rbtVendedor.TabStop = true;
            this.rbtVendedor.Text = "Un Vendedor";
            this.rbtVendedor.UseVisualStyleBackColor = true;
            this.rbtVendedor.CheckedChanged += new System.EventHandler(this.rbtVendedor_CheckedChanged);
            // 
            // rbtGeneral
            // 
            this.rbtGeneral.AutoSize = true;
            this.rbtGeneral.Location = new System.Drawing.Point(6, 19);
            this.rbtGeneral.Name = "rbtGeneral";
            this.rbtGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbtGeneral.TabIndex = 9;
            this.rbtGeneral.TabStop = true;
            this.rbtGeneral.Text = "General";
            this.rbtGeneral.UseVisualStyleBackColor = true;
            this.rbtGeneral.CheckedChanged += new System.EventHandler(this.rbtGeneral_CheckedChanged);
            // 
            // lblNroIden
            // 
            this.lblNroIden.AutoSize = true;
            this.lblNroIden.Location = new System.Drawing.Point(3, 92);
            this.lblNroIden.Name = "lblNroIden";
            this.lblNroIden.Size = new System.Drawing.Size(83, 13);
            this.lblNroIden.TabIndex = 8;
            this.lblNroIden.Text = "Nro. Doc. Ident.";
            // 
            // cboVendedores
            // 
            this.cboVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedores.FormattingEnabled = true;
            this.cboVendedores.Location = new System.Drawing.Point(112, 36);
            this.cboVendedores.Name = "cboVendedores";
            this.cboVendedores.Size = new System.Drawing.Size(216, 21);
            this.cboVendedores.TabIndex = 0;
            // 
            // txtNomClie
            // 
            this.txtNomClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNomClie.ForeColor = System.Drawing.Color.Blue;
            this.txtNomClie.Location = new System.Drawing.Point(6, 115);
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.ReadOnly = true;
            this.txtNomClie.Size = new System.Drawing.Size(319, 20);
            this.txtNomClie.TabIndex = 6;
            this.txtNomClie.TabStop = false;
            // 
            // txtNroDocuIden
            // 
            this.txtNroDocuIden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNroDocuIden.ForeColor = System.Drawing.Color.Blue;
            this.txtNroDocuIden.Location = new System.Drawing.Point(112, 89);
            this.txtNroDocuIden.Name = "txtNroDocuIden";
            this.txtNroDocuIden.ReadOnly = true;
            this.txtNroDocuIden.Size = new System.Drawing.Size(100, 20);
            this.txtNroDocuIden.TabIndex = 5;
            this.txtNroDocuIden.TabStop = false;
            // 
            // txtClieCod
            // 
            this.txtClieCod.Location = new System.Drawing.Point(155, 63);
            this.txtClieCod.Name = "txtClieCod";
            this.txtClieCod.Size = new System.Drawing.Size(173, 20);
            this.txtClieCod.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(109, 66);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtOrdCorrelativo);
            this.groupBox2.Controls.Add(this.rbtOrdVendedor);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtDesExcel);
            this.groupBox3.Controls.Add(this.rbtDesImpresora);
            this.groupBox3.Controls.Add(this.rbtDesPantalla);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGrabar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(89, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 48);
            this.groupBox4.TabIndex = 4;
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
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(67, 164);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(63, 21);
            this.cboMoneda.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Moneda";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(237, 165);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.Value = new System.DateTime(2018, 3, 20, 9, 5, 8, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta el ";
            // 
            // rbtOrdVendedor
            // 
            this.rbtOrdVendedor.AutoSize = true;
            this.rbtOrdVendedor.Location = new System.Drawing.Point(6, 19);
            this.rbtOrdVendedor.Name = "rbtOrdVendedor";
            this.rbtOrdVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbtOrdVendedor.TabIndex = 5;
            this.rbtOrdVendedor.TabStop = true;
            this.rbtOrdVendedor.Text = "Vendedor";
            this.rbtOrdVendedor.UseVisualStyleBackColor = true;
            // 
            // rbtOrdCorrelativo
            // 
            this.rbtOrdCorrelativo.AutoSize = true;
            this.rbtOrdCorrelativo.Location = new System.Drawing.Point(173, 19);
            this.rbtOrdCorrelativo.Name = "rbtOrdCorrelativo";
            this.rbtOrdCorrelativo.Size = new System.Drawing.Size(90, 17);
            this.rbtOrdCorrelativo.TabIndex = 6;
            this.rbtOrdCorrelativo.TabStop = true;
            this.rbtOrdCorrelativo.Text = "N° Correlativo";
            this.rbtOrdCorrelativo.UseVisualStyleBackColor = true;
            // 
            // rbtDesPantalla
            // 
            this.rbtDesPantalla.AutoSize = true;
            this.rbtDesPantalla.Location = new System.Drawing.Point(6, 19);
            this.rbtDesPantalla.Name = "rbtDesPantalla";
            this.rbtDesPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbtDesPantalla.TabIndex = 3;
            this.rbtDesPantalla.TabStop = true;
            this.rbtDesPantalla.Text = "Pantalla";
            this.rbtDesPantalla.UseVisualStyleBackColor = true;
            // 
            // rbtDesImpresora
            // 
            this.rbtDesImpresora.AutoSize = true;
            this.rbtDesImpresora.Location = new System.Drawing.Point(136, 19);
            this.rbtDesImpresora.Name = "rbtDesImpresora";
            this.rbtDesImpresora.Size = new System.Drawing.Size(71, 17);
            this.rbtDesImpresora.TabIndex = 4;
            this.rbtDesImpresora.TabStop = true;
            this.rbtDesImpresora.Text = "Impresora";
            this.rbtDesImpresora.UseVisualStyleBackColor = true;
            // 
            // rbtDesExcel
            // 
            this.rbtDesExcel.AutoSize = true;
            this.rbtDesExcel.Location = new System.Drawing.Point(274, 19);
            this.rbtDesExcel.Name = "rbtDesExcel";
            this.rbtDesExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtDesExcel.TabIndex = 5;
            this.rbtDesExcel.TabStop = true;
            this.rbtDesExcel.Text = "Excel";
            this.rbtDesExcel.UseVisualStyleBackColor = true;
            // 
            // frmRepoCuentasCobrarPrincipal
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(358, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepoCuentasCobrarPrincipal";
            this.Text = "CUENTAS POR COBRAR";
            this.Load += new System.EventHandler(this.frmRepoCuentasCobrarPrincipal_Load);
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
        private System.Windows.Forms.Label lblNroIden;
        private System.Windows.Forms.ComboBox cboVendedores;
        private System.Windows.Forms.TextBox txtNomClie;
        private System.Windows.Forms.TextBox txtNroDocuIden;
        private System.Windows.Forms.TextBox txtClieCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.RadioButton rbtVendedor;
        private System.Windows.Forms.RadioButton rbtGeneral;
        private System.Windows.Forms.RadioButton rbtOrdCorrelativo;
        private System.Windows.Forms.RadioButton rbtOrdVendedor;
        private System.Windows.Forms.RadioButton rbtDesExcel;
        private System.Windows.Forms.RadioButton rbtDesImpresora;
        private System.Windows.Forms.RadioButton rbtDesPantalla;
    }
}