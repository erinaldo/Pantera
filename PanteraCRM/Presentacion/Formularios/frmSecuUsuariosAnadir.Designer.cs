namespace Presentacion
{
    partial class frmSecuUsuariosAnadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecuUsuariosAnadir));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListaModulos = new System.Windows.Forms.DataGridView();
            this.IDPRIVILEGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMODULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHVALOR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // dgvListaModulos
            // 
            this.dgvListaModulos.AllowUserToAddRows = false;
            this.dgvListaModulos.AllowUserToDeleteRows = false;
            this.dgvListaModulos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRIVILEGIO,
            this.CHVAL,
            this.CHMODULO,
            this.CHVALOR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaModulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaModulos.Location = new System.Drawing.Point(12, 266);
            this.dgvListaModulos.Name = "dgvListaModulos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaModulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaModulos.RowHeadersVisible = false;
            this.dgvListaModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaModulos.Size = new System.Drawing.Size(575, 150);
            this.dgvListaModulos.TabIndex = 1;
            // 
            // IDPRIVILEGIO
            // 
            this.IDPRIVILEGIO.DataPropertyName = "p_inidmenu";
            this.IDPRIVILEGIO.HeaderText = "IDPRIVILEGIO";
            this.IDPRIVILEGIO.Name = "IDPRIVILEGIO";
            this.IDPRIVILEGIO.Visible = false;
            // 
            // CHVAL
            // 
            this.CHVAL.DataPropertyName = "chcodigomenu";
            this.CHVAL.HeaderText = "VAL";
            this.CHVAL.Name = "CHVAL";
            this.CHVAL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHVAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHVAL.Visible = false;
            // 
            // CHMODULO
            // 
            this.CHMODULO.DataPropertyName = "chdescripcionmenu";
            this.CHMODULO.HeaderText = "MODULO";
            this.CHMODULO.Name = "CHMODULO";
            this.CHMODULO.ReadOnly = true;
            this.CHMODULO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CHMODULO.Width = 450;
            // 
            // CHVALOR
            // 
            this.CHVALOR.DataPropertyName = "estado";
            this.CHVALOR.HeaderText = "PERMITIDO";
            this.CHVALOR.Name = "CHVALOR";
            this.CHVALOR.Width = 120;
            // 
            // frmSecuUsuariosAnadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 454);
            this.Controls.Add(this.dgvListaModulos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecuUsuariosAnadir";
            this.ShowInTaskbar = false;
            this.Text = "USUARIO AÑADIR";
            this.Load += new System.EventHandler(this.frmSecuUsuariosAnadir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaModulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListaModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRIVILEGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMODULO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHVALOR;
    }
}