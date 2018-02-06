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
        internal productobuscado tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
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
                textBox1.Text = f.chcodigoproducto;
                txtNombreconpuesto.Text = f.nombrecompuesto;
                txtidcodigo.Text = ""+f.p_inidproducto;
                txtCantidad.Enabled = true;
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
            int p_inidproducto;
            int cantidad;
            int contador;
            string chproducto;
            string chnombrecompuesto;
            string chserie;
            string chobs;
            
            contador = dgvListaIngreso.Rows.Count;
            if (txtCantidad.Text.Length > 0 && Int32.Parse(txtCantidad.Text) > 0)
            {
                cantidad = Int32.Parse(txtCantidad.Text);
                if (contador <= cantidad)
                {
                    if(txtSerie.Text.Length > 0)
                    {
                        if (!validarExistencia(txtSerie.Text))
                        {
                            if (!validarExistenciaMemoria(txtSerie.Text))
                            {
                                p_inidproducto = Int32.Parse(txtidcodigo.Text);
                                chproducto = txtidcodigo.Text;
                                chnombrecompuesto = txtNombreconpuesto.Text;
                                chserie = txtSerie.Text;
                                chobs = txtObs.Text;
                                dgvListaIngreso.Rows.Add(p_inidproducto, chproducto, chnombrecompuesto, chserie, chobs);
                                txtSerie.Text = "";
                                txtObs.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("La Serie Ingresada Ya Existe", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                return;
                            }
                            
                        }else
                        {
                            MessageBox.Show("La Serie Ingresada Ya Existe", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
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
                return;
            }
           
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvListaIngreso.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }else
            {
                if (dgvListaIngreso.Rows.Count == 0)
                {
                    MessageBox.Show("Lista Vacia", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                   dgvListaIngreso.Rows.Remove(dgvListaIngreso.CurrentRow);
                    
                }
            }
            
                       
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0 && Int32.Parse(txtCantidad.Text) > 0)
            {
                if (dgvListaIngreso.Rows.Count > Int32.Parse(txtCantidad.Text))
                {
                    dgvListaIngreso.Rows.Clear();
                    return;
                }
            }else
            {
                MessageBox.Show("Cantidad Invalida");
                return;
            }
            
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
    }
}
