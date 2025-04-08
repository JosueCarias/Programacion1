using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class csPersona
    {
        private string nombre;
        private int edad;
        private double peso;
        private double estatura;
        private string genero;
        private double costoConsulta;

        public csPersona(string nombre,int edad, double peso,double estatura,string genero,double costoConsulta){
            this.nombre=nombre;
            this.edad=edad;
            this.peso=peso;
            this.estatura=estatura;
            this.genero=genero;
            this.costoConsulta=costoConsulta;
        }

        public string Nombre{
            get {return nombre;}
            set {nombre=value;}
        }

        public int Edad{
            get {return edad;}
            set {edad=value;}
        }

        public double Peso{
            get {return peso;}
            set {peso=value;}
        }

        public double Estatura{
            get {return estatura;}
            set {estatura=value;}
        }

        public string Genero{
            get {return genero;}
            set {genero=value;}
        }

        public double CostoConsulta{
            get {return costoConsulta;}
            set {costoConsulta=value;}
        }

        public string verPersonas(){
            return $"Nombre: {nombre}\nEdad:{edad}\nPeso:{peso}\nEstatura:{estatura}\nGenero:{genero}\nCosto Consulta:{costoConsulta}";
        }
    }
}