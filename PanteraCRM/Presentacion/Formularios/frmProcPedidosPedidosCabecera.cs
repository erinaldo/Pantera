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
    public partial class frmProcPedidosPedidosCabecera : Form
    {
        public frmProcPedidosPedidosCabecera()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            frmProcPedidosPedidosDetalle f = new frmProcPedidosPedidosDetalle();
            //f.pasado += new frmProcFacturacionAnadir.pasar(ejecutar);
            f.ShowDialog();
        }

        private void frmProcPedidosPedidosCabecera_Load(object sender, EventArgs e)
        {
            txtSubtotal.Text = "0.00";
            txtDesctot.Text = "0.00";
            txtIgv.Text = "0.00";
            txtValVenta.Text = "0.00";
            txtTotVenta.Text = "0.00";
        }
    }
}
