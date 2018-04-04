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

namespace Presentacion
{
    public partial class frmManClienteLicenciaAnadir : Form
    {
        internal List<licencia> ListaLicenciasG;
        public delegate void PasarLicencias(List<licencia> LicenciasRegistro);
        public event PasarLicencias pasado;
        public delegate void pasarcantidad(int cantidad);
        public event pasarcantidad pasadocantidad;
        public frmManClienteLicenciaAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string tarjeta = txtCodigo.Text;

                DateTime dt1 = DateTime.Parse(txtFechVenci.Text);
                string fecha = dt1.ToString("dd/MM/yyyy");
                
                dgvListasTarjetas.Rows.Add("", "", tarjeta, fecha, "");
                txtCodigo.Text = "";
                txtFechVenci.Text = "";
            }
            else
            {
                return;
            }
        }
        public bool ValidarCampos()
        {
            bool flat = false;
            if (txtCodigo.Text.Length > 0)
            {
                if (txtFechVenci.Text.Length > 0)
                {
                    flat = true;
                }
                else
                {
                    MessageBox.Show("Fecha de Vencimiento Vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Código Vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
            return flat;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvListasTarjetas.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            dgvListasTarjetas.Rows.Remove(dgvListasTarjetas.CurrentRow);
        }

        private void frmManClienteLicenciaAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (ListaLicenciasG != null)
            {
                CargarTalba();
            }
        }
        private void CargarTalba()
        {
            foreach (licencia Registros in ListaLicenciasG)
            {
                dgvListasTarjetas.Rows.Add("", "", Registros.chlicencia, Registros.fechavencimiento, "");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (basicas.validarAcceso("G"))
            {
                if (dgvListasTarjetas.RowCount > 0)
                {
                    ListaLicenciasG = new List<licencia>();
                    int count = 0;
                    for (int i = 0; i < dgvListasTarjetas.RowCount; i++)
                    {
                        licencia RegistrosIngresoDetalle = new licencia();
                        RegistrosIngresoDetalle.chlicencia = dgvListasTarjetas.Rows[i].Cells["CHLICENCIA"].Value.ToString();
                        RegistrosIngresoDetalle.fechavencimiento = dgvListasTarjetas.Rows[i].Cells["CHVENCIMIENTO"].Value.ToString();
                        ListaLicenciasG.Add(RegistrosIngresoDetalle);
                        count++;
                    }
                    pasado(ListaLicenciasG);
                    pasadocantidad(count);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Lista de Registros Vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
            }            
        }
    }
}
