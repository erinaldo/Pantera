using Entidades;
using Negocios;
using Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegistroPresupuestoAnadir : Form
    {

        internal presupuesto tmpPresupuesto;
        internal persona tmpPersona;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public DataTable dtCursor = new DataTable("Detalle");
        public decimal vTotal = 0;
        public frmRegistroPresupuestoAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void frmRegistroPresupuestoAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            txtCantidad.Text = "1";
            dtCursor.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtCursor.Columns.Add("idmediarticulo", System.Type.GetType("System.String"));
            dtCursor.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            dtCursor.Columns.Add("nombrearticulo", System.Type.GetType("System.String"));
            dtCursor.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            dtCursor.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dgvCursor.DataSource = dtCursor;

            cboMarca.DataSource = marcaNE.marcaListar();
            cboMarca.ValueMember = "idmarca";
            cboMarca.DisplayMember = "nombremarca";

            cboModelo.DataSource = modeloNE.modeloBuscarPorMarca(Convert.ToInt32(cboMarca.SelectedValue));
            cboModelo.ValueMember = "idmodelo";
            cboModelo.DisplayMember = "nombremodelo";

            cboArticulo.DataSource = articuloNE.articuloListarPresupuesto();
            cboArticulo.ValueMember = "idarticulo";
            cboArticulo.DisplayMember = "nombrearticulo";

            if (this.vBoton == "A")
            {
                this.Text = "AÑADIR PRESUPUESTO";
                txtCodigoserie.Text = sesion.puntoventasesion.prefijopresupuesto;
                txtPresupuesto.Text = puntoventaNE.puntoventaObtenerNumero(sesion.puntoventasesion.idpuntoventa, "P", "C");
                txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                txtTotal.Text = vTotal.ToString("0,0.00");
            }
            else
            {
                txtCodigoserie.Text = tmpPresupuesto.codigoserie;
                txtPresupuesto.Text = tmpPresupuesto.numeropresupuesto;
                txtPlaca.Text = tmpPresupuesto.placa;
                txtFecha.Text = tmpPresupuesto.fechapresupuesto;
                txtFechara.Text = tmpPresupuesto.fechara;
                txtFecharq.Text = tmpPresupuesto.fecharq;
                cboMarca.SelectedValue = tmpPresupuesto.idmarca;
                cboModelo.DataSource = modeloNE.modeloBuscarPorMarca(tmpPresupuesto.idmarca);
                cboModelo.SelectedValue = tmpPresupuesto.idmodelo;
                txtObservacion.Text = tmpPresupuesto.observacion;
                btnAnadir.Enabled = false;
                btnQuitar.Enabled = false;
                try
                {
                    persona tmpPersona = personaNE.buscaPorIdpersona(tmpPresupuesto.idpersona);
                    if (tmpPersona != null)
                    {
                        //txtDni.Text = tmpPersona.dni;
                        //txtUbigeo.Text = tmpPersona.ubigeo;
                        //txtIdpersona.Text = tmpPersona.idpersona.ToString();
                        //txtApe_paterno.Text = tmpPersona.ape_paterno;
                        //txtApe_materno.Text = tmpPersona.ape_materno;
                        //txtNombres.Text = tmpPersona.nombres;
                        //txtFecha_nac.Text = tmpPersona.fecha_nac;
                        //txtSexo.Text = tmpPersona.sexo;
                        //txtDireccion.Text = tmpPersona.direccion;
                        //txtTelefono.Text = tmpPersona.telefono;
                        //txtDireccion.Enabled = true;
                        //ubigeo tmpUbigeo = ubigeoNE.buscarPorCodigo(tmpPersona.ubigeo);
                        //txtUbigeo.Text = tmpUbigeo.cod_ubigeo;
                        //txtDepartamento.Text = tmpUbigeo.desc_departamento;
                        //txtProvincia.Text = tmpUbigeo.desc_provincia;
                        //txtDistrito.Text = tmpUbigeo.desc_distrito;
                        //txtUbigeo.Enabled = true;
                        //txtTelefono.Enabled = true;
                        //txtApe_paterno.Enabled = false;
                        //txtApe_materno.Enabled = false;
                        //txtNombres.Enabled = false;
                        //txtFecha_nac.Enabled = false;
                        //txtSexo.Enabled = false;
                        //txtDireccion.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ubigeo no encontrado, informar para su verificación", "Mensaje de Sistema", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                dtCursor = presupuestoNE.presupuestodetalleDatatable(tmpPresupuesto.idpresupuesto);

                dgvCursor.DataSource = dtCursor;
                if (dgvCursor.RowCount > 0)
                {
                    vTotal = 0;
                    foreach (DataGridViewRow fila in dgvCursor.Rows)
                    {
                        vTotal = vTotal + (decimal)fila.Cells["subtotal"].Value;
                    }
                }
                txtTotal.Text = vTotal.ToString("0,0.00");

                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR PRESUPUESTO";
                }
                else
               if (this.vBoton == "V")
                    {

                    this.Text = "VER PRESUPUESTO";
                    btnGrabar.Enabled = false;
                }
            }
        }
        private void cboMarca_Validating(object sender, CancelEventArgs e)
        {
            if (cboMarca.SelectedValue != null)
            {
                cboModelo.DataSource = modeloNE.modeloBuscarPorMarca((int)cboMarca.SelectedValue);
                cboModelo.ValueMember = "idmodelo";
                cboModelo.DisplayMember = "nombremodelo";
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDni.Text;
            try
            {
                if (dni == string.Empty || dni.Trim().Length == 0)
                {
                    txtDni.Focus();
                    throw new Exception("Ingrese un DNI ");
                }
                if (dni.Trim().Length != 8)
                {
                    txtDni.Focus();
                    throw new Exception("Ingrese un DNI de 8 dígitos");
                }
                persona registro = personaNE.buscaPorDNI(dni);
                if ((this.vBoton == "A" && registro != null) || (this.vBoton == "M" && registro != null))
                {
                    //txtIdpersona.Text = Convert.ToString(registro.idpersona);
                    //txtUbigeo.Text = registro.ubigeo;
                    //txtApe_paterno.Text = registro.ape_paterno;
                    //txtApe_materno.Text = registro.ape_materno;
                    //txtNombres.Text = registro.nombres;
                    //txtFecha_nac.Text = registro.fecha_nac;
                    //txtSexo.Text = registro.sexo;
                    //txtTelefono.Text = registro.telefono;
                    //txtDireccion.Text = registro.direccion;
                    //txtDireccion.Enabled = false;
                    //ubigeo registro3 = ubigeoNE.buscarPorCodigo(registro.ubigeo);
                    //txtUbigeo.Text = registro3.cod_ubigeo;
                    //txtDepartamento.Text = registro3.desc_departamento;
                    //txtProvincia.Text = registro3.desc_provincia;
                    //txtDistrito.Text = registro3.desc_distrito;
                    //txtUbigeo.Enabled = true;
                    //txtApe_paterno.Enabled = false;
                    //txtApe_materno.Enabled = false;
                    //txtNombres.Enabled = false;
                    //txtFecha_nac.Enabled = false;
                    //txtSexo.Enabled = false;
                    txtDireccion.Enabled = true;
                    //MessageBox.Show("DNI ingresado ya se encuentra registrado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    //txtDni.Focus();
                }
                else
                {
                    persona registro2 = reniecNE.buscaPorDNI(dni);
                    if (registro2 != null)
                    {
                        txtIdpersona.Text = Convert.ToString(registro2.idpersona);
                        txtUbigeo.Text = registro2.ubigeo;
                        txtApe_paterno.Text = registro2.ape_paterno;
                        txtApe_materno.Text = registro2.ape_materno;
                        txtNombres.Text = registro2.nombres;
                        txtFecha_nac.Text = registro2.fecha_nac;
                        //txtSexo.Text = registro2.sexo;
                        //txtDireccion.Enabled = false;
                        //ubigeo registro3 = ubigeoNE.buscarPorCodigo(registro2.ubigeo);
                        //txtUbigeo.Text = registro3.cod_ubigeo;
                        //txtDepartamento.Text = registro3.desc_departamento;
                        //txtProvincia.Text = registro3.desc_provincia;
                        //txtDistrito.Text = registro3.desc_distrito;
                        txtUbigeo.Enabled = true;
                        txtApe_paterno.Enabled = false;
                        txtApe_materno.Enabled = false;
                        txtNombres.Enabled = false;
                        txtFecha_nac.Enabled = false;
                        txtSexo.Enabled = false;
                        txtDireccion.Enabled = true;
                    }
                    else
                    {
                        if (this.vBoton == "A")
                        {
                            txtUbigeo.Text = "";
                            txtApe_paterno.Text = "";
                            txtApe_materno.Text = "";
                            txtNombres.Text = "";
                            txtFecha_nac.Text = "";
                            txtSexo.Text = "";
                            txtTelefono.Text = "";
                            txtDepartamento.Text = "";
                            txtProvincia.Text = "";
                            txtDistrito.Text = "";
                            txtIdpersona.Text = "-1";
                        }
                        txtUbigeo.Enabled = true;
                        txtApe_paterno.Enabled = true;
                        txtApe_materno.Enabled = true;
                        txtNombres.Enabled = true;
                        txtFecha_nac.Enabled = true;
                        txtSexo.Enabled = true;
                        txtDireccion.Enabled = true;
                        txtTelefono.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void cargarUbigeo(ubigeo ubigeo)
        {
            //txtUbigeo.Text = ubigeo.cod_ubigeo;
            txtDepartamento.Text = ubigeo.desc_departamento;
            txtProvincia.Text = ubigeo.desc_provincia;
            txtDistrito.Text = ubigeo.desc_distrito;
        }
        private void txtCodigoserie_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtPresupuesto_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }
        private void SetTextBoxSelectAll(TextBox txtbox)
        {
            txtbox.SelectionStart = 0;
            txtbox.SelectionLength = txtbox.Text.Length;
        }
        private void txtFecha_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });
        }

        private void txtFechara_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });
        }

        private void SetMaskedTextBoxSelectAll(MaskedTextBox txtbox)
        {
            txtbox.SelectAll();
        }

        private void txtFecharq_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });
        }


        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtApe_paterno_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtApe_materno_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtFecha_nac_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar.ToString() == "1" || e.KeyChar.ToString() == "2")
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtDni_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUbigeo_Validating(object sender, CancelEventArgs e)
        {
            string cod_ubigeo = txtUbigeo.Text;
            try
            {
                ubigeo registro = ubigeoNE.buscarPorCodigo(1);
                if (registro != null)
                {
                    //txtUbigeo.Text = registro.cod_ubigeo;
                    txtDepartamento.Text = registro.desc_departamento;
                    txtProvincia.Text = registro.desc_provincia;
                    txtDistrito.Text = registro.desc_distrito;
                }
                else
                {
                    if (MessageBox.Show("Código no encontrado, desea buscar por descripción?", "Mensaje de confirmación", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmUbigeoBuscar);
                        if (frm != null)
                        {
                            frm.BringToFront();
                            return;
                        }
                        frmUbigeoBuscar f = new frmUbigeoBuscar();
                        f.pasadoUbigeo += new frmUbigeoBuscar.pasarUbigeo(cargarUbigeo);
                        f.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void txtUbigeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUbigeo_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            articulopresupuesto oDataRowView = cboArticulo.SelectedItem as articulopresupuesto;
            if (oDataRowView != null)
            {
                txtIdmediarticulo.Text = oDataRowView.idmediarticulo;
                txtPrecio.Text = Convert.ToString(oDataRowView.precio);
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            DataRow Renglon;
            Renglon = dtCursor.NewRow();
            Renglon[0] = Convert.ToInt32(txtCantidad.Text);
            Renglon[1] = txtIdmediarticulo.Text;
            Renglon[2] = cboArticulo.SelectedValue;
            Renglon[3] = cboArticulo.Text;
            Renglon[4] = Convert.ToDecimal(txtPrecio.Text);
            Renglon[5] = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
            vTotal = vTotal + Convert.ToDecimal(Renglon[5]);
            dtCursor.Rows.Add(Renglon);
            txtTotal.Text = vTotal.ToString("0,0.00");
            this.dgvCursor.DataSource = dtCursor;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCursor.RowCount > 0)
            {
                vTotal = vTotal - (decimal)dgvCursor.CurrentRow.Cells["subtotal"].Value;
                txtTotal.Text = vTotal.ToString("0,0.00");
                dgvCursor.Rows.Remove(dgvCursor.CurrentRow);
            }
        }

        private void imprimirPresupuesto()
        {
            //Creamos una instancia d ela clase CrearTicket
            crearTicket ticket = new crearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(sesion.empresasesion.nombreempresa);
            ticket.TextoCentro(sesion.almacensesion.nombrealmacen);
            ticket.TextoCentro(sesion.empresasesion.direccion);
            ticket.TextoCentro(sesion.empresasesion.distrito.Trim());
            ticket.TextoCentro("TELEFONO: " +sesion.empresasesion.telefono);
            //ticket.TextoIzquierda("DIRECCION: " + sesion.almacensesion.direccion.Substring(0,30));
            //ticket.TextoIzquierda(sesion.almacensesion.direccion.Substring(31, sesion.almacensesion.direccion.Length-34));
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Estacion:" + System.Environment.MachineName.Trim(), "Ticket: " + tmpPresupuesto.codigoserie.Trim() + "-" + tmpPresupuesto.numeropresupuesto.Trim());
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + txtFecha.Text, "HORA: " + DateTime.Now.ToShortTimeString());
            //ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("VENDEDOR(A): " + sesion.usuariosesion.nombre);
            ticket.TextoIzquierda("CLIENTE: " + txtApe_paterno.Text.Trim() + ' ' + txtApe_materno.Text.Trim() + ' ' + txtNombres.Text.Trim());
            ticket.TextoIzquierda("TELEFONO: " + txtTelefono.Text.Trim() );
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("MARCA VEH.: " + ((string)cboMarca.Text).Substring(0, cboMarca.Text.Length < 25 ? cboMarca.Text.Length : 25));
            ticket.TextoIzquierda("PLACA     : " + txtPlaca.Text);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("FECHA REV. ANUAL: " + txtFechara.Text);
            ticket.TextoIzquierda("FECHA REV. QUINQ: " + txtFecharq.Text);
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgvCursor.Rows)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(fila.Cells[3].Value.ToString(), int.Parse(fila.Cells[0].Value.ToString()),
                decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[5].Value.ToString()));
            }
            //ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            //ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            //ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         TOTAL........S/  ", tmpPresupuesto.total);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("OBSERVACION: " + txtObservacion.Text.Trim());
            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + dgvCursor.RowCount);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("POR FAVOR CANJEAR POR BOLETA Y/O FACTURA");
            ticket.TextoCentro("ESTE DOCUMENTO NO DA DERECHO A EJERCER");
            ticket.TextoCentro("CRÉDITO FISCAL");
            ticket.CortaTicket();
            //ticket.ImprimirTicket("EPSON TM-U220 Receipt");//Nombre de la impresora ticketera
            ticket.ImprimirTicket(sesion.impresoraticket);//Nombre de la impresora ticketera
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text.Trim() == "/  /")
            {
                MessageBox.Show("Debe indicar la fecha del presupuesto, validar", "Mensaje de Sistema");
                return;
            }
            if (txtFechara.Text.Trim() == "/  /")
            {
                MessageBox.Show("Debe indicar la fecha de revisión anual, validar", "Mensaje de Sistema");
                return;
            }
            if (txtFecharq.Text.Trim() == "/  /")
            {
                MessageBox.Show("Debe indicar la fecha de revisión quinquenal, validar", "Mensaje de Sistema");
                return;
            }
            if (txtIdpersona.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un cliente, validar", "Mensaje de Sistema");
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe indicar el número celular del cliente, validar", "Mensaje de Sistema");
                return;
            }
            int idPersona;
            int varIdPresupuesto;
            switch (this.vBoton)
            {
                case "A":
                    ////////// Administrar persona
                    tmpPersona = new persona();
                    tmpPersona.idpersona = Convert.ToInt32(txtIdpersona.Text);
                    tmpPersona.dni = txtDni.Text;
                    tmpPersona.ape_paterno = txtApe_paterno.Text;
                    tmpPersona.ape_materno = txtApe_materno.Text;
                    tmpPersona.nombres = txtNombres.Text;
                    tmpPersona.ubigeo = txtUbigeo.Text;
                    tmpPersona.fecha_nac = txtFecha_nac.Text;
                    tmpPersona.sexo = txtSexo.Text;
                    tmpPersona.telefono = txtTelefono.Text;
                    tmpPersona.direccion = txtDireccion.Text;

                    idPersona = presupuestoNE.tramitarPersona(tmpPersona);
                    switch (idPersona)
                    {
                        case 0:
                            {
                                MessageBox.Show("Problemas al registrar al Cliente, no se puede continua con la transacción");
                                return;
                                // break;
                            }
                        case -1:
                            {
                                MessageBox.Show("Problemas al actualizar al Cliente, no se puede continua con la transacción");
                                return;
                                //     break;
                            }
                    }

                    ////////// Registrar Presupuesto
                    tmpPresupuesto = new presupuesto();
                    tmpPresupuesto.idempresa = sesion.empresasesion.idempresa;
                    tmpPresupuesto.idpuntoventa = sesion.puntoventasesion.idpuntoventa;
                    tmpPresupuesto.codigoserie = txtCodigoserie.Text;
                    tmpPresupuesto.numeropresupuesto = txtPresupuesto.Text;
                    tmpPresupuesto.placa = txtPlaca.Text;
                    tmpPresupuesto.idpersona = Convert.ToInt32(idPersona);
                    tmpPresupuesto.fechapresupuesto = txtFecha.Text;
                    tmpPresupuesto.fecharq = txtFecharq.Text;
                    tmpPresupuesto.fechara = txtFechara.Text;
                    tmpPresupuesto.idmarca = Convert.ToInt32(cboMarca.SelectedValue);
                    tmpPresupuesto.idmodelo = Convert.ToInt32(cboModelo.SelectedValue);
                    tmpPresupuesto.total = Convert.ToDecimal(txtTotal.Text);
                    tmpPresupuesto.observacion = txtObservacion.Text;

                    //Registrar cabecera detalle
                    varIdPresupuesto = presupuestoNE.presupuestoInsertar(tmpPresupuesto, dtCursor, sesion.puntoventasesion.idpuntoventa,sesion.usuariosesion.idusuario);
                    if (varIdPresupuesto <= 0)
                    {
                        MessageBox.Show("Problemas al registrar el Presupuesto, validar");
                        return;
                    }

                    //MessageBox.Show("Registro Ok");
//                    int vNumero = puntoventaNE.puntoventaAumentarNumero(sesion.empresasesion.idempresa, "P","C");
                    //if (vNumero == 0)
                    //{
                    //    MessageBox.Show("Problemas al actualizar el número de presupuesto, validar");
                    //    return;
                    //}

                    pasado(varIdPresupuesto);
                    break;
                case "M":
                    tmpPersona = new persona();
                    tmpPersona.idpersona = Convert.ToInt32(txtIdpersona.Text);
                    tmpPersona.dni = txtDni.Text;
                    tmpPersona.ape_paterno = txtApe_paterno.Text;
                    tmpPersona.ape_materno = txtApe_materno.Text;
                    tmpPersona.nombres = txtNombres.Text;
                    tmpPersona.ubigeo = txtUbigeo.Text;
                    tmpPersona.fecha_nac = txtFecha_nac.Text;
                    tmpPersona.sexo = txtSexo.Text;
                    tmpPersona.telefono = txtTelefono.Text;
                    tmpPersona.direccion = txtDireccion.Text;
                    idPersona = presupuestoNE.tramitarPersona(tmpPersona);
                    switch (idPersona)
                    {
                        case 0:
                            {
                                MessageBox.Show("Problemas al registrar al Cliente, no se puede continua con la transacción");
                                return;
                                // break;
                            }
                        case -1:
                            {
                                MessageBox.Show("Problemas al actualizar al Cliente, no se puede continua con la transacción");
                                return;
                                //     break;
                            }
                    }
                    tmpPresupuesto.idempresa = sesion.empresasesion.idempresa;
                    tmpPresupuesto.idpuntoventa = sesion.puntoventasesion.idpuntoventa;
                    tmpPresupuesto.codigoserie = txtCodigoserie.Text;
                    tmpPresupuesto.numeropresupuesto = txtPresupuesto.Text;
                    tmpPresupuesto.placa = txtPlaca.Text;
                    tmpPresupuesto.idpersona = Convert.ToInt32(idPersona);
                    tmpPresupuesto.fechapresupuesto = txtFecha.Text;
                    tmpPresupuesto.fecharq = txtFecharq.Text;
                    tmpPresupuesto.fechara = txtFechara.Text;
                    tmpPresupuesto.idmarca = Convert.ToInt32(cboMarca.SelectedValue);
                    tmpPresupuesto.idmodelo = Convert.ToInt32(cboModelo.SelectedValue);
                    tmpPresupuesto.total = Convert.ToDecimal(txtTotal.Text);
                    tmpPresupuesto.observacion = txtObservacion.Text;

                    varIdPresupuesto = presupuestoNE.presupuestoActualizar(tmpPresupuesto, dtCursor,sesion.usuariosesion.idusuario);
                    if (varIdPresupuesto <= 0)
                    {
                        MessageBox.Show("Problemas al actualizar el Presupuesto, validar");
                        return;
                    }
                    //MessageBox.Show("Actulización Ok");
                    pasado(varIdPresupuesto);

                    break;
            }

            DialogResult result;

            if (this.vBoton == "A")
            {
                result = MessageBox.Show("Desea imprimir la proforma?", "Mensaje de confirmación", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    imprimirPresupuesto();
                }
            }
            else if (this.vBoton == "M")
            {
                if (sesion.usuariosesion.idperfil == 3)
                {
                    result = MessageBox.Show("Desea imprimir la proforma?", "Mensaje de confirmación", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        imprimirPresupuesto();
                    }
                }
            }

            this.Dispose();
        }
    }
}