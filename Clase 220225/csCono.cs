using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_220225
{
    public class csCono
    {
        private double radio;
        private double altura;

        public csCono(double radio,double altura){
            this.radio=radio;
            this.altura=altura;
        }
        public csCono(){
            
        }
        public void setRadio(double radio){
            this.radio=radio;
        }
        public void setAltura(double altura){
            this.altura=altura;
        }

        public double calcularVolumen(){
            
            return (1.0/3.0)*Math.PI*Math.Pow(radio,2)*altura;
        }
    }
}