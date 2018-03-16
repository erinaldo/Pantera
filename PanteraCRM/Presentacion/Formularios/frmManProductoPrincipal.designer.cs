namespace Presentacion
{
    partial class frmManProductoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManProductoPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgProducto = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCHECK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCALIBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHCODPRODANTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCALIBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSUARIOINSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUSUARIOINSERT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSUARIODELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUSUARIODELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUPRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSITUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(349, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(178, 14);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(93, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ImageList = this.imageList1;
            this.btnAnadir.Location = new System.Drawing.Point(6, 14);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-1.png");
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
            this.groupBox1.Location = new System.Drawing.Point(165, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dvgProducto
            // 
            this.dvgProducto.AllowUserToAddRows = false;
            this.dvgProducto.AllowUserToDeleteRows = false;
            this.dvgProducto.BackgroundColor = System.Drawing.Color.White;
            this.dvgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.IDCHECK,
            this.CODPRODUCTO,
            this.CHFAMILIA,
            this.CHMARCA,
            this.CHTIPO,
            this.CHCALIBRE,
            this.CHMODELO,
            this.CHFECHA,
            this.ESTADO,
            this.CHMEDIDA,
            this.CHCODPRODANTES,
            this.IDFAMILIA,
            this.CHDESCRIPCION,
            this.IDMODELO,
            this.IDCALIBRE,
            this.IDMEDIDA,
            this.IDTIPO,
            this.IDUSUARIOINSER,
            this.CHUSUARIOINSERT,
            this.IDUSUARIODELETE,
            this.CHUSUARIODELETE,
            this.IDMARCA,
            this.NUPRECIO,
            this.IDSITUACION,
            this.CHSITUACION});
            this.dvgProducto.Location = new System.Drawing.Point(12, 60);
            this.dvgProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProducto.Name = "dvgProducto";
            this.dvgProducto.ReadOnly = true;
            this.dvgProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProducto.Size = new System.Drawing.Size(742, 392);
            this.dvgProducto.TabIndex = 1;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.DataPropertyName = "p_inidproducto";
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            // 
            // IDCHECK
            // 
            this.IDCHECK.DataPropertyName = "req_serie";
            this.IDCHECK.HeaderText = "IDCHECK";
            this.IDCHECK.Name = "IDCHECK";
            this.IDCHECK.ReadOnly = true;
            this.IDCHECK.Visible = false;
            // 
            // CODPRODUCTO
            // 
            this.CODPRODUCTO.DataPropertyName = "chcodigoproducto";
            this.CODPRODUCTO.HeaderText = "CODIGO";
            this.CODPRODUCTO.Name = "CODPRODUCTO";
            this.CODPRODUCTO.ReadOnly = true;
            this.CODPRODUCTO.Width = 60;
            // 
            // CHFAMILIA
            // 
            this.CHFAMILIA.DataPropertyName = "chfamiliaproducto";
            this.CHFAMILIA.HeaderText = "CATEGORIA";
            this.CHFAMILIA.Name = "CHFAMILIA";
            this.CHFAMILIA.ReadOnly = true;
            this.CHFAMILIA.Width = 90;
            // 
            // CHMARCA
            // 
            this.CHMARCA.DataPropertyName = "chmarca";
            this.CHMARCA.HeaderText = "MARCA";
            this.CHMARCA.Name = "CHMARCA";
            this.CHMARCA.ReadOnly = true;
            this.CHMARCA.Width = 110;
            // 
            // CHTIPO
            // 
            this.CHTIPO.DataPropertyName = "chtipoproducto";
            this.CHTIPO.HeaderText = "TIPO";
            this.CHTIPO.Name = "CHTIPO";
            this.CHTIPO.ReadOnly = true;
            this.CHTIPO.Width = 110;
            // 
            // CHCALIBRE
            // 
            this.CHCALIBRE.DataPropertyName = "chcalibre";
            this.CHCALIBRE.HeaderText = "CALIBRE";
            this.CHCALIBRE.Name = "CHCALIBRE";
            this.CHCALIBRE.ReadOnly = true;
            this.CHCALIBRE.Width = 110;
            // 
            // CHMODELO
            // 
            this.CHMODELO.DataPropertyName = "chdmodelo";
            this.CHMODELO.HeaderText = "MODELO";
            this.CHMODELO.Name = "CHMODELO";
            this.CHMODELO.ReadOnly = true;
            this.CHMODELO.Width = 150;
            // 
            // CHFECHA
            // 
            this.CHFECHA.DataPropertyName = "chfechacreacion";
            this.CHFECHA.HeaderText = "FECHA";
            this.CHFECHA.Name = "CHFECHA";
            this.CHFECHA.ReadOnly = true;
            this.CHFECHA.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // CHMEDIDA
            // 
            this.CHMEDIDA.DataPropertyName = "chunidadmedidaproducto";
            this.CHMEDIDA.HeaderText = "MEDIDA";
            this.CHMEDIDA.Name = "CHMEDIDA";
            this.CHMEDIDA.ReadOnly = true;
            // 
            // CHCODPRODANTES
            // 
            this.CHCODPRODANTES.DataPropertyName = "chcodigoproductoantes";
            this.CHCODPRODANTES.HeaderText = "CODIGO ANTERIOR";
            this.CHCODPRODANTES.Name = "CHCODPRODANTES";
            this.CHCODPRODANTES.ReadOnly = true;
            this.CHCODPRODANTES.Visible = false;
            // 
            // IDFAMILIA
            // 
            this.IDFAMILIA.DataPropertyName = "p_inidfamiliaproducto";
            this.IDFAMILIA.HeaderText = "IDFAMILIA";
            this.IDFAMILIA.Name = "IDFAMILIA";
            this.IDFAMILIA.ReadOnly = true;
            this.IDFAMILIA.Visible = false;
            // 
            // CHDESCRIPCION
            // 
            this.CHDESCRIPCION.DataPropertyName = "chdescripcionproducto";
            this.CHDESCRIPCION.HeaderText = "DESCRIPCION";
            this.CHDESCRIPCION.Name = "CHDESCRIPCION";
            this.CHDESCRIPCION.ReadOnly = true;
            this.CHDESCRIPCION.Visible = false;
            // 
            // IDMODELO
            // 
            this.IDMODELO.DataPropertyName = "p_inidmodelo";
            this.IDMODELO.HeaderText = "IDMODELO";
            this.IDMODELO.Name = "IDMODELO";
            this.IDMODELO.ReadOnly = true;
            this.IDMODELO.Visible = false;
            // 
            // IDCALIBRE
            // 
            this.IDCALIBRE.DataPropertyName = "p_inidcalibre";
            this.IDCALIBRE.HeaderText = "IDCALIBRE";
            this.IDCALIBRE.Name = "IDCALIBRE";
            this.IDCALIBRE.ReadOnly = true;
            this.IDCALIBRE.Visible = false;
            // 
            // IDMEDIDA
            // 
            this.IDMEDIDA.DataPropertyName = "p_inidunidadmedidaproducto";
            this.IDMEDIDA.HeaderText = "IDMEDIDA";
            this.IDMEDIDA.Name = "IDMEDIDA";
            this.IDMEDIDA.ReadOnly = true;
            this.IDMEDIDA.Visible = false;
            // 
            // IDTIPO
            // 
            this.IDTIPO.DataPropertyName = "p_inidtipoproducto";
            this.IDTIPO.HeaderText = "IDTIPO";
            this.IDTIPO.Name = "IDTIPO";
            this.IDTIPO.ReadOnly = true;
            this.IDTIPO.Visible = false;
            // 
            // IDUSUARIOINSER
            // 
            this.IDUSUARIOINSER.DataPropertyName = "p_inidusuarioinsert";
            this.IDUSUARIOINSER.HeaderText = "IDUSUARIOINTER";
            this.IDUSUARIOINSER.Name = "IDUSUARIOINSER";
            this.IDUSUARIOINSER.ReadOnly = true;
            this.IDUSUARIOINSER.Visible = false;
            // 
            // CHUSUARIOINSERT
            // 
            this.CHUSUARIOINSERT.DataPropertyName = "chusuarioinsert";
            this.CHUSUARIOINSERT.HeaderText = "CHUSUARIOINSERT";
            this.CHUSUARIOINSERT.Name = "CHUSUARIOINSERT";
            this.CHUSUARIOINSERT.ReadOnly = true;
            this.CHUSUARIOINSERT.Visible = false;
            // 
            // IDUSUARIODELETE
            // 
            this.IDUSUARIODELETE.DataPropertyName = "p_inidusuariodelete";
            this.IDUSUARIODELETE.HeaderText = "IDUSUARIODELETE";
            this.IDUSUARIODELETE.Name = "IDUSUARIODELETE";
            this.IDUSUARIODELETE.ReadOnly = true;
            this.IDUSUARIODELETE.Visible = false;
            // 
            // CHUSUARIODELETE
            // 
            this.CHUSUARIODELETE.DataPropertyName = "chusuariodelete";
            this.CHUSUARIODELETE.HeaderText = "CHUSUARIODELETE";
            this.CHUSUARIODELETE.Name = "CHUSUARIODELETE";
            this.CHUSUARIODELETE.ReadOnly = true;
            this.CHUSUARIODELETE.Visible = false;
            // 
            // IDMARCA
            // 
            this.IDMARCA.DataPropertyName = "p_inidmarca";
            this.IDMARCA.HeaderText = "IDMARCA";
            this.IDMARCA.Name = "IDMARCA";
            this.IDMARCA.ReadOnly = true;
            this.IDMARCA.Visible = false;
            // 
            // NUPRECIO
            // 
            this.NUPRECIO.DataPropertyName = "nuprecio";
            this.NUPRECIO.HeaderText = "PRECIO";
            this.NUPRECIO.Name = "NUPRECIO";
            this.NUPRECIO.ReadOnly = true;
            this.NUPRECIO.Visible = false;
            // 
            // IDSITUACION
            // 
            this.IDSITUACION.DataPropertyName = "p_inidsituacion";
            this.IDSITUACION.HeaderText = "IDSIATUACION";
            this.IDSITUACION.Name = "IDSITUACION";
            this.IDSITUACION.ReadOnly = true;
            this.IDSITUACION.Visible = false;
            // 
            // CHSITUACION
            // 
            this.CHSITUACION.DataPropertyName = "chsituacion";
            this.CHSITUACION.HeaderText = "SITUACION";
            this.CHSITUACION.Name = "CHSITUACION";
            this.CHSITUACION.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda";
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Location = new System.Drawing.Point(70, 17);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(666, 20);
            this.txtParametro.TabIndex = 0;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // frmManProductoPrincipal
            // 
            this.AcceptButton = this.btnAnadir;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(785, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvgProducto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManProductoPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "MANTENIMIENTO DE PRODUCTOS";
            this.Load += new System.EventHandler(this.frmManProductoPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dvgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCALIBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHCODPRODANTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCALIBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIOINSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUSUARIOINSERT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIODELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUSUARIODELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUPRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSITUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSITUACION;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro;
    }
}