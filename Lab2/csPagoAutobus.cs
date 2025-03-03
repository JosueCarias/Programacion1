using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Lab2
{
    public class csPagoAutobus
    {
        private int nAlumnos;

        public csPagoAutobus(int nAlumnos){
            this.nAlumnos=nAlumnos;
        }
       public int NAlumnos{
            get { return nAlumnos; }
            set { nAlumnos = value; }
        }
       public int calcularPagoAutoBus(){
        int pago=0;
        if (nAlumnos>=100){
            pago=nAlumnos*65;
        }else if(nAlumnos<=99 && nAlumnos>=50){
            pago=nAlumnos*70;
        }else if(nAlumnos<=49 && nAlumnos>=30){
            pago=nAlumnos*95;
        }else if(nAlumnos<=30){
            pago=4000;
        }
        return  pago;
       }
       public int calcularPagoIndividual(){
        int pago=0;
        pago=calcularPagoAutoBus()/nAlumnos;
        return pago;
       }
    }
}