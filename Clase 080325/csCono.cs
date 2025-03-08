using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_080325
{
    public class csCono
    {
        private double altura;
        private double radio;

        public csCono(double altura,double radio){
            this.altura=altura;
            this.radio=radio;
        }
        public double Radio{
            get {return radio;}
            set {radio=value;}
        }
        public double Altura{
            get {return altura;}
            set {altura=value;}
        }
        public double resultado(){
            double volumen=(1.0/3.0)*Math.PI*Math.Pow(radio,2)*altura;
            
            return volumen;
        }
    }
}