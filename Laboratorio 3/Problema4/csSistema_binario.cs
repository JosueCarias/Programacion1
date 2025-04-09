using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema4
{
    public class csSistema_binario : csSistema_decimal
    {
        public csSistema_binario(int numero): base(numero){

        }
        public string calcular(){
            int aux = Numero;
            string binario = "";
            while (aux > 0)
            {
                int residuo = aux % 2;
                binario = residuo + binario; 
                aux = aux / 2;  
            }
            return $"El numero en binario es: {binario}";
        }
    }
}