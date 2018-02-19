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
        }
        public void calcular()
        {
            int cantidad = 0;
            if (txtCantidad.Text.Length >0)
            {
                cantidad =int.Parse(txtCantidad.Text);
            }
            decimal precio = 0;
            if (txtprecio.Text.Length > 0)
            {
                precio = decimal.Parse(txtprecio.Text);
            }
            txtsubtotal.Text =decimal.Round( precio * cantidad).ToString();
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
            txtcodprod.Focus();
            txtNombreconpuesto.Text = "";
            txtMedida.Text = "";
            txtidcodigo.Text = "";
            txtCantidad.Text = "0";
            txtSerie.Text = "";
            txtCodigoSerie.Text = "";
            txtObs.Text = "";
            txtprecio.Text = "0.00";
        }

        private void txtcodprod_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtcodprod.Text;
            buscaProducto(parametro);
        }

        private void txtcodprod_DoubleClick(object sender, EventArgs e)
        {
            frmBusquedaProductoGeneral f = new frmBusquedaProductoGeneral();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                
                txtcodprod.Text = f.chcodigoproducto;

            }
        }
        public void buscaProducto(string parametro)
        {
            List<productoparaventa> obprodventa = new List<productoparaventa>();
            obprodventa = productoNE.ProductosVentaParametro(parametro);
            if (obprodventa.Count > 0)
            {
                foreach (productoparaventa a in obprodventa)
                {
                    txtNombreconpuesto.Text = a.chnombrecompuesto;
                    txtMedida.Text = a.chunidadmedidaproducto;
                    txtidcodigo.Text = "" + a.p_inidproducto;
                    txtCantidad.Enabled = true;
                    txtCantidad.Text = "0";
                    txtCantidad.Focus();
                    txtSerie.Text = "";
                    txtCodigoSerie.Text = "";
                    txtObs.Text = "";
                    txtprecio.Text = "00.00";
                    if (a.req_serie)
                    {
                        //ckbSerie.Checked = true;
                        grbAgregadoSerie.Enabled = true;
                    }

                }
                dgvListaIngreso.Rows.Clear();
            }
            else
            {
                txtNombreconpuesto.Text = "";
                txtMedida.Text = "";
                txtidcodigo.Text = "";
                txtCantidad.Text = "0" ;
                txtSerie.Text = "";
                txtCodigoSerie.Text = "";
                txtObs.Text = "";
                txtprecio.Text = "00.00";
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtprecio.Text.Length; i++)
            {
                if (txtprecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            calcular();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            calcular();
        }
    }
}
