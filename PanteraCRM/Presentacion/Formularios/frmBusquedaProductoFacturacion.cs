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
    public partial class frmBusquedaProductoFacturacion : Form
    {
        public frmBusquedaProductoFacturacion()
        {
            InitializeComponent();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void cargarData(int registro, string parametro)
        {
            List<productobuscado> listado = productoNE.productobuscadoListar(parametro);
            dgvListaProductos.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaProductos.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaProductos.CurrentCell = dgvListaProductos.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {

        }
    }
}
