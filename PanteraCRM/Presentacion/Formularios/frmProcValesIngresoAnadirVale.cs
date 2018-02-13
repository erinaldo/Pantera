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
        }
        decimal suma = 0;
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
            txtTotal.Text = ""+suma;

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
            f.pasado += new frmProcSeriesAnadir.pasar(ejecutar);
            
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                valedetalle obj = sesion.valedetalles;
                if (obj != null)
                {
                    dgvListaValeDetalle.Rows.Add(
                     obj.chcodigoproducto, obj.chcodigoproducto,
                     obj.nucantidad,
                     obj.chcodigoserie,
                     obj.chnombrecompuesto,
                     obj.nucosto,
                     obj.nutotal);
                    suma =suma + obj.nutotal;
                    txtTotal.Text = "" + suma;

                }
                else
                {
                    MessageBox.Show("No hay datos");
                }
                

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
    }
}
