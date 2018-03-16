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
    public partial class frmProcNotaCrediDevModificar : Form
    {
        public delegate void PasarDetalleModificado(pedidodetallecontenido PedidoContenido, int orden);
        public event PasarDetalleModificado PasadoDetalle;
        internal pedidodetallecontenido PedidoDetalleContenido;
        internal int ordenG;
        public frmProcNotaCrediDevModificar()
        {
            InitializeComponent();
        }

        private void frmProcNotaCrediDevModificar_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            CargarDatosCabecera();
        }
        private void CargarDatosCabecera()
        {
            txtCodigo.Text = PedidoDetalleContenido.productoparaventa.chcodigoproducto;
            txtDescripcion.Text = PedidoDetalleContenido.productoparaventa.chnombrecompuesto;
            txtDesc1.Text = string.Format("{0:0,0.00}", PedidoDetalleContenido.pedidodetalle.nuporcentajedesc1.ToString("N2")); 
            txtDesc2.Text = string.Format("{0:0,0.00}", PedidoDetalleContenido.pedidodetalle.nuporcentajedesc2.ToString("N2"));
            txtPreUnit.Text = string.Format("{0:0,0.00}", PedidoDetalleContenido.pedidodetalle.nuprecioproducto.ToString("N2"));
            txtStock.Text = PedidoDetalleContenido.pedidodetalle.nucantidad.ToString();
            txtCant.Text = PedidoDetalleContenido.pedidodetalle.nucantidad.ToString();
            txtMedida.Text = PedidoDetalleContenido.productoparaventa.chunidadmedidaproducto;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            PedidoDetalleContenido.pedidodetalle.nucantidad = int.Parse(txtCant.Text);
            PedidoDetalleContenido.pedidodetalle.nuimportesubtotal = decimal.Parse(txtImporte.Text);
            PasadoDetalle(PedidoDetalleContenido, ordenG);
            this.Dispose();
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
                cantidad = Decimal.ToInt32(decimal.Parse(txtCant.Text));
            }
            if (txtStock.Text.Length > 0)
            {
                stock = int.Parse(txtStock.Text);
            }
            txtPrecioVenta.Text = "";
            txtPrecioVenta.Text = string.Format("{0:0,0.00}", (preciounitario * (1 - (desc1 / 100)) * (1 - (desc2 / 100))).ToString("N2")); 

            if (cantidad > stock)
            {
                MessageBox.Show("La Cantidad Ingresada Supera el Stock Actual", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCant.Focus();
                txtCant.Text = "";
                return;
            }
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
            txtImporte.Text = string.Format("{0:0,0.00}", (precioventa * cantidad).ToString("N2"));
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txtCant_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }
    }
}
