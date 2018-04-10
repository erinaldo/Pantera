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
    public partial class frmRepoCierreCompra : Form
    {
        public frmRepoCierreCompra()
        {
            InitializeComponent();
        }

        private void frmRepoCierreCompra_Load(object sender, EventArgs e)
        {
            CargarElemetos();
        }
        private void CargarElemetos()
        {
            cboCategoria.DataSource = maestrodetalleNE.ListarCategorias();
            cboCategoria.ValueMember = "p_inidcategoria";
            cboCategoria.DisplayMember = "chcategoria";
            rbtPatalla.Checked = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Crearimpresion()
        {
            Reportes.FrmReportesM f = new Reportes.FrmReportesM();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsPedidos();
            /*PRA CABECERA*/
            int orden = 1;

            DateTime dt1 = DateTime.Parse(txtfi.Text);
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse(txtff.Text);
            string fin = dt2.ToString("dd/MM/yyyy");
            List<registroventaexcel> Lista = pedidoNE.RegistroVentasListadoExcel(inicio, fin, (int)cboCategoria.SelectedValue);
            if (Lista.Count <= 0)
            {
                MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                lblrespuesta.Text = "No hay datos.";
                return;
            }
            lblrespuesta.Text = "Cargando datos...";
            foreach (registroventaexcel registro in Lista)
            {
                Dts.Tables["registroventa"].LoadDataRow(new object[]
            {
                orden++,
                registro.razon,
                registro.tipoclie,
                registro.chlicencia,
                registro.nucantidad.ToString(),
                registro.chtipoproducto,
                registro.chmarca,
                registro.chcalibre,
                registro.chdmodelo,
                registro.chcodigoserie,
                fin,
                "",
                sesion.SessionGlobal.chpuntoventa,
                "DIRECCION: AV. DEFENSORES DEL MORRO  N° 666  OF. 44, 45 y 46 - CHORRILLOS - LIMA - PERU",
                "RUC: 20522355292",
                "REGISTRO DE VENTAS",
                "MES:"
            }, true);

            }
            Dts.AcceptChanges();
            Rpt1 = new Reportes.CrystalReportRegistroVentas();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
        }


        private void creaExcel()
        {
            lblrespuesta.Text = "Cargando archivos ...";
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
            int fila = 9;
            int orden = 1;

            DateTime dt1 = DateTime.Parse(txtfi.Text);
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse(txtff.Text);
            string fin = dt2.ToString("dd/MM/yyyy");

            //List<registroventaexcel> Lista = pedidoNE.RegistroVentasListadoExcel(inicio, fin, (int)cboCategoria.SelectedValue);
            //if (Lista.Count <= 0)
            //{
            //    MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
            //    lblrespuesta.Text = "No hay datos.";
            //    return;
            //}
            //lblrespuesta.Text = "Cargando datos...";
            //foreach (registroventaexcel registro in Lista)
            //{

            //    fila++;
            //    hoja.Cells[fila, 2] = orden++;
            //    hoja.Cells[fila, 3] = registro.razon;
            //    hoja.Cells[fila, 4] = registro.tipoclie;
            //    hoja.Cells[fila, 5] = registro.chlicencia;
            //    hoja.Cells[fila, 6] = registro.nucantidad.ToString();
            //    hoja.Cells[fila, 7] = registro.chtipoproducto;
            //    hoja.Cells[fila, 8] = registro.chmarca;
            //    hoja.Cells[fila, 9] = registro.chcalibre;
            //    hoja.Cells[fila, 10] = registro.chdmodelo;
            //    hoja.Cells[fila, 11] = registro.chcodigoserie;
            //    hoja.Cells[fila, 12] = fin;
            //    hoja.Cells[fila, 13] = "";

            //    //Definimos la fila y la columna del rango 
            //    string x = "B" + (fila).ToString();
            //    string y = "N" + (fila).ToString();
            //    rango = hoja.Range[x, y];
            //    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            //}
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
                hoja.Cells[5, 2] = "REGISTRO DE COMPRAS";
                hoja.Cells[7, 2] = "MES:";

                hoja.Cells[8, 4] = "POR IMPORTACION";
                hoja.Cells[8, 7] = "ADQ. EN CASA COMERCIAL";
                hoja.Cells[8, 11] = "DESCRIPCION DEL ARMA";

                //** Montamos las cabeceras en la línea 3 **
                hoja.Cells[9, 2] = "N° ORDEN";
                hoja.Cells[9, 3] = "PROCEDENCIA O PROVEEDOR";

                hoja.Cells[9, 4] = "CANT";
                hoja.Cells[9, 5] = "N° RD INTER";
                hoja.Cells[9, 6] = "FECHA";

                hoja.Cells[9, 7] = "CANT";
                hoja.Cells[9, 8] = "N° STOCK-STO";
                hoja.Cells[9, 9] = "FECHA";
                                
                hoja.Cells[9, 10] = "TIPO DE ARMA";
                hoja.Cells[9, 11] = "MARCA";
                hoja.Cells[9, 12] = "CALIBRE";
                hoja.Cells[9, 13] = "MODELO";
                hoja.Cells[9, 14] = "N° SERIE";
                hoja.Cells[9, 15] = "CODIGO";



                rango = hoja.Range["B2", "O2"];
                rango.Merge();
                rango.Font.Bold = true;
                rango = hoja.Range["B3", "O3"];
                rango.Merge();
                rango.Font.Bold = true;
                rango = hoja.Range["B4", "O4"];
                rango.Merge();
                rango.Font.Bold = true;
                rango = hoja.Range["B5", "O5"];
                rango.Merge();
                rango.Font.Bold = true;
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                rango = hoja.Range["B7", "O7"];
                rango.Merge();
                rango.Font.Bold = true;
                rango = hoja.Range["D8", "F8"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                rango = hoja.Range["G8", "I8"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                rango = hoja.Range["K8", "M8"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                rango = hoja.Range["B8", "B9"];
                rango.Merge();
                rango = hoja.Range["C8", "C9"];
                rango.Merge();
                rango = hoja.Range["J8", "J9"];
                rango.Merge();
                rango = hoja.Range["N8", "N9"];
                rango.Merge();
                rango = hoja.Range["O8", "O9"];
                rango.Merge();




                //Ponemos borde a las celdas

                rango = hoja.Range["B2", "O7"];
                rango.Font.Bold = true;
                rango.Font.Size = 12;
                rango = hoja.Range["B8", "O9"];
                rango.Font.Bold = true;
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //Centramos los textos

                //Modificamos los anchos de las columnas
                rango = hoja.Columns[1];
                rango.ColumnWidth = 1;
                rango = hoja.Columns[2];
                rango.ColumnWidth = 6;
                rango = hoja.Columns[3];
                rango.ColumnWidth = 24;
                rango = hoja.Columns[4];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[5];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[6];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[7];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[8];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[9];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[10];
                rango.ColumnWidth = 12;
                rango = hoja.Columns[11];
                rango.ColumnWidth = 12;
                rango = hoja.Columns[12];
                rango.ColumnWidth = 12;
                rango = hoja.Columns[13];
                rango.ColumnWidth = 12;
                rango = hoja.Columns[14];
                rango.ColumnWidth = 14;
                rango = hoja.Columns[15];
                rango.ColumnWidth = 14;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbtExcel.Checked)
            {
                creaExcel();
            }
            else
            {
                if (rbtPatalla.Checked)
                {
                    Crearimpresion();
                }
                else
                {
                    if (rbtImpresora.Checked)
                    {
                        MessageBox.Show("Generado impre", "Mensaje de Sistema", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error de seleccion", "Mensaje de Sistema", MessageBoxButtons.OK);
                        txtfi.Focus();
                        return;
                    }
                }
            }
        }
    }
}
