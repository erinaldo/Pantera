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
using Excel = Microsoft.Office.Interop.Excel;
using Presentacion.Programas;
using Presentacion.Dataset;

namespace Presentacion
{
    public partial class frmRepoVentasPrincipal : Form
    {
        public frmRepoVentasPrincipal()
        {
            InitializeComponent();
        }

        private void frmRepoVentasPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            rbtnPantalla.Checked = true;
            cboDocumento.DataSource = tipodocumentoNE.ListarDocumentosVenta();
            cboDocumento.ValueMember = "p_inidtipodocumento";
            cboDocumento.DisplayMember = "chnombredocumento";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbtnExcel.Checked)
            {
                creaExcel();
            }
            else
            {
                if (rbtnPantalla.Checked)
                {
                    Crearimpresion();
                }
                else
                {
                    if (rbtnImpresora.Checked)
                    {
                        MessageBox.Show("Generado impre", "Mensaje de Sistema", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error de seleccion", "Mensaje de Sistema", MessageBoxButtons.OK);
                        txtfechai.Focus();
                        return;
                    }
                }
            }
        }
        private void Crearimpresion()
        {
            Reportes.FrmReportesM f = new Reportes.FrmReportesM();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsPedidos();
            /*PRA CABECERA*/

            DateTime dt1 = DateTime.Parse(txtfechai.Text);
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse(txtfechaf.Text);
            string fin = dt2.ToString("dd/MM/yyyy");
            List<registroventa1> Lista = new List<registroventa1>();
            if (cbkTodo.Checked)
            {
                Lista = pedidoNE.RegistroVentasListadoExcelTipo2(inicio, fin);
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                    //lblrespuesta.Text = "No hay datos.";
                    return;
                }
            }
            else
            {
                Lista = pedidoNE.RegistroVentasListadoExcelTipo1(inicio, fin, (int)cboDocumento.SelectedValue);
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                    //lblrespuesta.Text = "No hay datos.";
                    return;
                }
            }
            lblrespuesta.Text = "Cargando datos...";
            foreach (registroventa1 registro in Lista)
            {
                Dts.Tables["registroventa1"].LoadDataRow(new object[]
            {
                registro.chfechadoc ,
                registro.chnombredocumento,
                registro.chcodigodocu ,
                registro.nuimportetotvta,
                registro.nuimporvtaafecta ,
                registro.nuimporttotigv,
                registro.chcodigocliente ,
                registro.tipodocu,
                registro.nrodocumento ,
                registro.razon ,
                sesion.SessionGlobal.chpuntoventa,
                "DIRECCION: AV. DEFENSORES DEL MORRO  N° 666  OF. 44, 45 y 46 - CHORRILLOS - LIMA - PERU",
                "RUC: 20522355292",
                "REGISTRO DE VENTAS",
                "MES:"
            }, true);

            }
            Dts.AcceptChanges();
            Rpt1 = new Reportes.CrystalReportRegistroVenta1();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
        }
        private void creaExcel()
        {
            //lblrespuesta.Text = "Cargando archivos ...";
            Excel.Application excel = new Excel.Application();
            Excel._Workbook libro = null;
            Excel._Worksheet hoja = null;
            Excel.Range rango = null;

            //creamos un libro nuevo y la hoja con la que vamos a trabajar
            libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            hoja = (Excel._Worksheet)libro.Worksheets.Add();
            hoja.Name = "REGISTRO DE VENTAS";
            ((Excel.Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();   //Borramos la hoja que crea en el libro por defecto


            //Montamos las cabeceras 
            lblrespuesta.Text = "Cargando cabecera...";
            montaCabeceras(3, ref hoja);
            //Rellenamos las celdas
            int fila = 8;
            int orden = 1;

            DateTime dt1 = DateTime.Parse(txtfechai.Text);
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse(txtfechaf.Text);
            string fin = dt2.ToString("dd/MM/yyyy");
            List<registroventa1> Lista = new List<registroventa1>();
            if (cbkTodo.Checked)
            {
                Lista = pedidoNE.RegistroVentasListadoExcelTipo2(inicio, fin);
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                    //lblrespuesta.Text = "No hay datos.";
                    return;
                }
            }
            else
            {
                Lista = pedidoNE.RegistroVentasListadoExcelTipo1(inicio, fin, (int)cboDocumento.SelectedValue);
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                    //lblrespuesta.Text = "No hay datos.";
                    return;
                }
            }
            
            lblrespuesta.Text = "Cargando datos...";
            foreach (registroventa1 registro in Lista)
            {

                fila++;
                hoja.Cells[fila, 2] = registro.chfechadoc;
                hoja.Cells[fila, 3] = registro.chnombredocumento;
                hoja.Cells[fila, 4] = registro.chcodigodocu;
                hoja.Cells[fila, 5] = registro.nuimportetotvta;
                hoja.Cells[fila, 6] = registro.nuimporvtaafecta;
                hoja.Cells[fila, 7] = registro.nuimporttotigv;
                hoja.Cells[fila, 8] = registro.chcodigocliente;
                hoja.Cells[fila, 9] = registro.tipodocu;
                hoja.Cells[fila, 10] = registro.nrodocumento;
                hoja.Cells[fila, 11] = registro.razon;
                

                //Definimos la fila y la columna del rango 
                string x = "B" + (fila).ToString();
                string y = "K" + (fila).ToString();
                rango = hoja.Range[x, y];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            }
            lblrespuesta.Text = "Finalizando...";
            excel.Visible = true;
            excel.UserControl = false;
            //excel.Quit();
            lblrespuesta.Text = "Archivo generado abierto.";
            basicas.liberaObjeto(excel);
        }

        private void montaCabeceras(int fila, ref Excel._Worksheet hoja)
        {
            try
            {
                Excel.Range rango;

                //** Montamos el título en la línea 1 **
                hoja.Cells[2, 2] = sesion.SessionGlobal.chpuntoventa;
                hoja.Cells[3, 2] = "DIRECCION: AV. DEFENSORES DEL MORRO  N° 666  OF. 44, 45 y 46 - CHORRILLOS - LIMA - PERU";
                hoja.Cells[4, 2] = "RUC: 20522355292";
                hoja.Cells[5, 2] = "REGISTRO DE VENTAS";
                hoja.Cells[7, 2] = "MES:";
                //** Montamos las cabeceras en la línea 3 **
                hoja.Cells[8, 2] = "FECHA";
                hoja.Cells[8, 3] = "TIPO DOC.";
                hoja.Cells[8, 4] = "N° DOC.";
                hoja.Cells[8, 5] = "IMPORTE TOTAL";
                hoja.Cells[8, 6] = "IMPORTE AFECTA";
                hoja.Cells[8, 7] = "IGV";
                hoja.Cells[8, 8] = "CODIGO CLIENTE";
                hoja.Cells[8, 9] = "TIPO DOCU.";
                hoja.Cells[8, 10] = "N° DOCU";
                hoja.Cells[8, 11] = "NOMBRES";


                rango = hoja.Range["B2", "K2"];
                rango.Merge();
                rango = hoja.Range["B3", "K3"];
                rango.Merge();
                rango = hoja.Range["B4", "K4"];
                rango.Merge();
                rango = hoja.Range["B5", "K5"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
              
                //Ponemos borde a las celdas

                rango = hoja.Range["B2", "K7"];
                rango.Font.Bold = true;
                rango.Font.Size = 12;
                rango = hoja.Range["B8", "K8"];
                rango.Font.Bold = true;
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //Centramos los textos

                //Modificamos los anchos de las columnas
                rango = hoja.Columns[1];
                rango.ColumnWidth = 1;
                rango = hoja.Columns[2];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[3];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[4];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[5];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[6];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[7];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[8];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[9];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[10];
                rango.ColumnWidth = 15;
                rango = hoja.Columns[11];
                rango.ColumnWidth = 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkTodo.Checked)
            {
                cboDocumento.Enabled = false;
            }else
            {
                cboDocumento.Enabled = true;
            }
        }
    }
}
