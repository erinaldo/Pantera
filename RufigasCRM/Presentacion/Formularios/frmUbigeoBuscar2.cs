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

namespace Presentacion
{
    public partial class frmUbigeoBuscar : Form
    {
        internal perfil tmpPerfil;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public int varItem;
        public frmUbigeoBuscar(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
        }

        private void crearCursor()
        {
            //Crea la tabla con el nombre de Detalle
            DataTable dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            dtDetalle.Columns.Add("IDMENU", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("SELECCION", System.Type.GetType("System.Boolean"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dgvCursor.DataSource = dtDetalle;

        }
        private void frmUbigeoBuscar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            crearCursor();
            

            if (this.vBoton =="A")
            {
                this.Text = "AÑADIR PERFIL";
            }
            else 
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR PERFIL";
            }
            else
                   if(this.vBoton == "V")
                    {
                        this.Text = "VER PERFIL";
                    }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            string desc_distrito = txtDescripcion.Text;

        }
    }
}