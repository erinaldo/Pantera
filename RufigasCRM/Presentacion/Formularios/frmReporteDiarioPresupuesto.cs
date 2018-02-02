using Entidades;
using Negocios;
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
    public partial class frmReporteDiarioPresupuesto : Form
    {
        public frmReporteDiarioPresupuesto()
        {
            InitializeComponent();
        }

        public void ejecutar(int dato)
        {
            cargarData();
            foreach (DataGridViewRow Row in dgvPresupuesto.Rows)
            {
                int valor = (int)Row.Cells["IDPRESUPUESTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvPresupuesto.CurrentCell = dgvPresupuesto.Rows[puntero].Cells[3];
                    return;
                }
            }
        }
        private void frmReporteDiarioPresupuesto_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboVendedor.DataSource = usuarioNE.usuarioListar();
            cboVendedor.ValueMember = "idusuario";
            cboVendedor.DisplayMember = "nombre";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            List<presupuesto> listado = presupuestoNE.presupuestoListarFechasVendedor(sesion.empresasesion.idempresa,
            dtpfechaini.Text, dtpfechafin.Text, (int)cboVendedor.SelectedValue);
            dgvPresupuesto.DataSource = listado; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            imprimirPresupuesto();
        }
        private void imprimirPresupuesto()
        {
            //Creamos una instancia d ela clase CrearTicket
            crearTicket ticket = new crearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            DateTime thisDay = DateTime.Today;
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("**********************");
            ticket.TextoCentro((string)cboVendedor.Text.Trim());
            ticket.TextoCentro("**********************");
//            ticket.TextoIzquierda("");
            ticket.TextoCentro("FECHA: "+thisDay.ToString("d"));
 //           ticket.TextoIzquierda("");
   //         ticket.TextoCentro("PRESUPUESTOS");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("========================================");
            int vCuenta=0 , vItems = 0;
            decimal vTotal = 0;
            int vMaximo = dgvPresupuesto.RowCount;
            string vFila = "",vPrimer = "", vSegundo="";
            foreach (DataGridViewRow fila in dgvPresupuesto.Rows)//dgvLista es el nombre del datagridview
            {
                //vTotal = vTotal + (decimal)fila.Cells[14].Value;
                //vFila = vFila + string.Format("{0:0.00}", fila.Cells[14].Value).Trim().PadLeft(12, ' ')+ "|";
                //vItems++;
                //vCuenta++;
                //if (vCuenta == 3)
                //{
                //    ticket.TextoIzquierda(vFila);
                //    vFila = "|";
                //    vCuenta = 0;
                //    vMaximo = vMaximo - 3;
                //}
                //if ((vCuenta == vMaximo)&&(vCuenta != 0))
                //{
                //    vFila = vFila.PadRight(39, ' ') + "|";
                //    ticket.TextoIzquierda(vFila);
                //}

                vPrimer = ((vPrimer == "") ? fila.Cells[4].Value.ToString() : vPrimer);
                vSegundo = fila.Cells[4].Value.ToString();
                vTotal = vTotal + (decimal)fila.Cells[14].Value;
                vFila = vFila + fila.Cells[4].Value + string.Format("{0:0.00}", fila.Cells[14].Value).Trim().PadLeft(10, ' ') + ((vCuenta == 0)? "      ":"");
                vItems++;
                vCuenta++;
                if (vCuenta == 2)
                {
                    ticket.TextoIzquierda(vFila);
                    vFila = "";
                    vCuenta = 0;
                    vMaximo = vMaximo - 2;
                }
                if ((vCuenta == vMaximo) && (vCuenta != 0))
                {
                    vFila = vFila.PadRight(40, ' ');
                    ticket.TextoIzquierda(vFila);
                }
            }
            ticket.TextoIzquierda("========================================");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("TOTAL DE VENTA:   "+ vTotal.ToString("C2"));
            ticket.TextoIzquierda("                 -------------");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("     BOUCHERS :  __________   __________");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("     BOUCHERS :  __________   __________");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ENTREGA EN EFECTIVO: ___________________");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("  MONTO DE DEUDA   : ___________________");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("REC. INICIO: " + vPrimer+ "  REC. FINAL:" + vSegundo);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("CANTIDAD DE PRESUPUESTOS: " + vItems);
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();

            ticket.CortaTicket();
            //ticket.ImprimirTicket("EPSON TM-U220 Receipt");//Nombre de la impresora ticketera
            //MessageBox.Show(System.Environment.MachineName);
            //MessageBox.Show(sesion.impresoraticket);
            ticket.ImprimirTicket(sesion.impresoraticket);//Nombre de la impresora ticketera
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }
    }
}
