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
        
        internal serie tmpSerie;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmProcSeriesAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            if (!char.IsDigit(e.KeyChar) &&  !(8== Convert.ToInt32(e.KeyChar)) )
            {
                e.Handled = true;
                
            }
            decimal vadsr = decimal.Parse(txtprecio.Text) * int.Parse(txtCantidad.Text);
            txtsubtotal.Text = "" + vadsr;
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

        

        private void txtcodprod_MouseClick(object sender, MouseEventArgs e)
        {
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtcodprod.Text = "";
                txtcodprod.Text = f.chcodigoproducto;
                txtNombreconpuesto.Text = f.nombrecompuesto;
                txtidcodigo.Text = "" + f.p_inidproducto;
                txtMedida.Text = f.chmedida;
                txtCantidad.Enabled = true;
                txtCantidad.Text = "" + 1;
                txtCantidad.Focus();
                dgvListaIngreso.Rows.Clear();
                txtSerie.Text = "";
                txtObs.Text = "";
                txtprecio.Text = "" + Decimal.Round(f.nuprecio,2);
                
                
                if (f.p_inidsituacionproducto > 1)
                {
                    //ckbSerie.Checked = true;
                    grbAgregadoSerie.Enabled = true;
                }

            }
        }

        private void txtcodprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {

                txtcodprod.Text = "";
                txtcodprod.Text = f.chcodigoproducto;
                txtNombreconpuesto.Text = f.nombrecompuesto;
                txtidcodigo.Text = "" + f.p_inidproducto;
                txtMedida.Text = f.chmedida;
                txtCantidad.Enabled = true;
                txtCantidad.Text = "" + 1;
                txtCantidad.Focus();
                dgvListaIngreso.Rows.Clear();
                txtSerie.Text = "";
                txtObs.Text = "";
                txtprecio.Text = "" + Decimal.Round(f.nuprecio, 2);
                if (f.req_seriesss)
                {
                    //ckbSerie.Checked = true;
                    grbAgregadoSerie.Enabled = true;
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // IDEA: PARA GARANTIZAR EL INGRESO SE TENDRIA QUE GUARDAR EN UN ARREGLO Y LUEGO VALIDAR SU EXISTENCIA TOTAL.
            int varIdArticulo;
            switch (this.vBoton)
            {
                case "A":
                    //ATRIBUTOS PARA INGRESAR PRODUCTO
                    // CONFIRMACION
                    bool flat3 = ValidarCampos();                    
                    if (flat3)
                    {
                        //VALIDACION
                        bool flat4 = ConfirmacionRegistro();
                        if (flat4)
                        {
                            //INGRESO
                            bool flat = true;
                            //IngresoRegistros();
                            List<serie> obsej =  new List<serie>();
                            for (int i = 0; i < dgvListaIngreso.RowCount; i++)
                            {
                               
                                tmpSerie = new serie();
                                tmpSerie.chcodigoserie = dgvListaIngreso.Rows[i].Cells[3].Value.ToString();
                                tmpSerie.estado = true;
                                tmpSerie.p_inidproducto = int.Parse(txtidcodigo.Text);
                                tmpSerie.chadicional = dgvListaIngreso.Rows[i].Cells[4].Value.ToString();
                                tmpSerie.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                                tmpSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                                tmpSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                                obsej.Add(tmpSerie);

                            }
                            sesion.listaserie = obsej;
                            valedetalle valedetallessss = new valedetalle();
                            valedetallessss.chnombrecompuesto = txtNombreconpuesto.Text;
                            valedetallessss.chcodigoproducto = txtcodprod.Text;
                            valedetallessss.chcodigoserie = txtMedida.Text;
                            valedetallessss.p_inidproducto = int.Parse(txtidcodigo.Text);
                            valedetallessss.nucantidad = int.Parse(txtCantidad.Text);
                            valedetallessss.nucosto = decimal.Parse(txtprecio.Text);
                            valedetallessss.nutotal = decimal.Parse(txtsubtotal.Text);

                            sesion.valedetalles = valedetallessss;
                            //MessageBox.Show("Las Series se Ingresaron al Sistema");
                            dgvListaIngreso.Rows.Clear();
                             
                                
                            
                           
                           
                         }
                    }else
                    {
                        MessageBox.Show("Campos incorrectos verificar");
                        return;
                    }                                   
                   
                    break;
                case "M":
                    tmpSerie = new serie();
                    varIdArticulo = serieNE.seriesIngresar(tmpSerie);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                        MessageBox.Show("Registro actualizado");
                        pasado(varIdArticulo);
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();  
        }
        private  bool IngresoRegistros()
        {
            List<serie> registo= new List<serie>();
            bool flat2 = false;
            for (int i = 0; i < dgvListaIngreso.RowCount; i++)
            {
                tmpSerie = new serie();
                tmpSerie.chcodigoserie = dgvListaIngreso.Rows[i].Cells[3].Value.ToString();
                tmpSerie.estado = true;
                tmpSerie.p_inidproducto = int.Parse(txtidcodigo.Text);
                tmpSerie.chadicional = dgvListaIngreso.Rows[i].Cells[4].Value.ToString();
               int  varIdArticulo = serieNE.seriesIngresar(tmpSerie);
                if (varIdArticulo > 0)
                {
                    tmpSerie.p_inidserie = i;
                    // SE acumula el registro
                    registo.Add(tmpSerie);
                }

            }
            if (registo == null)
            {
                flat2 = false;
            }else
            {
                foreach (serie aPart in registo)
                {
                    int a = aPart.p_inidserie;
                    dgvListaIngreso.CurrentCell = dgvListaIngreso.Rows[a].Cells[a];
                    dgvListaIngreso.Rows.Remove(dgvListaIngreso.CurrentRow);
                }
                if (dgvListaIngreso.RowCount > 0)
                {
                    flat2 = false;
                }else
                {
                    flat2 = true;
                }
            }               
            return flat2;
        }
        private bool ValidarCampos()
        {

            return true;
        }
        private bool ConfirmacionRegistro()
        {
            bool flat55 = false;
            if (MessageBox.Show("¿Esta Seguro de Grabar las series?", "Mensaje de Confirmación",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                flat55 = true;
            }
            return flat55;
        }

        private void frmProcSeriesAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            mskFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
        }
    }
}
