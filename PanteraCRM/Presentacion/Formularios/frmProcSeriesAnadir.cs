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
    public partial class frmProcSeriesAnadir : Form
    {       
        public frmProcSeriesAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void textBox1_Click(object sender, EventArgs e)
        {
            
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            DialogResult res =   f.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtcodprod.Text = f.chcodigoproducto;
                txtNombreconpuesto.Text = f.nombrecompuesto;
                txtidcodigo.Text = ""+f.p_inidproducto;
                txtCantidad.Enabled = true;
                txtCantidad.Text = ""+1;
                txtCantidad.Focus();
                dgvListaIngreso.Rows.Clear();
                txtSerie.Text = "";
                txtObs.Text = "";
                if (f.p_inidsituacionproducto > 1)
                {
                    ckbSerie.Checked = true;
                    grbAgregadoSerie.Enabled = true;
                }

            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ckbSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSerie.Checked == true)
            {
                grbAgregadoSerie.Enabled= true;
                dgvListaIngreso.Enabled = true;
            }
            if (ckbSerie.Checked == false)
            {
                grbAgregadoSerie.Enabled = false;
                dgvListaIngreso.Enabled = false;
            }
        }
        
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            bool valCantidad = txtCantidad.Text.Length > 0 && int.Parse(txtCantidad.Text) > 0;
            bool valListasize = int.Parse(txtCantidad.Text) > dgvListaIngreso.RowCount  ;
            bool valserie = txtSerie.Text.Length > 0;
            bool valExisBd = validarExistencia(txtSerie.Text);
            bool valExisList = validarExistenciaMemoria(txtSerie.Text);
            if (valCantidad)
            {               
                if (valListasize)
                {
                    if (valserie)
                    {
                        if (!valExisBd && !valExisList)
                        {
                            int p_inidproducto = int.Parse(txtidcodigo.Text);
                            string chproducto = txtidcodigo.Text;
                            string chnombrecompuesto = txtNombreconpuesto.Text;
                            string chserie = txtSerie.Text;
                            string chobs = txtObs.Text;
                            dgvListaIngreso.Rows.Add(p_inidproducto, chproducto, chnombrecompuesto, chserie, chobs);
                            txtSerie.Text = "";
                            txtObs.Text = "";
                            txtSerie.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La Serie Ingresada ya Existe", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingreso de Serie Obligatorio");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Lista de Producto Completada");
                    return;
                }
            }
            else
            {
                MessageBox.Show("La cantidad Invalida");
                txtCantidad.Focus();
                return;
            }


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvListaIngreso.RowCount == 0 && dgvListaIngreso.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            dgvListaIngreso.Rows.Remove(dgvListaIngreso.CurrentRow);
        }       
        
        private bool validarExistencia(string cosigoserie)
        {     
            return serieNE.verificarExistencia(cosigoserie);           
        }
        private bool validarExistenciaMemoria(string cosigoserie)
        {
            bool flat = false;
                for (int i = 0; i < dgvListaIngreso.RowCount ; i++)
                {
                    if (dgvListaIngreso.Rows[i].Cells[3].Value.ToString() == cosigoserie)
                    {
                        flat = true;
                    }
                }
            return flat;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLOR NUMEROS Y BORRADO
            if (!char.IsDigit(e.KeyChar) &&  !(8== Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;
            }
            // VALIDAR CON UN SOLO PUNTO DECIMAL
            //if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            //{
            //    e.Handled = true;
            //}
            //if (e.KeyChar == '.'  && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}


        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtCantidad.Text) > 0 && txtCantidad.Text.Length > 0)
            {
                if (dgvListaIngreso.Rows.Count > int.Parse(txtCantidad.Text))
                {
                    dgvListaIngreso.Rows.Clear();
                    return;
                }
            }
        }
    }
}
