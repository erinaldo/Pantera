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
            cargarData(0,"");
            

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
            dgvPedidos.Rows.Clear();
            int countfile = 0;
            foreach (pedidocabecera registros in Listado)
            {
                string razon="";
                string documento = "";
                Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(registros.p_inidcliente);
                if (Registroscliente.p_inidjurinat == 1)
                {
                    Mclientejuridico    ClienteJuridicoG = clienteNE.ClienteJuridicoBusquedaCodigo(Registroscliente.p_inidcliente);
                    empresas EmpresaG = empresaNE.EmpresaBusquedaCodigo(ClienteJuridicoG.p_inidempresa);
                    razon = EmpresaG.chrazonsocial;
                }
                else
                {

                    Mclientenatural ClienteNaturalG = clienteNE.ClienteNaturalBusquedaCodigo(Registroscliente.p_inidcliente);
                    persona PersonaG = personaNE.PersonaBusquedaCodigo(ClienteNaturalG.p_inidpersona);
                    razon = PersonaG.chapellidopaterno+""+ PersonaG.chapellidomaterno+", "+ PersonaG.chnombres;
                }
                maestrodetalle madet = maestrodetalleNE.BuscarPorCodigoDetalle(registros.p_inidsituacionpedido);
                tipodocumento detalle = tipodocumentoNE.documentoVentaBusquedacodigo(registros.p_inidtipodocumento);
                
                dgvPedidos.Rows.Add(registros.p_inidpedidocabecera, registros.chcodigopedido, registros.chfechapedido, razon, detalle.chnombredocumento, registros.nutotalventamonnacional, madet.nombreitem);
                if (madet.nombreitem == "BAJA")
                {
                    dgvPedidos.Rows[countfile].DefaultCellStyle.ForeColor = Color.Red;
                }
                countfile++;
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
                    f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
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

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0,parametro);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    ConectaFormSecundario(vBoton);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    ConectaFormSecundario(vBoton);
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
        private void ConectaFormSecundario(string vBoton)
        {
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
                f.CodigoPedidoCabecera = (int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "BAJA")
                {
                    MessageBox.Show("El pedido está anulado", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El pedido ya tiene lo comprobantes generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                DialogResult result = MessageBox.Show("¿Está seguro de anular el pedido N° "+ dgvPedidos.CurrentRow.Cells["CHCORRELATIVO"].Value.ToString() + " ?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //MessageBox.Show("Registro anulado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                  int codigo =  serieNE.CabeceraAnular((int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value);
                    ejecutar(codigo);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "BAJA")
                {
                    MessageBox.Show("El pedido ya está anulado", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El pedido ya tiene lo comprobantes generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }
    }
}
