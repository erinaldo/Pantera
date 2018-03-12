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
    public partial class frmProcKardexProductoDetalle : Form
    {

        internal productobuscado ProductoBuscado;
        public frmProcKardexProductoDetalle()
        {
            InitializeComponent();
        }
        
        private void frmProcKardexProductoDetalle_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;            
            CargarDatosTabla();
        }
        private void CargarDatosTabla()
        {
            txtAlamacen.Text = sesion.SessionGlobal.chalamacen;
            txtCodigo.Text = ProductoBuscado.chcodigoproducto;
            txtDescrip.Text = ProductoBuscado.chnombrecompuesto;
            txtUnidad.Text = ProductoBuscado.chunidadmedidaproducto;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
