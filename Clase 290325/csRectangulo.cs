using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_290325
{
    public class csRectangulo : csFigura
    {
        private int ancho;
        private int altura;

        public csRectangulo(int ancho, int altura) : base("Rectángulo", 4){
            this.ancho=ancho;
            this.altura=altura;
        }

        public int Altura{
            get { return altura; }
            set { altura = value; }
        }

        public int Ancho{
            get { return ancho; }
            set { ancho = value; }
        }

        public int CalcularArea(){
            return ancho*altura;
        }
        public int CalcularPerimetro(){
            return 2*ancho+2*altura;
        }
        public new string verDatos(){
            return base.verDatos() + $"\nAncho: {ancho}, Altura: {altura}, Perímetro: {CalcularPerimetro()}, Área: {CalcularArea()}";
        }
    }
}