using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema4
{
    public class csSistema_octal:csSistema_decimal
    {
        public csSistema_octal(int numero): base(numero){

        }
        public string calcular(){
            int aux = Numero;
            string octal = "";
            while (aux > 0)
            {
                int residuo = aux % 8;
                octal = residuo + octal; 
                aux = aux / 8;  
            }
            return $"El numero en octal es: {octal}";
        }
    }
}