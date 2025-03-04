using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csEntero
    {
        private int numero;

        public csEntero(int numero){
            this.numero=numero;
        }

        public int Entero{
            get {return numero;}
            set {numero=value;}
        }

        public String calculaPositivo(){
            string mensaje="";
            if (numero<0){
                mensaje="Es negativo";
            }else if (numero>0){
                mensaje="Es positivo";
            }else mensaje="Es neutro";
            
            return mensaje;
        }
    }
}