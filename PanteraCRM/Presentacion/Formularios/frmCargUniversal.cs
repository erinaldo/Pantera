using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel =Microsoft.Office.Interop.Excel ;
using System.Windows.Forms;
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmCargUniversal : Form
    {
        private int conteo;
        public frmCargUniversal()
        {
            InitializeComponent();
            conteo = 0;
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            label1.Text = conteo.ToString();
            if (pBar.Value < 100)
            {
                pBar.Value++;
            }else
            {
                if (pBar.Value == 100)
                {
                    pBar.Value++;
                }
            }
            
        }
    }
}
