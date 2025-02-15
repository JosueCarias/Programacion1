using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    internal class csCono
    {
        public double volumen(double r, double h)
        {
            double volumen;
            volumen= (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
            return volumen;
        }
    }
}
