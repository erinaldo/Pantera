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
        
        public List<pedidodetalle> tmplistado;

        internal List<pedidodetalle> ListadoValidarG;
        internal pedidodetalle PedidoG;
        internal List<pedidodetalle> ListaDetalleG;
        internal bool FlatG;
        public delegate void PasarDetalle(List<pedidodetalle> Listado, pedidodetalle Registros,bool Flat);
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

                }else
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
            List<productoparaventa> obprodventa = productoNE.ProductosVentaParametro(parametro);
            if (obprodventa != null)
            {
                foreach (productoparaventa a in obprodventa)
                {
                    if (ListadoValidarG != null)
                    {
                        decimal val = 0;
                        foreach (pedidodetalle obj in ListadoValidarG)
                        {
                            if (obj.p_inidproducto == a.p_inidproducto)
                            {
                                val = val + obj.nucantidad;                                
                            }                            
                        }
                        txtStock.Text = (a.nustockactual - val).ToString();
                        txtDescripcion.Text = a.chnombrecompuesto;
                        txtIdproducto.Text = a.p_inidproducto.ToString();
                        txtImporte.Text = "0.000";
                        txtPreUnit.Text = a.nuprecio.ToString();
                        txtMedida.Text = a.chunidadmedidaproducto;
                        cargarData(0, a.p_inidproducto);
                        ckbSerie.Checked = a.req_serie;
                    }
                    else
                    {
                        txtDescripcion.Text = a.chnombrecompuesto;
                        txtIdproducto.Text = a.p_inidproducto.ToString();
                        txtImporte.Text = "0.00";
                        txtPreUnit.Text = a.nuprecio.ToString();
                        txtStock.Text = a.nustockactual.ToString(); ;
                        txtMedida.Text = a.chunidadmedidaproducto;
                        cargarData(0, a.p_inidproducto);
                        ckbSerie.Checked = a.req_serie;
                    }
                    
                }
            }else
            {
                txtDescripcion.Text = "";
            }
        }
       
        public void cargarData(int registro, int parametro)
        {
            List<productoparaventa> listado = productoNE.ListaProductosVentaParametro(parametro);
            if (listado != null)
            {
                dgvListaProdSeries.DataSource = listado;
            }
            else
            {
                dgvListaProdSeries.ReadOnly = true;
            }   
        }
        public void ejecutar(int dato)
        {
            cargarData(0, 0);
            foreach (DataGridViewRow Row in dgvListaProdSeries.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaProdSeries.CurrentCell = dgvListaProdSeries.Rows[puntero].Cells[1];
                    return;
                }
            }
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
                desc1 = decimal.Round(decimal.Parse(txtPreUnit.Text));
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text));
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text));
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = (cantidad * (preciounitario * (desc1 / 100) * (desc2 / 100))).ToString();
            if (cantidad > stock)
            {
                MessageBox.Show("La Cantidad Ingresada Supera el Stock Actual", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.Text = "0";
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
                desc1 = decimal.Round(decimal.Parse(txtPreUnit.Text));
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text));
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text));
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = (cantidad * (preciounitario * (desc1 / 100) * (desc2 / 100))).ToString();
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
                desc1 = decimal.Round(decimal.Parse(txtPreUnit.Text));
            }
            if (txtDesc1.Text.Length > 0)
            {
                desc1 = decimal.Round(decimal.Parse(txtDesc1.Text));
            }
            if (txtDesc2.Text.Length > 0)
            {
                desc2 = decimal.Round(decimal.Parse(txtDesc2.Text));
            }
            if (txtCant.Text.Length > 0)
            {
                cantidad = int.Parse(txtCant.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = (cantidad * (preciounitario * (desc1 / 100) * (desc2 / 100))).ToString();
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
            if (Validar())
            {
                ListaDetalleG = new List<pedidodetalle>();
                PedidoG = new pedidodetalle();
                if (ckbSerie.Checked)
                {
                    FlatG = ckbSerie.Checked;
                    
                    for (int i = 0; i < dgvListaProdSeries.RowCount; i++)
                    {
                        if (bool.Parse(dgvListaProdSeries.Rows[i].Cells["REQSERIE"].Value.ToString()))
                        {
                            PedidoG = new pedidodetalle();
                            PedidoG.p_inidproducto = int.Parse(txtIdproducto.Text);
                            PedidoG.chcodigoproducto = txtCodigo.Text;
                            PedidoG.chnombrecompuesto = txtDescripcion.Text;
                            PedidoG.nustock = int.Parse(txtStock.Text);
                            PedidoG.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                            PedidoG.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                            PedidoG.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                            PedidoG.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                            PedidoG.nuimportesubtotal = decimal.Parse(txtPrecioVenta.Text) * 1;
                            PedidoG.nucantidad = decimal.Parse(txtCant.Text);
                            PedidoG.p_inidserie = int.Parse(dgvListaProdSeries.Rows[i].Cells["IDSERIE"].Value.ToString());
                            PedidoG.chserie = dgvListaProdSeries.Rows[i].Cells["CHSERIE"].Value.ToString();
                            ListaDetalleG.Add(PedidoG);
                        }
                    }
                }
                else
                {
                    FlatG = ckbSerie.Checked;
                    //EL PRODUCTO NO REQUIERE DE SERIES
                    
                    PedidoG.p_inidproducto = int.Parse(txtIdproducto.Text);
                    PedidoG.chcodigoproducto = txtCodigo.Text;
                    PedidoG.chnombrecompuesto = txtDescripcion.Text;
                    PedidoG.nustock = int.Parse(txtStock.Text);
                    PedidoG.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                    PedidoG.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                    PedidoG.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                    PedidoG.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                    PedidoG.nuimportesubtotal = decimal.Parse(txtImporte.Text);
                    PedidoG.nucantidad = decimal.Parse(txtCant.Text);
                }
                PasadoDetalle(ListaDetalleG, PedidoG,FlatG);
            }
            else
            {
                return;
            }

            this.Dispose();
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
                    }else
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
            }else
            {
                MessageBox.Show("Ingrese un Codigo Válido", "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //MessageBox.Show("Ingrese un Codigo Válido", "MENSAJE DE SISTEMA");
                //txtCodigo.BackColor = Color.Red;
                txtCodigo.Focus();
            }

            return flatvalidar;

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            

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
            if (txtPrecioVenta.Text.Length >0 && txtCant.Text.Length > 0)
            {
                precioventa = decimal.Parse(txtPrecioVenta.Text);
                cantidad = decimal.Round(decimal.Parse(txtCant.Text));
            }
            txtImporte.Text = (precioventa*cantidad).ToString();
        }
    }
}
