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
    public partial class frmProcPedidoPermitir : Form
    {
        public delegate void PasarClienteCodigo(string CodigoCliente,bool estado);
        public event PasarClienteCodigo Pasado;
        public frmProcPedidoPermitir()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Pasado(txtDoc.Text, false);
            this.Dispose();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Pasado(txtDoc.Text, true);
            }
            else
            {
                return;                
            }
            this.Dispose();        
        }
        private  bool validar()
        {
            bool flat = false;
            if (txtDoc.Text.Length > 0)
            {
                flat = true;
            }else
            {
                MessageBox.Show("Número de documento vacío", "Mensaje de Sistema", MessageBoxButtons.OK);
            }
            return flat;
        }
    }
}
