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
    public partial class frmProcSalidaProductosAnadir : Form
    {
        public frmProcSalidaProductosAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
     

        private void frmProcSalidaProductosAnadir_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cboTipoMov.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(19);
            cboTipoMov.ValueMember = "idmaestrodetalle";
            cboTipoMov.DisplayMember = "nombreitem";


            if (this.vBoton == "A")
            {
                txtejercicio.Text = "2018";
                txtperiodo.Text = "01";
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "SALIDA";
                string correlativo = valeNE.CorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen) ;
                txtNroVale.Text = correlativo;
                mskfechareg.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                txtTotal.Text = "0.00";
                cboTipoMov.Focus();
            }
            else
            {
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR MOVIMIENTO";



                    //RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);
                    //txtejercicio.Text = "2018";
                    //txtperiodo.Text = "01";
                    //txtAlmacen.Text = "PRINCIPAL";
                    //txtClase.Text = "INGRESO";
                    //txtRuc.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);
                    //cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
                    //cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
                    //txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
                    //mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
                    //txtobs.Text = RegistrosMovimientoC.chobservacion;
                    //txtFacBol.Text = RegistrosMovimientoC.chboletafactura;
                    //txtGuiaRem.Text = RegistrosMovimientoC.chguiaremision;
                    //cboTipoMov.Focus();


                    ///**/
                    //List<movimientoproductoaccion> ListaMovimiento = new List<movimientoproductoaccion>();
                    //List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidvalecebecera);
                    //int i = 1;
                    //foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                    //{
                    //    movimientoproductoaccion RegistrosMoviento = new movimientoproductoaccion();
                    //    valedetalle registrosValeDet = new valedetalle();
                    //    registrosValeDet.p_inidvaledetalle = i;
                    //    registrosValeDet.chnombrecompuesto = registrosMovimientoD.chnombrecompuesto.ToString();
                    //    registrosValeDet.chmedida = registrosMovimientoD.chmedida.ToString();
                    //    registrosValeDet.chcodigoproducto = registrosMovimientoD.chcodigoproducto.ToString();
                    //    registrosValeDet.chfecha = RegistrosMovimientoC.chvalefecha.ToString();
                    //    registrosValeDet.p_inidproducto = registrosMovimientoD.p_inidproducto;
                    //    registrosValeDet.nucantidad = registrosMovimientoD.nucantidad;
                    //    registrosValeDet.nucosto = registrosMovimientoD.nucosto;
                    //    registrosValeDet.nutotal = registrosMovimientoD.nutotal;
                    //    registrosValeDet.estado = registrosMovimientoD.estado;

                    //    List<serie> ListaSerie = serieNE.SerieBusquedaMovimiento(registrosMovimientoD.p_inidvaledetalle);
                    //    List<serie> ListasSeries = new List<serie>();
                    //    //MessageBox.Show(""+registrosMovimientoD.p_inidvaledetalle, "Mensaje de Sistema", MessageBoxButtons.OK);
                    //    foreach (serie Registroxxxxs in ListaSerie)
                    //    {
                    //        serie registrosSerie = new serie();
                    //        registrosSerie.chcodigoserie = Registroxxxxs.chcodigoserie.ToString();
                    //        registrosSerie.estado = true;
                    //        registrosSerie.p_inidproducto = Registroxxxxs.p_inidproducto;
                    //        registrosSerie.chadicional = Registroxxxxs.chadicional.ToString();
                    //        registrosSerie.chfecha = Registroxxxxs.chfecha;
                    //        registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    //        registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                    //        registrosSerie.chinforme = Registroxxxxs.chinforme.ToString();
                    //        registrosSerie.chinformeobs = Registroxxxxs.chinformeobs.ToString();
                    //        registrosSerie.chinformefecha = Registroxxxxs.chinformefecha;
                    //        registrosSerie.boexhibicion = Registroxxxxs.boexhibicion;
                    //        ListasSeries.Add(registrosSerie);
                    //    }

                    //    RegistrosMoviento.valedet = registrosValeDet;
                    //    RegistrosMoviento.listaserie = ListasSeries;
                    //    i++;
                    //    ListaMovimiento.Add(RegistrosMoviento);
                    //}


                    //sesion.movprodaccion = ListaMovimiento;
                    //CargarTabla();
                }
                else
                {
                    if (this.vBoton == "V")
                    {
                        //this.Text = "VER MOVIMIENTO";
                        //btnAnadir.Enabled = false;
                        //btnModificar.Enabled = false;
                        //btnEliminar.Enabled = false;
                        //btnGrabar.Enabled = false;

                        //RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);
                        //txtejercicio.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                        //txtperiodo.Text = "01";
                        //txtAlmacen.Text = "PRINCIPAL";
                        //txtClase.Text = "INGRESO";
                        //txtRuc.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);
                        //cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
                        //cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
                        //txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
                        //mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
                        //txtobs.Text = RegistrosMovimientoC.chobservacion;
                        //txtFacBol.Text = RegistrosMovimientoC.chboletafactura;
                        //txtGuiaRem.Text = RegistrosMovimientoC.chguiaremision;
                        //cboTipoMov.Focus();
                        //txtRuc.ReadOnly = true;
                        //txtobs.ReadOnly = true;
                        //txtFacBol.ReadOnly = true;
                        //txtGuiaRem.ReadOnly = true;
                        //mskfechareg.ReadOnly = true;

                        ///**/
                        //List<movimientoproductoaccion> ListaMovimiento = new List<movimientoproductoaccion>();
                        //List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(RegistrosMovimientoC.p_inidvalecebecera);
                        //int i = 1;
                        //foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                        //{
                        //    movimientoproductoaccion RegistrosMoviento = new movimientoproductoaccion();
                        //    valedetalle registrosValeDet = new valedetalle();
                        //    registrosValeDet.p_inidvaledetalle = i;
                        //    registrosValeDet.chnombrecompuesto = registrosMovimientoD.chnombrecompuesto;
                        //    registrosValeDet.chmedida = registrosMovimientoD.chmedida;
                        //    registrosValeDet.chcodigoproducto = registrosMovimientoD.chcodigoproducto;
                        //    registrosValeDet.chfecha = registrosMovimientoD.chfecha;
                        //    registrosValeDet.p_inidproducto = registrosMovimientoD.p_inidproducto;
                        //    registrosValeDet.nucantidad = registrosMovimientoD.nucantidad;
                        //    registrosValeDet.nucosto = registrosMovimientoD.nucosto;
                        //    registrosValeDet.nutotal = registrosMovimientoD.nutotal;
                        //    registrosValeDet.estado = registrosMovimientoD.estado;

                        //    List<serie> ListaSerie = serieNE.SerieBusquedaMovimiento(registrosMovimientoD.p_inidvaledetalle);
                        //    List<serie> ListasSeries = new List<serie>();
                        //    //MessageBox.Show(""+registrosMovimientoD.p_inidvaledetalle, "Mensaje de Sistema", MessageBoxButtons.OK);
                        //    foreach (serie Registroxxxxs in ListaSerie)
                        //    {
                        //        serie registrosSerie = new serie();
                        //        registrosSerie.chcodigoserie = Registroxxxxs.chcodigoserie;
                        //        registrosSerie.estado = true;
                        //        registrosSerie.p_inidproducto = Registroxxxxs.p_inidproducto;
                        //        registrosSerie.chadicional = Registroxxxxs.chadicional;
                        //        registrosSerie.chfecha = Registroxxxxs.chfecha;
                        //        registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        //        registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                        //        registrosSerie.chinforme = Registroxxxxs.chinforme;
                        //        registrosSerie.chinformeobs = Registroxxxxs.chinformeobs;
                        //        registrosSerie.chinformefecha = Registroxxxxs.chinformefecha;
                        //        registrosSerie.boexhibicion = Registroxxxxs.boexhibicion;
                        //        ListasSeries.Add(registrosSerie);
                        //    }

                        //    RegistrosMoviento.valedet = registrosValeDet;
                        //    RegistrosMoviento.listaserie = ListasSeries;
                        //    i++;
                        //    ListaMovimiento.Add(RegistrosMoviento);
                        //}


                        //sesion.movprodaccion = ListaMovimiento;
                        //CargarTabla();
                    }
                }                   
            }                
        }

      
        private void BuscaProveedor(string ruc)
        {
            proveedor registro = proveedorNE.ProveedorBusquedaRuc(ruc);
            if (registro != null)
            {
                txtProvnombre.Text = registro.razon;
                //txtidprov.Text = registro.p_inidcodigoclie.ToString();
            }
            else
            {
                txtProvnombre.Text = "";
                //txtidprov.Text = "";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboTipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoMov.Text == "VENTA")
            {
                LNroDoc.Text = "Codigo";
                LDecripcion.Text = "Cliente";
            }
            else
            {
                if (cboTipoMov.Text == "DEVOLUCION POR COMPRA")
                {

                    LNroDoc.Text = "R.U.C.";
                    LDecripcion.Text = "Proveedor";
                }
            }
        }

        private void txtRuc_TextChanged_1(object sender, EventArgs e)
        {
            string parametro = txtRuc.Text;
            if (cboTipoMov.Text == "VENTA")
            {
            }
            else
            {
                if (cboTipoMov.Text == "DEVOLUCION POR COMPRA")
                {
                    BuscaProveedor(parametro);
                }
            }
            
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

        }
    }
}
