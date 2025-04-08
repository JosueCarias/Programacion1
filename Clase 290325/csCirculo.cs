using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_290325
{
    public class csCirculo:csFigura
    {
        private double radio;

        public csCirculo(double radio) : base("Circulo", 365){
            this.radio=radio;
        }

        public double Radio{
            get { return radio; }
            set { radio = value; }
        }

        public double CalcularArea(){
            return Math.PI*radio*radio;
        }
        public Double CalcularPerimetro(){
            return 2*Math.PI*radio;
        }
        public new string verDatos(){
            return base.verDatos() + $"\nRadio: {radio}, Perímetro: {CalcularPerimetro()}, Área: {CalcularArea()}";
        }
    }
}