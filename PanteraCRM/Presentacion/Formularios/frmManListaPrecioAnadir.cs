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
using System.Globalization;
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmManListaPrecioAnadir : Form
    {
        internal productobuscado tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmManListaPrecioAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdArticulo;
            switch (this.vBoton)
            {
                
                case "M":
                    if (validarCampos())
                    {
                        tmpProducto = new productobuscado();
                        //ATRIBUTOS PARA MODIFICAR PRECIO PRODUCTO
                        tmpProducto.p_inidproducto = int.Parse(txtIdproducto.Text);
                        tmpProducto.nuprecio = decimal.Round(decimal.Parse(txtCantidad.Text), 2);
                        varIdArticulo = productoNE.productoPrecioInsertar(tmpProducto);
                        if (varIdArticulo <= 0)
                        {
                            MessageBox.Show("Error en el Registro", "Mensaje de Sistema", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            // MessageBox.Show("Registro Ingresado", "Mensaje de Sistema", MessageBoxButtons.OK);
                            pasado(varIdArticulo);
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

        private void frmManListaPrecioAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;            
            txtDescripcion.Text = "";
           
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR PRECIO";
                txtCodigo.Text = tmpProducto.chcodigoproducto.ToString();
                txtDescripcion.Text = tmpProducto.chnombrecompuesto;
                txtCantidad.Text = string.Format("{0:0,0.00}", tmpProducto.nuprecio.ToString("N2"));
                txtCantidad.Focus();
                txtIdproducto.Text = tmpProducto.p_inidproducto.ToString();
                CambiarForma(txtCodigo);


            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PRECIO";
                txtCodigo.Text = tmpProducto.chcodigoproducto.ToString();
                txtDescripcion.Text = tmpProducto.chnombrecompuesto;
                txtCantidad.Text = string.Format("{0:0,0.00}", tmpProducto.nuprecio.ToString("N2"));
                txtIdproducto.Text = tmpProducto.p_inidproducto.ToString();
                CambiarForma(txtCodigo);
                CambiarForma(txtCantidad);

                btnGrabar.Enabled = false;
            }

        }
        private void CambiarForma(TextBox Tex)
        {
            Tex.ReadOnly = true;
            Tex.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            Tex.ForeColor = Color.Blue;
        }
       

       
        private bool validarCampos()
        {
            bool flatvalidar = false;
            if (decimal.Parse(txtCantidad.Text) > 0)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    flatvalidar = true;
                }
                else
                {
                    MessageBox.Show("Ingrese un Codigo Válido", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }else
            {
                MessageBox.Show("El Precio Tiene que ser mayor a Cero", "Mensaje de Sistema", MessageBoxButtons.OK);
            }
            return flatvalidar;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }

        
    }
}
