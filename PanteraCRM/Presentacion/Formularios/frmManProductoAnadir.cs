using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Globalization;
using Negocios;

namespace Presentacion
{
    public partial class frmManProductoAnadir : Form
    {
        internal producto  tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
         
        public frmManProductoAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
       
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
        }

     

        private void frmManProductoAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            //Seleccion Categoria
            cboCategoria.DataSource = maestrodetalleNE.ListarCategorias();
            cboCategoria.ValueMember = "p_inidcategoria";
            cboCategoria.DisplayMember = "chcategoria";
            cboTipo.Enabled = false;
            //Seleccion tipo
            //cboTipo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(2);
            //cboTipo.ValueMember = "idmaestrodetalle";
            //cboTipo.DisplayMember = "nombreitem";
            ////Seleccion Marca
            cboMarca.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(3);
            cboMarca.ValueMember = "idmaestrodetalle";
            cboMarca.DisplayMember = "nombreitem";
            ////Seleccion Calibre
            cboCalibre.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(4);
            cboCalibre.ValueMember = "idmaestrodetalle";
            cboCalibre.DisplayMember = "nombreitem";
            ////Seleccion Modelo
            cboModelo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(5);
            cboModelo.ValueMember = "idmaestrodetalle";
            cboModelo.DisplayMember = "nombreitem";
            ////Seleccion Unidad Medida
            cboMedida.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(6);
            cboMedida.ValueMember = "idmaestrodetalle";
            cboMedida.DisplayMember = "nombreitem";
            ////Situacion Producto
            cboSituacion.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(7);
            cboSituacion.ValueMember = "idmaestrodetalle";
            cboSituacion.DisplayMember = "nombreitem";

