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
    public partial class frmConsEstadoCuentaDetalle : Form
    {
        internal int p_inidclienteG;
        internal string codigoclienteG;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmConsEstadoCuentaDetalle()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmConsEstadoCuentaDetalle_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            DevolverDatosCliente();
            cargarData();
        }
        public void cargarData()
        {
            List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
            CargarTabla(pedidoNE.BuscarRegistroVentasCliente(p_inidclienteG));
            
        }
        public void DevolverDatosCliente()
        {
            clientebusqueda ClienteRegistros = clienteNE.ClienteBusquedaCodigoSecundario(codigoclienteG);
            txtCodigo.Text = ClienteRegistros.chcodigocliente;
            txtruc.Text = ClienteRegistros.nrodocumento;
            lblTipdoc.Text = ClienteRegistros.tipodocu;
            txtRazon.Text = ClienteRegistros.razon;

        }
        public void CargarTabla(List<RegistroVenta> RegistroVenta)
        {
            dgvListaRegistros.Rows.Clear();
            foreach (RegistroVenta Registros in RegistroVenta)
            {
                if (Registros.p_inidtipodocu != 4)
                {
                    if (Registros.p_inidtipodocu != 5)
                    {
                        decimal montoencontra = pedidoNE.BuscarMontoEncontra(Registros.p_inidtipodocu, Registros.chcodigodocu, Registros.p_inidcliente);
                       dgvListaRegistros.Rows.Add(Registros.p_inidregistroventa, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, Registros.chfechadoc, Registros.nuimportetotvta, montoencontra, Registros.nuimportetotvta - montoencontra, DevolverEstado(Registros.chestadopago));
                        
                    }  
                }
            }
        }
        private string DevolverEstado(int codigo)
        {
            string Descri = "";
            switch (codigo)
            {
                case 0: { Descri = "PENDI"; } break;
                case 1: { Descri = "CANCE"; } break;
                case 2: { Descri = "CANJE"; } break;
                case 3: { Descri = "CANJE"; } break;
            }
            return Descri;
        }
        private string DevolverNombrecomprobante(int codigo)
        {
            tipodocumento tipodocumentos = tipodocumentoNE.documentoVentaBusquedacodigo(codigo);
            return tipodocumentos.chacrominodocumento;
        }
    }
}
