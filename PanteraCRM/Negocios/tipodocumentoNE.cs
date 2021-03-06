﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class tipodocumentoNE
    {
        public static List<tipodocumento> ListarDocumentosVenta()
        {
            return tipodocumentoDL.ListarTipoDocumentosVenta();
        }
        public static List<tipodocumento> ListarTipoDocumentosVentaParametro(bool parametro)
        {
            return tipodocumentoDL.ListarTipoDocumentosVentaParametro(parametro);
        }
        
        public static tipodocumento documentoVentaBusquedacodigo(int codigo)
        {
            return tipodocumentoDL.documentoVentaBusquedacodigo(codigo);
        }
    }
}