            if (this.vBoton == "A")
            {
                //label8.Text = "Añadir Producto";
                txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                int index = cboCategoria.FindString("NUEVA CATEGORIA");
                cboCategoria.SelectedIndex = index;
                int index1 = cboMarca.FindString("NUEVA MARCA");
                cboMarca.SelectedIndex = index1;
                int index2 = cboCalibre.FindString("NUEVO CALIBRE");
                cboCalibre.SelectedIndex = index2;
                int index3 = cboModelo.FindString("NUEVO MODELO");
                cboModelo.SelectedIndex = index3;
            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR PRODUCTO";
                txtidproducto.Text = tmpProducto.p_inidproducto.ToString();
                txtCodigo.Text = tmpProducto.chcodigoproducto;
                txtNombre.Text = tmpProducto.chdescripcionproducto;
                cboCategoria.SelectedValue = tmpProducto.p_inidfamiliaproducto;
                cboTipo.SelectedValue = tmpProducto.p_inidtipoproducto;
                cboMarca.SelectedValue = tmpProducto.p_inidmarca;
                cboCalibre.SelectedValue = tmpProducto.p_inidcalibre;
                cboModelo.SelectedValue = tmpProducto.p_inidmodelo;
                cboMedida.SelectedValue = tmpProducto.p_inidunidadmedidaproducto;
                cboSituacion.SelectedValue = tmpProducto.p_inidsituacion;
                ckbSerie.Checked = true;
                
                
                
                txtFecha.Text = "01012018";
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PRODUCTO";
                txtCodigo.Text = tmpProducto.chcodigoproducto;
                txtNombre.Text = tmpProducto.chdescripcionproducto;
                cboCategoria.SelectedValue = tmpProducto.p_inidfamiliaproducto;
                cboTipo.SelectedValue = tmpProducto.p_inidtipoproducto;
                cboMarca.SelectedValue = tmpProducto.p_inidmarca;
                cboCalibre.SelectedValue = tmpProducto.p_inidcalibre;
                cboModelo.SelectedValue = tmpProducto.p_inidmodelo;
                cboMedida.SelectedValue = tmpProducto.p_inidunidadmedidaproducto;
                cboSituacion.SelectedValue = tmpProducto.p_inidsituacion;
                txtFecha.Text = tmpProducto.chfechacreacion;
                ckbSerie.Checked = true;
                btnGrabar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || 8 == Convert.ToInt32(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        bool flat = false;
        int flat2 = 0;
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            //this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            string tipocategoria = cboCategoria.Text;
            if (tipocategoria == "NUEVA CATEGORIA")
            {
                if (flat)
                {
                    cboTipo.Enabled = false;
                    cboTipo.Text = "----";
                    MessageBox.Show("En Mantenimiento");
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flat = true;
            }
            else
            {
                flat2 = 0;
                cboTipo.Enabled = true;
                //Llenado datos tipo
                cboTipo.DataSource = maestrodetalleNE.buscarTipoPorCategoria(tipocategoria);
                cboTipo.ValueMember = "p_inidtipo";
                cboTipo.DisplayMember = "chtipo";
                int index = cboTipo.FindString("NUEVO "+tipocategoria);
                cboTipo.SelectedIndex = index;
                //int index = cboCategoria.FindString("NUEVA CATGORIA");
                //cboCategoria.SelectedIndex = 0;
                

            }

        }
       
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cboCategoria.Text;
            int cantidad = cboCategoria.Items.Count-1;
            if (cboTipo.Text == "NUEVO "+ tipo )
            {
                if (flat2 != 0)
                {
                    //cboTipo.Enabled = false;
                    cboTipo.Text = "----";
                    MessageBox.Show("En Mantenimiento");
                }
                flat2++;

            }

        }
        bool flatmarca = false;
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.Text == "NUEVO MARCA")
            {
                if (flatmarca)
                {
                    //cboMarca.Enabled = false;
                    //cboMarca.Text = "----";
                    MessageBox.Show("En Mantenimiento");
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatmarca = true;
            }
        }
        bool flatcalibre = false;
        private void cboCalibre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalibre.Text == "NUEVO CALIBRE")
            {
                if (flatcalibre)
                {
                   // cboCalibre.Enabled = false;
                    //cboCalibre.Text = "----";
                    MessageBox.Show("En Mantenimiento");
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatcalibre = true;
            }

        }
        bool flatmodelo = false;
        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelo.Text == "NUEVO MODELO")
            {
                if (flatmodelo)
                {
                    //cboModelo.Enabled = false;
                    //cboModelo.Text = "----";
                    MessageBox.Show("En Mantenimiento");
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatmodelo = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            int varIdArticulo;
            switch (this.vBoton)
            {
                case "A":
                    tmpProducto = new producto();
                    //ATRIBUTOS PARA INGRESAR PRODUCTO
                    //tmpProducto.p_inidproducto = 0; AUTO-GENERADO  
                    tmpProducto.chcodigoproducto = txtCodigo.Text;
                    tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
                    tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue;
                    tmpProducto.p_inidunidadmedidaproducto = (int)cboMedida.SelectedValue;
                    tmpProducto.chfechacreacion = txtFecha.Text;
                    tmpProducto.estado = true;
                    tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
                    tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
                    tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
                    tmpProducto.chcodigoproductoantes = "";
                    tmpProducto.chdescripcionproducto = txtNombre.Text;
                    tmpProducto.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    tmpProducto.p_inidusuariodelete = 0;
                    tmpProducto.nuprecio = 0;
                    tmpProducto.p_inidsituacion = (int)cboSituacion.SelectedValue;
                    tmpProducto.req_serie = ckbSerie.Checked; 
                    varIdArticulo = productoNE.productoInsertar(tmpProducto);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        MessageBox.Show("Código generado", varIdArticulo.ToString());
                        pasado(varIdArticulo);
                    }
                    break;
                case "M":
                    tmpProducto.p_inidproducto = int.Parse(txtidproducto.Text);
                    tmpProducto.chcodigoproducto = txtCodigo.Text;
                    tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
                    tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue;
                    tmpProducto.p_inidunidadmedidaproducto = (int)cboMedida.SelectedValue;
                    tmpProducto.chfechacreacion = txtFecha.Text;
                    tmpProducto.estado = true;
                    tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
                    tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
                    tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
                    tmpProducto.chcodigoproductoantes = "";
                    tmpProducto.chdescripcionproducto = txtNombre.Text;
                    tmpProducto.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    tmpProducto.p_inidusuariodelete = 0;
                    tmpProducto.nuprecio = 0;
                    tmpProducto.req_serie = ckbSerie.Checked;
                    tmpProducto.p_inidsituacion = (int)cboSituacion.SelectedValue;
                    varIdArticulo = productoNE.ProductoActualizar(tmpProducto);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                        MessageBox.Show("Registro actualizado");
                        pasado(varIdArticulo);
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }



        //private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if ((Int32.Parse(cboCategoria.ValueMember) != 0) && (Int32.Parse(cboTipo.ValueMember) != 0))
        //    {
        //        txtCodigo.Text = articuloNE.articuloObtenerNumero((int)cboTipo.SelectedValue, (int)cboCategoria.SelectedValue);
        //    }
        //}

    }
}