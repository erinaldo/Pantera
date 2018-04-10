﻿using System;
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
            CargarElemetos();
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
            grpCarga.Text = "Cargando Cabecera: "+txtfi.Text+":"+txtff.Text+ ":"+(int)cboCategoria.SelectedValue;
            montaCabeceras(3, ref hoja);
            //Rellenamos las celdas
            int fila = 9;
            int orden = 1;

            DateTime dt1 = DateTime.Parse(txtfi.Text);
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse(txtff.Text);
            string fin = dt2.ToString("dd/MM/yyyy");
            List<registroventaexcel> Lista= pedidoNE.RegistroVentasListadoExcel(inicio,fin,(int)cboCategoria.SelectedValue);
            foreach (registroventaexcel registro in Lista)
            {
                
                fila++;
                hoja.Cells[fila, 2] = orden++;
                hoja.Cells[fila, 3] = registro.razon;
                hoja.Cells[fila, 4] = registro.tipoclie;
                hoja.Cells[fila, 5] = registro.chlicencia;
                hoja.Cells[fila, 6] = registro.nucantidad.ToString();
                hoja.Cells[fila, 7] = registro.chtipoproducto;
                hoja.Cells[fila, 8] = registro.chmarca;
                hoja.Cells[fila, 9] = registro.chcalibre;
                hoja.Cells[fila, 10] = registro.chdmodelo;
                hoja.Cells[fila, 11] = registro.chcodigoserie;
                hoja.Cells[fila, 12] = fin;
                hoja.Cells[fila, 13] = "";
                
                //Definimos la fila y la columna del rango 
                string x = "B" + (fila).ToString();
                string y = "N" + (fila).ToString();
                rango = hoja.Range[x, y];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            }

            //for (int i = 0; i < 20; i++)
            //{               
            //    //Asignamos los datos a las celdas de la fila
            //    hoja.Cells[fila + i, 2] = fila * i;
            //    hoja.Cells[fila + i, 3] = "Descripción " + (i + 1).ToString();
            //    hoja.Cells[fila + i, 4] = "Observación " + (fila * i).ToString();
            //    //Definimos la fila y la columna del rango 
            //    string x = "B" + (fila + i).ToString();
            //    string y = "D" + (fila + i).ToString();
            //    rango = hoja.Range[x, y];
            //    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;                
            //    grpCarga.Text = "Cargando:" + i + "%";

            //}
            excel.Visible = true;
            excel.UserControl = false;
            //excel.Quit();
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
                hoja.Cells[8, 7] = "DECRIPCION DE ARMA/MUNICION";
                //** Montamos las cabeceras en la línea 3 **
                hoja.Cells[9, 2] = "N° ORDEN";
                hoja.Cells[9, 3] = "NOMBRES Y APELLIDOS";
                hoja.Cells[9, 4] = "CLIENTE";
                hoja.Cells[9, 5] = "N° LICENCIA";
                hoja.Cells[9, 6] = "CANT.";
                hoja.Cells[9, 7] = "TIPO ARMA";
                hoja.Cells[9, 8] = "MARCA";
                hoja.Cells[9, 9] = "CALIBRE";
                hoja.Cells[9, 10] = "MODELO";
                hoja.Cells[9, 11] = "N° SERIE";
                hoja.Cells[9, 12] = "FECHA";
                hoja.Cells[9, 13] = "FIRMA";


                rango = hoja.Range["B2", "N2"];
                rango.Merge();       
                rango = hoja.Range["B3", "N3"];
                rango.Merge();
                rango = hoja.Range["B4", "N4"];
                rango.Merge();
                rango = hoja.Range["B5", "N5"];
                rango.Merge();
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                rango = hoja.Range["B7", "N7"];
                rango.Merge();

                rango = hoja.Range["G8", "J8"];
                rango.Merge();

                rango = hoja.Range["B8", "B9"];
                rango.Merge();
                rango = hoja.Range["C8", "C9"];
                rango.Merge();
                rango = hoja.Range["D8", "D9"];
                rango.Merge();
                rango = hoja.Range["E8", "E9"];
                rango.Merge();
                rango = hoja.Range["F8", "F9"];
                rango.Merge();
                rango = hoja.Range["K8", "K9"];
                rango.Merge();
                rango = hoja.Range["L8", "L9"];
                rango.Merge();
                rango = hoja.Range["M8", "M9"];
                rango.Merge();
                rango = hoja.Range["N8", "N9"];
                rango.Merge();
               
               

                //Ponemos borde a las celdas
                rango = hoja.Range["B8", "N9"];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //Centramos los textos
                
                //Modificamos los anchos de las columnas
                rango = hoja.Columns[1];
                rango.ColumnWidth = 1;
                rango = hoja.Columns[2];
                rango.ColumnWidth = 6;
                rango = hoja.Columns[3];
                rango.ColumnWidth = 41;
                rango = hoja.Columns[4];
                rango.ColumnWidth = 10;
                rango = hoja.Columns[5];
                rango.ColumnWidth = 13;
                rango = hoja.Columns[6];
                rango.ColumnWidth = 6;
                rango = hoja.Columns[7];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[8];
                rango.ColumnWidth = 14;
                rango = hoja.Columns[9];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[10];
                rango.ColumnWidth = 12;
                rango = hoja.Columns[11];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[12];
                rango.ColumnWidth = 11;
                rango = hoja.Columns[13];
                rango.ColumnWidth = 10;
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
