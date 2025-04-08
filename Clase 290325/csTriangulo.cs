using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_290325
{
    public class csTriangulo:csFigura
    {
        private int ancho;
        private int altura;

        public csTriangulo(int ancho, int altura) : base("Triangulo", 3){
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

        public double CalcularArea(){
            return 0.5*ancho*altura;
        }
        public int CalcularPerimetro(){
            return 3*ancho;
        }
        public new string verDatos(){
            return base.verDatos() + $"\nAncho: {ancho}, Altura: {altura}, Perímetro: {CalcularPerimetro()}, Área: {CalcularArea()}";
        }
    }
}