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
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmSecuUsuariosAnadir : Form
    {
        internal usuariomenu DatosUsuarioG;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmSecuUsuariosAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        private void frmSecuUsuariosAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            switch (vBoton)
            {
                case "A":
                    {
                        cargarDataAgregar();
                    }
                    break;
                case "M":
                    {

                    }
                    break;
                case "V":
                    {

                    }
                    break;
            }
        }
        public void cargarDataAgregar()
        {
            List<modulos> ModulosLista = usuarioNE.ModulosListar();
            string[] cadena = new string[7];
            cadena[0] = "MODULO PRINCIPAL-> ";
            int count = 0;
             foreach (modulos registros in ModulosLista)
            {
                if (registros.chcodigomenu == 0)
                {
                    cadena[registros.p_inidmenu] = registros.chdescripcionmenu + "-> ";
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, registros.chcodigomenu, cadena[registros.chcodigomenu] + registros.chdescripcionmenu, registros.estado);
                    dgvListaModulos.Rows[count].ReadOnly = true;
                }
                else
                {
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, registros.chcodigomenu, cadena[registros.chcodigomenu] + registros.chdescripcionmenu, registros.estado);
                }
                count++;
            }
        }
        public void cargarData(int registro, string parametro)
        {
            var privilegios = sesion.SessionGlobal.chprivilegios.ToCharArray();
            List<modulos> ModulosLista = usuarioNE.ModulosListar();
            bool estado;
            string valor;
            foreach (modulos registros in ModulosLista)
            {
                if (privilegios[registros.p_inidmenu - 1] == '1')
                {
                    estado = true;
                    valor = "1";
                }
                else
                {
                    estado = false;
                    valor = "0";
                }
                dgvListaModulos.Rows.Add(registros.p_inidmenu, registros.chdescripcionmenu, estado, valor);
            }

        }
    }
}
