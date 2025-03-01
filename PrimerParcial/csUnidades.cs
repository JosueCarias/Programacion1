using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class csUnidades
    {
        private int numero;

        public csUnidades(int numero){
            this.numero=numero;
        }
        public int Numero{
            get {return numero;}
            set {numero=value;}
        }
        public string calcularUnidadDeMedida(){
            string respuesta="";
            if(numero<10){
                respuesta="El numero pertenece a las unidades";
            }
            else if (numero<100){
                respuesta="El numero pertenece a las decenas";
            }
            else if(numero<1000){
                respuesta="El numero pertenece a las centenas";
            }
            else if(numero<10000){
                respuesta="El numero pertenece a las millares";
            }
            else{
                respuesta="El numero esta fuera del rango";
            }
            return respuesta;
        }
    }
}