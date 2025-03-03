using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csEdad
    {
        private string nombre;
        private int edad;

        public csEdad(String nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
        }

        public string Nombre{
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public static csEdad CalcularMenor(csEdad[] personas){
        csEdad menor = personas[0];
        for (int i = 1; i < personas.Length; i++)
        {
            if (personas[i].Edad < menor.Edad)
            {
                menor = personas[i];
            }
        }
        return menor;
        }
    }
}