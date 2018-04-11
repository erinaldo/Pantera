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
    public partial class frmRepoCuentasCobrarPrincipal : Form
    {
        internal Mcliente ClienteG;
        public frmRepoCuentasCobrarPrincipal()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void CargarBeans()
        {
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cboVendedores.Visible = false;
            txtClieCod.Visible = false;
            lblCodigo.Visible = false;
            lblNroIden.Visible = false;
            txtNroDocuIden.Visible = false;
            txtNomClie.Visible = false;
            rbtOrdVendedor.Checked = true;
            rbtnPantalla.Checked = true;
        }

        private void frmRepoCuentasCobrarPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            CargarBeans();
        }

        private void rbtGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGeneral.Checked == true)
            {
                cboVendedores.Visible = false;
                txtClieCod.Visible = false;
                lblCodigo.Visible = false;
                lblNroIden.Visible = false;
                txtNroDocuIden.Visible = false;
                txtNomClie.Visible = false;
            }
        }

        private void rbtVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtVendedor.Checked == true)
            {
                cboVendedores.Visible = true;
                txtClieCod.Visible = false;
                lblCodigo.Visible = false;
                lblNroIden.Visible = false;
                txtNroDocuIden.Visible = false;
                txtNomClie.Visible = false;
            }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliente.Checked == true)
            {
                cboVendedores.Visible = false;
                txtClieCod.Visible = true;
                lblCodigo.Visible = true;
                lblNroIden.Visible = true;
                txtNroDocuIden.Visible = true;
                txtNomClie.Visible = true;
            }

        }

        private void txtClieCod_TextChanged(object sender, EventArgs e)
        {
            TextBox TextoUsado = (TextBox)sender;

        }

        private void txtClieCod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtClieCod_Enter(object sender, EventArgs e)
        {

        }

        private void CargarDatosTabla()
        {
           
            List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
            RegistroVenta = pedidoNE.BuscarRegistroVentasListar();
            foreach (RegistroVenta Registros in RegistroVenta)
            {
                if (Registros.p_inidtipodocu == 4)
                {
                    decimal montoencontra = pedidoNE.BuscarDocNCCodigo(Registros.chcodigodocu);
                    if ((Registros.nuimportetotvta - montoencontra) > 0)
                    {
                        //dgvDocumentosPendientes.Rows.Add(Registros.p_inidregistroventa, Registros.p_inidtipodocu, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", (-1) * (Registros.nuimportetotvta - montoencontra));
                    }

                }
                else
                {
                    decimal montoencontra = pedidoNE.BuscarMontoEncontra(Registros.p_inidtipodocu, Registros.chcodigodocu, Registros.p_inidcliente);
                    if ((Registros.nuimportetotvta - montoencontra) > 0)
                    {
                       // dgvDocumentosPendientes.Rows.Add(Registros.p_inidregistroventa, Registros.p_inidtipodocu, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", Registros.nuimportetotvta - montoencontra);
                    }

                }

            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbtnPantalla.Checked)
            {
                creaExcel();
            }
            else
            {
                if (rbtnPantalla.Checked)
                {
                    //Crearimpresion();
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
                        //txtfechai.Focus();
                        return;
                    }
                }
            }
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
            //lblrespuesta.Text = "Cargando cabecera...";
            montaCabeceras(3, ref hoja);
            //Rellenamos las celdas
            int fila = 9;
            int orden = 1;

            DateTime dt1 = DateTime.Parse("");
            string inicio = dt1.ToString("dd/MM/yyyy");

            DateTime dt2 = DateTime.Parse("");
            string fin = dt2.ToString("dd/MM/yyyy");

            List<registroventaexcel> Lista = pedidoNE.RegistroVentasListadoExcel(inicio, fin, 1);
            if (Lista.Count <= 0)
            {
                MessageBox.Show("No se encontraron datos", "Mensaje de Sistema", MessageBoxButtons.OK);
                //lblrespuesta.Text = "No hay datos.";
                return;
            }
            //lblrespuesta.Text = "Cargando datos...";
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
            //lblrespuesta.Text = "Finalizando...";
            excel.Visible = true;
            excel.UserControl = false;
            //excel.Quit();
            //lblrespuesta.Text = "Archivo generado abierto.";
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

                rango = hoja.Range["B2", "N7"];
                rango.Font.Bold = true;
                rango.Font.Size = 12;
                rango = hoja.Range["B8", "N9"];
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
    }
}
