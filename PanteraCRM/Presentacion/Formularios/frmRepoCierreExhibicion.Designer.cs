namespace Presentacion
{
    partial class frmRepoCierreExhibicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepoCierreExhibicion));
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtExcel = new System.Windows.Forms.RadioButton();
            this.rbtImpresora = new System.Windows.Forms.RadioButton();
            this.rbtPatalla = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(12, 194);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblrespuesta.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(91, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 48);
            this.groupBox4.TabIndex = 15;
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
            this.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(6, 14);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(80, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbtExcel);
            this.groupBox2.Controls.Add(this.rbtImpresora);
            this.groupBox2.Controls.Add(this.rbtPatalla);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // rbtExcel
            // 
            this.rbtExcel.AutoSize = true;
            this.rbtExcel.Location = new System.Drawing.Point(247, 23);
            this.rbtExcel.Name = "rbtExcel";
            this.rbtExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtExcel.TabIndex = 5;
            this.rbtExcel.TabStop = true;
            this.rbtExcel.Text = "Excel";
            this.rbtExcel.UseVisualStyleBackColor = true;
            // 
            // rbtImpresora
            // 
            this.rbtImpresora.AutoSize = true;
            this.rbtImpresora.Location = new System.Drawing.Point(128, 23);
            this.rbtImpresora.Name = "rbtImpresora";
            this.rbtImpresora.Size = new System.Drawing.Size(71, 17);
            this.rbtImpresora.TabIndex = 4;
            this.rbtImpresora.TabStop = true;
            this.rbtImpresora.Text = "Impresora";
            this.rbtImpresora.UseVisualStyleBackColor = true;
            // 
            // rbtPatalla
            // 
            this.rbtPatalla.AutoSize = true;
            this.rbtPatalla.Location = new System.Drawing.Point(17, 23);
            this.rbtPatalla.Name = "rbtPatalla";
            this.rbtPatalla.Size = new System.Drawing.Size(63, 17);
            this.rbtPatalla.TabIndex = 3;
            this.rbtPatalla.TabStop = true;
            this.rbtPatalla.Text = "Pantalla";
            this.rbtPatalla.UseVisualStyleBackColor = true;
            // 
            // frmRepoCierreExhibicion
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(362, 146);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepoCierreExhibicion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRepoCierreExhibicion";
            this.Load += new System.EventHandler(this.frmRepoCierreExhibicion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtExcel;
        private System.Windows.Forms.RadioButton rbtImpresora;
        private System.Windows.Forms.RadioButton rbtPatalla;
    }
}