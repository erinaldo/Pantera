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
            this.rbtOrdCorrelativo = new System.Windows.Forms.RadioButton();
            this.rbtOrdVendedor = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnExcel = new System.Windows.Forms.RadioButton();
            this.rbtnImpresora = new System.Windows.Forms.RadioButton();
            this.rbtnPantalla = new System.Windows.Forms.RadioButton();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
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
            this.txtClieCod.TextChanged += new System.EventHandler(this.txtClieCod_TextChanged);
            this.txtClieCod.Enter += new System.EventHandler(this.txtClieCod_Enter);
            this.txtClieCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClieCod_KeyPress);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnExcel);
            this.groupBox3.Controls.Add(this.rbtnImpresora);
            this.groupBox3.Controls.Add(this.rbtnPantalla);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(274, 19);
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
            this.rbtnImpresora.Location = new System.Drawing.Point(136, 19);
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
            this.rbtnPantalla.Location = new System.Drawing.Point(6, 19);
            this.rbtnPantalla.Name = "rbtnPantalla";
            this.rbtnPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbtnPantalla.TabIndex = 3;
            this.rbtnPantalla.TabStop = true;
            this.rbtnPantalla.Text = "Pantalla";
            this.rbtnPantalla.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(89, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 48);
            this.groupBox4.TabIndex = 12;
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
            // frmRepoCuentasCobrarPrincipal
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(358, 360);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepoCuentasCobrarPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.RadioButton rbtVendedor;
        private System.Windows.Forms.RadioButton rbtGeneral;
        private System.Windows.Forms.RadioButton rbtOrdCorrelativo;
        private System.Windows.Forms.RadioButton rbtOrdVendedor;
        private System.Windows.Forms.RadioButton rbtnExcel;
        private System.Windows.Forms.RadioButton rbtnImpresora;
        private System.Windows.Forms.RadioButton rbtnPantalla;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
    }
}