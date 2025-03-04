using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Lab2
{
    public class csVolumen
    {
        private double radio;
        private double altura;

        public csVolumen(double radio,double altura){
            this.radio=radio;
            this.altura=altura;
        }

        public double Radio{
            get {return radio;}
            set {radio=value;}
        }

        public double Altura{
            get {return altura;}
            set{ altura=value;}
        } 

        public double calcularVolumen(){
            double volumen=0.0;

            volumen=Math.PI*Math.Pow(radio,2)*altura;


            return volumen;
        }
    }
}