using Entidades;
using Negocios;
using Presentacion.Dataset;
using Presentacion.Reportes;
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
    public partial class frmReporteMovimiento : Form
    {
        public frmReporteMovimiento()
        {
            InitializeComponent();
        }

        public DataTable dtCursor = new DataTable("Detalle");
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                cboVendedor.Enabled = false;
            }
            else
            { 
                cboVendedor.Enabled = true;
            }
        }

        private void rbElegir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbElegir.Checked)
            {
                cboVendedor.Enabled = true;
            }
            else
            {
                cboVendedor.Enabled = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                dtCursor = articuloNE.articuloReporteTotalCantidadTodos(dtpfechaini.Text, dtpfechafin.Text);
            }
            
            if (rbElegir.Checked)
            {
                dtCursor = articuloNE.articuloReporteTotalCantidadPorVendedor((int)cboVendedor.SelectedValue, dtpfechaini.Text, dtpfechafin.Text);
            }
            this.dgvPresupuesto.DataSource = dtCursor;
        }

        private void frmReporteMovimiento_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboVendedor.DataSource = usuarioNE.usuarioListar();
            cboVendedor.ValueMember = "idusuario";
            cboVendedor.DisplayMember = "nombre";

            dtCursor.Columns.Add("codigoarticulo", System.Type.GetType("System.String"));
            dtCursor.Columns.Add("nombrearticulo", System.Type.GetType("System.String"));
            dtCursor.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtCursor.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dgvPresupuesto.DataSource = dtCursor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            crearTicket ticket = new crearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            DateTime thisDay = DateTime.Today;
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("**********************");
            ticket.TextoCentro(((rbTodos.Checked) ? "TODOS" : (string)cboVendedor.Text.Trim()));
            ticket.TextoCentro("**********************");
            //            ticket.TextoIzquierda("");
            ticket.TextoCentro("CANTIDAD VENDIDA POR ITEM");
            ticket.TextoCentro("DESDE : " + dtpfechaini.Text);
            ticket.TextoCentro("HASTA : " + dtpfechafin.Text);
            //           ticket.TextoIzquierda("");
            //         ticket.TextoCentro("PRESUPUESTOS");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("DESCRIPCION          |CANTIDAD|SUB TOTAL");
            ticket.TextoIzquierda("========================================");
            decimal impTotal = 0;
            string vFila = "";
            foreach (DataGridViewRow fila in dgvPresupuesto.Rows)//dgvLista es el nombre del datagridview
            {
                //vFila = fila.Cells[0].Value.ToString().Trim().PadRight(5, ' ') + fila.Cells[1].Value.ToString().Substring(0, ((fila.Cells[1].Value.ToString().Length < 25) ? fila.Cells[1].Value.ToString().Length : 25)).Trim().PadRight(25, ' ') + ' '+ fila.Cells[2].Value.ToString().PadLeft(5, ' ');
                vFila = fila.Cells[1].Value.ToString().Substring(0, ((fila.Cells[1].Value.ToString().Length < 23) ? fila.Cells[1].Value.ToString().Length : 23)).Trim().PadRight(23, ' ') + ' ' + fila.Cells[2].Value.ToString().PadLeft(5, ' ') + string.Format("{0:0.00}", fila.Cells[3].Value).ToString().Trim().PadLeft(10, ' ');
                impTotal = impTotal + (decimal)fila.Cells[3].Value;
                //decimal.Parse(
                ticket.TextoIzquierda(vFila);
            }
            ticket.TextoIzquierda("========================================");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("TOTAL S/: " + string.Format("{0:0.00}", impTotal));
            ticket.TextoIzquierda("CANTIDAD DE ITEMS: " + dgvPresupuesto.RowCount);
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            //ticket.ImprimirTicket("EPSON TM-U220 Receipt");//Nombre de la impresora ticketera
            //MessageBox.Show(System.Environment.MachineName);
            //MessageBox.Show(sesion.impresoraticket);
            ticket.ImprimirTicket(sesion.impresoraticket);//Nombre de la impresora ticketera
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }

    }

}