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
namespace Presentacion
{
    public partial class frmRepoCierreVenta : Form
    {
        public frmRepoCierreVenta()
        {
            InitializeComponent();
        }

        private void frmRepoCierreVenta_Load(object sender, EventArgs e)
        {
            
        }
        private void CargarElemetos()
        {
            cboCategoria.DataSource = maestrodetalleNE.ListarCategorias();
            cboCategoria.ValueMember = "p_inidcategoria";
            cboCategoria.DisplayMember = "chcategoria";

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            creaExcel();
        }

        //if (rbtExcel.Checked)
        //{
        //    MessageBox.Show("generado excel", "Mensaje de Sistema", MessageBoxButtons.OK);
        //}
        //else
        //{
        //    if (rbtPatalla.Checked)
        //    {
        //        MessageBox.Show("generado pantalla", "Mensaje de Sistema", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        if (rbtImpresora.Checked)
        //        {
        //            MessageBox.Show("Generado impre", "Mensaje de Sistema", MessageBoxButtons.OK);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Generado", "Mensaje de Sistema", MessageBoxButtons.OK);
        //            txtfi.Focus();
        //            return;
        //        }
        //    }
        //}
   
        private void creaExcel()
        {
            grpCarga.Visible = true;
            grpCarga.Text = "Cargando archivos ...";
            Excel.Application excel = new Excel.Application();
            Excel._Workbook libro = null;
            Excel._Worksheet hoja = null;
            Excel.Range rango = null;

            //creamos un libro nuevo y la hoja con la que vamos a trabajar
            libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            hoja = (Excel._Worksheet)libro.Worksheets.Add();
            hoja.Name = "EJEMPLO";
            ((Excel.Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();   //Borramos la hoja que crea en el libro por defecto


            //Montamos las cabeceras 
            grpCarga.Text = "Cargando Cabecera";
            montaCabeceras(3, ref hoja);
            //Rellenamos las celdas
            int fila = 9;
            for (int i = 0; i < 20; i++)
            {               
                //Asignamos los datos a las celdas de la fila
                hoja.Cells[fila + i, 2] = fila * i;
                hoja.Cells[fila + i, 3] = "Descripción " + (i + 1).ToString();
                hoja.Cells[fila + i, 4] = "Observación " + (fila * i).ToString();
                //Definimos la fila y la columna del rango 
                string x = "B" + (fila + i).ToString();
                string y = "D" + (fila + i).ToString();
                rango = hoja.Range[x, y];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                int valor = (i / 20) * 100;
                grpCarga.Text = "Cargando:" + valor + "%";

            }
            excel.Visible = true;
            excel.UserControl = false;
            //excel.Quit();
            grpCarga.Text = "Linerando";
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


                rango = hoja.Range["B2", "H2"];
                rango.Merge();       
                rango = hoja.Range["B3", "H3"];
                rango.Merge();
                rango = hoja.Range["B4", "H4"];
                rango.Merge();
                rango = hoja.Range["B5", "H5"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                rango = hoja.Range["B7", "H7"];
                rango.Merge();
                //** Montamos las cabeceras en la línea 3 **
                hoja.Cells[8, 2] = "Código";
                hoja.Cells[8, 3] = "Descripción";
                hoja.Cells[8, 4] = "Observaciones";

                //Ponemos borde a las celdas
                rango = hoja.Range["B8", "D8"];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                //Centramos los textos
                rango = hoja.Rows[8];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                
                //Modificamos los anchos de las columnas
                rango = hoja.Columns[1];
                rango.ColumnWidth = 1;
                rango = hoja.Columns[2];
                rango.ColumnWidth = 10;
                rango = hoja.Columns[3];
                rango.ColumnWidth = 20;
                rango = hoja.Columns[4];
                rango.ColumnWidth = 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
