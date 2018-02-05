using Entidades;
using Negocios;
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
    public partial class frmArticulo : Form
    {
        private string vBoton = "A";
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmArticuloAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmArticuloAnadir f = new frmArticuloAnadir(vBoton);
                    f.pasado += new frmArticuloAnadir.pasar(ejecutar);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error de Aceso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sisaaatema", MessageBoxButtons.OK);
            }
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }
        public void cargarData(int registro)
        {
            List<articulo> listado = articuloNE.articuloListar();
            dgvArticulo.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvArticulo.Rows)
            {
                int valor = (int)Row.Cells["IDARTICULO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvArticulo.CurrentCell = dgvArticulo.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioAnadir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }

        }

        private void cargarFormularioAnadir()
        {
            if (dgvArticulo.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmArticuloAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmArticuloAnadir f = new frmArticuloAnadir(vBoton);
            f.pasado += new frmArticuloAnadir.pasar(ejecutar);
            f.tmpProducto = new producto();
            //f.tmpArticulo.idarticulo = (int)dgvArticulo.CurrentRow.Cells["IDARTICULO"].Value;
            //f.tmpArticulo.codigoarticulo = (string)dgvArticulo.CurrentRow.Cells["CODIGOARTICULO"].Value;
            //f.tmpArticulo.nombrearticulo = (string)(dgvArticulo.CurrentRow.Cells["NOMBREARTICULO"].Value);
            //f.tmpArticulo.idtipoarticulo = (string)(dgvArticulo.CurrentRow.Cells["IDTIPOARTICULO"].Value);
            //f.tmpArticulo.idcatearticulo = (string)(dgvArticulo.CurrentRow.Cells["IDCATEARTICULO"].Value);
            //f.tmpArticulo.idmediarticulo = (string)(dgvArticulo.CurrentRow.Cells["IDMEDIARTICULO"].Value);
            //f.tmpArticulo.fechacreacion = (string)(dgvArticulo.CurrentRow.Cells["FECHACREACION"].Value);
            //f.tmpArticulo.precio = (decimal)(dgvArticulo.CurrentRow.Cells["PRECIO"].Value);
            //f.tmpArticulo.idsituarticulo = (string)(dgvArticulo.CurrentRow.Cells["IDSITUARTICULO"].Value);
            //f.tmpArticulo.estadoarticulo = (bool)(dgvArticulo.CurrentRow.Cells["ESTADOARTICULO"].Value);
            f.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}