using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema2
{
    public class csInteres
    {
        private double tasa_Interes;
        private double capital_inicial;

        public csInteres(double tasa_Interes,double capital_inicial){
            this.tasa_Interes=tasa_Interes;
            this.capital_inicial=capital_inicial;
        }

        public double Tasa_Interes{
            get { return tasa_Interes;}
            set { tasa_Interes=value;}
        }
        public double Capital_inicial{
            get { return capital_inicial;}
            set { capital_inicial=value;}
        }
        public string calcular(){
            return $"El interes es de: {tasa_Interes*capital_inicial}";
        }
    }
}