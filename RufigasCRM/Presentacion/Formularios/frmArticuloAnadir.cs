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
    public partial class frmArticuloAnadir : Form
    {
        internal articulo tmpArticulo;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmArticuloAnadir(string vBoton)
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
                    tmpArticulo = new articulo();
                    tmpArticulo.codigoarticulo = txtCodigo.Text;
                    tmpArticulo.nombrearticulo = txtNombre.Text;
                    tmpArticulo.idtipoarticulo= (string)cboTipo.SelectedValue;
                    tmpArticulo.idcatearticulo = (string)cboCategoria.SelectedValue;
                    tmpArticulo.idmediarticulo = ((string)cboMedida.SelectedValue==null) ? "" : (string)cboMedida.SelectedValue;
                    tmpArticulo.fechacreacion = txtFecha.Text;
                    if (txtPrecio.Text == "")
                    {
                        tmpArticulo.precio = 0;
                    }
                    else
                    {
                        tmpArticulo.precio = Convert.ToDecimal(txtPrecio.Text);
                    }
                    tmpArticulo.idusuario = sesion.usuariosesion.idusuario;
                    tmpArticulo.idsituarticulo = (string)cboSituacion.SelectedValue;
                    tmpArticulo.estadoarticulo = true;
                    varIdArticulo = articuloNE.articuloInsertar(tmpArticulo);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        //MessageBox.Show("Código generado", varIdArticulo.ToString());
                        pasado(varIdArticulo);
                    }
                        break;
                case "M":
                    tmpArticulo.codigoarticulo = txtCodigo.Text;
                    tmpArticulo.nombrearticulo = txtNombre.Text;
                    tmpArticulo.idtipoarticulo = (string)cboTipo.SelectedValue;
                    tmpArticulo.idcatearticulo = (string)cboCategoria.SelectedValue;
                    tmpArticulo.idmediarticulo = ((string)cboMedida.SelectedValue == null) ? "" : (string)cboMedida.SelectedValue;
                    tmpArticulo.fechacreacion = txtFecha.Text;
                    tmpArticulo.precio = Convert.ToDecimal(txtPrecio.Text);
                    tmpArticulo.idusuario = sesion.usuariosesion.idusuario;
                    tmpArticulo.idsituarticulo = (string)cboSituacion.SelectedValue;
                    tmpArticulo.estadoarticulo = true;
                    varIdArticulo = articuloNE.articuloActualizar(tmpArticulo);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                       // MessageBox.Show("Registro actualizado");
                        pasado(varIdArticulo);
                    }
                        break;
                default:
                    break;
            }
            this.Dispose();
        }

        private void frmArticuloAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboTipo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro("TIPOARTICU");
            cboTipo.ValueMember = "codigoitem";
            cboTipo.DisplayMember = "nombreitem";
            cboCategoria.DataSource = maestrodetalleNE.buscarPorCodigoMaestro("CATEARTICU");
            cboCategoria.ValueMember = "codigoitem";
            cboCategoria.DisplayMember = "nombreitem";
            cboMedida.DataSource = maestrodetalleNE.buscarPorCodigoMaestro("UNIDMEDIDA");
            cboMedida.ValueMember = "codigoitem";
            cboMedida.DisplayMember = "nombreitem";
            cboSituacion.DataSource = maestrodetalleNE.buscarPorCodigoMaestro("SITUARTICU");
            cboSituacion.ValueMember = "codigoitem";
            cboSituacion.DisplayMember = "nombreitem";

            if (this.vBoton =="A")
            {
                this.Text = "AÑADIR ARTÍCULO";
                txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                int index = cboMedida.FindString("UNIDADES");
                cboMedida.SelectedIndex = index;
                txtPrecio.Text = "0";
            }
            else 
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR ARTÍCULO";
                    txtCodigo.Text = tmpArticulo.codigoarticulo;
                    txtNombre.Text = tmpArticulo.nombrearticulo;
                    cboTipo.SelectedValue = tmpArticulo.idtipoarticulo;
                    cboCategoria.SelectedValue = tmpArticulo.idcatearticulo;
                    cboMedida.SelectedValue = tmpArticulo.idmediarticulo;
                    txtPrecio.Text = tmpArticulo.precio.ToString();
                    cboSituacion.SelectedValue = tmpArticulo.idsituarticulo;
                    txtFecha.Text = tmpArticulo.fechacreacion;
                }
                else
                   if(this.vBoton == "V")
                    {
                        this.Text = "VER ARTÍCULO";
                        txtCodigo.Text = tmpArticulo.codigoarticulo;
                        txtNombre.Text = tmpArticulo.nombrearticulo;
                        cboTipo.SelectedValue = tmpArticulo.idtipoarticulo;
                        cboCategoria.SelectedValue = tmpArticulo.idcatearticulo;
                        cboMedida.SelectedValue = tmpArticulo.idmediarticulo;
                        txtPrecio.Text = tmpArticulo.precio.ToString();
                        cboSituacion.SelectedValue = tmpArticulo.idsituarticulo;
                        txtFecha.Text = tmpArticulo.fechacreacion;
                        btnGrabar.Enabled = false;
                    }
                }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.Text != "ARTICULOS")
            {
                cboMedida.Enabled = false;
                txtPrecio.Enabled = false;
                cboMedida.SelectedIndex = -1;
                //if (cboCategoria.Text != "FAMILIAS")
                //{
                //    cboTipo.Enabled = false;
                //}
                //else
                //{
                //    cboTipo.Enabled = true;
                //}
            }
            else
            {
                cboMedida.Enabled = true;
                txtPrecio.Enabled = true;
                int index = cboMedida.FindString("UNIDADES");
                cboMedida.SelectedIndex = index;
            }
            if (((string)cboTipo.ValueMember != "") && ((string)cboCategoria.ValueMember != ""))
            {
                txtCodigo.Text = articuloNE.articuloObtenerNumero((string)cboTipo.SelectedValue, (string)cboCategoria.SelectedValue);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || 8 == Convert.ToInt32(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboCategoria.ValueMember != "") && (cboTipo.ValueMember != ""))
            {
                txtCodigo.Text = articuloNE.articuloObtenerNumero((string)cboTipo.SelectedValue, (string)cboCategoria.SelectedValue);
            }
        }
    }
}