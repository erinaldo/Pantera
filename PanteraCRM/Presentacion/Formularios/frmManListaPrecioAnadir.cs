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
                txtCantidad.Text = tmpProducto.nuprecio.ToString();
                txtCantidad.Focus();
                txtIdproducto.Text = tmpProducto.p_inidproducto.ToString();
                txtCodigo.ReadOnly = true;
                txtCodigo.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtCodigo.ForeColor = Color.Blue;
                txtCodigo.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PRECIO";
                txtCodigo.Text = tmpProducto.chcodigoproducto.ToString();
                txtDescripcion.Text = tmpProducto.chnombrecompuesto;
                txtCantidad.Text = tmpProducto.nuprecio.ToString();
                txtIdproducto.Text = tmpProducto.p_inidproducto.ToString();
                txtCodigo.ReadOnly = true;
                txtCodigo.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtCodigo.ForeColor = Color.Blue;
                txtCantidad.ReadOnly = true;
                txtCantidad.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtCantidad.ForeColor = Color.Blue;
                txtCodigo.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtCantidad.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                btnGrabar.Enabled = false;
            }

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
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtCantidad.Text.Length; i++)
            {
                if (txtCantidad.Text[i] == '.')
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
    }
}
