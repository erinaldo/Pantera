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
            int vale = valeNE.generarcorrelativo()+1;
            string correlativo="00000000"+ vale;
            int cfin = correlativo.Length-1;
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
            f.p_inidproducto = dgvListaValeDetalle.RowCount+1;
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
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
            sesion.movprodaccion.Clear();
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
                txtTotal.Text = decimal.Round(suma,2).ToString();
            }
        }
    }
}
