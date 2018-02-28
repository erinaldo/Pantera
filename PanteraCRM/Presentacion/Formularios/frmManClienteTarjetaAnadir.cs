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
    public partial class frmManClienteTarjetaAnadir : Form
    {
        internal int codigocliente;
        internal List<tarjetapropiedad> ListaTarjetadeProiedadG;
        public delegate void PasarListaTarjetas(List<tarjetapropiedad> TarjetasRegistro);
        public event PasarListaTarjetas pasado;

        public delegate void pasarcantidad(int cantidad);
        public event pasarcantidad pasadocantidad;
        public frmManClienteTarjetaAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string tarjeta = txtCodigo.Text;
                string fecha = txtFechVenci.Text;
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
                }else
                {                    
                    MessageBox.Show("Fecha de Vencimiento Vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }else
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmManClienteTarjetaAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (ListaTarjetadeProiedadG != null)
            {
                CargarTalba();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dgvListasTarjetas.RowCount > 0)
            {
                ListaTarjetadeProiedadG = new List<tarjetapropiedad>();
                int count = 0;
                for (int i = 0; i < dgvListasTarjetas.RowCount; i++)
                {
                    tarjetapropiedad RegistrosIngresoDetalle = new tarjetapropiedad();
                    RegistrosIngresoDetalle.chtarjeta = dgvListasTarjetas.Rows[i].Cells["CHTARJETA"].Value.ToString();
                    RegistrosIngresoDetalle.fechavencimiento = dgvListasTarjetas.Rows[i].Cells["CHVENCIMIENTO"].Value.ToString();
                    ListaTarjetadeProiedadG.Add(RegistrosIngresoDetalle);
                    count++;
                }
                pasado(ListaTarjetadeProiedadG);
                pasadocantidad(count);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lista de Registros Vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
            
        }
        private void CargarTalba()
        {
           foreach(tarjetapropiedad Registros  in ListaTarjetadeProiedadG)
            {
                dgvListasTarjetas.Rows.Add("", "", Registros.chtarjeta, Registros.fechavencimiento, "");
            }
        }
    }
}
