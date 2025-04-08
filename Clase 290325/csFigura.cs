using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_290325
{
    public class csFigura
    {
        private string tipoFigura;
        private int cantidadLados;

        public csFigura(string tipoFIgura, int cantidadLados){
            this.tipoFigura=tipoFIgura;
            this.cantidadLados=cantidadLados;
        }
        public string TipoFigura{
            get {return tipoFigura;}
            set {tipoFigura=value;}

        }
        public int CantidadLados{
            get {return cantidadLados;}
            set {cantidadLados=value;}
        }
        public string verDatos(){
            return $"Tipo de figurar: {tipoFigura} Cantidad de lados: {cantidadLados}";
        }
    }
}