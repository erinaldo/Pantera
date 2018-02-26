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
        internal movimientoproductoc RegistrosMovimientoC;
        
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
                
                
                
                RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);
                txtejercicio.Text = "2018";
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                txtRuc.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);
                cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
                cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
                txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
                mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
                txtobs.Text = RegistrosMovimientoC.chobservacion;
                txtFacBol.Text = RegistrosMovimientoC.chboletafactura;
                txtGuiaRem.Text = RegistrosMovimientoC.chguiaremision;
                cboTipoMov.Focus();


                /**/                
                List<movimientoproductoaccion> ListaMovimiento = new List<movimientoproductoaccion>();
                List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidvalecebecera);
                int i = 1;
                foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                {
                    movimientoproductoaccion RegistrosMoviento = new movimientoproductoaccion();
                    valedetalle registrosValeDet = new valedetalle();
                    registrosValeDet.p_inidvaledetalle = i;
                    registrosValeDet.chnombrecompuesto = registrosMovimientoD.chnombrecompuesto.ToString();
                    registrosValeDet.chmedida = registrosMovimientoD.chmedida.ToString();
                    registrosValeDet.chcodigoproducto = registrosMovimientoD.chcodigoproducto.ToString();
                    registrosValeDet.chfecha = RegistrosMovimientoC.chvalefecha.ToString();
                    registrosValeDet.p_inidproducto = registrosMovimientoD.p_inidproducto;
                    registrosValeDet.nucantidad = registrosMovimientoD.nucantidad;
                    registrosValeDet.nucosto = registrosMovimientoD.nucosto;
                    registrosValeDet.nutotal = registrosMovimientoD.nutotal;
                    registrosValeDet.estado = registrosMovimientoD.estado;
                    
                        List<serie> ListaSerie = serieNE.SerieBusquedaMovimiento(registrosMovimientoD.p_inidvaledetalle);
                    List<serie> ListasSeries = new List<serie>();
                    //MessageBox.Show(""+registrosMovimientoD.p_inidvaledetalle, "Mensaje de Sistema", MessageBoxButtons.OK);
                    foreach (serie Registroxxxxs in ListaSerie)
                        {
                            serie registrosSerie = new serie();
                            registrosSerie.chcodigoserie = Registroxxxxs.chcodigoserie.ToString();
                            registrosSerie.estado = true;
                            registrosSerie.p_inidproducto = Registroxxxxs.p_inidproducto;
                            registrosSerie.chadicional = Registroxxxxs.chadicional.ToString();
                            registrosSerie.chfecha = Registroxxxxs.chfecha;
                            registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                            registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                        registrosSerie.chinforme = Registroxxxxs.chinforme.ToString();
                        registrosSerie.chinformeobs = Registroxxxxs.chinformeobs.ToString();
                        registrosSerie.chinformefecha = Registroxxxxs.chinformefecha;
                        registrosSerie.boexhibicion = Registroxxxxs.boexhibicion;
                        ListasSeries.Add(registrosSerie);
                        }
                    
                    RegistrosMoviento.valedet = registrosValeDet;
                    RegistrosMoviento.listaserie = ListasSeries;
                    i++;
                    ListaMovimiento.Add(RegistrosMoviento);
                }

                
                sesion.movprodaccion = ListaMovimiento;   
                CargarTabla();
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER MOVIMIENTO";
                btnAnadir.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGrabar.Enabled = false;

                RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);
                txtejercicio.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                txtRuc.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);
                cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
                cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
                txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
                mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
                txtobs.Text = RegistrosMovimientoC.chobservacion;
                txtFacBol.Text = RegistrosMovimientoC.chboletafactura;
                txtGuiaRem.Text = RegistrosMovimientoC.chguiaremision;
                cboTipoMov.Focus();
                txtRuc.ReadOnly = true;
                txtobs.ReadOnly = true;
                txtFacBol.ReadOnly = true;
                txtGuiaRem.ReadOnly = true;
                mskfechareg.ReadOnly = true;

                /**/
                List<movimientoproductoaccion> ListaMovimiento = new List<movimientoproductoaccion>();
                List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidvalecebecera);
                int i = 1;
                foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                {
                    movimientoproductoaccion RegistrosMoviento = new movimientoproductoaccion();
                    valedetalle registrosValeDet = new valedetalle();
                    registrosValeDet.p_inidvaledetalle = i;
                    registrosValeDet.chnombrecompuesto = registrosMovimientoD.chnombrecompuesto;
                    registrosValeDet.chmedida = registrosMovimientoD.chmedida;
                    registrosValeDet.chcodigoproducto = registrosMovimientoD.chcodigoproducto;
                    registrosValeDet.chfecha = registrosMovimientoD.chfecha;
                    registrosValeDet.p_inidproducto = registrosMovimientoD.p_inidproducto;
                    registrosValeDet.nucantidad = registrosMovimientoD.nucantidad;
                    registrosValeDet.nucosto = registrosMovimientoD.nucosto;
                    registrosValeDet.nutotal = registrosMovimientoD.nutotal;
                    registrosValeDet.estado = registrosMovimientoD.estado;

                    List<serie> ListaSerie = serieNE.SerieBusquedaMovimiento(registrosMovimientoD.p_inidvaledetalle);
                    List<serie> ListasSeries = new List<serie>();
                    //MessageBox.Show(""+registrosMovimientoD.p_inidvaledetalle, "Mensaje de Sistema", MessageBoxButtons.OK);
                    foreach (serie Registroxxxxs in ListaSerie)
                    {
                        serie registrosSerie = new serie();
                        registrosSerie.chcodigoserie = Registroxxxxs.chcodigoserie;
                        registrosSerie.estado = true;
                        registrosSerie.p_inidproducto = Registroxxxxs.p_inidproducto;
                        registrosSerie.chadicional = Registroxxxxs.chadicional;
                        registrosSerie.chfecha = Registroxxxxs.chfecha;
                        registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                        registrosSerie.chinforme = Registroxxxxs.chinforme;
                        registrosSerie.chinformeobs = Registroxxxxs.chinformeobs;
                        registrosSerie.chinformefecha = Registroxxxxs.chinformefecha;
                        registrosSerie.boexhibicion = Registroxxxxs.boexhibicion;
                        ListasSeries.Add(registrosSerie);
                    }

                    RegistrosMoviento.valedet = registrosValeDet;
                    RegistrosMoviento.listaserie = ListasSeries;
                    i++;
                    ListaMovimiento.Add(RegistrosMoviento);
                }


                sesion.movprodaccion = ListaMovimiento;
                CargarTabla();
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
                    f.Cargado += new frmProcSeriesAnadir.CargarTabla(CargarTabla);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    //DialogResult result = f.ShowDialog();
                    //if (result == DialogResult.OK)
                    //{
                    //    CargarTabla();
                    //}
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
                string moton2 = "G";
                if (basicas.validarAcceso(moton2))
                {
                    switch (this.vBoton)
                    {
                        case "A":
                            if (ValdiarCabeceramovimiento())
                            {
                                DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    GrabarMovimiento();
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
                            
                            break;
                        case "M":
                            if (ValdiarCabeceramovimiento())
                            {
                                DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    ModificarMovimiento();
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
                           
                            break;
                        default:
                            break;
                    }
                   
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
            
                int codigoSerie = 0;
                int codigoCabecera = 0;
                int codigoDetalle = 0;
                //validar Campos
                
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
                      
                            pasado(codigoCabecera);
                        
                    }
               
                
           
            if (sesion.movprodaccion != null)
            {
                sesion.movprodaccion.Clear();
                dgvListaValeDetalle.Rows.Clear();
            }
        }
        private void ModificarMovimiento()
        {
            int codigoSerie = 0;
            int codigoCabecera = 0;
            int codigoDetalle = 0;
            //validar Campos
            bool flat = false;
            movimientoproductoc registrosCabecera = new movimientoproductoc();
            registrosCabecera.p_inidvalecebecera = RegistrosMovimientoC.p_inidvalecebecera;
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
            //modificacion de cabecera
            codigoCabecera = movimientosNE.MovimientoProductoCabeceraModificar(registrosCabecera);
            List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidvalecebecera);
            foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
            {
                serieNE.SeriesFalsear(registrosMovimientoD.p_inidvaledetalle);
                //MessageBox.Show("error Falseo"+ registrosMovimientoD.p_inidvaledetalle, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                int cantidad = (-1) * registrosMovimientoD.nucantidad;
                almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, registrosMovimientoD.p_inidproducto, cantidad);

            }
            movimientosNE.MovimientoProductoDetalleFalsear(RegistrosMovimientoC.p_inidvalecebecera);
            List<movimientoproductoaccion> ListaMovimeintoDetalle = sesion.movprodaccion;
            foreach (movimientoproductoaccion RegistrosMovimeintoDetalle in ListaMovimeintoDetalle)
            {
                if (RegistrosMovimeintoDetalle.valedet.estado == true)
                {
                    movimientoproductod registrosDetalle = new movimientoproductod();
                    //registrosDetalle.p_inidvaledetalle = 0;
                    registrosDetalle.p_inidvalecebecera = RegistrosMovimientoC.p_inidvalecebecera;
                    registrosDetalle.p_inidproducto = RegistrosMovimeintoDetalle.valedet.p_inidproducto;
                    registrosDetalle.nucantidad = RegistrosMovimeintoDetalle.valedet.nucantidad;
                    registrosDetalle.nucosto = RegistrosMovimeintoDetalle.valedet.nucosto;
                    registrosDetalle.nutotal = RegistrosMovimeintoDetalle.valedet.nutotal;

                    codigoDetalle = movimientosNE.MovimientoProductoDetalleIngresar(registrosDetalle);
                    almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, RegistrosMovimeintoDetalle.valedet.nucantidad);
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
                            Registros.boexhibicion = registrosSerie.boexhibicion;
                            Registros.chinforme = registrosSerie.chinforme;
                            Registros.chinformefecha = registrosSerie.chinformefecha;
                            Registros.chinformeobs = registrosSerie.chinformeobs;
                            codigoSerie = serieNE.seriesIngresar(Registros);
                        }
                    }
                }
            }
            pasado(codigoMovimiento);                          
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
                    if (i > 0)
                    {
                        flat = true;                        
                    }else
                    {
                        MessageBox.Show("Lista Vacia", "Mensaje de Sistema", MessageBoxButtons.OK);
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
                string vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioModificar(vBoton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void cargarFormularioModificar(string vBoton)
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
            f.Cargado += new frmProcSeriesAnadir.CargarTabla(CargarTabla);
            f.MdiParent = this.MdiParent;
            f.Show();
            //DialogResult res = f.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    CargarTabla();
            //}
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
                sesion.movprodaccion = listaMovi;
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
                        dgvListaValeDetalle.Rows.Add(
                        registrosMovi.valedet.p_inidvaledetalle,
                        registrosMovi.valedet.p_inidproducto,
                        registrosMovi.valedet.chcodigoproducto.ToString(),
                        registrosMovi.valedet.nucantidad,
                        registrosMovi.valedet.chmedida,
                        registrosMovi.valedet.chnombrecompuesto.ToString(),
                        decimal.Round(registrosMovi.valedet.nucosto, 2),
                        decimal.Round(registrosMovi.valedet.nutotal, 2));
                        suma += registrosMovi.valedet.nutotal;
                    }                
                }
                txtTotal.Text = decimal.Round(suma, 2).ToString();
            }else
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
        }

       
       

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtRuc.Text;
            BuscaProveedor(parametro);
        }
        private void BuscaProveedor(string ruc)
        {
            proveedor registro = proveedorNE.ProveedorBusquedaRuc(ruc);
            if (registro != null)
            {
                txtProvnombre.Text = registro.razon;
                txtidprov.Text = registro.p_inidcodigoclie.ToString();
            }
            else
            {
                txtProvnombre.Text = "";
                txtidprov.Text = "";

            }
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
                string vBoton = "E";
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
                string vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioModificar(vBoton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
