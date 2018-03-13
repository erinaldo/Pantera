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
    public partial class frmProcKardexProductoDetalle : Form
    {

        internal productobuscado ProductoBuscado;
        public frmProcKardexProductoDetalle()
        {
            InitializeComponent();
        }
        
        private void frmProcKardexProductoDetalle_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;            
            CargarDatosTabla();
        }
        private void CargarDatosTabla()
        {
            txtAlamacen.Text = sesion.SessionGlobal.chalamacen;
            txtCodigo.Text = ProductoBuscado.chcodigoproducto;
            txtDescrip.Text = ProductoBuscado.chnombrecompuesto;
            txtUnidad.Text = ProductoBuscado.chunidadmedidaproducto;
            List<kardexdetalle> ListaKardex = movimientosNE.ListarKardexBusquedaCodigo(ProductoBuscado.p_inidproducto);
            decimal saldo = 0;            
            foreach (kardexdetalle RegistrosKardex in ListaKardex)
            {
                decimal ingreso = 0;
                decimal salida = 0;
                if (RegistrosKardex.p_inidmovimiento == 14) {/*INGRESO*/ ingreso = RegistrosKardex.nucantidad; saldo += ingreso; } else {/*SALIDA*/ salida = RegistrosKardex.nucantidad; saldo -= salida; }
               
                dgvListaKardex.Rows.Add(
                    RegistrosKardex.chfechamovi,
                    maestrodetalleNE.BuscarPorCodigoDetalle(RegistrosKardex.p_inidtipomovimiento).nombreitem,
                    RegistrosKardex.chcorrelativo,
                    ingreso,
                    salida,
                    saldo,
                    RegistrosKardex.chreftip1,
                    RegistrosKardex.chrefnombre1, 
                    RegistrosKardex.chreftip2,
                    RegistrosKardex.chrefnombre2,
                    RegistrosKardex.chreftip3,
                    RegistrosKardex.chrefnombre3,
                    RegistrosKardex.chreftip4,
                    RegistrosKardex.chrefnombre4
                    );

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
