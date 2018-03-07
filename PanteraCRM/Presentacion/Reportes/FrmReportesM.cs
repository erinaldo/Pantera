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
   
    public partial class FrmReportesM : Form
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        public FrmReportesM()
        {
            InitializeComponent();
        }

        private void FrmReportesM_Load(object sender, EventArgs e)
        {
            this.crpViewer.ReportSource = Rpt;
        }
    }
}
