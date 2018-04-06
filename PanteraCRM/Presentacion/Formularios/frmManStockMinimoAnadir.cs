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
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmManStockMinimoAnadir : Form
    {
        internal saldoalmacen tmpsaldoalmacen;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmManStockMinimoAnadir(string vBoton)
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
            int valor = 0;
            if (txtstockminimo.Text.Length > 0)
            {
                valor = int.Parse(txtstockminimo.Text);
            }
            if (valor > 0)
            {
                saldoalmacen registros = new saldoalmacen();
                registros.p_inidproducto = tmpsaldoalmacen.p_inidproducto;
                registros.nustockminima = decimal.Parse(txtstockminimo.Text);
                varIdArticulo = productoNE.stockminimoingresar(registros);
                if (varIdArticulo <= 0)
                {
                    MessageBox.Show("Error en la Modificación", "Mensaje de Sistema", MessageBoxButtons.OK);
                    //MessageBox.Show("Registro con error por actualizado, validar");
                }
                else
                {
                    // MessageBox.Show("Registro Modificado", "Mensaje de Sistema", MessageBoxButtons.OK);
                    pasado(varIdArticulo);
                }
            }
            else
            {
                MessageBox.Show("El Stock no puede ser menor a cero", "Mensaje de Sistema", MessageBoxButtons.OK);
                txtstockminimo.Focus();
                return;
            }
            
            this.Dispose();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void frmManStockMinimoAnadir_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (this.vBoton == "M")
            {

                txtstockminimo.Text = tmpsaldoalmacen.nustockminima.ToString();
                txtstockminimo.Focus();
                txtDescripcionprod.Text = tmpsaldoalmacen.chnombrecompuesto;
                txtCodigo.Text = tmpsaldoalmacen.chcodigo;


            }
            else
                if (this.vBoton == "V")
            {
                txtDescripcionprod.Text = tmpsaldoalmacen.chnombrecompuesto;
                txtCodigo.Text = tmpsaldoalmacen.chcodigo;
                txtstockminimo.Text = tmpsaldoalmacen.nustockminima.ToString();
                txtstockminimo.ReadOnly = true;
                txtstockminimo.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                txtstockminimo.ForeColor = Color.Blue;
                txtstockminimo.TabStop = false;
                btnGrabar.Enabled = false;

                //txtstockminimo.Focus();
            }
            
        }

        private void txtstockminimo_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }
    }
}
