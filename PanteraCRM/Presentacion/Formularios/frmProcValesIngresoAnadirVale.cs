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
        internal int codigoMovimiento;
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
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cboTipoMov.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(14);
            cboTipoMov.ValueMember = "idmaestrodetalle";
            cboTipoMov.DisplayMember = "nombreitem";


            if (this.vBoton == "A")
            {
                txtejercicio.Text = "2018";
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                int vale = valeNE.CorrelativoMovimientoIngreso(sesion.SessionGlobal.p_inidalmacen) + 1;
                string correlativo = "0000000000" + vale;
                int cfin = correlativo.Length - 1;
                int cini = correlativo.Length - 10;
                txtNroVale.Text = "" + correlativo.Substring(cini, cfin);
                mskfechareg.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                txtTotal.Text = "0.00";
                cboTipoMov.Focus();
            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR MOVIMIENTO";
                txtejercicio.Text = "2018";
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                txtNroVale.Text = "" ;                
                mskfechareg.Text = "";
                txtTotal.Text = "0.00";
                cboTipoMov.Focus();  
                List<movimientoproductoaccion> ListaMovimiento = new List<movimientoproductoaccion>() ;
                movimientoproductoaccion RegistrosMoviento = new movimientoproductoaccion();
                movimientoproductoc RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);
                List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidmovimiento);
                foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                {
                    valedetalle RegistrosDetalle = null;
                    List<serie> ListaSeries = null;
                    RegistrosDetalle = registrosMovimientoD;
                    ListaSeries = serieNE.SerieBusquedaMovimiento(registrosMovimientoD.p_inidvaledetalle);
                    RegistrosMoviento.valedet = RegistrosDetalle;
                    RegistrosMoviento.listaserie= ListaSeries;
                    ListaMovimiento.Add(RegistrosMoviento);
                }
                sesion.movprodaccion = ListaMovimiento;
                CargarTabla();
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER MOVIMIENTO";
                txtejercicio.Text = "2018";
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                txtNroVale.Text = "";
                mskfechareg.Text = "";
                txtTotal.Text = "0.00";
                cboTipoMov.Focus();
                btnAnadir.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGrabar.Enabled = false;
            }



        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmProcSeriesAnadir f = new frmProcSeriesAnadir(vBoton);
                    f.p_inidproducto = dgvListaValeDetalle.RowCount + 1;
                    DialogResult result = f.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        CargarTabla();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }            
        }
      

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "G";

                if (basicas.validarAcceso(vBoton))
                {
                    GrabarMovimiento();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
            
            this.Dispose();           
        }
        private void GrabarMovimiento()
        {
            if (ValdiarCabeceramovimiento())
            {
                int codigoSerie = 0;
                int codigoCabecera = 0;
                int codigoDetalle = 0;
                //validar Campos
                DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool flat = false;
                    movimientoproductoc registrosCabecera = new movimientoproductoc();
                    //registrosCabecera.p_inidvalecebecera = 0;
                    registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
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
                    int gorrelativo = valeNE.GenerarCorrelativoMovimientoIngreso(sesion.SessionGlobal.p_inidalmacen);

                    if (codigoCabecera <= 0 && gorrelativo <= 0)
                    {

                        MessageBox.Show("error Cabecera", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        List<movimientoproductoaccion> ListaMovimeintoDetalle = sesion.movprodaccion;
                        foreach (movimientoproductoaccion RegistrosMovimeintoDetalle in ListaMovimeintoDetalle)
                        {

                            if (RegistrosMovimeintoDetalle.valedet.estado == true)
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
                                    }
                                    else
                                    {
                                        flat = true;
                                    }
                                }
                            }
                        }
                        if (flat)
                        {
                            pasado(codigoCabecera);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            if (sesion.movprodaccion != null)
            {
                sesion.movprodaccion.Clear();
                dgvListaValeDetalle.Rows.Clear();
            }
        }
        private bool ValdiarCabeceramovimiento()
        {
            bool flat = false;
            if (txtidprov.Text.Length > 0)
            {
                if (sesion.movprodaccion != null)
                {
                    int i = 0;
                    List<movimientoproductoaccion> lita = sesion.movprodaccion;
                    foreach (movimientoproductoaccion oj in lita)
                    {
                        if (oj.valedet.estado == true)
                        {
                            i++;
                        }
                    }
                    if (i!=0)
                    {
                        flat = true;
                    }                    
                }
                else
                {
                    MessageBox.Show("Lista Vacia", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingresar proveedor", "Mensaje de Sistema", MessageBoxButtons.OK);
            }
            return flat;
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
        private void cargarFormularioEliminar()
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
            List<movimientoproductoaccion> listaMovi = sesion.movprodaccion;
            
            if (listaMovi != null)
            {
                foreach (movimientoproductoaccion registrosMovi in listaMovi)
                {                    
                    if (registrosMovi.valedet.p_inidvaledetalle == (int)dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value)
                    {
                        //registrosMovi.valedet.p_inidvaledetalle = 0;
                        registrosMovi.valedet.estado = false;
                    }
                }
            }
            CargarTabla();
            
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
                    if (registrosMovi.valedet.estado == true)
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

        private void brnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "E";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioEliminar();
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
                    cargarFormularioModificar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
