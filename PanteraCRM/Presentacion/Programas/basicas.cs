using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
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
        public static int validarModulo(int position)
        {
            var privilegios = sesion.SessionGlobal.chprivilegios.ToCharArray();
            char a = privilegios[position - 1];
            return int.Parse(a.ToString());
        }
        public static bool validarAcceso(string vBoton)
        {
            var privilegios = sesion.SessionGlobal.chprivilegios.ToCharArray();
            try
            {
                bool vEvalua = true;
                switch (vBoton)
                {
                    case "A":  // Permiso para añadir
                        if (privilegios[34] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para añadir");
                        }
                        break;
                    case "M":  // Permiso para modificar
                        if (privilegios[35] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para modificar");
                        }
                        break;
                    
                    case "G":  // Permiso para grabar
                        if (privilegios[36] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para anular");
                        }
                        break;
                    case "E":  // Permiso para Eliminar
                        if (privilegios[37] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para anular");
                        }
                        break;
                    case "I":  // Permiso para imprimir
                        if (privilegios[38] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para anular");
                        }
                        break;
                    case "X":  // Permiso para exportar
                        if (privilegios[39] != '1')
                        {
                            vEvalua = false;
                            throw new Exception("No cuenta con los permisos para anular");
                        }
                        break;
                    case "V":  // Permiso para ver
                        if (privilegios[40] != '1')
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
        private static string[] UNIDADES = { "", "un ", "dos ", "tres ", "cuatro ", "cinco ", "seis ", "siete ", "ocho ", "nueve " };
        private static string[] DECENAS = {"diez ", "once ", "doce ", "trece ", "catorce ", "quince ", "dieciseis ",
        "diecisiete ", "dieciocho ", "diecinueve", "veinte ", "treinta ", "cuarenta ",
        "cincuenta ", "sesenta ", "setenta ", "ochenta ", "noventa "};
        private static string[] CENTENAS = {"", "ciento ", "doscientos ", "trecientos ", "cuatrocientos ", "quinientos ", "seiscientos ",
        "setecientos ", "ochocientos ", "novecientos "};

        private static Regex r;

        public static string Convertir(string numero, bool mayusculas)
        {

            string literal = "";
            string parte_decimal;
            //si el numero utiliza (.) en lugar de (,) -> se reemplaza
            numero = numero.Replace(".", ",");

            //si el numero no tiene parte decimal, se le agrega ,00
            if (numero.IndexOf(",") == -1)
            {
                numero = numero + ",00";
            }
            //se valida formato de entrada -> 0,00 y 999 999 999,00
            r = new Regex(@"\d{1,9},\d{1,2}");
            MatchCollection mc = r.Matches(numero);
            if (mc.Count > 0)
            {
                //se divide el numero 0000000,00 -> entero y decimal
                string[] Num = numero.Split(',');

                //de da formato al numero decimal
                parte_decimal = " con "+ Num[1] + "/100 nuevos soles.";
                //se convierte el numero a literal
                if (int.Parse(Num[0]) == 0)
                {//si el valor es cero                
                    literal = "cero ";
                }
                else if (int.Parse(Num[0]) > 999999)
                {//si es millon
                    literal = getMillones(Num[0]);
                }
                else if (int.Parse(Num[0]) > 999)
                {//si es miles
                    literal = getMiles(Num[0]);
                }
                else if (int.Parse(Num[0]) > 99)
                {//si es centena
                    literal = getCentenas(Num[0]);
                }
                else if (int.Parse(Num[0]) > 9)
                {//si es decena
                    literal = getDecenas(Num[0]);
                }
                else
                {//sino unidades -> 9
                    literal = getUnidades(Num[0]);
                }
                //devuelve el resultado en mayusculas o minusculas
                if (mayusculas)
                {
                    return (literal + parte_decimal).ToUpper();
                }
                else
                {
                    return (literal + parte_decimal);
                }
            }
            else
            {//error, no se puede convertir
                return literal = null;
            }
        }

        /* funciones para convertir los numeros a literales */

        private static string getUnidades(string numero)
        {   // 1 - 9            
            //si tuviera algun 0 antes se lo quita -> 09 = 9 o 009=9
            string num = numero.Substring(numero.Length - 1);
            return UNIDADES[int.Parse(num)];
        }

        private static string getDecenas(string num)
        {// 99                        
            int n = int.Parse(num);
            if (n < 10)
            {//para casos como -> 01 - 09
                return getUnidades(num);
            }
            else if (n > 19)
            {//para 20...99
                string u = getUnidades(num);
                if (u.Equals(""))
                { //para 20,30,40,50,60,70,80,90
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8];
                }
                else
                {
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8] + "y " + u;
                }
            }
            else
            {//numeros entre 11 y 19
                return DECENAS[n - 10];
            }
        }

        private static string getCentenas(string num)
        {// 999 o 099
            if (int.Parse(num) > 99)
            {//es centena
                if (int.Parse(num) == 100)
                {//caso especial
                    return " cien ";
                }
                else
                {
                    return CENTENAS[int.Parse(num.Substring(0, 1))] + getDecenas(num.Substring(1));
                }
            }
            else
            {//por Ej. 099 
                //se quita el 0 antes de convertir a decenas
                return getDecenas(int.Parse(num) + "");
            }
        }

        private static string getMiles(string numero)
        {// 999 999
            //obtiene las centenas
            string c = numero.Substring(numero.Length - 3);
            //obtiene los miles
            string m = numero.Substring(0, numero.Length - 3);
            string n = "";
            //se comprueba que miles tenga valor entero
            if (int.Parse(m) > 0)
            {
                n = getCentenas(m);
                return n + "mil " + getCentenas(c);
            }
            else
            {
                return "" + getCentenas(c);
            }

        }

        private static string getMillones(string numero)
        { //000 000 000        
            //se obtiene los miles
            string miles = numero.Substring(numero.Length - 6);
            //se obtiene los millones
            string millon = numero.Substring(0, numero.Length - 6);
            string n = "";
            if (millon.Length > 1)
            {
                n = getCentenas(millon) + "millones ";
            }
            else
            {
                n = getUnidades(millon) + "millon ";
            }
            return n + getMiles(miles);
        }
    }
}
