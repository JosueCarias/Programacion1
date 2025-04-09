using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema2
{
    public class csInteres_simple : csInteres 
    {
        private double tiempo;

        public csInteres_simple(double tasa_Interes, double capital_inicial, double tiempo) 
            : base(tasa_Interes, capital_inicial) 
        {
            this.tiempo = tiempo;
        }

        public double Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public double InteresSimple()
        {
            return Capital_inicial * Tasa_Interes * Tiempo;
        }
    }
}