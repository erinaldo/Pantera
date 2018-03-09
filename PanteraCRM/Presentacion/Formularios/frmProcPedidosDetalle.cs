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
    public partial class frmProcPedidosDetalle : Form
    {
        public pedidodetalle tmbpedidodetalle;
        public pedidodetalle tmppedidodetalle;

        internal int codigoorden;

        public List<pedidodetalle> tmplistado;
        internal productoparaventa ProductoG;
        internal List<pedidodetalle> ListadoValidarG;
        internal pedidodetalle PedidoG;
        internal List<productoparaventa> ListaproductoparaventaDetalleG;
        internal List<pedidodetallecontenido> ListasDetallePedidoContenido;
        internal bool FlatG;
        public delegate void PasarDetalle();
        public event PasarDetalle PasadoDetalle;
        public frmProcPedidosDetalle(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void frmProcPedidosPedidosDetalle_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (vBoton == "A")
            {
                txtDesc1.Text = "0.00";
                txtDesc2.Text = "0.00";
                txtPrecioVenta.Text = "0.00";
                txtImporte.Text = "0.00";
                txtPreUnit.Text = "0.00";
                txtStock.Text = "0";
            }
            else
            {
                if (vBoton == "M")
                {
                    foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
                    {
                        if (codigoorden == obj.orden)
                        {
                            txtCodigo.Text = obj.productoparaventa.chcodigoproducto;
                            txtDesc1.Text = obj.pedidodetalle.nuporcentajedesc1.ToString();
                            txtDesc2.Text = obj.pedidodetalle.nuporcentajedesc2.ToString();
                        }
                    }
                    
                }
                else
                {
                    if (vBoton == "V")
                    {

                    }
                }
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtCodigo.Text;
            cargarDatosCabecera(parametro);
        }
        public void cargarDatosCabecera(string parametro)
        {
            ProductoG = productoNE.ProductosVentaParametro(parametro);
            
            if (ProductoG.p_inidproducto != 0)
            {
                //MessageBox.Show("" + ProductoG.p_inidproducto, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                decimal val = 0;
                if (ListadoValidarG != null)
                {
                    foreach (pedidodetalle obj in ListadoValidarG)
                    {
                        if (obj.p_inidproducto == ProductoG.p_inidproducto)
                        {
                            val = val + obj.nucantidad;
                        }
                    }
                }
                if (vBoton == "A")
                {
                    txtStock.Text = (ProductoG.nustockactual - val).ToString();
                }
                else
                {
                    txtStock.Text = (ProductoG.nustockactual).ToString();
                }
                txtDescripcion.Text = ProductoG.chnombrecompuesto;
                txtImporte.Text = "0.00";
                txtPreUnit.Text = ProductoG.nuprecio.ToString();
                txtMedida.Text = ProductoG.chunidadmedidaproducto;
                dgvListaProdSeries.Rows.Clear();
                cargarData(0, ProductoG.p_inidproducto);
            }
            else
            {
                //MessageBox.Show("" + ProductoG.p_inidproducto, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtDescripcion.Text = "";
                txtDesc1.Text = "0.00";
                txtDesc2.Text = "0.00";
                txtPrecioVenta.Text = "0.00";
                txtImporte.Text = "0.00";
                txtPreUnit.Text = "0.00";
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
                            //productoparaventa registros = new productoparaventa();
                            //registros = rrr;
                            //rrr.req_serie = buscarSerieMcodigo(rrr.p_inidserie);
                            dgvListaProdSeries.Rows.Add(buscarSerieMcodigo(rrr.p_inidserie), rrr.p_inidproducto, rrr.chcodigoproducto, rrr.chnombrecompuesto, rrr.chunidadmedidaproducto, rrr.nuprecio, rrr.chserie, rrr.p_inidserie);
                            //listadosssss.Add(registros);
                        }
                        else
                        {
                            //productoparaventa registros = new productoparaventa();
                            //registros = rrr;
                            dgvListaProdSeries.Rows.Add(rrr.req_serie, rrr.p_inidproducto, rrr.chcodigoproducto, rrr.chnombrecompuesto, rrr.chunidadmedidaproducto, rrr.nuprecio, rrr.chserie, rrr.p_inidserie);
                            //listadosssss.Add(registros);
                        }

                    }
                    //dgvListaProdSeries.DataSource = listadosssss;
                    //CargarTablaDetalleSeries();
                }
                //dgvListaProdSeries.DataSource = listado;
            }
            else
            {
                // dgvListaProdSeries.DataSource = listadosssss;
                //dgvListaProdSeries.Rows.Clear();
                dgvListaProdSeries.ReadOnly = true;
            }
        }
   
        private void CargarTablaDetalleSeries()
        {
            dgvListaProdSeries.DataSource = ListaproductoparaventaDetalleG;
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
            if (sesion.pedidodetallecontenido != null)
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
            



        private void txtCodigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {                
                txtCodigo.Text = f.chcodigoproducto;
            }
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
            decimal preciounitario = 0;
            decimal desc1 = 0;
            decimal desc2 = 0;

            if (txtPreUnit.Text.Length > 0)
            {
                preciounitario = decimal.Round(decimal.Parse(txtPreUnit.Text), 2);
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text), 2);
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text), 2);
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = "";
            txtPrecioVenta.Text = decimal.Round((preciounitario * (1 - (desc1 / 100)) * (1 - (desc2 / 100))), 2).ToString();
  
            if (cantidad > stock)
            {
                MessageBox.Show("La Cantidad Ingresada Supera el Stock Actual", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.Focus();
                txtCant.Text = "";
                return;
            }
        }
        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            int stock = 0;
            decimal preciounitario = 0;
            decimal desc1 = 0;
            decimal desc2 = 0;
          
            if (txtPreUnit.Text.Length > 0)
            {
                preciounitario = decimal.Round(decimal.Parse(txtPreUnit.Text),2);
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text),2);
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text),2);
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = decimal.Round((preciounitario * (1 - (desc1 / 100)) * (1 - (desc2 / 100))),2).ToString();
        }
        private void txtDesc2_TextChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            int stock = 0;
            decimal preciounitario = 0;
            decimal desc1 = 0;
            decimal desc2 = 0;

            if (txtPreUnit.Text.Length > 0)
            {
                preciounitario = decimal.Round(decimal.Parse(txtPreUnit.Text), 2);
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text), 2);
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text), 2);
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = decimal.Round((preciounitario * (1 - (desc1 / 100)) * (1 - (desc2 / 100))), 2).ToString();
        }
        private void txtDesc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtDesc1.Text.Length; i++)
            {
                if (txtDesc1.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    if (txtDesc1.SelectionLength > 0)
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
        private void txtDesc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtDesc2.Text.Length; i++)
            {
                if (txtDesc2.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    if (txtDesc2.SelectionLength > 0)
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (this.vBoton)
            {
                case "A":
                    if (Validar())
                    {
                        AgregarDetalle();
                    }
                    else
                    {
                        return;
                    }

                    break;
                case "M":
                    if (Validar())
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
            int producto = 0;
            foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
            {
                if (codigoorden == obj.orden)
                {
                    producto = obj.productoparaventa.p_inidproducto;
                    break;
                }
            }
            List < pedidodetallecontenido> pedcont = sesion.pedidodetallecontenido;
            foreach (pedidodetallecontenido obj in pedcont)
            {
                if (producto == obj.productoparaventa.p_inidproducto)
                {
                    obj.estado = false;
                }
            }
            sesion.pedidodetallecontenido = pedcont;

        }
        private void AgregarDetalle()
        {
            if (ProductoG.req_serie)
            {
                ListasDetallePedidoContenido = new List<pedidodetallecontenido>();
                for (int i = 0; i < dgvListaProdSeries.RowCount; i++)
                {
                    if (sesion.pedidodetallecontenido != null)
                    {
                        ListasDetallePedidoContenido = sesion.pedidodetallecontenido;
                    }
                    if (bool.Parse(dgvListaProdSeries.Rows[i].Cells["REQSERIE"].Value.ToString()))
                    {
                        pedidodetallecontenido objpedidocontenido = new pedidodetallecontenido();
                        pedidodetalle ObjpedidoDetalle = new pedidodetalle();
                        serie objserie = new serie();
                        ObjpedidoDetalle.p_inidproducto = ProductoG.p_inidproducto;
                        ObjpedidoDetalle.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                        ObjpedidoDetalle.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                        ObjpedidoDetalle.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                        ObjpedidoDetalle.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                        ObjpedidoDetalle.nuimportesubtotal = decimal.Parse(txtImporte.Text)/ decimal.Parse(txtCant.Text);
                        ObjpedidoDetalle.nucantidad = decimal.Parse(txtCant.Text);
                        
                        objserie.p_inidserie = int.Parse(dgvListaProdSeries.Rows[i].Cells["IDSERIE"].Value.ToString());
                        objserie.chcodigoserie = dgvListaProdSeries.Rows[i].Cells["CHSERIE"].Value.ToString();
                        objpedidocontenido.orden = ListasDetallePedidoContenido.Count + 1;
                        objpedidocontenido.serie = objserie;
                        objpedidocontenido.pedidodetalle = ObjpedidoDetalle;
                        objpedidocontenido.productoparaventa = ProductoG;
                        objpedidocontenido.estado = true;
                        ListasDetallePedidoContenido.Add(objpedidocontenido);
                    }
                }
                sesion.pedidodetallecontenido = ListasDetallePedidoContenido;
            }
            else
            {
                ListasDetallePedidoContenido = new List<pedidodetallecontenido>();
                if (sesion.pedidodetallecontenido != null)
                {
                    ListasDetallePedidoContenido = sesion.pedidodetallecontenido;
                }
                //EL PRODUCTO NO REQUIERE DE SERIES
                pedidodetallecontenido objpedidocontenido = new pedidodetallecontenido();
                pedidodetalle ObjpedidoDetalle = new pedidodetalle();
                ObjpedidoDetalle.p_inidproducto = ProductoG.p_inidproducto;
                ObjpedidoDetalle.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                ObjpedidoDetalle.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                ObjpedidoDetalle.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                ObjpedidoDetalle.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                ObjpedidoDetalle.nuimportesubtotal = decimal.Parse(txtImporte.Text);
                ObjpedidoDetalle.nucantidad = decimal.Parse(txtCant.Text);
                objpedidocontenido.serie = null;
                objpedidocontenido.orden = ListasDetallePedidoContenido.Count + 1;
                objpedidocontenido.pedidodetalle = ObjpedidoDetalle;
                objpedidocontenido.productoparaventa = ProductoG;
                objpedidocontenido.estado = true;
                ListasDetallePedidoContenido.Add(objpedidocontenido);
                sesion.pedidodetallecontenido = ListasDetallePedidoContenido;
            }
            PasadoDetalle();
        }
       
        public bool Validar()
        {
            bool flatvalidar = false;
            int cantidad = 0;
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);

            }

            if (decimal.Parse(txtPreUnit.Text) > 0)
            {
                if (cantidad > 0)
                {

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

                            flatvalidar = true;
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
                        flatvalidar = true;
                    }

                }
                else
                {
                    //MessageBox.Show("The calculations are complete", "My Application",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // MessageBox.Show("La cantidad no es valida", "MENSAJE DE SISTEMA");
                    MessageBox.Show("La cantidad no es valida", "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //txtCant.BackColor = Color.Red;
                    txtCant.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Codigo Válido", "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //MessageBox.Show("Ingrese un Codigo Válido", "MENSAJE DE SISTEMA");
                //txtCodigo.BackColor = Color.Red;
                txtCodigo.Focus();
            }

            return flatvalidar;

        }
        private void txtDesc1_Enter(object sender, EventArgs e)
        {
            txtDesc1.SelectAll();
        }

        private void txtDesc2_Enter(object sender, EventArgs e)
        {
            txtDesc2.SelectAll();
        }

        private void txtCant_Enter(object sender, EventArgs e)
        {
            txtCant.SelectAll();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            decimal cantidad = 0;
            if (txtPrecioVenta.Text.Length > 0 && txtCant.Text.Length > 0)
            {
                precioventa = decimal.Parse(txtPrecioVenta.Text);
                cantidad = decimal.Round(decimal.Parse(txtCant.Text));
            }
            txtImporte.Text = (precioventa * cantidad).ToString();
        }
    }
}
