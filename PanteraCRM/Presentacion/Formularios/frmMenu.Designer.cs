namespace Presentacion
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.treMenu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LCabecera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treMenu
            // 
            this.treMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treMenu.ImageIndex = 0;
            this.treMenu.ImageList = this.imageList1;
            this.treMenu.ItemHeight = 22;
            this.treMenu.Location = new System.Drawing.Point(5, 83);
            this.treMenu.Name = "treMenu";
            this.treMenu.SelectedImageIndex = 0;
            this.treMenu.ShowLines = false;
            this.treMenu.Size = new System.Drawing.Size(271, 396);
            this.treMenu.TabIndex = 0;
            this.treMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treMenu_KeyDown);
            this.treMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treMenu_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(5, 57);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(271, 20);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opciones de Sistema";
            // 
            // LCabecera
            // 
            this.LCabecera.AutoSize = true;
            this.LCabecera.Location = new System.Drawing.Point(2, 41);
            this.LCabecera.Name = "LCabecera";
            this.LCabecera.Size = new System.Drawing.Size(0, 13);
            this.LCabecera.TabIndex = 3;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 491);
            this.Controls.Add(this.LCabecera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.treMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Menú del Sistema";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.TreeView treMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LCabecera;
    }
}