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
using System.Resources;
using System.Globalization;
using System.Collections;
using System.Reflection;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.cargaListaImagenes();
            this.cargaMenu();
            this.CargarFondo();
            this.ObtenerTipoCambio();
            LCabecera.Text = "USUARIO: "+sesion.SessionGlobal.chnombrepersona;
        }
        protected void CargarFondo()
        {
            frmFondo f = new frmFondo();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
        private void cargaListaImagenes()
        {
            ResourceSet images = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            foreach (DictionaryEntry entry in images)
            {
                if (entry.Value is Bitmap && entry.Key.ToString().Substring(1, 3) == "16x")
                {
                    this.imageList1.Images.Add(entry.Key.ToString().Substring(1, entry.Key.ToString().Length - 1), (Bitmap)entry.Value);
                }
            }
        }
        private void cargaMenu()
        {
            string criterio = this.txtCriterio.Text.ToUpper();
            List<menu> estructuraMenu = menuNE.obtieneEstructura();
            if (criterio.Trim().Length > 0)
            {
                this.buscaNodos(estructuraMenu, criterio);
            }
            this.treMenu.Nodes.Clear();
            this.cargaEstructura(estructuraMenu, null);
            
        }

        private List<menu> buscaNodos(List<menu> estructura, string criterio)
        {
            menu elemento;
            for (int i = estructura.Count - 1; i >= 0; i--)
            {
                elemento = estructura[i];
                if (elemento.submenu.Count > 0)
                {
                    this.buscaNodos(elemento.submenu, criterio);
                }
                else
                {
                    if (elemento.instancia != null)
                    {
                        if (elemento.descripcion.ToLower().Contains(criterio) == false)
                        {
                            estructura.RemoveAt(i);
                        }
                    }
                }
            }
            return null;
        }
        private void cargaEstructura(List<menu> estructura, TreeNode nodo)
        {
            TreeNode nodoActual;
            foreach (menu elemento in estructura)
            {
                if (nodo == null)
                {
                    nodoActual = this.treMenu.Nodes.Add(elemento.descripcion.Trim());
                }
                else
                {
                    nodoActual = nodo.Nodes.Add(elemento.descripcion.Trim());
                }
                nodoActual.Name = elemento.idmenu.ToString();
                nodoActual.Tag = elemento.instancia;
                nodoActual.ImageKey = elemento.icono.Trim();
                nodoActual.SelectedImageKey = elemento.icono.Trim();
                if (elemento.submenu.Count > 0)
                {
                    this.cargaEstructura(elemento.submenu, nodoActual);
                }
            }
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            this.cargaMenu();
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtCriterio.Focused == false)
            {
                string teclas = "qwertyuiopasdfghjklñzxcvbnm";
                if (teclas.Contains(e.KeyCode.ToString().ToLower()))
                {
                    this.txtCriterio.Focus();
                    this.txtCriterio.Text = e.KeyCode.ToString();
                    this.txtCriterio.SelectionStart = this.txtCriterio.TextLength;
                    e.Handled = true;
                }
            }
        }

        private void abreElementoMenu()
        {
            //bool flat = true;
            TreeNode nodo = this.treMenu.SelectedNode;
            if (nodo.Tag != null)
            {
                string formula = "Presentacion." + nodo.Tag.ToString().Trim();
                string forumlario = nodo.Tag.ToString().Trim(); ;
                Form frm = (Form)(Assembly.GetExecutingAssembly().CreateInstance(formula));                
                if (basicas.validarModulo(Convert.ToInt32(nodo.Name)) == 1)
                {
                    if (frm != null)
                    {                        
                        frm.ShowDialog();
                    }
                    
                }
                else MessageBox.Show("Error de Acceso :: No cuenta con los permisos", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error" + Convert.ToInt32(nodo.Name));
            }

        }

        private void treMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.abreElementoMenu();
        }

        private void treMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.abreElementoMenu();
            }

        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF10;
            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref message);
        }
        public void ObtenerTipoCambio()
        {
            //comprobar si existe tipo de cambio para hoy
            string fecha= DateTime.Now.ToShortDateString().PadLeft(10, '0');
            int flat = generarCodigoNE.ObtenerTipoCambio(fecha);
            if (flat == 0)
            {
                frmTipoDeCambio f = new frmTipoDeCambio();
                //f.MdiParent = this.MdiParent;
                 f.ShowDialog();
               
            }
            // mostrar la ventana si hace falta
        }

      
    }
}