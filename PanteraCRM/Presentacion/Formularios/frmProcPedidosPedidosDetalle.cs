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
    public partial class frmProcPedidosPedidosDetalle : Form
    {
        public pedidodetalle tmbpedidodetalle;
        public pedidodetalle tmppedidodetalle;
        public List<pedidodetalle> tmplistadovalidar;
        public List<pedidodetalle> tmplistado;
        public bool reqserie ;
        public frmProcPedidosPedidosDetalle()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void frmProcPedidosPedidosDetalle_Load(object sender, EventArgs e)
        {
            
            txtDesc1.Text = "0.00";
            txtDesc2.Text = "0.00";
            txtPrecioVenta.Text = "0.00";
            txtImporte .Text = "0.00";
            txtPreUnit.Text = "0.00";
            txtStock.Text = "0";
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
                    if (tmplistadovalidar != null)
                    {
                        decimal val = 0;
                        foreach (pedidodetalle obj in tmplistadovalidar)
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
            int valor1 = 0;
            decimal valor2 = 0;
            decimal valor3 = 0;
            decimal valor4 = 0;
            decimal valor5 = 0;
            decimal valor6 = 0;
            if (txtCant.Text.Length > 0)
            {
                valor1 = int.Parse(txtCant.Text);
            }
            if (txtPreUnit.Text.Length > 0)
            {
                valor2 = decimal.Parse(txtPreUnit.Text);
            }
            if (txtDesc1.Text.Length > 0)
            {
                valor3 = decimal.Parse(txtDesc1.Text);
            }
            if (txtDesc2.Text.Length > 0)
            {
                valor4 = decimal.Parse(txtDesc2.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                valor5 = decimal.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = decimal.Round(valor2 - valor3 - valor4, 2).ToString();

            if (txtPrecioVenta.Text.Length > 0)
            {
                valor6 = decimal.Parse(txtPrecioVenta.Text);
            }
            txtImporte.Text = decimal.Round(valor1 * valor6, 2).ToString();

            if (valor1 > valor5)
            {
                MessageBox.Show("La Cantidad Ingresada Supera el Stock Actual", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.Text = "0";
                return;
            }

        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {
            int valor1 = 0;
            decimal valor2 = 0;
            decimal valor3 = 0;
            decimal valor4 = 0;
            decimal valor5 = 0;
            decimal valor6 = 0;
            if (txtCant.Text.Length > 0)
            {
                valor1 = int.Parse(txtCant.Text);
            }
            if (txtPreUnit.Text.Length > 0)
            {
                valor2 = decimal.Parse(txtPreUnit.Text);
            }
            if (txtDesc1.Text.Length > 0)
            {
                valor3 = decimal.Parse(txtDesc1.Text);
            }
            if (txtDesc2.Text.Length > 0)
            {
                valor4 = decimal.Parse(txtDesc2.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                valor5 = decimal.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = decimal.Round(valor2 - valor3 - valor4, 2).ToString();

            if (txtPrecioVenta.Text.Length > 0)
            {
                valor6 = decimal.Parse(txtPrecioVenta.Text);
            }
            txtImporte.Text = decimal.Round(valor1 * valor6, 2).ToString();

        }

        private void txtDesc2_TextChanged(object sender, EventArgs e)
        {
            int valor1 = 0;
            decimal valor2 = 0;
            decimal valor3 = 0;
            decimal valor4 = 0;
            decimal valor5 = 0;
            decimal valor6 = 0;
            if (txtCant.Text.Length > 0)
            {
                valor1 = int.Parse(txtCant.Text);
            }
            if (txtPreUnit.Text.Length > 0)
            {
                valor2 = decimal.Parse(txtPreUnit.Text);
            }
            if (txtDesc1.Text.Length > 0)
            {
                valor3 = decimal.Parse(txtDesc1.Text);
            }
            if (txtDesc2.Text.Length > 0)
            {
                valor4 = decimal.Parse(txtDesc2.Text);
            }
            if (txtStock.Text.Length > 0)
            {
                valor5 = decimal.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = decimal.Round(valor2 - valor3 - valor4, 2).ToString();

            if (txtPrecioVenta.Text.Length > 0)
            {
                valor6 = decimal.Parse(txtPrecioVenta.Text);
            }
            txtImporte.Text = decimal.Round(valor1 * valor6, 2).ToString();
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
                    e.Handled = true;
                    return;
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
                    e.Handled = true;
                    return;
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
                btnValidar.PerformClick();

            }else
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
                            btnValidar.Enabled = true;
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
                        btnValidar.Enabled = true;
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
            if (ckbSerie.Checked)
            {
                reqserie = ckbSerie.Checked;
                tmplistado = new List<pedidodetalle>();
                for (int i = 0; i < dgvListaProdSeries.RowCount; i++)                {
                    
                    //
                    // MessageBox.Show("Ingrese un Codigo Válido" + dgvListaProdSeries.Rows[i].Cells["REQSERIE"].Value.ToString(), "MENSAJE DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (bool.Parse(dgvListaProdSeries.Rows[i].Cells["REQSERIE"].Value.ToString()))
                    {
                        tmppedidodetalle = new pedidodetalle();
                        tmppedidodetalle.p_inidproducto = int.Parse(txtIdproducto.Text);
                        tmppedidodetalle.chcodigoproducto = txtCodigo.Text;
                        tmppedidodetalle.chnombrecompuesto = txtDescripcion.Text;
                        tmppedidodetalle.nustock = int.Parse(txtStock.Text);
                        tmppedidodetalle.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                        tmppedidodetalle.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                        tmppedidodetalle.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                        tmppedidodetalle.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                        tmppedidodetalle.nuimportesubtotal = decimal.Parse(txtImporte.Text);
                        tmppedidodetalle.nucantidad = decimal.Parse(txtCant.Text);
                        tmppedidodetalle.p_inidserie = int.Parse(dgvListaProdSeries.Rows[i].Cells["IDSERIE"].Value.ToString());
                        tmppedidodetalle.chserie = dgvListaProdSeries.Rows[i].Cells["CHSERIE"].Value.ToString();
                        tmplistado.Add(tmppedidodetalle);
                    }
                }
            }
            else
            {
                reqserie = ckbSerie.Checked;
                //EL PRODUCTO NO REQUIERE DE SERIES
                tmbpedidodetalle = new pedidodetalle();
                tmbpedidodetalle.p_inidproducto = int.Parse(txtIdproducto.Text);
                tmbpedidodetalle.chcodigoproducto = txtCodigo.Text;
                tmbpedidodetalle.chnombrecompuesto = txtDescripcion.Text;
                tmbpedidodetalle.nustock = int.Parse(txtStock.Text);
                tmbpedidodetalle.nuprecioproducto = decimal.Parse(txtPreUnit.Text);
                tmbpedidodetalle.nuprecioventa = decimal.Parse(txtPrecioVenta.Text);
                tmbpedidodetalle.nuporcentajedesc1 = decimal.Parse(txtDesc1.Text);
                tmbpedidodetalle.nuporcentajedesc2 = decimal.Parse(txtDesc2.Text);
                tmbpedidodetalle.nuimportesubtotal = decimal.Parse(txtImporte.Text);
                tmbpedidodetalle.nucantidad = decimal.Parse(txtCant.Text);



            }

        }
    }
}
