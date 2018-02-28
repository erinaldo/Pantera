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
namespace Presentacion
{
    public partial class frmManClienteTarjetaAnadir : Form
    {
        internal producto tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmManClienteTarjetaAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
    }
}
