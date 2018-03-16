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
    public partial class frmProcSalidaProductosAnadir : Form
    {
        internal int p_inidmovimientoG;
        public delegate void pasarNuevoVale(int varreg);
        public event pasarNuevoVale pasadoVale;
        internal List<tipomovimiento> ListasMovimientoG;
        public frmProcSalidaProductosAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        /*INICIO :: PRUEBA SOLO NUMEROS*/
        

        private void textBox1_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;// Convierto el sender a texto
            utilidades.ValidarNumero(ref textboxusado, e);
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);// Llamamos a nuestro método.
        }   
        /*FIN :: PRUEBA SOLO NUMEROS*/

        private void frmProcSalidaProductosAnadir_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";

            ListasMovimientoG = movimientosNE.ListarTipomovimientos(19);
            cboTipoMov.DataSource = ListasMovimientoG;
            cboTipoMov.ValueMember = "p_inidtipomovimiento";
            cboTipoMov.DisplayMember = "chnombremovimiento";

            DateTime fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString().PadLeft(10, '0'));

            if (this.vBoton == "A")
            {
                txtejercicio.Text = fecha.Year.ToString();
                txtperiodo.Text = fecha.Month.ToString();
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
                    CargarDatos();
                    CargarDatosSession();
                   
                }
                else
                {
                    if (this.vBoton == "V")
                    {
                        CargarDatos();
                        CargarDatosSession();
                        Desactivartext(txtobs);
                        Desactivartext(txtCref1);
                        Desactivartext(txtCref2);
                        Desactivartext(txtCref3);
                        Desactivartext(txtCref4);
                        Desactivartext(txtCref5);
                        btnAnadir.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnGrabar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnVer.Enabled = false;
                    }
                }                   
            }                
        }
        private void Desactivartext(TextBox texbox)
        {
            texbox.ReadOnly = true;
            texbox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            texbox.ForeColor = Color.Blue;
            texbox.TabStop = false;
        }
        private void CargarDatos()
        {
            movimientoproductoc RegistrosMovimientoC = movimientosNE.MovimientoProductoCabeceraBusqueda(p_inidmovimientoG);
            
            txtAlmacen.Text = "PRINCIPAL";
            txtClase.Text = "SALIDA";
            cboMoneda.SelectedValue = RegistrosMovimientoC.p_inidtipomoneda;
            cboTipoMov.SelectedValue = RegistrosMovimientoC.p_inidtipomoviemiento;
            txtNroVale.Text = RegistrosMovimientoC.p_inidcorrevale.ToString();
            mskfechareg.Text = RegistrosMovimientoC.chvalefecha.ToString();
            txtobs.Text = RegistrosMovimientoC.chobservacion;
            DateTime Fechas = Convert.ToDateTime(mskfechareg.Text);
            txtejercicio.Text = Fechas.Year.ToString();
            txtperiodo.Text = Fechas.Month.ToString();

            txtCref1.Text = RegistrosMovimientoC.chref1;
            txtCref2.Text = RegistrosMovimientoC.chref2;
            txtCref3.Text = RegistrosMovimientoC.chref3;
            txtCref4.Text = RegistrosMovimientoC.chref4;
            txtCref5.Text = RegistrosMovimientoC.chref5;
            //txtFacBol.Text = RegistrosMovimientoC.chboletafactura;
            //txtGuiaRem.Text = RegistrosMovimientoC.chguiaremision;

            //txtRuc.Text = proveedorNE.ProveedorBusquedaCodigo(RegistrosMovimientoC.p_inidproveedor);

            List<movimientoproductoaccion> ListaMovimientosPr = new List<movimientoproductoaccion>();
            List<valedetalle> valdedetalle = movimientosNE.MovimientoProductoDetalleBusqueda(p_inidmovimientoG);
            int count = 1;
            foreach (valedetalle obj in valdedetalle)
            {
                movimientoproductoaccion movprodac = new movimientoproductoaccion();
                movprodac.orden = count;
                movprodac.valedet = obj;
                List<serie> regiserie = new List<serie>();
                regiserie = serieNE.SerieBusquedaMovimiento(obj.p_inidvaledetalle);
                if (regiserie != null)
                {
                    movprodac.listaserie = regiserie;
                }
                else
                {
                    movprodac.listaserie = null;
                }

                ListaMovimientosPr.Add(movprodac);
                count++;
            }
            sesion.movprodaccion = ListaMovimientosPr;
        }
        private void CargarTablaDetalle()
        {

        }
        private void LimpiarDatosTexto()
        {
            txtCref1.Text = "";
            txtCref2.Text = "";
            txtCref3.Text = "";
            txtCref4.Text = "";
            txtCref5.Text = "";
        }
        private void BuscaProveedor(string ruc)
        {
            proveedor registro = proveedorNE.ProveedorBusquedaRuc(ruc);
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void txtRuc_TextChanged_1(object sender, EventArgs e)
        {
            //string parametro = txtRuc.Text;
            //if (cboTipoMov.Text == "DEVOLUCION POR COMPRA")
            //{
            //    BuscarProveedor(parametro);
            //}
        }
        private void BuscarProveedor(string parametro)
        {
            //proveedor registro = proveedorNE.ProveedorBusquedaRuc(parametro);
            //if (registro != null)
            //{
            //    txtProvnombre.Text = registro.razon;
            //    txtidprov.Text = registro.p_inidcodigoclie.ToString();
            //}
            //else
            //{
            //    txtProvnombre.Text = "";
            //    txtidprov.Text = "";

            //}
        }

        private void PonerProveedor(string ruc)
        {
                txtCref1.Text = ruc;            
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";

                if (basicas.validarAcceso(vBoton))
                {
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadirDetalle);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcSalidaProductosAnadirDetalle f = new frmProcSalidaProductosAnadirDetalle(vBoton);
                    f.pasadoDetalle += new frmProcSalidaProductosAnadirDetalle.pasarDetalleAnadido(CargarDatosSession);
                    //f.MdiParent = this.MdiParent;
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void CargarDatosSession()
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
                        registrosMovi.orden,
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
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
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
        private void cargarFormularioEliminar()
        {
            if (dgvListaValeDetalle.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadirDetalle);
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
                    if (registrosMovi.orden == (int)dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value)
                    {
                        //registrosMovi.valedet.p_inidvaledetalle = 0;
                        registrosMovi.valedet.estado = false;
                    }
                }
                sesion.movprodaccion = listaMovi;
            }
            CargarDatosSession();

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
        private void cargarFormularioModificar(string vBoton)
        {
            if (dgvListaValeDetalle.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadirDetalle);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmProcSalidaProductosAnadirDetalle f = new frmProcSalidaProductosAnadirDetalle(vBoton);
            // f.pasado += new frmProcSeriesAnadir.pasar(ejecutar);            
             f.orden = (int)dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value;
            //MessageBox.Show(dgvListaValeDetalle.CurrentRow.Cells["IDITEM"].Value.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            f.pasadoDetalle += new frmProcSalidaProductosAnadirDetalle.pasarDetalleAnadido(CargarDatosSession);
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
            //DialogResult res = f.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    CargarTabla();
            //}
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
                    }
                    else
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
            //registrosCabecera.chguiaremision = txtGuiaRem.Text;
            //registrosCabecera.chboletafactura = txtFacBol.Text;
            registrosCabecera.p_inidtipomoviemiento = (int)cboTipoMov.SelectedValue;
            registrosCabecera.chobservacion = txtobs.Text;
            registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.estado = true;
            registrosCabecera.p_inidmovimiento = 19;
            //ingreso de cabecera


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
            codigoCabecera = movimientosNE.MovimientoProductoCabeceraIngresar(registrosCabecera);
            int gorrelativo = valeNE.GenerarCorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);

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
                        int cantidad = RegistrosMovimeintoDetalle.valedet.nucantidad*(-1);
                        int entero = almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, cantidad);
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
                                    serieNE.SeriesFalsearCodigo(registrosSerie.p_inidserie);
                                }
                            }
                        }
                    }
                }
                pasadoVale(codigoCabecera);

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
            registrosCabecera.p_inidvalecebecera = p_inidmovimientoG;
            registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
            registrosCabecera.p_inidclase = 1;
            registrosCabecera.p_inidcorrevale = txtNroVale.Text;
            registrosCabecera.chvalefecha = mskfechareg.Text;
            registrosCabecera.p_inidtipomoneda = (int)cboMoneda.SelectedValue;
            registrosCabecera.p_inidproveedor = 0;
            //registrosCabecera.chguiaremision = txtGuiaRem.Text;
            //registrosCabecera.chboletafactura = txtFacBol.Text;
            registrosCabecera.p_inidtipomoviemiento = (int)cboTipoMov.SelectedValue;
            registrosCabecera.chobservacion = txtobs.Text;
            registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.estado = true;
            registrosCabecera.p_inidmovimiento = 19;
            //ingreso de cabecera
            codigoCabecera = movimientosNE.MovimientoProductoCabeceraModificar(registrosCabecera);
            int gorrelativo = valeNE.GenerarCorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);

            if (codigoCabecera <= 0 && gorrelativo <= 0)
            {

                MessageBox.Show("error Cabecera", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            else
            {
                List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(p_inidmovimientoG);
                foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
                {
                    serieNE.SeriesFalsear(registrosMovimientoD.p_inidvaledetalle, true);
                    //MessageBox.Show("error Falseo"+ registrosMovimientoD.p_inidvaledetalle, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    int cantidad = (-1) * registrosMovimientoD.nucantidad;
                    almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, registrosMovimientoD.p_inidproducto, cantidad);

                }
                movimientosNE.MovimientoProductoDetalleFalsear(p_inidmovimientoG);

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
                        int cantidad = RegistrosMovimeintoDetalle.valedet.nucantidad * (-1);
                        int entero = almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, cantidad);
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
                                    serieNE.SeriesFalsearCodigo(registrosSerie.p_inidserie);
                                }
                            }
                        }
                    }
                }
                pasadoVale(codigoCabecera);

            }
            if (sesion.movprodaccion != null)
            {
                sesion.movprodaccion.Clear();
                dgvListaValeDetalle.Rows.Clear();
            }
        }

        private void txtRuc_DoubleClick(object sender, EventArgs e)
        {
            if (cboTipoMov.Text == "DEVOLUCION POR COMPRA")
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

        }

        private void txtCref1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCref1.Text.Length >= 20 || txtCref2.Text.Length >= 20 || txtCref3.Text.Length >= 20 || txtCref4.Text.Length >= 20 || txtCref5.Text.Length >= 20)
            {
                e.Handled = true;
            }
            if (13 == Convert.ToInt32(e.KeyChar))
            {
                if (cboTipoMov.Text == "DEVOLUCION POR COMPRA" && txtCref1.Text.Length > 0)
                {
                    string parametro = txtCref1.Text;
                    BuscaProveedor(parametro);
                }
            }
            if (8 == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = false;

            }
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 20);
        }

        private void txtCref1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCref1_DoubleClick(object sender, EventArgs e)
        {
            if (cboTipoMov.Text == "DEVOLUCION POR COMPRA")
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

        private void txtobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e,255);
        }
    }
}
