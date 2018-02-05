using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Presentacion
{
    public abstract class basicas

    {
        public static string encriptarStringHD5(string cadena)
        {
            //StringBuilder hash = new StringBuilder();
            //MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            //byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(cadena));
            //for (int i=0 ; i < bytes.Length; i++)
            //{
            //    hash.Append(bytes[i].ToString("x2"));
            //}
            //return hash.ToString();
            return cadena;
        }

        public static bool validarAcceso(string vBoton)
        {
            try
            {
                bool vEvalua = true;
                switch (vBoton)
                {
                    case "A":  // Permiso para añadir
                        if (sesion.SessionGlobal.p_inidperfil !=1)
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para añadir");
                        }
                        break;
                    case "M":  // Permiso para modificar
                        if (sesion.SessionGlobal.p_inidperfil != 1)
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para modificar");
                        }
                        break;
                    case "N":  // Permiso para anular
                        if (sesion.SessionGlobal.p_inidperfil != 1)
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para anular");
                        }
                        break;
                }
                return vEvalua;
            }
            catch (Exception)
            {
                throw;
            }
       }
        public static void exportaExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn colu in tabla.Columns)
            {
                if (colu.Visible)
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = colu.Name;
                }
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    if (col.Visible)
                    {
                        IndiceColumna++;
                        if (col.Name=="FECHAPRESUPUESTO")
                        {
                            //Range rango = excel.Cells[IndiceFila + 1, IndiceColumna];
                            //rango.EntireColumn.NumberFormat = "DD/MM/YYYY";
                            string a = (string)fila.Cells[col.Name].Value;
                            string b = a.Substring(3, 2)+'/'+a.Substring(0,2)+'/'+ a.Substring(6, 4);
                            excel.Cells[IndiceFila + 1, IndiceColumna] = b;
                            //excel.Cells[IndiceFila + 1, IndiceColumna]
                        }else
                        {
                            excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[col.Name].Value;
                        }

                    }
                }
            }
            excel.Visible = true;
            excel.UserControl = false;
            //excel.Quit();
            liberaObjeto(excel);   
        }

        private static void liberaObjeto(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
