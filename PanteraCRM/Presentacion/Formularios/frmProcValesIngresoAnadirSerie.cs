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
        internal int p_inidproducto;
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
            bool valserie = txtSerie.Text.Length > 0;
            bool valExisBd = validarExistencia(txtSerie.Text);
            bool valExisList = validarExistenciaMemoria(txtSerie.Text);
            bool valExistMen = validarExistenciaMemoriaStatica(txtSerie.Text);
            if (validarCantidad())
            {               
                if (validarCantidadfilas())
                {
                    if (valserie)
                    {
                        if (!valExisBd && !valExisList  && !valExistMen)
                        {
                            int p_inidproducto = int.Parse(txtidcodigo.Text);
                            string chproducto = txtidcodigo.Text;
                            string chnombrecompuesto = txtNombreconpuesto.Text;
                            string chserie = txtSerie.Text;
                            string chobs = txtObs.Text;
                            dgvListaIngreso.Rows.Add(p_inidproducto, chproducto, chnombrecompuesto, chserie, chobs);
                            txtSerie.Text = "";
                            txtObs.Text = "";
                            txtCodigoSerie.Text = "";
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
                        MessageBox.Show("Ingreso de Serie Obligatorio", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Lista está Completada", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("La cantidad es Invalida", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
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
            if (this.vBoton == "M")
            {
                string chcodigoserie = dgvListaIngreso.CurrentRow.Cells["CHSERIE"].Value.ToString();
                dgvListaIngreso.Rows.Remove(dgvListaIngreso.CurrentRow);
                List<movimientoproductoaccion> listaMovi = sesion.movprodaccion;
                if (listaMovi != null)
                {
                    foreach (movimientoproductoaccion registrosMov in listaMovi)
                    {
                        if (registrosMov.valedet.p_inidvaledetalle == p_inidproducto)
                        {
                            List<serie> listaSerie = registrosMov.listaserie;
                            int count = 0;
                            foreach (serie registrosSerie in listaSerie)
                            {
                                if (chcodigoserie == registrosSerie.chcodigoserie)
                                {
                                    registrosSerie.estado = false;
                                }
                                count++;
                            }
                        }

                    }
                }
            }
            else
            {
                dgvListaIngreso.Rows.Remove(dgvListaIngreso.CurrentRow);
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
        private bool validarExistenciaMemoriaStatica(string cosigoserie)
        {
            bool flat = false;
            List<movimientoproductoaccion> listaMovi = sesion.movprodaccion;
            if (listaMovi != null)
            {
                foreach (movimientoproductoaccion registrosMov in listaMovi)
                {
                    List<serie> listaSerie = registrosMov.listaserie;
                    foreach (serie registrosSerie in listaSerie)
                    {
                        if (cosigoserie == registrosSerie.chcodigoserie && registrosSerie.estado == true)
                        {
                            flat = true;
                        }                        
                    }
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
            txtsubtotal.Text =decimal.Round( precio * cantidad,2).ToString();
        }

      
        private void btnGrabar_Click(object sender, EventArgs e)
        {
             //int varIdArticulo;
            switch (this.vBoton)
            {
                case "A":
                    //VALIDAR EXISTENCIA DE PRODUCTO
                    if (validarParaingreso())
                    {
                        DialogResult result = MessageBox.Show("¿Esta Seguro de Grabar las series?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            GrabarRegistros();
                            btnConfirma.Enabled = true;
                            btnConfirma.PerformClick();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                    break;
                case "M":
                    if (validarParaingreso())
                    {
                        DialogResult result = MessageBox.Show("¿Esta Seguro de Grabar las series?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ModificarRegistros();
                            btnConfirma.Enabled = true;
                            btnConfirma.PerformClick();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;

            }
            this.Dispose();  
        }
        public void GrabarRegistros()
        {
            List<movimientoproductoaccion> listaMovi = listaMovi = sesion.movprodaccion;
            if (listaMovi == null)
            {
                listaMovi = new List<movimientoproductoaccion>();
            }
            movimientoproductoaccion registrosMovi = new movimientoproductoaccion();

            List<serie> ListaSerie = new List<serie>();
            if (grbAgregadoSerie.Enabled == true)
            {
                for (int i = 0; i < dgvListaIngreso.RowCount; i++)
                {
                    serie registrosSerie = new serie();
                    registrosSerie.chcodigoserie = dgvListaIngreso.Rows[i].Cells[3].Value.ToString();
                    registrosSerie.estado = true;
                    registrosSerie.p_inidproducto = int.Parse(txtidcodigo.Text);
                    registrosSerie.chadicional = dgvListaIngreso.Rows[i].Cells[4].Value.ToString();
                    registrosSerie.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                    registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                    ListaSerie.Add(registrosSerie);
                }
            }
            
            valedetalle registrosValeDet = new valedetalle();
            registrosValeDet.p_inidvaledetalle = p_inidproducto;
            registrosValeDet.chnombrecompuesto = txtNombreconpuesto.Text;
            registrosValeDet.chmedida = txtMedida.Text;
            registrosValeDet.chcodigoproducto = txtcodprod.Text;
            registrosValeDet.chcodigoserie = txtMedida.Text;
            registrosValeDet.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            registrosValeDet.p_inidproducto = int.Parse(txtidcodigo.Text);
            registrosValeDet.nucantidad = int.Parse(txtCantidad.Text);
            registrosValeDet.nucosto = decimal.Parse(txtprecio.Text);
            registrosValeDet.nutotal = decimal.Parse(txtsubtotal.Text);

            registrosMovi.listaserie = ListaSerie;
            registrosMovi.valedet = registrosValeDet;

            listaMovi.Add(registrosMovi);
            sesion.movprodaccion = listaMovi;
            dgvListaIngreso.Rows.Clear();
        }
        public void ModificarRegistros()
        {
           
            List<serie> ListaSerie = new List<serie>();
            if (grbAgregadoSerie.Enabled == true)
            {
                for (int i = 0; i < dgvListaIngreso.RowCount; i++)
                {
                    serie registrosSerie = new serie();
                    registrosSerie.chcodigoserie = dgvListaIngreso.Rows[i].Cells[3].Value.ToString();
                    registrosSerie.estado = true;
                    registrosSerie.p_inidproducto = int.Parse(txtidcodigo.Text);
                    registrosSerie.chadicional = dgvListaIngreso.Rows[i].Cells[4].Value.ToString();
                    registrosSerie.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                    registrosSerie.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    registrosSerie.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                    ListaSerie.Add(registrosSerie);
                }
            }

            valedetalle registrosValeDet = new valedetalle();
            registrosValeDet.p_inidvaledetalle = p_inidproducto;
            registrosValeDet.chnombrecompuesto = txtNombreconpuesto.Text;
            registrosValeDet.chmedida = txtMedida.Text;
            registrosValeDet.chcodigoproducto = txtcodprod.Text;
            registrosValeDet.chcodigoserie = txtMedida.Text;
            registrosValeDet.chfecha = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            registrosValeDet.p_inidproducto = int.Parse(txtidcodigo.Text);
            registrosValeDet.nucantidad = int.Parse(txtCantidad.Text);
            registrosValeDet.nucosto = decimal.Parse(txtprecio.Text);
            registrosValeDet.nutotal = decimal.Parse(txtsubtotal.Text);      

            List<movimientoproductoaccion> ListaMov = sesion.movprodaccion;
            foreach (movimientoproductoaccion RegistrosMov in ListaMov)
            {
                if (RegistrosMov.valedet.p_inidvaledetalle == p_inidproducto)
                {
                    RegistrosMov.valedet = registrosValeDet;
                    RegistrosMov.listaserie = ListaSerie;
                }
            }

            dgvListaIngreso.Rows.Clear();
        }
        private  bool IngresoRegistros()
        {
            List<serie> registo= new List<serie>();
            bool flat2 = false;
            for (int i = 0; i < dgvListaIngreso.RowCount; i++)
            {
                serie tmpSerie = new serie();
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
       

        private void frmProcSeriesAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            if (this.vBoton == "A")
            {
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
            else
                if (this.vBoton == "M")
            {
                List<movimientoproductoaccion> ListaMov = sesion.movprodaccion;
                foreach (movimientoproductoaccion RegistrosMov in ListaMov)
                {
                    if (RegistrosMov.valedet.p_inidvaledetalle == p_inidproducto)
                    {
                        valedetalle RegistroValDet = RegistrosMov.valedet;
                        txtcodprod.Text = RegistroValDet.chcodigoproducto;
                        mskFecha.Text = RegistroValDet.chfecha;
                        txtCantidad.Text = RegistroValDet.nucantidad.ToString();
                        txtprecio.Text = RegistroValDet.nucosto.ToString();
                        txtSerie.Text = "";
                        txtObs.Text = "";
                        txtSerie.Focus();
                        List<serie> ListaSerie = RegistrosMov.listaserie;
                        foreach (serie RegistrosSerie in ListaSerie)
                        {
                            if (RegistrosSerie.estado == true)
                            {
                                dgvListaIngreso.Rows.Add(p_inidproducto, RegistroValDet.chcodigoproducto, RegistroValDet.chnombrecompuesto, RegistrosSerie.chcodigoserie, RegistrosSerie.chadicional);
                            }
                            
                        }
                    }
                }
            }
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
                    grbAgregadoSerie.Enabled = a.req_serie;
                    

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
            LimpiarFilasporCambio();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            calcular();
        }
        public  bool validarCantidadfilas()
        {
            bool flat = false;
            int cantidad = 0;
            if (txtCantidad.Text.Length >0)
            {
                cantidad = int.Parse(txtCantidad.Text);
            }
            if (cantidad > dgvListaIngreso.RowCount)
            {
                flat = true;
            }
            
            return flat;
        }
        public void LimpiarFilasporCambio()
        {
            int cantidad = 0;
            if (txtCantidad.Text.Length > 0)
            {
                cantidad = int.Parse(txtCantidad.Text);
            }
            if (cantidad < dgvListaIngreso.RowCount)
            {
                dgvListaIngreso.Rows.Clear();
            }
            
        }
        public bool validarCantidad()
        {
            bool flat = false;
            int cantidad = 0;
            if (txtCantidad.Text.Length > 0)
            {
                cantidad = int.Parse(txtCantidad.Text);
                if (cantidad > 0)
                {
                    flat = true;
                }
            }           

            return flat;
        }
        public bool validarParaingreso()
        {
            bool flat = false;
            int cantidad = 0;
            decimal precio = 0;
            if (txtCantidad.Text.Length > 0)
            {
                cantidad = int.Parse(txtCantidad.Text);
            }
            if (txtprecio.Text.Length >0)
            {
                precio= decimal.Parse( txtprecio.Text);
            }
            int lista = dgvListaIngreso.RowCount;
            if (grbAgregadoSerie.Enabled == true)
            {
                if (cantidad == lista && validarCantidad())
                {
                    if(txtidcodigo.Text.Length > 0)
                    {
                        if (precio > 0)
                        {
                            flat = true;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese costo unitario", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtprecio.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto no Seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtcodprod.Focus();
                      
                    }
                }
                else
                {
                    MessageBox.Show("Lista incompleta", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtSerie.Focus();
                  
                }
            }else
            {
                if (validarCantidad())
                {
                    if (txtidcodigo.Text.Length > 0)
                    {
                        if (precio > 0)
                        {
                            flat = true;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese costo unitario", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtprecio.Focus();
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Producto no Seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtcodprod.Focus();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese cantidad", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtCantidad.Focus();
                  
                }
            }
            
            return flat;
        }
    }
}
