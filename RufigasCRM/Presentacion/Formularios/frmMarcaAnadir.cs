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
    public partial class frmMarcaAnadir : Form
    {
        internal marca tmpMarca;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public int varItem;
        string vBoton;
        public frmMarcaAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }

        private void frmMarcaAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            if (this.vBoton == "A")
            {
                this.Text = "AÑADIR MARCA";
                txtCodigoMarca.Text = marcaNE.marcaObtenerNumero();
            }
            else
            { 
                txtCodigoMarca.Text = tmpMarca.codigomarca;
                txtNombreMarca.Text = tmpMarca.nombremarca;
                chkEstado.Checked = tmpMarca.estadomarca;
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR MARCA";
                }
                else
                   if (this.vBoton == "V")
                    {
                        this.Text = "VER MARCA";
                        btnGrabar.Enabled = false;
                    }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdMarca;
            switch (this.vBoton)
            {
                case "A":
                    tmpMarca = new marca();
                    tmpMarca.codigomarca = txtCodigoMarca.Text;
                    tmpMarca.nombremarca = txtNombreMarca.Text;
                    tmpMarca.estadomarca = chkEstado.Checked;
                    varIdMarca = marcaNE.marcaInsertar(tmpMarca);
                    if (varIdMarca <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        pasado(varIdMarca);
                    }
                    break;
                case "M":
                    tmpMarca.codigomarca = txtCodigoMarca.Text;
                    tmpMarca.nombremarca = txtNombreMarca.Text;
                    tmpMarca.estadomarca = chkEstado.Checked;
                    varIdMarca = marcaNE.marcaActualizar(tmpMarca);
                    if (varIdMarca <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                            pasado(varIdMarca);
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
