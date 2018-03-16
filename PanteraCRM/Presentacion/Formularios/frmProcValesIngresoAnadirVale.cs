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
    public partial class frmProcIngresoValesAnadir : Form
    {
        internal movimientoproductoc RegistrosMovimientoC;
        internal List<tipomovimiento> ListasMovimientoG;
        internal int codigoMovimiento;
        internal bool EstadoModificar=true;
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
            ListasMovimientoG = movimientosNE.ListarTipomovimientos(14);
            cboTipoMov.DataSource = ListasMovimientoG;
            cboTipoMov.ValueMember = "p_inidtipomovimiento";
            cboTipoMov.DisplayMember = "chnombremovimiento";
            DateTime fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString().PadLeft(10, '0'));
            if (this.vBoton == "A")
            {
                txtejercicio.Text = fecha.Year.ToString(); 
                txtperiodo.Text = fecha.Month.ToString(); 
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                string correlativo = valeNE.CorrelativoMovimientoIngreso(sesion.SessionGlobal.p_inidalmacen) ;
                txtNroVale.Text = correlativo;
                mskfechareg.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                txtTotal.Text = "0.00";
                cboTipoMov.Focus();
            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR MOVIMIENTO";     
               
                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
                CargarDatosrecarga();
                CargarTabla();
                btnGrabar.Enabled = EstadoModificar;
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER MOVIMIENTO";
                CargarDatosrecarga();
                btnAnadir.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGrabar.Enabled = false;
                

                txtAlmacen.Text = "PRINCIPAL";
                txtClase.Text = "INGRESO";
               

                InvalidarCampos(txtobs);
                InvalidarCampos(txtCref1);
                InvalidarCampos(txtCref2);
                InvalidarCampos(txtCref3);
                InvalidarCampos(txtCref4);
                InvalidarCampos(txtCref5);

                
                CargarTabla();
            }
            


        }
        private void InvalidarCampos(TextBox TextBox)
        {
            TextBox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            TextBox.ForeColor = Color.Blue;
            TextBox.ReadOnly = true;
        }
        private void CargarDatosrecarga()
        {
            RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(codigoMovimiento);            
            //txtidprov.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);
            cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
            cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
            txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
            mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
            DateTime fechaV = Convert.ToDateTime(mskfechareg.Text);
            txtejercicio.Text = fechaV.Year.ToString();
            txtobs.Text = RegistrosMovimientoC.chobservacion;

            txtperiodo.Text = fechaV.Month.ToString();
            //txtCref4.Text = RegistrosMovimientoC.chboletafactura;
            //txtCref3.Text = RegistrosMovimientoC.chguiaremision;
            cboTipoMov.Focus();

            txtCref1.Text = RegistrosMovimientoC.chref1;
            txtCref2.Text = RegistrosMovimientoC.chref2;
            txtCref3.Text = RegistrosMovimientoC.chref3;
            txtCref4.Text = RegistrosMovimientoC.chref4;
            txtCref5.Text = RegistrosMovimientoC.chref5;

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
                    EstadoModificar = Registroxxxxs.estado;
                    registrosSerie.p_inidproducto = Registroxxxxs.p_inidproducto;
                    registrosSerie.chadicional = Registroxxxxs.chadicional.ToString();
                    registrosSerie.chfecha = Registroxxxxs.chfecha;
                    registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                    registrosSerie.chinforme = Registroxxxxs.chinforme.ToString();
                    registrosSerie.chinformeobs = Registroxxxxs.chinformeobs.ToString();
                    registrosSerie.chinformefecha = Registroxxxxs.chinformefecha;
                    registrosSerie.boexhibicion = Registroxxxxs.boexhibicion;
                    registrosSerie.chidentificador = Registroxxxxs.chidentificador;
                    ListasSeries.Add(registrosSerie);
                }

                RegistrosMoviento.valedet = registrosValeDet;
                RegistrosMoviento.listaserie = ListasSeries;
                i++;
                ListaMovimiento.Add(RegistrosMoviento);
            }
            sesion.movprodaccion = ListaMovimiento;
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcSeriesAnadir f = new frmProcSeriesAnadir(vBoton);
                    f.p_inidproducto = dgvListaValeDetalle.RowCount + 1;                    
                    f.Cargado += new frmProcSeriesAnadir.CargarTabla(CargarTabla);
                    //f.MdiParent = this.MdiParent;
                    f.ShowDialog();
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
            movimientoproductoc registrosCabecera = new movimientoproductoc();
            //registrosCabecera.p_inidvalecebecera = 0;
            registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
            registrosCabecera.p_inidclase = 1;
            registrosCabecera.p_inidcorrevale = txtNroVale.Text;
            registrosCabecera.chvalefecha = mskfechareg.Text;
            registrosCabecera.p_inidtipomoneda = (int)cboMoneda.SelectedValue;
            registrosCabecera.p_inidproveedor = 0;
            registrosCabecera.chguiaremision = txtCref3.Text;
            registrosCabecera.chboletafactura = txtCref4.Text;
            registrosCabecera.p_inidtipomoviemiento = (int)cboTipoMov.SelectedValue;
            registrosCabecera.chobservacion = txtobs.Text;
            registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.estado = true;
            registrosCabecera.p_inidmovimiento = 14;


            registrosCabecera.chtipref1 = lblTipref1.Text;
            registrosCabecera.chref1 = txtCref1.Text;
            registrosCabecera.chnref1 = lblNref1.Text;
            registrosCabecera.chtipref2 = lblTipref2.Text;
            registrosCabecera.chref2 = txtCref2.Text;
            registrosCabecera.chnref2 = lblNref2.Text;
            registrosCabecera.chtipref3 = lblTipref3.Text;
            registrosCabecera.chref3 = txtCref3.Text;
            registrosCabecera.chnref3 = lblNref3.Text;
            registrosCabecera.chtipref4 = lblTipref4.Text;
            registrosCabecera.chref4 = txtCref4.Text;
            registrosCabecera.chnref4 = lblNref4.Text;
            registrosCabecera.chtipref5 = lblTipref5.Text;
            registrosCabecera.chref5 = txtCref5.Text;
            registrosCabecera.chnref5 = lblNref5.Text;
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
                                    Registros.chadicional = registrosSerie.chadicional;
                                    Registros.chidentificador = registrosSerie.chidentificador;
                                    Registros.chfecha = mskfechareg.Text;
                                    Registros.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                                    Registros.p_inidmovimientod = codigoDetalle;
                                    Registros.p_inidpedidod = 0;
                                    codigoSerie = serieNE.seriesIngresar(Registros);
                                    if (codigoSerie <= 0)
                                    {
                                        MessageBox.Show("Error Serie", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                        return;
                                    }
                                }
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
            movimientoproductoc registrosCabecera = new movimientoproductoc();
            registrosCabecera.p_inidvalecebecera = RegistrosMovimientoC.p_inidvalecebecera;
            registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
            registrosCabecera.p_inidclase = 1;
            registrosCabecera.p_inidcorrevale = txtNroVale.Text;
            registrosCabecera.chvalefecha = mskfechareg.Text;
            registrosCabecera.p_inidtipomoneda = (int)cboMoneda.SelectedValue;
            registrosCabecera.p_inidproveedor = 0;
            registrosCabecera.chguiaremision = txtCref3.Text;
            registrosCabecera.chboletafactura = txtCref4.Text;
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
                serieNE.SeriesFalsear(registrosMovimientoD.p_inidvaledetalle,false);
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
                            Registros.chadicional = registrosSerie.chadicional;
                            Registros.chidentificador = registrosSerie.chidentificador;
                            Registros.chfecha = mskfechareg.Text;
                            Registros.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                            Registros.p_inidmovimientod = codigoDetalle;
                            Registros.p_inidpedidod = 0;
                            codigoSerie = serieNE.seriesIngresar(Registros);
                            if (codigoSerie <= 0)
                            {
                                MessageBox.Show("Error Serie", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                return;
                            }
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
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
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
                        registrosMovi.valedet.nucosto,
                        registrosMovi.valedet.nutotal);
                        suma += registrosMovi.valedet.nutotal;
                    }                
                }
                txtTotal.Text = string.Format("{0:0,0.00}", suma); 
            }else
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
        }

       
       

      
        private void BuscaProveedor(string ruc)
        {
            proveedor registro = proveedorNE.ProveedorBusquedaRuc(ruc);
            if (registro != null)
            {
                //txtProvnombre.Text = registro.razon;
                //txtidprov.Text = registro.p_inidcodigoclie.ToString();
            }
            else
            {
                LlamarVentanaBusquedaProveedor();
            }
        }
        private void txtRuc_DoubleClick(object sender, EventArgs e)
        {
            if (cboTipoMov.Text == "COMPRAS NACIONALES")
            {
                LlamarVentanaBusquedaProveedor();
            }
        }
        private void LlamarVentanaBusquedaProveedor()
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
            
            if (ruc == "")
            {
                MessageBox.Show("Datos no encontrados", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtCref1.Text = "";
            }else
            {
                txtCref1.Text = ruc;
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

        private void cboTipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (tipomovimiento Registrostipomovimiento in ListasMovimientoG)
            {
                if (cboTipoMov.Text == Registrostipomovimiento.chnombremovimiento)
                {
                    LimpiarDatosTexto();
                    lblNref1.Text = Registrostipomovimiento.chnref1;
                    lblNref2.Text = Registrostipomovimiento.chnref2;
                    lblNref3.Text = Registrostipomovimiento.chnref3;
                    lblNref4.Text = Registrostipomovimiento.chnref4;
                    lblNref5.Text = Registrostipomovimiento.chnref5;
                    lblTipref1.Text = Registrostipomovimiento.chtipref1;
                    lblTipref2.Text = Registrostipomovimiento.chtipref2;
                    lblTipref3.Text = Registrostipomovimiento.chtipref3;
                    lblTipref4.Text = Registrostipomovimiento.chtipref4;
                    lblTipref5.Text = Registrostipomovimiento.chtipref5;
                }
            }
        }
        private void LimpiarDatosTexto()
        {
            txtCref1.Text = "";
            txtCref2.Text = "";
            txtCref3.Text = "";
            txtCref4.Text = "";
            txtCref5.Text = "";
        }

        private void txtCref1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCref1.Text.Length >= 20 || txtCref2.Text.Length >= 20 || txtCref3.Text.Length >= 20 || txtCref4.Text.Length >= 20 || txtCref5.Text.Length >= 20 )
            {
                e.Handled = true;
            }
            if ( 13 == Convert.ToInt32(e.KeyChar))
            {
                if (cboTipoMov.Text == "COMPRAS NACIONALES" && txtCref1.Text.Length > 0)
                {
                    string parametro = txtCref1.Text;
                    BuscaProveedor(parametro);
                }
            }
            if (8 == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 20);
        }

        private void txtCref1_Validated(object sender, EventArgs e)
        {

        }
    }
}
