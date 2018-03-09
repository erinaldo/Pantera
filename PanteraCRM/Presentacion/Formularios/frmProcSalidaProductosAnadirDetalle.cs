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
using Negocios;
namespace Presentacion
{
    public partial class frmProcSalidaProductosAnadirDetalle : Form
    {
        internal productoparaventa ProductoG ;
        public delegate void pasarDetalleAnadido();
        public event pasarDetalleAnadido pasadoDetalle;
        internal List<pedidodetalle> ListadoValidarG;
        public frmProcSalidaProductosAnadirDetalle(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcSalidaProductosAnadirDetalle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            txtImporte.Text = "0.00";
            txtCant.Text = "0";
            txtPreComp.Text = "0.00";
            txtStock.Text = "0.00";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCamposdetalle())
            {
                List<movimientoproductoaccion> listaMovi = sesion.movprodaccion;
                if (listaMovi == null)
                {
                    listaMovi = new List<movimientoproductoaccion>();
                }
                movimientoproductoaccion registrosMovi = new movimientoproductoaccion();

                List<serie> ListaSerie = new List<serie>();
                if (dgvListaProdSeries.RowCount > 0)
                {
                    for (int i = 0; i < dgvListaProdSeries.RowCount; i++)
                    {
                        serie registrosSerie = new serie();
                        registrosSerie.chcodigoserie = dgvListaProdSeries.Rows[i].Cells["CHSERIE"].Value.ToString();
                        registrosSerie.estado = true;
                        registrosSerie.p_inidproducto = ProductoG.p_inidproducto;
                        registrosSerie.chadicional = dgvListaProdSeries.Rows[i].Cells["CHSERIE"].Value.ToString();
                        registrosSerie.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                        registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        ListaSerie.Add(registrosSerie);
                    }
                }

                valedetalle registrosValeDet = new valedetalle();
                registrosValeDet.p_inidvaledetalle = ProductoG.p_inidproducto;
                registrosValeDet.chnombrecompuesto = ProductoG.chnombrecompuesto;
                registrosValeDet.chmedida = txtMedida.Text;
                registrosValeDet.chcodigoproducto = ProductoG.chcodigoproducto;
                registrosValeDet.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                registrosValeDet.p_inidproducto = ProductoG.p_inidproducto;
                registrosValeDet.nucantidad = int.Parse(txtCant.Text);
                registrosValeDet.nucosto = decimal.Round(decimal.Parse(txtPreComp.Text), 2);
                registrosValeDet.nutotal = decimal.Round(decimal.Parse(txtImporte.Text), 2);
                registrosValeDet.estado = true;

                registrosMovi.listaserie = ListaSerie;
                registrosMovi.valedet = registrosValeDet;

                listaMovi.Add(registrosMovi);
                //sesion.movprodaccion.Clear();
                sesion.movprodaccion = listaMovi;
                dgvListaProdSeries.Rows.Clear();
                pasadoDetalle();
                this.Dispose();
            }
            
        }
        private bool validarCamposdetalle()
        {
            bool flat = false;
            int cantidad = 0;
            decimal compra = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtPreComp.Text.Length > 0)
            {
                compra = decimal.Parse(txtPreComp.Text);
            }
            if ( cantidad > 0 )
            {
                if ( compra > 0)
                {
                    if (txtDescripcion.Text.Length > 0)
                    {
                        if (ValidaLista())
                        {
                            flat = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro de Lista", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        }
                        
                    }else
                    {
                        MessageBox.Show("Ingrese código de producto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        
                        txtCodigo.SelectAll();
                    }                    
                }else
                {
                    MessageBox.Show("Precio de compra vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtPreComp.SelectAll();
                }
            }else
            {
                MessageBox.Show("Cantidad vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.SelectAll();
            }
            return flat;
        }
        private bool ValidaLista()
        {
            bool flat = false;
            int cantidad = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }

            if (dgvListaProdSeries.RowCount > 0)
            {
                int variante = 0;
                for (int i = 0; i < dgvListaProdSeries.RowCount; i++)
                {
                    if (bool.Parse(dgvListaProdSeries.Rows[i].Cells["REQSERIE"].Value.ToString()))
                    {
                        variante++;
                    }
                }
                if (cantidad == variante)
                {

                    flat = true;
                }
                else
                {
                    MessageBox.Show("La CANTIDAD debe ser igual a los ITEMS Seleccionados", "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //txtCant.BackColor = Color.Red;
                    txtCant.Focus();

                }
            }
            else
            {
                flat = true;
            }

            return flat;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtCodigo.Text;
            buscaProducto(parametro);
        }
        public void buscaProducto(string parametro)
        {
            ProductoG = productoNE.ProductosVentaParametro(parametro);

            if (ProductoG.p_inidproducto != 0)
            {
                //MessageBox.Show("" + ProductoG.p_inidproducto, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                //decimal val = 0;
                //if (dgvListaProdSeries != null)
                //{
                //    foreach (pedidodetalle obj in ListadoValidarG)
                //    {
                //        if (obj.p_inidproducto == ProductoG.p_inidproducto)
                //        {
                //            val = val + obj.nucantidad;
                //        }
                //    }
                //}
                txtDescripcion.Text = ProductoG.chnombrecompuesto;
                txtCant.Text = "0";
                txtPreComp.Text = "0.00";
                txtImporte.Text = "0.00";
                txtMedida.Text = ProductoG.chunidadmedidaproducto;
                txtStock.Text = ProductoG.nustockactual.ToString();
                dgvListaProdSeries.Rows.Clear();
                cargarData(0, ProductoG.p_inidproducto);
            }
            else
            {
                //MessageBox.Show("" + ProductoG.p_inidproducto, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtDescripcion.Text = "";
                txtMedida.Text = "";
                txtCant.Text = "0";
                txtPreComp.Text = "0.00";
                txtImporte.Text = "0.00";
                txtStock.Text = "0";
                dgvListaProdSeries.Rows.Clear();

            }
        }
        private void cargarData(int registro, int parametro)
        {
            List<productoparaventa> listado = productoNE.ListaProductosVentaParametro(parametro);
            List<productoparaventa> listadosssss = new List<productoparaventa>();
            if (listado != null)
            {
                foreach (productoparaventa rrr in listado)
                {

                    bool flat = buscarSerieM(rrr.p_inidserie, rrr.p_inidproducto);
                    if (!flat)
                    {
                        if (vBoton == "M")
                        {
                            dgvListaProdSeries.Rows.Add(buscarSerieMcodigo(rrr.p_inidserie), rrr.p_inidproducto, rrr.chcodigoproducto, rrr.chnombrecompuesto, rrr.chunidadmedidaproducto, rrr.nuprecio, rrr.chserie, rrr.p_inidserie);            
                        }
                        else
                        {
                            dgvListaProdSeries.Rows.Add(rrr.req_serie, rrr.p_inidproducto, rrr.chcodigoproducto, rrr.chnombrecompuesto, rrr.chunidadmedidaproducto, rrr.nuprecio, rrr.chserie, rrr.p_inidserie);                           
                        }

                    }
                }
            }
            else
            {
                dgvListaProdSeries.ReadOnly = true;
            }
        }
        private bool buscarSerieMcodigo(int serie)
        {
            bool flat = false;
            foreach (pedidodetalle s in ListadoValidarG)
            {
                if (s.p_inidserie == serie)
                {
                    flat = true;

                }
            }
            return flat;
        }
        private bool buscarSerieM(int serie, int producto)
        {
            bool flat = false;
            if (sesion.movprodaccion != null)
            {
                foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
                {
                    if (obj.serie != null)
                    {
                        if (obj.serie.p_inidserie == serie && obj.pedidodetalle.p_inidproducto == producto && obj.estado == true)
                        {
                            if (vBoton != "M")
                            {
                                flat = true;
                            }
                        }
                    }

                }
            }
            return flat;
        }

        private void txtCodigo_DoubleClick(object sender, EventArgs e)
        {
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            f.Cargado += new frmBusquedaProductoGeneral.CargarTabla(CargarCodigo);
            f.MdiParent = this.MdiParent;
            f.Show();
            
        }
        private void CargarCodigo(string codigo)
        {
            txtCodigo.Text = codigo;
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            int stock = 0;
            decimal preciocompra = 0;            
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            if (txtPreComp.Text.Length > 0)
            {
                preciocompra = decimal.Parse(txtPreComp.Text);
            }
            txtImporte.Text = (decimal.Round(cantidad * preciocompra,2)).ToString();
            if (cantidad > stock)
            {
                MessageBox.Show("La Cantidad Ingresada Supera el Stock Actual", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.Focus();
                txtCant.Text = "0";
                txtCant.SelectAll();
                return;
            }
        }

        private void txtPreComp_TextChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            int stock = 0;
            decimal preciocompra = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtPreComp.Text.Length > 0)
            {
                preciocompra = decimal.Parse(txtPreComp.Text);
            }
            txtImporte.Text = (decimal.Round(cantidad * preciocompra, 2)).ToString();
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txtPreComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPreComp.Text.Length; i++)
            {
                if (txtPreComp.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    if (txtPreComp.SelectionLength > 0)
                    {
                        if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57)
                            e.Handled = false;
                        return;

                    }
                    else
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}
