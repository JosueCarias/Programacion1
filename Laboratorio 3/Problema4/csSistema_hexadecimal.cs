using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problema4
{
    public class csSistema_hexadecimal : csSistema_decimal
    {
        public csSistema_hexadecimal(int numero): base(numero){

        }
        public string calcular(){
            if (Numero == 0) return "0";
    
            int aux = Math.Abs(Numero); // Manejo de negativos
            char[] digitosHex = "0123456789ABCDEF".ToCharArray();
            string hexadecimal = "";
    
            while (aux > 0)
            {
            hexadecimal = digitosHex[aux % 16] + hexadecimal;
            aux /= 16;
            }
            return $"El numero en hexadecimal es: {hexadecimal}";
        }
    }
}