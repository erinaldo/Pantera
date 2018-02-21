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
    public partial class frmProcIngresoValesAnadir : Form
    {
        internal valecabecera tmpSerie;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmProcIngresoValesAnadir(string vBoton)
        {
            InitializeComponent();

            this.vBoton = vBoton;
        }
        string vBoton;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if (sesion.movprodaccion != null)
            {
                sesion.movprodaccion.Clear();
            }

        }

        private void frmProcIngresoValesAnadir_Load(object sender, EventArgs e)
        {
            txtejercicio.Text = "2018";
            txtperiodo.Text = "01";
            txtAlmacen.Text = "PRINCIPAL";
            txtClase.Text = "INGRESO";
            int vale = valeNE.generarcorrelativo() + 1;
            string correlativo = "00000000" + vale;
            int cfin = correlativo.Length - 1;
            int cini = correlativo.Length - 8;
            txtNroVale.Text = "" + correlativo.Substring(cini, cfin);
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cboTipoMov.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(14);
            cboTipoMov.ValueMember = "idmaestrodetalle";
            cboTipoMov.DisplayMember = "nombreitem";
            mskfechareg.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            txtTotal.Text = "0.00";
            cboTipoMov.Focus();

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            string vboton = "A";
            frmProcSeriesAnadir f = new frmProcSeriesAnadir(vboton);
            f.p_inidproducto = dgvListaValeDetalle.RowCount + 1;
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarTabla();
            }
        }
        public void cargarData(int registro)
        {
            List<seriebuscada> listado = serieNE.serieListar();
            dgvListaValeDetalle.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvListaValeDetalle.Rows)
            {
                int valor = (int)Row.Cells["IDSERIE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaValeDetalle.CurrentCell = dgvListaValeDetalle.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoSerie = 0;
                int codigoCabecera = 0;
                int codigoDetalle = 0;
                //validar Campos
                if (true)
                {
                    bool flat = false;
                    movimientoproductoc registrosCabecera = new movimientoproductoc();
                    //registrosCabecera.p_inidvalecebecera = 0;
                    registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen ;
                    registrosCabecera.p_inidclase = 1;
                    registrosCabecera.p_inidcorrevale = txtNroVale.Text;
                    registrosCabecera.chvalefecha = mskfechareg.Text;
                    registrosCabecera.p_inidtipomoneda = (int)cboMoneda.SelectedValue;
                    registrosCabecera.p_inidproveedor = int.Parse(txtidprov.Text);
                    registrosCabecera.chguiaremision = txtGuiaRem.Text;
                    registrosCabecera.chboletafactura = txtFacBol.Text;
                    registrosCabecera.p_inidtipomoviemiento = (int)cboTipoMov.SelectedValue;
                    registrosCabecera.chobservacion = txtobs.Text;
                    registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    registrosCabecera.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                    registrosCabecera.estado = true;
                    registrosCabecera.p_inidmovimiento = 14;
                    //ingreso de cabecera
                    codigoCabecera = movimientosNE.MovimientoProductoCabeceraIngresar(registrosCabecera);
                   

                    if (codigoCabecera <= 0)
                    {

                        MessageBox.Show("error Cabecera", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        List<movimientoproductoaccion> ListaMovimeintoDetalle = sesion.movprodaccion;
                        foreach (movimientoproductoaccion RegistrosMovimeintoDetalle in ListaMovimeintoDetalle)
                        {
                            movimientoproductod registrosDetalle = new movimientoproductod();
                            //registrosDetalle.p_inidvaledetalle = 0;
                            registrosDetalle.p_inidvalecebecera = codigoCabecera;
                            registrosDetalle.p_inidproducto = RegistrosMovimeintoDetalle.valedet.p_inidproducto;
                            registrosDetalle.nucantidad = RegistrosMovimeintoDetalle.valedet.nucantidad;
                            registrosDetalle.nucosto = RegistrosMovimeintoDetalle.valedet.nucosto;
                            registrosDetalle.nutotal = RegistrosMovimeintoDetalle.valedet.nutotal;
                            codigoDetalle = movimientosNE.MovimientoProductoDetalleIngresar(registrosDetalle);
                            int entero = almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, RegistrosMovimeintoDetalle.valedet.nucantidad);
                            if (codigoDetalle <= 0 && entero <= 0)
                            {

                                MessageBox.Show("Error Detalle", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                List<serie> ListaSeries = RegistrosMovimeintoDetalle.listaserie;
                                if (ListaSeries != null)
                                {
                                    foreach (serie registrosSerie in ListaSeries)
                                    {
                                        serie Registros = new serie();
                                        //Registros.p_inidserie = 0;
                                        Registros.chcodigoserie = registrosSerie.chcodigoserie;
                                        Registros.estado = true;
                                        Registros.p_inidproducto = RegistrosMovimeintoDetalle.valedet.p_inidproducto;
                                        Registros.chadicional = "";
                                        Registros.chfecha = mskfechareg.Text;
                                        Registros.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                                        Registros.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                                        Registros.p_inidmovimientod = codigoDetalle;
                                        Registros.p_inidpedidod = 0;
                                        codigoSerie = serieNE.seriesIngresar(Registros);
                                        if (codigoSerie <= 0)
                                        {

                                            MessageBox.Show("Error Serie", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                            return;
                                        }
                                        else
                                        {
                                            flat = true;
                                        }
                                    }
                                }else
                                {
                                    flat = true;
                                }
                            }
                            
                        }
                        if (!flat)
                        {
                            pasado(codigoCabecera);
                        }
                    }
                    
                }else
                {
                    MessageBox.Show("Validacion nula", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    return;
                }
            }else
            {
                return;
            }
            if (sesion.movprodaccion != null)
            {
                sesion.movprodaccion.Clear();
            }
            this.Dispose();           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioModificar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void cargarFormularioModificar()
        {
            if (dgvListaValeDetalle.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmProcSeriesAnadir f = new frmProcSeriesAnadir(vBoton);
            // f.pasado += new frmProcSeriesAnadir.pasar(ejecutar);            
            f.p_inidproducto = (int)dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value;
            //MessageBox.Show(dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarTabla();
            }
        }
        private void CargarTabla()
        {
            decimal suma = 0;
            List<movimientoproductoaccion> listaMovi = sesion.movprodaccion;
            // valedetalle obj = sesion.valedetalles;
            if (listaMovi != null)
            {
                dgvListaValeDetalle.Rows.Clear();
                foreach (movimientoproductoaccion registrosMovi in listaMovi)
                {
                    dgvListaValeDetalle.Rows.Add(registrosMovi.valedet.p_inidvaledetalle,
                        registrosMovi.valedet.p_inidproducto,
                        registrosMovi.valedet.chcodigoproducto,
                        registrosMovi.valedet.nucantidad,
                        registrosMovi.valedet.chcodigoserie,
                        registrosMovi.valedet.chnombrecompuesto,
                        registrosMovi.valedet.nucosto,
                        registrosMovi.valedet.nutotal);
                    suma += registrosMovi.valedet.nutotal;
                }
                txtTotal.Text = decimal.Round(suma, 2).ToString();
            }
        }

       
       

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtRuc.Text;
            BuscaProveedor(parametro);
        }

        private void txtRuc_DoubleClick(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBusquedaProveedor);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmBusquedaProveedor f = new frmBusquedaProveedor();
            f.pasadoproveedor += new frmBusquedaProveedor.pasarproveedor(PonerProveedor);
            f.MdiParent = this.MdiParent;
            f.Show();
        }
        private void PonerProveedor(string ruc)
        {
            txtRuc.Text = ruc;
        }
        private void BuscaProveedor(string ruc)
        {
            proveedor registro = proveedorNE.ProveedorBusquedaRuc(ruc);
            if (registro != null)
            {
                txtProvnombre.Text = registro.razon;
                txtidprov.Text = registro.p_inidcodigoclie.ToString();
            }else
            {
                txtProvnombre.Text = "";
                txtidprov.Text = "";

            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}
