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
    public partial class frmConsVentasPrincipal : Form
    {
        public frmConsVentasPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmConsVentasDetalle f = new frmConsVentasDetalle();
            f.ShowDialog();
        }

        private void frmConsVentasPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0, "");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
                CargarTabla(pedidoNE.RegistroVentasListar());
            }
            else
            {
                List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
                CargarTabla(pedidoNE.RegistroVentasListarParametro(parametro));
            }
        }
        string codigocliente, nombrecliente;
        public void CargarTabla(List<RegistroVenta> RegistroVenta)
        {
            dgvListaRegistros.Rows.Clear();
            foreach (RegistroVenta Registros in RegistroVenta)
            {
                DevolverDatosCliente(Registros.p_inidcliente);
                dgvListaRegistros.Rows.Add(Registros.p_inidregistroventa, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, codigocliente, nombrecliente, Registros.chfechadoc, Registros.nuimportetotvta, DevolverEstado(Registros.chestadopago));              

            }
        }
        private string DevolverNombrecomprobante(int codigo)
        {
            return tipodocumentoNE.documentoVentaBusquedacodigo(codigo).chacrominodocumento;         
        }
        private string DevolverEstado(int codigo)
        {
            string Descri="";
            switch (codigo)
            {
                case 0: { Descri = "PENDI"; } break;
                case 1: { Descri = "CANCE"; } break;
                case 2: { Descri = "CANJE"; } break;
                case 3: { Descri = "CANJE"; } break;
            }
            return Descri;
        }
        private void DevolverDatosCliente(int codigo)
        {
            nombrecliente = clienteNE.ClienteBusquedaCodigoSecundario(clienteNE.ClienteBusquedaCodigo(codigo).chcodigocliente).razon;
            codigocliente = clienteNE.ClienteBusquedaCodigoSecundario(clienteNE.ClienteBusquedaCodigo(codigo).chcodigocliente).chcodigocliente;
        }

        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaRegistros.Rows)
            {
                int valor = (int)Row.Cells["a"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaRegistros.CurrentCell = dgvListaRegistros.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }
    }
}
