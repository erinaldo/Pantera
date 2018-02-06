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
    public partial class frmBusquedaProductoGeneral : Form
    {
        private string vBoton = "X";
        public int p_inidproducto;
        public string chcodigoproducto;
        public string nombrecompuesto;
        public int p_inidsituacionproducto;
        public string chsituacionproducto;
        public frmBusquedaProductoGeneral()
        {
            InitializeComponent();
        }
        
        public void cargarData(int registro,string parametro)
        {
            List<productobuscado> listado = productoNE.productobuscadoListar(parametro);
            dgvProductosBuscados.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dgvProductosBuscados.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvProductosBuscados.CurrentCell = dgvProductosBuscados.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string parametro = textBox1.Text;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,parametro);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
               cargarFormularioAnadir();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void cargarFormularioAnadir()
        {
            if (dgvProductosBuscados.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
           
            p_inidproducto= (int)dgvProductosBuscados.CurrentRow.Cells["IDPRODUCTO"].Value;
            chcodigoproducto= (string)dgvProductosBuscados.CurrentRow.Cells["CHCODIGO"].Value;
            nombrecompuesto = (string)(dgvProductosBuscados.CurrentRow.Cells["CHPRODUCTO"].Value);
            p_inidsituacionproducto = (int)dgvProductosBuscados.CurrentRow.Cells["IDSITUACION"].Value;
            chsituacionproducto = (string)(dgvProductosBuscados.CurrentRow.Cells["CHSITUACION"].Value);

        }
    }
}
