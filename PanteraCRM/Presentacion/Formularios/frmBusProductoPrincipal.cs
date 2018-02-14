using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class frmBusProductoPrincipal : Form
    {

        //internal productobuscado tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmBusProductoPrincipal(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmBusProductoPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
