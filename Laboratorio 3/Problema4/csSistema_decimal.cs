using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema4
{
    public class csSistema_decimal
    {
        private int numero;

        public csSistema_decimal(int numero){
            this.numero=numero;
        }
        public int Numero{
            get{return numero;}
            set{numero=value;}
        }
        public string calcular(){
            return $"El numero en base decimal es: {Numero}";
        }
    }
}