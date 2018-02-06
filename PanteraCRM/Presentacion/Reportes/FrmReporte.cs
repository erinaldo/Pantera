using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;

namespace Presentacion.Reportes
{
    public partial class FrmReporte : Form
    {

        public CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.CrpViewer.ReportSource = Rpt;            
        }
    }
}
