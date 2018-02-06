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
            
            int varIdArticulo;
            switch (this.vBoton)
            {
                case "A":
                    {
                        tmpProducto = new producto();
                        ////tmpProducto.p_inidproducto = (int);
                        //tmpProducto.chcodigoproducto = txtCodigo.Text;
                        //tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
                        //tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue; 
                        //tmpProducto.p_inunidadmedidaproducto = (int)cboMedida.SelectedValue;
                        //tmpProducto.chfechacreacion = txtFecha.Text;
                        //tmpProducto.estado = true;
                        //tmpProducto.tmhoracreacion = txtFecha.Text;
                        //tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
                        //tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
                        //tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
                        //tmpProducto.chcodigoproductoantes = txtNombre.Text;
                        //tmpProducto.chdescripcionproducto = txtNombre.Text;
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
                    }
                    break;
                case "M":
                    {

                    }break;
                default:
                    break;
            }
            //int varIdArticulo ;
            //switch (this.vBoton)
            //{
            //    case "A":
            //        //tmpProducto = new producto();
            //        //tmpProducto.chcodigoproducto = txtCodigo.Text;
            //        //tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
            //        //tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
            //        //tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue;
            //        //tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
            //        //tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
            //        //tmpProducto.chdescripcionproducto = txtNombre.Text;
            //        //tmpProducto.p_inunidadmedidaproducto =  (int)cboMedida.SelectedValue;
            //        //tmpProducto.chfechacreacion = txtFecha.Text;

            //       // varIdArticulo = productoNE.productoInsertar(tmpProducto);
            //        if (varIdArticulo <= 0)
            //        {
            //            MessageBox.Show("a"+ tmpProducto.chcodigoproducto.ToString());
            //            MessageBox.Show("Registro errado, validar");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Código generado", varIdArticulo.ToString());
            //            pasado(varIdArticulo);
            //        }
            //        break;
            //    //case "M":
            //    //    //tmpArticulo.codigoarticulo = txtCodigo.Text;
            //    //    //tmpArticulo.nombrearticulo = txtNombre.Text;
            //    //    //tmpArticulo.idtipoarticulo = (string)cboTipo.SelectedValue;
            //    //    //tmpArticulo.idcatearticulo = (string)cboCategoria.SelectedValue;
            //    //    //tmpArticulo.idmediarticulo = ((string)cboMedida.SelectedValue == null) ? "" : (string)cboMedida.SelectedValue;
            //    //    //tmpArticulo.fechacreacion = txtFecha.Text;
            //    //    //tmpArticulo.precio = Convert.ToDecimal(txtPrecio.Text);
            //    //    //tmpArticulo.idusuario = sesion.usuariosesion.idusuario;
            //    //    //tmpArticulo.idsituarticulo = (string)cboSituacion.SelectedValue;
            //    //    //tmpArticulo.estadoarticulo = true;
            //    //    //varIdArticulo = articuloNE.articuloActualizar(tmpArticulo);
            //    //    //if (varIdArticulo <= 0)
            //    //    //{
            //    //    //    MessageBox.Show("Registro con error por actualizado, validar");
            //    //    //}
            //    //    //else
            //    //    //{
            //    //    //    MessageBox.Show("Registro actualizado");
            //    //    //    pasado(varIdArticulo);
            //    //    //}
            //    //    break;
            //    default:
            //        break;
            //}
            this.Dispose();
        }

     

        private void frmManProductoAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            //Seleccion Categoria
            cboCategoria.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(1);
            cboCategoria.ValueMember = "idmaestrodetalle";
            cboCategoria.DisplayMember = "nombreitem";
            //Seleccion tipo
            cboTipo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(2);
            cboTipo.ValueMember = "idmaestrodetalle";
            cboTipo.DisplayMember = "nombreitem";            
            //Seleccion Marca
            cboMarca.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(3);
            cboMarca.ValueMember = "idmaestrodetalle";
            cboMarca.DisplayMember = "nombreitem";
            //Seleccion Calibre
            cboCalibre.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(4);
            cboCalibre.ValueMember = "idmaestrodetalle";
            cboCalibre.DisplayMember = "nombreitem";
            //Seleccion Modelo
            cboModelo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(5);
            cboModelo.ValueMember = "idmaestrodetalle";
            cboModelo.DisplayMember = "nombreitem";
            //Seleccion Unidad Medida
            cboMedida.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(6);
            cboMedida.ValueMember = "idmaestrodetalle";
            cboMedida.DisplayMember = "nombreitem";
            //Situacion Producto
            cboSituacion.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(7);
            cboSituacion.ValueMember = "idmaestrodetalle";
            cboSituacion.DisplayMember = "nombreitem";

            if (this.vBoton =="A")
            {
                //label8.Text = "Añadir Producto";
                txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
               // int index = cboMedida.FindString("UNIDADES");
               // cboMedida.SelectedIndex = 0;
                //txtPrecio.Text = "0";
            }
            else 
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR PRODUCTO";
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
            }
            else
                   if(this.vBoton == "V")
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

                btnGrabar.Enabled = false;
                    }
         }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboCategoria.Text == "Productos")
            //{
                
            //    //cboSituacion.Enabled = false;
            //    //txtPrecio.Enabled = false;
            //    //cboMedida.SelectedIndex = -1;


            //    //if (cboCategoria.Text != "FAMILIAS")
            //    //{
            //    //    cboTipo.Enabled = false;
            //    //}
            //    //else
            //    //{
            //    //    cboTipo.Enabled = true;
            //    //}
            //}
            //else
            //{
            //    if (cboCategoria.Text == "Acesorios")
            //    {
            //       // cboMarca.Enabled = false;
            //       // cboSituacion.Enabled = false;

            //    }
            //    else
            //    {

            //    }
            //    //cboMedida.Enabled = true;
            //    //txtPrecio.Enabled = true;
            //    //int index = cboMedida.FindString("UNIDADES");
            //    //cboMedida.SelectedIndex = index;
            //}
            ////if (((string)cboTipo.ValueMember != "") && ((string)cboCategoria.ValueMember != ""))
            ////{
            ////    txtCodigo.Text = articuloNE.articuloObtenerNumero((string)cboTipo.SelectedValue, (string)cboCategoria.SelectedValue);
            ////}
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || 8 == Convert.ToInt32(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
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