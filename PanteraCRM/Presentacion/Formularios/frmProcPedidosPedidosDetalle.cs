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
    public partial class frmProcPedidosPedidosDetalle : Form
    {
        public frmProcPedidosPedidosDetalle()
        {
            InitializeComponent();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void frmProcPedidosPedidosDetalle_Load(object sender, EventArgs e)
        {
            txtCant.Text = "0";
            txtDesc1.Text = "0.00";
            txtDesc2.Text = "0.00";
            txtImporte .Text = "0.00";
            txtPreUnit.Text = "0.00";
            txtStock.Text = "0";
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtCodigo.Text;

        }
    }
}
