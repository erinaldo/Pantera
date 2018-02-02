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
    public partial class frmModeloAnadir : Form
    {
        internal modelo tmpModelo;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public int varItem;
        string vBoton;
        public frmModeloAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }

        private void frmModeloAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cboMarca.DataSource = marcaNE.marcaListar();
            cboMarca.ValueMember = "idmarca";
            cboMarca.DisplayMember = "nombremarca";

            if (this.vBoton == "A")
            {
                this.Text = "AÑADIR MODELO";
                txtCodigo.Text = modeloNE.modeloObtenerNumero();
            }
            else
            { 
        txtCodigo.Text = tmpModelo.codigomodelo;
                txtNombre.Text = tmpModelo.nombremodelo;
                cboMarca.SelectedValue = tmpModelo.idmarca;
                chkEstado.Checked = tmpModelo.estadomodelo;
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR MODELO";
                }
                else
                   if (this.vBoton == "V")
                    {
                        this.Text = "VER MODELO";
                        btnGrabar.Enabled = false;
                    }
    }
}

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdModelo;
            switch (this.vBoton)
            {
                case "A":
                    tmpModelo = new modelo();
                    tmpModelo.codigomodelo = txtCodigo.Text;
                    tmpModelo.nombremodelo = txtNombre.Text;
                    tmpModelo.idmarca = (int)cboMarca.SelectedValue;
                    tmpModelo.estadomodelo = chkEstado.Checked;
                    varIdModelo = modeloNE.modeloInsertar(tmpModelo);
                    if (varIdModelo <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        pasado(varIdModelo);
                    }
                    break;
                case "M":
                    tmpModelo.codigomodelo = txtCodigo.Text;
                    tmpModelo.nombremodelo = txtNombre.Text;
                    tmpModelo.idmarca = (int)cboMarca.SelectedValue;
                    tmpModelo.estadomodelo = chkEstado.Checked;
                    varIdModelo = modeloNE.modeloActualizar(tmpModelo);
                    if (varIdModelo <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                        pasado(varIdModelo);
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
