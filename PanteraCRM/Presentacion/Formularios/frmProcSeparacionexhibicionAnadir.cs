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
    public partial class frmProcSeparacionexhibicionAnadir : Form
    {
        internal productoserie tmpProductoSerie;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmProcSeparacionexhibicionAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grbDatosexhi.Enabled = ckbExhibicion.Checked;            
        }

        private void frmProcSeparacionexhibicionAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (this.vBoton == "A")
            {

            }
            else
            {
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR EXHIBICION";
                    cargarDatos();
                }
                else
                {
                    if (this.vBoton == "V")
                    {
                        this.Text = "VER EXHIBICION";
                        cargarDatos();
                        grbDatosexhi.Enabled = true;
                        txtObservacion.ReadOnly = true;
                        txtFecha.ReadOnly = true;
                        txtDocumento.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                        txtDocumento.ForeColor = Color.Blue;
                        txtDocumento.ReadOnly = true;
                        txtObservacion.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                        txtObservacion.ForeColor = Color.Blue;
                        txtFecha.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                        txtFecha.ForeColor = Color.Blue;
                        btnGrabar.Enabled = false;
                    }
                }                   
            }                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void cargarDatos()
        {
            txtCodigo.Text = tmpProductoSerie.chcodigoproducto;
            txtDescripcion.Text = tmpProductoSerie.chdescripcion;
            txtidentificador.Text = tmpProductoSerie.identificador;            
            txtSerie.Text = tmpProductoSerie.chcodigoserie;
            ckbExhibicion.Checked = tmpProductoSerie.boexhibicion;
            txtDocumento.Text = tmpProductoSerie.chinforme;
            txtObservacion.Text = tmpProductoSerie.chinformeobs;
            txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int flat;
            switch (this.vBoton)
            {
                case "M":
                    int p_inidserie;
                    string chinforme, chinformeobs, chinformefecha;
                    bool boexhibicion;
                    p_inidserie = tmpProductoSerie.p_inidserie;
                    chinforme = txtDocumento.Text;
                    chinformeobs = txtObservacion.Text;
                    chinformefecha = txtFecha.Text;
                    boexhibicion = ckbExhibicion.Checked;
                    int cantidad = 0;
                    if (boexhibicion)
                    {
                        cantidad = 1;
                    }else
                    {
                        cantidad = -1;
                    }
                    int entero = almacenNE.CambiarSaldoComprometido(sesion.SessionGlobal.p_inidalmacen, tmpProductoSerie.p_inidproducto, cantidad);
                    flat = exhibicionNE.ExibicionIngresar(p_inidserie, chinforme, chinformeobs, chinformefecha, boexhibicion);
                    if (flat <= 0)
                    {
                        MessageBox.Show("Error en el Ingreso", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        pasado(flat);
                    }


                    break;
                case "V":

                    break;
                default:
                    break;
            }
            this.Dispose();
            
        }
    }
}
