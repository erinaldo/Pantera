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
using System.Globalization;
using Negocios;
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmManProductoAnadir : Form
    {
        internal producto  tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
         
        public frmManProductoAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
       
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
        }

     

        private void frmManProductoAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            //Seleccion Categoria
            cboCategoria.DataSource = maestrodetalleNE.ListarCategorias();
            cboCategoria.ValueMember = "p_inidcategoria";
            cboCategoria.DisplayMember = "chcategoria";
            //cboTipo.Enabled = false;
            //cboCategoria.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(1);
            //cboCategoria.ValueMember = "idmaestrodetalle";
            //cboCategoria.DisplayMember = "nombreitem";
            //Seleccion tipo
            //cboTipo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(2);
            //cboTipo.ValueMember = "idmaestrodetalle";
            //cboTipo.DisplayMember = "nombreitem";
            ////Seleccion Marca
            cboMarca.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(3);
            cboMarca.ValueMember = "idmaestrodetalle";
            cboMarca.DisplayMember = "nombreitem";
            ////Seleccion Calibre
            cboCalibre.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(4);
            cboCalibre.ValueMember = "idmaestrodetalle";
            cboCalibre.DisplayMember = "nombreitem";
            ////Seleccion Modelo
            cboModelo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(5);
            cboModelo.ValueMember = "idmaestrodetalle";
            cboModelo.DisplayMember = "nombreitem";
            ////Seleccion Unidad Medida
            cboMedida.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(6);
            cboMedida.ValueMember = "idmaestrodetalle";
            cboMedida.DisplayMember = "nombreitem";
            ////Situacion Producto
            cboSituacion.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(7);
            cboSituacion.ValueMember = "idmaestrodetalle";
            cboSituacion.DisplayMember = "nombreitem";

            if (this.vBoton == "A")
            {
                //label8.Text = "Añadir Producto";
                txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
                int index = cboCategoria.FindString("ARMA");
                cboCategoria.SelectedIndex = index;                
                int index1 = cboMarca.FindString("--NUEVA MARCA--");
                cboMarca.SelectedIndex = index1;
                int index2 = cboCalibre.FindString("--NUEVO CALIBRE--");
                cboCalibre.SelectedIndex = index2;
                int index3 = cboModelo.FindString("--NUEVO MODELO--");
                cboModelo.SelectedIndex = index3;
                //int index4 = cboTipo.FindString("--NUEVO TIPO--");
                //cboTipo.SelectedIndex = index4;
                //cboTipo.Text = "--ELEGIR--";
                txtUnidad.Text = "0";

            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR PRODUCTO";
                txtidproducto.Text = tmpProducto.p_inidproducto.ToString();
                txtCodigo.Text = tmpProducto.chcodigoproducto;
                txtNombre.Text = tmpProducto.chdescripcionproducto;
                cboCategoria.SelectedValue = tmpProducto.p_inidfamiliaproducto;
                cboTipo.SelectedValue = tmpProducto.p_inidtipoproducto;
                cboMarca.SelectedValue = tmpProducto.p_inidmarca;
                cboCalibre.SelectedValue = tmpProducto.p_inidcalibre;
                cboModelo.SelectedValue = tmpProducto.p_inidmodelo;
                cboMedida.SelectedValue = tmpProducto.p_inidunidadmedidaproducto;
                cboSituacion.SelectedValue = tmpProducto.p_inidsituacion;
                ckbSerie.Checked = tmpProducto.req_serie;
                txtFecha.Text = tmpProducto.chfechacreacion;
                txtFecha.ReadOnly = true;
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PRODUCTO";
                txtCodigo.Text = tmpProducto.chcodigoproducto;
                txtNombre.Text = tmpProducto.chdescripcionproducto;
                cboCategoria.SelectedValue = tmpProducto.p_inidfamiliaproducto;
                cboTipo.SelectedValue = tmpProducto.p_inidtipoproducto;
                cboMarca.SelectedValue = tmpProducto.p_inidmarca;
                cboCalibre.SelectedValue = tmpProducto.p_inidcalibre;
                cboModelo.SelectedValue = tmpProducto.p_inidmodelo;
                cboMedida.SelectedValue = tmpProducto.p_inidunidadmedidaproducto;
                cboSituacion.SelectedValue = tmpProducto.p_inidsituacion;               
                txtFecha.Text = tmpProducto.chfechacreacion;
                ckbSerie.Checked = tmpProducto.req_serie;
                txtCodigo.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtCodigo.ForeColor = Color.Blue;
                txtCodigo.ReadOnly = true;
                txtNombre.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtNombre.ForeColor = Color.Blue;
                txtNombre.ReadOnly = true;

                btnGrabar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || 8 == Convert.ToInt32(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        bool flatcboCategoria = false;
        int flatcboCategoria2 = 0;
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboCategoria.Text == "--NUEVA CATEGORIA--")
            //{
            //    if (flatcboCategoria)
            //    {
            //        //cboMarca.Enabled = false;
            //        //cboMarca.Text = "----";
            //        MessageBox.Show("Nueva Categoria En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
            //    }
            //    // cboTipo.Enabled = true;
            //    //cboTipo.Text = "--Elegir--";
            //    flatcboCategoria = true;
            //}
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            string tipocategoria = cboCategoria.Text;
            if (tipocategoria == "--NUEVA CATEGORIA--")
            {
                if (flatcboCategoria)
                {
                    //cboTipo.Enabled = false;
                    //cboTipo.Text = "--ELEGIR--";
                    MessageBox.Show("Nueva Categoria En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                // cboTipo.Enabled = true;
                flatcboCategoria = true;
            }
            else
            {
                flatcboCategoria2 = 0;
                //cboTipo.Enabled = true;
                //Llenado datos tipo
                cboTipo.DataSource = maestrodetalleNE.buscarTipoPorCategoria(tipocategoria);
                cboTipo.ValueMember = "p_inidtipo";
                cboTipo.DisplayMember = "chtipo";
                int index = cboTipo.FindString("--NUEVO " + tipocategoria+"--");
                cboTipo.SelectedIndex = index;
                //int index = cboCategoria.FindString("NUEVA CATGORIA");
                //cboCategoria.SelectedIndex = 0;
            }
        }
        //bool flatcbotipo = false;
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTipo.Text == "--NUEVO TIPO--")
            //{
            //    if (flatcbotipo)
            //    {
            //        //cboMarca.Enabled = false;
            //        //cboMarca.Text = "----";
            //        MessageBox.Show("Nuevo Tipo En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
            //    }
            //    // cboTipo.Enabled = true;
            //    //cboTipo.Text = "--Elegir--";
            //    flatcbotipo = true;
            //}
            string tipo = cboCategoria.Text;
            int cantidad = cboCategoria.Items.Count - 1;
            if (cboTipo.Text == "--NUEVO " + tipo+"--")
            {
                if (flatcboCategoria2 != 0)
                {
                    //cboTipo.Enabled = false;
                   // cboTipo.Text = "----";
                    MessageBox.Show("Nuevo Tipo En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                flatcboCategoria2 ++;

            }

        }
        bool flatmarca = false;
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.Text == "--NUEVA MARCA--")
            {
                if (flatmarca)
                {
                    //cboMarca.Enabled = false;
                    //cboMarca.Text = "----";
                    MessageBox.Show("Nueva Marca En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatmarca = true;
            }
        }
        bool flatcalibre = false;
        private void cboCalibre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalibre.Text == "--NUEVO CALIBRE--")
            {
                if (flatcalibre)
                {
                    // cboCalibre.Enabled = false;
                    //cboCalibre.Text = "----";
                    MessageBox.Show("Nuevo Calibre En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatcalibre = true;
            }

        }
        bool flatmodelo = false;
        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelo.Text == "--NUEVO MODELO--")
            {
                if (flatmodelo)
                {
                    //cboModelo.Enabled = false;
                    //cboModelo.Text = "----";
                    MessageBox.Show("Nuevo Modelo En Mantenimiento", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                // cboTipo.Enabled = true;
                //cboTipo.Text = "--Elegir--";
                flatmodelo = true;
            }
        }

        

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            if (basicas.validarAcceso("G"))
            {
                int varIdArticulo;
                switch (this.vBoton)
                {
                    case "A":
                        if (validarCampos())
                        {
                            tmpProducto = new producto();
                            //ATRIBUTOS PARA INGRESAR PRODUCTO
                            //tmpProducto.p_inidproducto = 0; AUTO-GENERADO  
                            tmpProducto.chcodigoproducto = txtCodigo.Text;
                            tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
                            tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue;
                            tmpProducto.p_inidunidadmedidaproducto = (int)cboMedida.SelectedValue;
                            tmpProducto.chfechacreacion = txtFecha.Text;
                            tmpProducto.estado = true;
                            tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
                            tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
                            tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
                            tmpProducto.chcodigoproductoantes = "";
                            tmpProducto.chdescripcionproducto = txtNombre.Text;
                            tmpProducto.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                            tmpProducto.p_inidusuariodelete = 0;
                            tmpProducto.nuprecio = decimal.Parse("0.00");
                            tmpProducto.p_inidsituacion = (int)cboSituacion.SelectedValue;
                            tmpProducto.req_serie = ckbSerie.Checked;
                            tmpProducto.nucantporuni = int.Parse(txtUnidad.Text);
                            varIdArticulo = productoNE.productoInsertar(tmpProducto);
                            if (varIdArticulo <= 0)
                            {
                                MessageBox.Show("Error en el Registro", "Mensaje de Sistema", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                // MessageBox.Show("Registro Ingresado", "Mensaje de Sistema", MessageBoxButtons.OK);
                                saldoalmacen registros = new saldoalmacen();
                                //registros.p_inidsaldoalmancen = 0;
                                registros.nustockactual = 0;
                                registros.nustockcomprpmetido = 0;
                                registros.nustockminima = 0;
                                registros.estado = true;
                                registros.p_inidalmacen = sesion.SessionGlobal.p_inidalmacen;
                                registros.p_inidproducto = varIdArticulo;
                                int verdad = productoNE.productoInsertarSaldoalamcen(registros);
                                if (verdad <= 0)
                                {
                                    MessageBox.Show("Error en la creación de Stock, realizar manualmente", "Mensaje de Sistema", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    pasado(varIdArticulo);
                                }

                            }
                        }
                        else
                        {
                            return;
                        }

                        break;
                    case "M":
                        tmpProducto.p_inidproducto = int.Parse(txtidproducto.Text);
                        tmpProducto.chcodigoproducto = txtCodigo.Text;
                        tmpProducto.p_inidtipoproducto = (int)cboTipo.SelectedValue;
                        tmpProducto.p_inidmarca = (int)cboMarca.SelectedValue;
                        tmpProducto.p_inidunidadmedidaproducto = (int)cboMedida.SelectedValue;
                        tmpProducto.chfechacreacion = txtFecha.Text;
                        tmpProducto.estado = true;
                        tmpProducto.p_inidfamiliaproducto = (int)cboCategoria.SelectedValue;
                        tmpProducto.p_inidcalibre = (int)cboCalibre.SelectedValue;
                        tmpProducto.p_inidmodelo = (int)cboModelo.SelectedValue;
                        tmpProducto.chcodigoproductoantes = "";
                        tmpProducto.chdescripcionproducto = txtNombre.Text;
                        tmpProducto.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        tmpProducto.p_inidusuariodelete = 0;
                        tmpProducto.nuprecio = 0;
                        tmpProducto.req_serie = ckbSerie.Checked;
                        tmpProducto.p_inidsituacion = (int)cboSituacion.SelectedValue;
                        tmpProducto.nucantporuni = int.Parse(txtUnidad.Text);
                        varIdArticulo = productoNE.ProductoActualizar(tmpProducto);
                        if (varIdArticulo <= 0)
                        {
                            MessageBox.Show("Error en la Modificación", "Mensaje de Sistema", MessageBoxButtons.OK);
                            //MessageBox.Show("Registro con error por actualizado, validar");
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Mensaje de Sistema", MessageBoxButtons.OK);
                            pasado(varIdArticulo);
                        }
                        break;
                    default:
                        break;
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
            }           
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool validarCampos()
        {
            bool flatvalidacampo = false;
            if (txtCodigo.Text.Length > 0)
            {
                if (cboCategoria.Text != "--NUEVA CATEGORIA--")
                {
                    if (cboTipo.Text != "--NUEVO "+ cboCategoria.Text+"--")
                    {
                        if (cboMarca.Text != "--NUEVA MARCA--")
                        {
                            if (cboCalibre.Text != "--NUEVO CALIBRE--")
                            {
                                if (cboModelo.Text != "--NUEVO MODELO--")
                                {
                                    if (cboMedida.Text != "--ELEGIR--")
                                    {
                                        flatvalidacampo = true;

                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione una Medida Válida", "Mensaje de Sistema", MessageBoxButtons.OK);
                                        cboMedida.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione un Modelo Válido", "Mensaje de Sistema", MessageBoxButtons.OK);
                                    cboModelo.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un Calibre Válido", "Mensaje de Sistema", MessageBoxButtons.OK);
                                cboCalibre.Focus();
                            }
                        }else
                        {
                            MessageBox.Show("Seleccione una Marca Válida", "Mensaje de Sistema", MessageBoxButtons.OK);
                            cboMarca.Focus();
                        }

                    }else
                    {
                        MessageBox.Show("Seleccione una Tipo Válido", "Mensaje de Sistema", MessageBoxButtons.OK);
                        cboTipo.Focus();
                    }

                }else
                {
                    MessageBox.Show("Seleccione una Categoría Válida", "Mensaje de Sistema", MessageBoxButtons.OK);
                    cboCategoria.Focus();
                }
            }else
            {
                MessageBox.Show("El Codigo no Puede estar Vacio", "Mensaje de Sistema", MessageBoxButtons.OK);
                txtCodigo.Focus();
            }
            return flatvalidacampo;
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 15);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 15);
        }

        private void cboMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedida.Text != "UNIDAD")
            {
                lblUnidad.Text = "Unidades Por " + cboMedida.Text;
                lblUnidad.Visible = true;
                txtUnidad.Visible = true;
            }
            else
            {
                lblUnidad.Text = string.Empty;
                lblUnidad.Visible = false; 
                txtUnidad.Visible = false;
            }
        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}