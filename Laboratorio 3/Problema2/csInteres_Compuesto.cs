using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema2
{
    public class csInteres_Compuesto: csInteres
    {
        private double tiempo;

        public csInteres_Compuesto(double tasa_Interes,double capital_inicial,double tiempo) 
            : base(tasa_Interes,capital_inicial){
            this.tiempo=tiempo;
        }

        public double Tiempo{
            get {return tiempo;}
            set {tiempo=value;}
        }

        public string interesCompuesto(){
            return $"El interes es de: {Capital_inicial * Math.Pow(1 + Tasa_Interes, tiempo)}";
            
        }
    }
}