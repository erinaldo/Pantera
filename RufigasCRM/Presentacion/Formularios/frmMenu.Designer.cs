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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treMenu
            // 
            this.treMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treMenu.ImageIndex = 0;
            this.treMenu.ImageList = this.imageList;
            this.treMenu.ItemHeight = 22;
            this.treMenu.Location = new System.Drawing.Point(-1, 38);
            this.treMenu.Name = "treMenu";
            this.treMenu.SelectedImageIndex = 0;
            this.treMenu.ShowLines = false;
            this.treMenu.Size = new System.Drawing.Size(318, 598);
            this.treMenu.TabIndex = 0;
            this.treMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treMenu_KeyDown);
            this.treMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treMenu_MouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(14, 11);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(284, 20);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 634);
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

        private System.Windows.Forms.TreeView treMenu;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox txtCriterio;
    }
}