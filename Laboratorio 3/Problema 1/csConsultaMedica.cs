using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class csConsultaMedica : csPersona
    {
        private string fechaConsulta;
        private string historialClinico;
        private double horasConsulta;
        private double precioPorHora;

        public csConsultaMedica(string nombre, int edad, double peso, double estatura, string genero, string fechaConsulta, string historialClinico, double horasConsulta, double precioPorHora)
            : base(nombre, edad, peso, estatura, genero, 0) 
        {
            this.fechaConsulta = fechaConsulta;
            this.historialClinico = historialClinico;
            this.horasConsulta = horasConsulta;
            this.precioPorHora = precioPorHora;
            this.CostoConsulta = calcularPrecioConsulta(); 
        }

        public string FechaConsulta{
            get {return fechaConsulta;}
            set {fechaConsulta=value;}
        }
        public string HistorialClinico{
            get {return historialClinico;}
            set {historialClinico=value;}
        }
        public double HorasConsulta{
            get {return horasConsulta;}
            set {horasConsulta=value;}
        }
        public double PrecioPorHora{
            get {return precioPorHora;}
            set {precioPorHora=value;}
        }
        public double CalculoPrecioConsulta(){
            return HorasConsulta * PrecioPorHora;
        }
        public double calcularPrecioConsulta()
        {
            return HorasConsulta * PrecioPorHora;
        }
        public string verConsultas(){
            return base.verPersonas() + 
            $"\nFecha Consulta: {FechaConsulta}" +
            $"\nHistoria Clínico: {HistorialClinico}" +
            $"\nHoras Consulta: {HorasConsulta}" +
            $"\nPrecio Por Hora: {PrecioPorHora:C}" +
            $"\nCalculo Precio Consulta: {CalculoPrecioConsulta:C}";
        }
    }
}