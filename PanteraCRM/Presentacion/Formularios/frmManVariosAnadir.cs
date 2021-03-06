﻿using System;
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
    public partial class frmManVariosAnadir : Form
    {
        //internal producto tmpProducto;
        internal int Maestrocodigo;
        internal List<maestrodetalle> DetalleListas;
        public delegate void pasar(int varreg); 
        public event pasar pasado;
        public frmManVariosAnadir(string vBoton)
        {
            InitializeComponent();
        this.vBoton = vBoton;
        }
        string vBoton;
        private void frmManVariosAnadir_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (vBoton=="A")
            {

            }
            else
            {
                if (vBoton == "M")
                {
                    this.Text = "MODIFICAR CABECERA";                    
                    CargarDatos(Maestrocodigo);
                }
                else
                {
                    if (vBoton == "V")
                    {
                        this.Text = "VISUALIZAR CABECERA";
                        CambiarForma(txtCod);
                        CambiarForma(txtAcro);
                        CambiarForma(txtDescrip);
                        CambiarForma(txtDetDesc);
                        CambiarForma(txtObbs);
                        dgvListaDetalle.ReadOnly = true;
                        btnGrabar.Enabled = false;
                        btnAnadir.Enabled = false;
                        btnQuitar.Enabled = false;                
                        CargarDatos(Maestrocodigo);
                    }
                }
            }
        }
        private void CambiarForma(TextBox texbox)
        {
            texbox.ReadOnly = true;
            texbox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            texbox.ForeColor = Color.Blue;
            texbox.TabStop = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (this.vBoton)
            {
                case "A":
                    if (ValidarCampos())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            GrabarDatos();
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
                    if (ValidarCampos())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de modificar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ModificarDatos();
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
            this.Dispose();
        }
        private void CargarDatos(int codigo)
        {
            maestrocabecera CabecerRegistros = maestrodetalleNE.MaestroCabeceraListarCodigo(codigo);
            txtDescrip.Text = CabecerRegistros.chdesmoestro;
            txtCod.Text = CabecerRegistros.chcodigomaestrocab;
            txtObbs.Text = CabecerRegistros.chobserbacion;
            List<maestrodetalle> DetalleListas1 = maestrodetalleNE.buscarPorCodigoMaestro(codigo);
            int a = 0;
            foreach (maestrodetalle Registros in DetalleListas1)
            {
                Registros.orden = a++;
            }
            DetalleListas = DetalleListas1;
            CargarTabla();
        }
        private void GrabarDatos()
        {
            Maestrocodigo = 0;
            maestrocabecera RegistrosIngresoCabecera= new maestrocabecera();
            //RegistrosIngresoCabecera.p_inidmaestrocabecera = 0;
            RegistrosIngresoCabecera.chdesmoestro = txtDescrip.Text;
            RegistrosIngresoCabecera.chobserbacion = txtObbs.Text;
            RegistrosIngresoCabecera.estado = true;
            RegistrosIngresoCabecera.chcodigomaestrocab = txtCod.Text;
            RegistrosIngresoCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            Maestrocodigo = maestrodetalleNE.MaestroCabeceraIngresar(RegistrosIngresoCabecera);
            if (Maestrocodigo <= 0)
            {
                MessageBox.Show("Error En el Ingreso", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            else
            {
                foreach (maestrodetalle d in DetalleListas)
                {
                    if (d.estado == true)
                    {
                        d.idmaestro = Maestrocodigo;
                        maestrodetalleNE.MaestroDetalleIngresar(d);
                    }
                }         
                pasado(Maestrocodigo);
            }      
        }
        private void ModificarDatos()
        {
            maestrocabecera RegistrosIngresoCabecera = new maestrocabecera();
            RegistrosIngresoCabecera.p_inidmaestrocabecera = Maestrocodigo;
            RegistrosIngresoCabecera.chdesmoestro = txtDescrip.Text;
            RegistrosIngresoCabecera.chobserbacion = txtObbs.Text;
            RegistrosIngresoCabecera.estado = true;
            RegistrosIngresoCabecera.chcodigomaestrocab = txtCod.Text;
            RegistrosIngresoCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            Maestrocodigo = maestrodetalleNE.MaestroCabeceraModificar(RegistrosIngresoCabecera);
            if (Maestrocodigo <= 0)
            {
                MessageBox.Show("Error modificacion de cabecera", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            else
            {
                foreach (maestrodetalle d in DetalleListas)
                {
                    if (d.estado == true)
                    {
                        if (d.idmaestrodetalle == 0)
                        {
                            d.idmaestro = Maestrocodigo;
                            maestrodetalleNE.MaestroDetalleIngresar(d);
                        }
                    }else
                    {
                        if (d.idmaestrodetalle != 0)
                        {
                            maestrodetalleNE.MaestroDetalleFalsear(d.idmaestrodetalle);
                        }
                    }
                }               
                pasado(Maestrocodigo);
            }
        }
        private  bool ValidarCampos()
        {
            bool flat = false;
           
            if (txtCod.Text.Length > 0 )
            {
                if (txtDescrip.Text.Length > 0)
                {
                    if (txtObbs.Text.Length > 0)
                    {
                        if (dgvListaDetalle.Rows.Count > 0)
                        {
                            flat = true;
                        }
                        else
                        {
                            MessageBox.Show("Lista Detalle Vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        }
                    }else
                    {
                        MessageBox.Show("Ingrese la Observación", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                }else
                {
                    MessageBox.Show("Ingrese la Descripción", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }else
            {
                MessageBox.Show("Ingrese un código", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
            return flat;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCod_Enter(object sender, EventArgs e)
        {
            txtCod.SelectAll();
        }

        private void txtDescrip_Enter(object sender, EventArgs e)
        {
            txtDescrip.SelectAll();
        }

        private void txtObbs_Enter(object sender, EventArgs e)
        {
            txtObbs.SelectAll();
        }

        private void txtDetDesc_Enter(object sender, EventArgs e)
        {
            txtDetDesc.SelectAll();
        }

        private void txtAcro_Enter(object sender, EventArgs e)
        {
            txtAcro.SelectAll();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {                      
            maestrodetalle RegistrosMDetalles = new maestrodetalle();
            RegistrosMDetalles.orden = DetalleListas.Count+1;
            RegistrosMDetalles.libre = txtAcro.Text;
            RegistrosMDetalles.nombreitem = txtDetDesc.Text;
            RegistrosMDetalles.estado = true;
            DetalleListas.Add(RegistrosMDetalles);
            CargarTabla();            
            txtDetDesc.Text = "";
            txtAcro.Text = "";
            txtDetDesc.Focus();
        }
        private void CargarTabla()
        {
            dgvListaDetalle.Rows.Clear();
            foreach (maestrodetalle RegistrosMDetalles in DetalleListas)
            {
                if (RegistrosMDetalles.estado == true)
                {
                    dgvListaDetalle.Rows.Add(RegistrosMDetalles.orden,RegistrosMDetalles.idmaestro, RegistrosMDetalles.idmaestrodetalle, RegistrosMDetalles.codigoitem, RegistrosMDetalles.nombreitem, RegistrosMDetalles.libre, RegistrosMDetalles.estado);
                }                
            }            
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (DetalleListas.Count > 0)
            {
                foreach ( maestrodetalle d in DetalleListas)
                {
                    if (d.orden == (int)dgvListaDetalle.CurrentRow.Cells["ORDEN"].Value)
                    {
                        d.estado = false;
                    }
                }
            }
            CargarTabla();
            txtDetDesc.Focus();
        }

        private void txtCod_Enter_1(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }
    }
}
