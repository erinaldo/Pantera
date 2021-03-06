﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public abstract class serieNE
    {
        public static bool verificarExistencia(string parametro)
        {
            return serieDL.verificarExistencias(parametro) ;
        }
        public static int seriesIngresar(serie serie)
        {
            return serieDL.seriesIngresar(serie);
        }
        public static List<seriebuscada> serieListar()
        {
            return serieDL.serieListar();
        }
        public static List<seriebuscada> serieBuscar(string parametro)
        {
            return serieDL.serieBuscar(parametro);
        }
        public static List<serie> SerieBusquedaMovimiento(int parametro)
        {
            return serieDL.SerieBusquedaMovimiento(parametro);
        }
        public static int SeriesFalsear(int parametro,bool estado)
        {
            return serieDL.SeriesFalsear(parametro,estado);
        }
        public static int SeriesFalsearPedido(int parametro, bool estado)
        {
            return serieDL.SeriesFalsearPedido(parametro, estado);
        }
        
        public static int SeriesFalsearCodigo(int parametro)
        {
            return serieDL.SeriesFalsearCodigo(parametro);
        }        
        public static serie SerieBusquedaCodigo(int parametro)
        {
            return serieDL.SerieBusquedaCodigo(parametro);
        }
        
    }
}
