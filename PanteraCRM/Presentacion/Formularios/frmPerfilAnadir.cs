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
    public partial class frmPerfilAnadir : Form
    {
        internal perfil tmpPerfil;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public int varItem;
        public frmPerfilAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdPerfil, varIdPerfilDetalle;
            switch (this.vBoton)
            {
                case "A":
                    //frmPerfil.cargarData(1);
                    tmpPerfil = new perfil();
                    tmpPerfil.descripcion = txtNombre.Text;
                    tmpPerfil.comentarioperfil = txtComentario.Text;
                    tmpPerfil.estadoperfil = chkEstado.Checked;
                    varIdPerfil = perfilNE.perfilInsertar(tmpPerfil);
                    if (varIdPerfil <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
              //          MessageBox.Show("Código generado", varIdPerfil.ToString());
                        perfildetalle tmpPerfilDetalle;
                        foreach (DataGridViewRow rowGrid in dgvCursor.Rows)
                        {
                            if ((bool)(rowGrid.Cells[2].Value))
                            {
                                tmpPerfilDetalle = new perfildetalle();
                                tmpPerfilDetalle.idmenu = (int)(rowGrid.Cells[0].Value);
                                perfildetalleNE.perfildetalleInsertar(varIdPerfil, tmpPerfilDetalle);
                            }

                        }
                        pasado(varIdPerfil);
                    }
                    break;
                case "M":
                    tmpPerfil.descripcion = txtNombre.Text;
                    tmpPerfil.comentarioperfil = txtComentario.Text;
                    tmpPerfil.estadoperfil = chkEstado.Checked;
                    varIdPerfil = perfilNE.perfilActualizar(tmpPerfil);
                    if (varIdPerfil <= 0)
                    {
                        MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                //        MessageBox.Show("Registro actualizado");
                        varIdPerfilDetalle = perfildetalleNE.perfildetalleEliminar(varIdPerfil);
                        if (varIdPerfilDetalle <= 0 && varItem > 0)
                        {
                            MessageBox.Show("Registro eliminado errado, validar");
                        }
                        else
                        {
                            perfildetalle tmpPerfilDetalle;
                            foreach (DataGridViewRow rowGrid in dgvCursor.Rows)
                            {
                                if ((bool)(rowGrid.Cells[2].Value))
                                {
                                    tmpPerfilDetalle = new perfildetalle();
                                    tmpPerfilDetalle.idmenu = (int)(rowGrid.Cells[0].Value);
                                    perfildetalleNE.perfildetalleInsertar(varIdPerfil, tmpPerfilDetalle);
                                }
                            }
                            pasado(varIdPerfil);
                        }
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
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
        private void frmPerfilAnadir_Load(object sender, EventArgs e)
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
                    txtNombre.Text = tmpPerfil.descripcion;
                    txtComentario.Text = tmpPerfil.comentarioperfil;
                    chkEstado.Checked = tmpPerfil.estadoperfil;
                    List<perfildetalle> listado = perfildetalleNE.perfildetalleListar(tmpPerfil.idperfil);
                    dgvCursor.DataSource = listado;
                    varItem = 0;
                    foreach (DataGridViewRow rowGrid in dgvCursor.Rows)
                    {
                        if ((bool)(rowGrid.Cells[2].Value))
                        {
                            varItem = varItem + 1;
                        }
                    }

                }
                else
                   if(this.vBoton == "V")
                    {
                        this.Text = "VER PERFIL";
                        txtNombre.Text = tmpPerfil.descripcion;
                        txtComentario.Text = tmpPerfil.comentarioperfil;
                        chkEstado.Checked = tmpPerfil.estadoperfil;
                        btnGrabar.Enabled = false;
                        List<perfildetalle> listado = perfildetalleNE.perfildetalleListar(tmpPerfil.idperfil);
                        dgvCursor.DataSource = listado;
                    }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }
    }
}