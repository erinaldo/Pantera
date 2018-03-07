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
    public partial class frmProcPedidosPrincipal : Form
    {
        public frmProcPedidosPrincipal()
        {
            InitializeComponent();
        }


        string vBoton;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcPedidosPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            //cargarData(0,"");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<pedidocabecera> listado = pedidoNE.PedidoCabeceraListar();
                CargarTabla(listado);
                //dgvPedidos.DataSource = listado;
            }
            else
            {
                List<pedidocabecera> listado = pedidoNE.PedidoCabeceraBusquedaParametro(parametro);
                CargarTabla(listado);
                //dgvPedidos.DataSource = listado;
            }

        }
        private void CargarTabla(List<pedidocabecera> Listado)
        {
            foreach (pedidocabecera registros in Listado)
            {
                //Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo();
                //dgvPedidos.Rows.Add(registros.p_inidpedidocabecera,,,,,,);
            }
            
        }

        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvPedidos.Rows)
            {
                int valor = (int)Row.Cells["IDPEDIDO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvPedidos.CurrentCell = dgvPedidos.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                    //f.pasado += new frmManClienteAnadir.pasar(ejecutar);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
