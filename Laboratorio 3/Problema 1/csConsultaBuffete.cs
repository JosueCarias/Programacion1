using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class csConsultaBuffete:csPersona
    {
        private string colegiadoAbogado;
        private string descripcion;

        public csConsultaBuffete(string nombre,int edad,double peso,double estatura,string genero,double costoConsulta,string colegiadoAbogado,string descripcion):base(nombre, edad, peso, estatura, genero, costoConsulta){
            this.colegiadoAbogado=colegiadoAbogado;
            this.descripcion=descripcion;
        }

        public string ColegiadoAbogado{
            get {return colegiadoAbogado;}
            set {colegiadoAbogado=value;}
        }

        public string Descripcion{
            get {return descripcion;}
            set {descripcion=value;}
        }

        public string verConsultas(double totalCancelar)
        {
            return base.verPersonas() +
                $"\nColegiado Abogado: {ColegiadoAbogado}" +
                $"\nDescripción: {Descripcion}" +
                $"\nTotal a Cancelar: {totalCancelar:C}";
        }
    }
}