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
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmProcSalidaProductosAnadirDetalle : Form
    {
        internal productoparaventa ProductoG ;
        internal int orden;
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
            
            if (vBoton == "A")
            {
                txtImporte.Text = "0.00";
                txtCant.Text = "0";
                txtPreComp.Text = "0.00";
                txtStock.Text = "0.00";
            }
            else
            {
                if (vBoton == "M")
                {
                    CargarDatos();
                }
                else
                {
                    if (vBoton == "V")
                    {
                        CargarDatos();
                        Desactivartext(txtCant);
                        Desactivartext(txtCodigo);
                        Desactivartext(txtPreComp);
                    }
                }
            }
        }
    
        private void Desactivartext(TextBox texbox)
        {
            texbox.ReadOnly = true;
            texbox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            texbox.ForeColor = Color.Blue;
            texbox.TabStop = false;
        }
        private void CargarDatos()
        {
            foreach (movimientoproductoaccion objMovimiento in sesion.movprodaccion)
            {
                if (orden == objMovimiento.orden)
                {
                    txtCodigo.Text = objMovimiento.valedet.chcodigoproducto;
                    txtCant.Text = objMovimiento.valedet.nucantidad.ToString();
                    txtPreComp.Text = objMovimiento.valedet.nucosto.ToString();
                }
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (this.vBoton)
            {
                case "A":
                    if (validarCamposdetalle())
                    {
                        AgregarDetalle();
                    }
                    else
                    {
                        return;
                    }

                    break;
                case "M":
                    if (validarCamposdetalle())
                    {
                        falsearDatos();
                        AgregarDetalle();
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
            
        }
        private void falsearDatos()
        {           
            List<movimientoproductoaccion> pedcont = sesion.movprodaccion;
            foreach (movimientoproductoaccion obj in pedcont)
            {
                if (orden == obj.orden)
                {
                    obj.valedet.estado = false;
                }
            }
            sesion.movprodaccion = pedcont;

        }
        private void AgregarDetalle()
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
                    ListaSerie.Add(registrosSerie);
                }
            }
            valedetalle registrosValeDet = new valedetalle();
            registrosValeDet.chnombrecompuesto = ProductoG.chnombrecompuesto;
            registrosValeDet.chmedida = txtMedida.Text;
            registrosValeDet.chcodigoproducto = ProductoG.chcodigoproducto;
            registrosValeDet.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            registrosValeDet.p_inidproducto = ProductoG.p_inidproducto;
            registrosValeDet.nucantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
            registrosValeDet.nucosto = decimal.Round(decimal.Parse(txtPreComp.Text), 2);
            registrosValeDet.nutotal = decimal.Round(decimal.Parse(txtImporte.Text), 2);
            registrosValeDet.estado = true;
            registrosMovi.listaserie = ListaSerie;
            registrosMovi.valedet = registrosValeDet;
            registrosMovi.orden = listaMovi.Count + 1;
            listaMovi.Add(registrosMovi);
            sesion.movprodaccion = listaMovi;
            dgvListaProdSeries.Rows.Clear();
            pasadoDetalle();
        }
        private bool validarCamposdetalle()
        {
            bool flat = false;
            int cantidad = 0;
            decimal compra = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
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
                cantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
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
             
                txtDescripcion.Text = ProductoG.chnombrecompuesto;
                txtCant.Text = "0";
                txtPreComp.Text = "0.00";
                txtImporte.Text = "0.00";
                txtMedida.Text = ProductoG.chunidadmedidaproducto;
                txtStock.Text = string.Format("{0:0,0.00}", ProductoG.nustockactual.ToString());
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
          
            if (listado != null)
            {
                foreach (productoparaventa rrr in listado)
                {
                   
                        dgvListaProdSeries.Rows.Add(rrr.req_serie, rrr.p_inidproducto, rrr.chcodigoproducto, rrr.chnombrecompuesto, rrr.chunidadmedidaproducto, rrr.nuprecio, rrr.chserie, rrr.p_inidserie);
                                     
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
            foreach (movimientoproductoaccion s in sesion.movprodaccion)
            {
                if (s.orden == orden)
                {
                    foreach (serie objSerie in s.listaserie)
                    {
                        if (objSerie.p_inidserie == serie)
                        {
                            flat = true;
                        }
                    }
                }                                 
            }
            return flat;
        }
        private bool buscarSerieM(int serie, int producto)
        {
            bool flat = false;
            if (sesion.movprodaccion != null)
            {
                foreach (movimientoproductoaccion obj in sesion.movprodaccion)
                {
                    if (obj.listaserie != null)
                    {
                        if (obj.valedet.p_inidproducto == producto && obj.valedet.estado == true)
                        {
                            foreach (serie objSerie in obj.listaserie)
                            {
                                if (objSerie.p_inidserie == serie)
                                {
                                    
                                        flat = true;
                                    
                                }
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
            //f.MdiParent = this.MdiParent;
            f.Show();
            
        }
        private void CargarCodigo(string codigo)
        {
            txtCodigo.Text = codigo;
        }


        
        /*INICIO :: VALIDACION DE NUMEROS Y FORMATO*/
        private void txtPreComp_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }
        private void txtPreComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);
        }

        private void txtCant_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }
        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            int stock = 0;
            decimal preciocompra = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
            }
            if (txtStock.Text.Length > 0)
            {
                stock = Decimal.ToInt32(decimal.Parse(txtStock.Text));
            }
            if (txtPreComp.Text.Length > 0)
            {
                preciocompra = decimal.Parse(txtPreComp.Text);
            }
            txtImporte.Text = string.Format("{0:0,0.00}",cantidad * preciocompra);
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
                cantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
            }
            if (txtPreComp.Text.Length > 0)
            {
                preciocompra = decimal.Parse(txtPreComp.Text);
            }
            txtImporte.Text = string.Format("{0:0,0.00}", (cantidad * preciocompra)); 
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 15);
        }

        private void txtPreComp_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }
        /*FIN :: VALIDACION DE NUMEROS Y FORMATO*/
    }
}
